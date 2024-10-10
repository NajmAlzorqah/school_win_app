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
    class SubjectsLayerClass
    {
        Database.DatabaseClass dataAccess = new Database.DatabaseClass();
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.read("GetSubjects", pr);
            return dataTable;
        }

        // INSERT To Classes
        public void InsertSubjects(string subjectName)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand com = new SqlCommand("InsertSubject", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;




            com.Parameters.AddWithValue("@SubjectName", subjectName);


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

        public void UpdateSubjects(int subjectID, string subjectName)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();

            // Validate the ID format
            

            // Command to check if the subject exists
            SqlCommand checkCommand = new SqlCommand("CheckSubjectExists", con.GetConnection());
            checkCommand.CommandType = CommandType.StoredProcedure;
            checkCommand.Parameters.AddWithValue("@SubjectID", subjectID);

            con.open();
            try
            {
                // Check if the subject exists
                object exists = checkCommand.ExecuteScalar();

                if (exists != null && (int)exists > 0)
                {
                    // Proceed to update if the subject exists
                    SqlCommand updateCommand = new SqlCommand("UpdateSubject", con.GetConnection());
                    updateCommand.CommandType = CommandType.StoredProcedure;
                    updateCommand.Parameters.AddWithValue("@SubjectID", subjectID);
                    updateCommand.Parameters.AddWithValue("@NewSubjectName", subjectName);

                    int result = updateCommand.ExecuteNonQuery();

                    if (result == -1) // Assuming the stored procedure returns 1 on success
                    {
                        PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                        formInsert.successFormText.Text = "Update Successfully";
                        formInsert.Show();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
                else
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Subject ID not found.";
                    failureForm.Show();
                }
            }
            catch (Exception ex)
            {
                PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                formInsert.successFormText.Text = "Error";
                formInsert.Show();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
        }

        public void DeleteSubjects(int subjectID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            con.open();
            try
            {
                // Check if the subjectID exists using the stored procedure
                SqlCommand checkCommand = new SqlCommand("CheckSubjectExistsInDelete", con.GetConnection());
                checkCommand.CommandType = CommandType.StoredProcedure;
                checkCommand.Parameters.AddWithValue("@SubjectID", subjectID);

                int exists = (int)checkCommand.ExecuteScalar();

                if (exists > 0)
                {
                    // Proceed to delete using the existing DeleteSubject procedure
                    SqlCommand com = new SqlCommand("DeleteSubject", con.GetConnection());
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@SubjectID", subjectID);

                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                        formInsert.successFormText.Text = "Deleted Successfully";
                        formInsert.Show();
                    }
                    else
                    {
                        PresentationLayer.FailureForm failureForm = new Project999.PresentationLayer.FailureForm();
                        failureForm.FailureFormText.Text = "Delete Failed.";
                        failureForm.Show();
                    }
                }
                else
                {
                    PresentationLayer.FailureForm failureForm = new Project999.PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Subject ID not found.";
                    failureForm.Show();
                }
            }
            catch (Exception ex)
            {
                PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                formInsert.successFormText.Text = "Error";
                formInsert.Show();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
        }


    }
}
