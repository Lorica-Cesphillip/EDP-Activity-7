using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNR_Locomotive_Management_System
{
    public partial class AddLocomotive : Form
    {
        private MainDashboard mainDashboard = new MainDashboard();

        private MySQLHandler manage = new MySQLHandler("localhost", "train_tickets", "root", "joselito12345");

        public AddLocomotive()
        {
            InitializeComponent();
            this.LocomotiveType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task<int> GetForeignKeyValueAsync(string powerSource)
        {
            string query = "SELECT power_id FROM train_powered where power_source = @powerSource";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@powerSource", powerSource)
            };

            object result = await manage.ExecuteScalarAsync(query, parameters);
            if (result != null) { return Convert.ToInt32(result); }
            else { throw new Exception("No loco_type_id found in train_powered table."); }

            /*
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@powerSource", powerSource);
                object result = command.ExecuteScalar(); //Null Reference Exception
                if (result != null)
                    return Convert.ToInt32(result);
                else
                    throw new Exception("No loco_type_id found in train_powered table.");
            }
            */
        }

        private async void AddaLocomotive_Click(object sender, EventArgs e)
        {
            String yearStr = YearManufactured.Text;
            DateTime yearDate = DateTime.ParseExact(yearStr, "yyyy", null);

            try
            {
                string query = "INSERT INTO `locomotives` (`loco_type_id`, `loco_brand`, `loco_manufacturer`, `power_kw`, `tr_eff_kN`, `weight_tons`, `year_manufactured`, `max_speed`, `loco_status`)" +
                            "VALUES(@locoTypeId, @locoBrand, @locoManufacturer, @powerKw, @trEffKn, @weightTons, @yearManufactured, @maxSpeed, @status)";

                int locoTypeID = await GetForeignKeyValueAsync(LocomotiveType.SelectedItem.ToString());

                MySqlParameter[] param =
                {
                    new MySqlParameter("@locoTypeId", locoTypeID),
                    new MySqlParameter("@locoBrand", LocoBrand.Text),
                    new MySqlParameter("@locoManufacturer", Manufacturer.Text),
                    new MySqlParameter("@powerKw", Convert.ToInt32(PowerinKW.Text)),
                    new MySqlParameter("@treffKn", Convert.ToDouble(TractiveEffort.Text)),
                    new MySqlParameter("@weightTons", Convert.ToDouble(WeightinTons.Text)),
                    new MySqlParameter("@yearManufactured", yearDate),
                    new MySqlParameter("@maxSpeed", Convert.ToInt32(MaxDesignedSpeed.Text)),
                    new MySqlParameter("@status", "🔶 Idle at the Garage")
                };

                bool result = manage.ExecuteNonQuery(query, param);

                if (result)
                {
                    MessageBox.Show("Locomotive Added to Database Successfully", "New Locomotive Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainDashboard.DatabaseTable();
                    this.Close();
                    return;
                }
                /*
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@locoTypeId", GetForeignKeyValue(conn, LocomotiveType.SelectedItem.ToString()));
                        cmd.Parameters.AddWithValue("@locoBrand", LocoBrand.Text);
                        cmd.Parameters.AddWithValue("@locoManufacturer", Manufacturer.Text);
                        cmd.Parameters.AddWithValue("@powerKw", Convert.ToInt32(PowerinKW.Text));
                        cmd.Parameters.AddWithValue("@trEffKn", Convert.ToDouble(TractiveEffort.Text));
                        cmd.Parameters.AddWithValue("@weightTons", Convert.ToDouble(WeightinTons.Text));
                        cmd.Parameters.AddWithValue("@yearManufactured", yearDate);
                        cmd.Parameters.AddWithValue("@maxSpeed", Convert.ToInt32(MaxDesignedSpeed.Text));
                        cmd.Parameters.AddWithValue("@status", "🔶 Idle at the Garage"); This is the Default Status of a Locomotive

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sucessfully Added a New Locomotive.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainDashboard.DatabaseTable();
                            this.Close();
                            return;
                        }
                    }
                }
                */
            }
            catch (Exception ex)
            {
                //MessageBox.Show("There is something wrong when adding a new Locomotive. If the Problem Persists, contact the System Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void AddLocomotive_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}