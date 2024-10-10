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
    class EnrolmentLayerClass
    {
        Database.DatabaseClass dataAccess = new Database.DatabaseClass();
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.read("GetEnrollmentFromView", pr);
            return dataTable;
        }

        public void InsertEnrolment(int enrolmentID, int classID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();

            // Check if Student ID exists
            using (SqlCommand checkStudentCmd = new SqlCommand("CheckStudentExistsInEnrolment", con.GetConnection()))
            {
                checkStudentCmd.CommandType = CommandType.StoredProcedure;
                checkStudentCmd.Parameters.AddWithValue("@StudentID", enrolmentID);

                con.open();
                int studentExists = (int)checkStudentCmd.ExecuteScalar();
                con.close();

                if (studentExists == 0)
                {
                    PresentationLayer.FailureForm failureForm = new Project999.PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Student ID not found.";
                    failureForm.Show();
                    return;
                }
            }

            // Check if Class ID exists
            using (SqlCommand checkClassCmd = new SqlCommand("CheckClassExistsInEnrolment", con.GetConnection()))
            {
                checkClassCmd.CommandType = CommandType.StoredProcedure;
                checkClassCmd.Parameters.AddWithValue("@ClassID", classID);

                con.open();
                int classExists = (int)checkClassCmd.ExecuteScalar();
                con.close();

                if (classExists == 0)
                {
                    PresentationLayer.FailureForm failureForm = new Project999.PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Class ID not found.";
                    failureForm.Show();
                    return;
                }
            }

            SqlCommand com = new SqlCommand("InsertEnrollment", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@StudentID", enrolmentID);
            com.Parameters.AddWithValue("@ClassID", classID);

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
            finally
            {
                con.close();
            }
        }

        public void DeleteEnrolment(int enrollmentID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();

            // Check if the enrollment ID exists
            SqlCommand checkCommand = new SqlCommand("CheckEnrollmentExists", con.GetConnection());
            checkCommand.CommandType = CommandType.StoredProcedure;
            checkCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

            con.open();
            try
            {
                int exists = (int)checkCommand.ExecuteScalar();

                if (exists > 0) // Enrollment ID exists
                {
                    // Proceed to delete
                    SqlCommand deleteCommand = new SqlCommand("DeleteEnrollment", con.GetConnection());
                    deleteCommand.CommandType = CommandType.StoredProcedure;
                    deleteCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                    int result = deleteCommand.ExecuteNonQuery();

                    if (result == -1) // Assuming 1 indicates success
                    {
                        PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                        formInsert.successFormText.Text = "Delete Successfully";
                        formInsert.Show();
                    }
                    else
                    {
                        PresentationLayer.FailureForm failureForm = new Project999.PresentationLayer.FailureForm();
                        failureForm.FailureFormText.Text = "Failed";
                        failureForm.Show();
                    }
                }
                else
                {
                    PresentationLayer.FailureForm failureForm = new Project999.PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Enrollment ID not found.";
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
