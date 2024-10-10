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
    class GradesLayerClass
    {
        Database.DatabaseClass dataAccess = new Database.DatabaseClass();
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();

            dataTable = dataAccess.read("GetGradesFromView", pr);
            return dataTable;
        }

        // INSERT To Classes
        public void InsertGrades(string ID, string classID, string grades)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand com = new SqlCommand("AddGrade", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;


            int studentID;
            int clID;
            decimal studentGrades;
            int.TryParse(ID, out studentID);
            int.TryParse(classID, out clID);
            decimal.TryParse(grades, out studentGrades);


            com.Parameters.AddWithValue("@StudentID", studentID);
            com.Parameters.AddWithValue("@ClassSubjectID", clID);
            com.Parameters.AddWithValue("@Grade", studentGrades);


            con.open();
            try
            {
                int result = com.ExecuteNonQuery();

                if (result > 0)
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


        public void UpdateGrades(string ID, string grades)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand com = new SqlCommand("UpdateGrade", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;


            int gradeID;
            //int studetnID;
            decimal studentNewGrades;

            int.TryParse(ID, out gradeID);
            //int.TryParse(sID, out studetnID);
            decimal.TryParse(grades, out studentNewGrades);

            //com.Parameters.AddWithValue("@StudentID", studetnID);
            com.Parameters.AddWithValue("@GradeID", gradeID);
            com.Parameters.AddWithValue("@NewGrade", studentNewGrades);


            con.open();
            try
            {
                int result = com.ExecuteNonQuery();

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
                PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                formInsert.successFormText.Text = "Error";
                formInsert.Show();
                MessageBox.Show(ex.Message);

            }
            con.close();

        }

        public void DeleteGrades(string ID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand checkCommand = new SqlCommand("CheckGradeExists", con.GetConnection());
            checkCommand.CommandType = CommandType.StoredProcedure;

            int gradeID;
            if (!int.TryParse(ID, out gradeID))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            checkCommand.Parameters.AddWithValue("@GradeID", gradeID);

            con.open();
            try
            {
                // Check if the grade exists
                object exists = checkCommand.ExecuteScalar();

                if (exists != null && (int)exists > 0)
                {
                    // Proceed to delete if the grade exists
                    SqlCommand deleteCommand = new SqlCommand("DeleteGrade", con.GetConnection());
                    deleteCommand.CommandType = CommandType.StoredProcedure;
                    deleteCommand.Parameters.AddWithValue("@GradeID", gradeID);

                    int result = deleteCommand.ExecuteNonQuery();

                    if (result == -1)
                    {
                        PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                        formInsert.successFormText.Text = "Delete Successfully";
                        formInsert.Show();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed.");
                    }
                }
                else
                {
                    PresentationLayer.FailureForm failureForm = new Project999.PresentationLayer.FailureForm();
                    failureForm.FailureFormText.Text = "Failed, Grade ID not found.";
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
