using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Project999.School_layes
{
    class UsersLayerClass
    {
        Database.DatabaseClass dataAccess = new Database.DatabaseClass();
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();


            dataTable = dataAccess.read("GetUsersHashed", pr);
            return dataTable;
        }


        // Method to hash the password
        private byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public void InsertUser(string userName, string password, int rollID)
        {
            Database.DatabaseClass con = new Database.DatabaseClass();
            SqlCommand com = new SqlCommand("InsertUser", con.GetConnection());
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Username", userName);

            // Hash the password and add it as a byte array
            byte[] passwordHash = HashPassword(password);
            com.Parameters.Add("@PasswordHash", SqlDbType.VarBinary).Value = passwordHash;

            com.Parameters.AddWithValue("@RoleID", rollID);

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
                formInsert.successFormText.Text = "Error, Wrong roll number.";
                formInsert.Show();
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
        }


        public void UpdateUser(int userID, string newUserName, string newPassword, int newRollNumber)
        {
            // Check if the user exists
            Database.DatabaseClass con = new Database.DatabaseClass();
            var connection = con.GetConnection();
            if (connection == null)
            {
                MessageBox.Show("Failed to establish a database connection.");
                return;
            }

            con.open();
            try
            {
                // Check user existence
                using (SqlCommand checkUserCommand = new SqlCommand("CheckUserExists", connection))
                {
                    checkUserCommand.CommandType = CommandType.StoredProcedure;
                    checkUserCommand.Parameters.AddWithValue("@UserID", userID);

                    // Ensure the command is not null
                    if (checkUserCommand == null)
                    {
                        MessageBox.Show("CheckUserExists command is null.");
                        return;
                    }


                    int userExists = (int)checkUserCommand.ExecuteScalar();

                    if (userExists == 0) // User does not exist
                    {
                        MessageBox.Show("User not found.");
                        return;
                    }
                }

                // Hash the new password
                byte[] newPasswordHash = HashPassword(newPassword);

                // Update user
                using (SqlCommand updateCommand = new SqlCommand("UpdateUser", connection))
                {
                    updateCommand.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the update
                    updateCommand.Parameters.AddWithValue("@UserID", userID);
                    updateCommand.Parameters.AddWithValue("@NewUsername", newUserName);
                    updateCommand.Parameters.Add("@NewPasswordHash", SqlDbType.VarBinary).Value = newPasswordHash;
                    updateCommand.Parameters.AddWithValue("@NewRoleID", newRollNumber);

                    // Check if the updateCommand is not null
                    if (updateCommand == null)
                    {
                        MessageBox.Show("UpdateUser command is null.");
                        return;
                    }

                    int result = updateCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                        if (formInsert.successFormText != null)
                        {
                            formInsert.successFormText.Text = "Updated Successfully";
                            formInsert.Show();
                        }
                        else
                        {
                            MessageBox.Show("Success message form not initialized properly.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception for debugging
                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.StackTrace}");
                PresentationLayer.SuccessMessage formInsert = new PresentationLayer.SuccessMessage();
                if (formInsert.successFormText != null)
                {
                    formInsert.successFormText.Text = "Error";
                    formInsert.Show();
                }
                else
                {
                    MessageBox.Show("Success message form not initialized properly.");
                }
            }
            finally
            {
                con.close();
            }
        }





    }
}
