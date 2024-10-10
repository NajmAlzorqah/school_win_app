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
    class StudentClass
    {
        Database.DatabaseClass dataAccess = new Database.DatabaseClass();
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.read("GetStudents", pr);
            return dataTable;
        }

        // INsert method
        /*
        public void insert(string studentInfo, string lastName, string dateOB, string email)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("FirstName", studentInfo);
            pr[1] = new SqlParameter("LastName", lastName);
            pr[2] = new SqlParameter("DateOfBirth", dateOB);
            pr[3] = new SqlParameter("Email", email);
            
            dataAccess.open();
            dataAccess.exce("InsertStudent", pr);
            dataAccess.close();
        }
        */

        //==============================================================================
        public void InsertStudent(string firstName, string lastName, string dateOfBirth, string email)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand com = new SqlCommand("InsertStudent3", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@FirstName", firstName);
            com.Parameters.AddWithValue("@LastName", lastName);
            com.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            com.Parameters.AddWithValue("@Email", email);
         
            con.open();
            try
            {
                int result = com.ExecuteNonQuery();

                if (result > 0)
                {
                    PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                    formInsert.Show();
                    //MessageBox.Show("Insert Successful.");
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
                //MessageBox.Show("Error: " + ex.Message);
            }
            con.close();

        }


        public void UpdateStudent(string id, string newFirstName, string newLastName, string newDOB, string newEmail)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand com = new SqlCommand("UpdateStudent2", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;


            
            int studentID;
            int.TryParse(id, out studentID);
            
            com.Parameters.AddWithValue("@StudentID", studentID);
            com.Parameters.AddWithValue("@NewFirstName", newFirstName);
            com.Parameters.AddWithValue("@NewLastName", newLastName);
            com.Parameters.AddWithValue("@NewDateOfBirth", newDOB);
            com.Parameters.AddWithValue("@NewEmail", newEmail);

            con.open();
            try
            {
                int result = com.ExecuteNonQuery();

                if (result > 0)
                {
                    PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                    formInsert.successFormText.Text = "Update Successfuly";
                    formInsert.Show();
                }
                else
                {
                    PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Grade ID not found.";
                    failureForm.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            con.close();

        }

        public void DeleteStudent(string id)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand checkCommand = new SqlCommand("CheckStudentExists", con.GetConnection());
            checkCommand.CommandType = CommandType.StoredProcedure;

            int studentID;
            if (!int.TryParse(id, out studentID))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            checkCommand.Parameters.AddWithValue("@StudentID", studentID);

            con.open();
            try
            {
                // Check if the student exists
                object exists = checkCommand.ExecuteScalar();

                if (exists != null && (int)exists > 0)
                {
                    // Proceed to delete if the student exists
                    SqlCommand deleteCommand = new SqlCommand("DeleteStudent", con.GetConnection());
                    deleteCommand.CommandType = CommandType.StoredProcedure;
                    deleteCommand.Parameters.AddWithValue("@StudentID", studentID);

                    int result = deleteCommand.ExecuteNonQuery();

                    if (result == -1)
                    {
                        PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                        formInsert.successFormText.Text = "Delete Successfully";
                        formInsert.Show();
                    }
                    else
                    {
                        PresentationLayer.FailureForm failureForm = new PresentationLayer.FailureForm();
                        failureForm.Show();
                    }
                }
                else
                {
                    PresentationLayer.FailureForm failureForm = new Project999.PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Student ID not found.";
                    failureForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.close();
            }
        }


    }
}
