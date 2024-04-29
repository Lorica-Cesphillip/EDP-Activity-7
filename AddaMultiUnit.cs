using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PNR_Locomotive_Management_System;
using PNR_Train_Management_System;

namespace PNR_Train_Management_System
{
    public partial class AddaMultiUnit : Form
    {
        private MainDashboard mainDashboard = new MainDashboard();
        MySQLHandler handler = new MySQLHandler("localhost", "train_tickets", "root", "joselito12345");
        public AddaMultiUnit()
        {
            InitializeComponent();
        }
        private async Task<int> GetForeignKeyValueAsync(string powerSource)
        {
            string query = "SELECT power_id FROM train_powered where power_source = @powerSource";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@powerSource", powerSource)
            };

            object result = await handler.ExecuteScalarAsync(query, parameters);
            if (result != null) { return Convert.ToInt32(result); }
            else { throw new Exception("No loco_type_id found in train_powered table."); }
        }
        private void AddaMultipleUnit_Click(object sender, EventArgs e)
        {
            String yearStr = YearManufactured.Text;
            DateTime yearDate = DateTime.ParseExact(yearStr, "yyyy", null);

            try
            {
                string query = "INSERT INTO " +
                            "VALUES";

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

                bool result = handler.ExecuteNonQuery(query, param);

                if (result)
                {
                    MessageBox.Show("Locomotive Added to Database Successfully", "New Locomotive Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainDashboard.DatabaseTable();
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("There is something wrong when adding a new Locomotive. If the Problem Persists, contact the System Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
