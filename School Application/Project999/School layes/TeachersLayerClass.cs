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
    class TeachersLayerClass
    {
        Database.DatabaseClass dataAccess = new Database.DatabaseClass();
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.read("GetClassSubjectsFromView", pr);
            return dataTable;
        }

        public void InsertTeachers(string firstName, string lastName, string email)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand com = new SqlCommand("InsertTeacher", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;




            com.Parameters.AddWithValue("@FirstName", firstName);
            com.Parameters.AddWithValue("@LastName", lastName);
            com.Parameters.AddWithValue("@Email", email);


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
                PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                failureForm.FailureFormText.Text = "Error";
                failureForm.Show();

                MessageBox.Show(ex.Message);

            }
            con.close();

        }


        public void UpdateTeachers(int teacherID, string newfirstName, string newlastName, string newemail)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();

            // Check if the teacher ID exists
            using (SqlCommand checkCmd = new SqlCommand("CheckTeacherIdExists", con.GetConnection()))
            {
                checkCmd.CommandType = CommandType.StoredProcedure;
                checkCmd.Parameters.AddWithValue("@TeacherId", teacherID);

                con.open();
                int exists = (int)checkCmd.ExecuteScalar();
                con.close();

                // If the teacher ID does not exist, show an error and return
                if (exists == 0)
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error, Teacher ID does not exist.";
                    failureForm.Show();
                    return;
                }
            }

            // Proceed with the update if the ID exists
            using (SqlCommand com = new SqlCommand("UpdateTeacher", con.GetConnection()))
            {
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@TeacherID", teacherID);
                com.Parameters.AddWithValue("@NewFirstName", newfirstName);
                com.Parameters.AddWithValue("@NewLastName", newlastName);
                com.Parameters.AddWithValue("@NewEmail", newemail);

                con.open();
                try
                {
                    int result = com.ExecuteNonQuery();

                    if (result == -1)
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

        public void DeleteTeachers(int teacherID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();

            // Check if the teacher ID exists
            using (SqlCommand checkCmd = new SqlCommand("CheckTeacherIdExists", con.GetConnection()))
            {
                checkCmd.CommandType = CommandType.StoredProcedure;
                checkCmd.Parameters.AddWithValue("@TeacherId", teacherID);

                con.open();
                int exists = (int)checkCmd.ExecuteScalar();
                con.close();

                // If the teacher ID does not exist, show an error and return
                if (exists == 0)
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Error, Teacher ID does not exist.";
                    failureForm.Show();
                    return;
                }
            }

            // Proceed with the deletion if the ID exists
            using (SqlCommand com = new SqlCommand("DeleteTeacher", con.GetConnection()))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TeacherID", teacherID);

                con.open();
                try
                {
                    int result = com.ExecuteNonQuery();

                    if (result == -1)
                    {
                        PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                        formInsert.successFormText.Text = "Deleted Successfully";
                        formInsert.Show();
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.");
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






    }
}
