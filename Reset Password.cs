using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PNR_Locomotive_Management_System
{
    public partial class resetPassword : Form
    {
        string server = "localhost";
        string database = "train_tickets";
        string user = "root";
        string password = "joselito12345";
        public resetPassword()
        {
            InitializeComponent();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            /*Change the admin password from the database.*/
            String AdminName = adminU.Text;
            String newPassword = newPass.Text;
            String confirm = repeatNewPass.Text;

            if (confirm == newPassword)
            {
                try
                {
                    MySQLHandler handler = new MySQLHandler(server, database, user, password);

                    string updateUser = "UPDATE admin_info SET password = @password WHERE username = @username";

                    MySqlParameter[] UserParam = {
                        new MySqlParameter("@username", AdminName),
                        new MySqlParameter("@password", newPassword)
                    };

                    bool result = handler.ExecuteNonQuery(updateUser, UserParam);

                    if (result)
                    {
                        DialogResult okay = MessageBox.Show("Your Password Has been updated. Please Log In Again.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("The Admin Username You entered does not exist in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        adminU.Text = "";
                        newPass.Text = "";
                        repeatNewPass.Text = "";
                        AdminName = "";
                        newPassword = "";
                        confirm = "";
                        return;
                    }
                    /*
                    using (var con = new MySqlConnection(connect))
                    {
                        con.Open();

                        // Update the password in the database
                        string updateQuery = "UPDATE admin_info SET password = @password WHERE username = @username";

                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, con))
                        {
                            updateCommand.Parameters.AddWithValue("@username", AdminName);
                            updateCommand.Parameters.AddWithValue("@password", newPassword);
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                DialogResult okay = MessageBox.Show("Your Password Has been updated. Please Log In Again.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("The Admin Username You entered does not exist in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                adminU.Text = "";
                                newPass.Text = "";
                                repeatNewPass.Text = "";
                                return;
                            }
                        }
                    }
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is something wrong when changing the password. If the Problem Persists, contact the System Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Both Passwords are Incorrect. Please Try Again.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminU.Text = "";
                newPass.Text = "";
                repeatNewPass.Text = "";
                return;
            }
        }
    }
}
