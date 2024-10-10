using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project999.School_layes
{
    class ClassesLayerClass
    {
        Database.DatabaseClass dataAccess = new Database.DatabaseClass();
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.read("GetClassSubjectsFromView", pr);
            return dataTable;
        }

        public void InsertClasses(string className, int level, int teacherID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand com = new SqlCommand("InsertClass", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;




            com.Parameters.AddWithValue("@ClassName", className);
            com.Parameters.AddWithValue("@GradeLevel", level);
            com.Parameters.AddWithValue("@TeacherID", teacherID);


            con.open();
            try
            {
                int result = com.ExecuteNonQuery();

                if (result == -1)
                {
                    PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                    formInsert.successFormText.Text = "Inserted Successfully";
                    formInsert.Show();

                }
                else
                {
                    MessageBox.Show("Insert failed.");
                }
            }
            catch (Exception ex)
            {
                PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                formInsert.successFormText.Text = "Error";
                formInsert.Show();
                MessageBox.Show(ex.Message);

            }
            con.close();

        }

        public void UpdateClasses(int classID, string newClassName, int newGradeLevel, int newTeacherID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();

            // Check if the class ID exists using the stored procedure
            using (SqlCommand checkCmd = new SqlCommand("CheckClassExists", con.GetConnection()))
            {
                checkCmd.CommandType = CommandType.StoredProcedure;
                checkCmd.Parameters.AddWithValue("@ClassID", classID);

                con.open();
                int count = (int)checkCmd.ExecuteScalar();
                con.close();

                if (count == 0)
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Class ID not found.";
                    failureForm.Show();
                    return; // Exit the method if the class ID is not found
                }
            }

            // Proceed to update the class since it exists
            using (SqlCommand updateCmd = new SqlCommand("UpdateClass", con.GetConnection()))
            {
                updateCmd.CommandType = CommandType.StoredProcedure;

                updateCmd.Parameters.AddWithValue("@ClassID", classID);
                updateCmd.Parameters.AddWithValue("@NewClassName", newClassName);
                updateCmd.Parameters.AddWithValue("@NewGradeLevel", newGradeLevel);
                updateCmd.Parameters.AddWithValue("@NewTeacherID", newTeacherID);

                con.open();
                try
                {
                    int result = updateCmd.ExecuteNonQuery();

                    if (result == -1)
                    {
                        PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                        formInsert.successFormText.Text = "Updated Successfully";
                        formInsert.Show();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
                catch (Exception ex)
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error";
                    failureForm.Show();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.close();
                }
            }
        }



        public void DeleteClasses(int classID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();

            // Check if the class ID exists using the stored procedure
            using (SqlCommand checkCmd = new SqlCommand("CheckClassExists", con.GetConnection()))
            {
                checkCmd.CommandType = CommandType.StoredProcedure;
                checkCmd.Parameters.AddWithValue("@ClassID", classID);

                con.open();
                int count = (int)checkCmd.ExecuteScalar();
                con.close();

                if (count == 0)
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Class ID not found.";
                    failureForm.Show();
                    return; // Exit the method if the class ID is not found
                }
            }

            // Proceed to delete the class since it exists
            using (SqlCommand deleteCmd = new SqlCommand("DeleteClass", con.GetConnection()))
            {
                deleteCmd.CommandType = CommandType.StoredProcedure;
                deleteCmd.Parameters.AddWithValue("@ClassID", classID);

                con.open();
                try
                {
                    int result = deleteCmd.ExecuteNonQuery();

                    if (result == -1)
                    {
                        PresentationLayer.SuccessMessage formDelete = new PresentationLayer.SuccessMessage();
                        formDelete.successFormText.Text = "Deleted Successfully";
                        formDelete.Show();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed.");
                    }
                }
                catch (Exception ex)
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error";
                    failureForm.Show();
                    MessageBox.Show(ex.Message);
                }
                
                con.close();
            }
        }


    }
}
