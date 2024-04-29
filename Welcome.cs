using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNR_Locomotive_Management_System
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            // Set the transparency and blur effect for the panel
            /*
            LogInPanel.BackColor = Color.FromArgb(128, Color.LightBlue);
            LogInPanel.BackgroundImage = BlurImage(global::PNR_Locomotive_Management_System.Properties.Resources.background, 10);
            */
        }

        // Method to create a blur effect for an image
        private Bitmap BlurImage(Image image, int blurAmount)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Create a blur effect using Gaussian blur algorithm
                using (Brush brush = new SolidBrush(Color.FromArgb(blurAmount, Color.White)))
                {
                    for (int i = 0; i <= blurAmount; i++)
                    {
                        g.FillRectangle(brush, -i, -i, image.Width + i * 2, image.Height + i * 2);
                    }
                }
            }

            return bmp;
        }

        protected async Task<bool> ValidationAsync()
        {
            await Task.Delay(0);

            String uname = username.Text;
            String pass = password.Text;
            int count = 0;

            /*Call the MySQLHandler Class.*/
            /*The Password Must be Encrypted.*/
            try
            {
                if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please Enter Your Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    string server = "localhost";
                    string database = "train_tickets";
                    string user = "root";
                    string password = "joselito12345";

                    MySQLHandler manage = new MySQLHandler(server, database, user, password);

                    String dblogin = "select count(1) from employee_info where username = @username and password = @password";

                    MySqlParameter[] parameters =
                    {
                        new MySqlParameter("@username", uname),
                        new MySqlParameter("@password", pass)
                    };

                    object result = await manage.ExecuteScalarAsync(dblogin, parameters);

                    if (result != null && result != DBNull.Value)
                    {
                        count = Convert.ToInt32(result);

                        if (count == 1)
                        {
                            MessageBox.Show("Successfully Logged In.");
                            this.Hide();
                            var mainBoard = new MainDashboard();
                            mainBoard.Show();
                            return true;
                        }
                        else
                        {
                            MessageBoxIcon err = MessageBoxIcon.Error;
                            MessageBox.Show("Incorrect Username or Password. Please Try Again.", "Error", MessageBoxButtons.OK, err);
                            return false;
                        }
                    }

                    /*
                    using (var con = new MySqlConnection(conString))
                    {
                        await con.OpenAsync();
                        String dblogin = "select count(1) from admin_info where username = @username and password = @password";
                        MySqlCommand command = new MySqlCommand(dblogin, con);
                        command.Parameters.AddWithValue("@username", uname);
                        command.Parameters.AddWithValue("@password", pass);

                        object result = await command.ExecuteScalarAsync();

                        if (result != null && result != DBNull.Value)
                        {
                            count = Convert.ToInt32(result);

                            if (count == 1)
                            {
                                MessageBox.Show("Successfully Logged In.");
                                this.Hide();
                                var mainBoard = new MainDashboard();
                                mainBoard.Show();
                                return;
                            }
                            else
                            {
                                MessageBoxIcon err = MessageBoxIcon.Error;
                                MessageBox.Show("Incorrect Username or Password. Please Try Again.", "Error", MessageBoxButtons.OK, err);
                            }
                        }
                    }
                    */
                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("There is a problem connecting to the Database. Please Try Again. if the Problem Persists. Contact the System Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case 1045:
                        MessageBox.Show("Invalid Username and Password. Please Contact the System Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return false;
            }
            return false;
        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reset = new resetPassword();
            reset.Show();
        }

        private void QuitProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close the Program?", "Quit Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
            return;
        }

        private async void validate_Click_1(object sender, EventArgs e)
        {
            await ValidationAsync();
        }
    }
}