using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PNR_Locomotive_Management_System
{
    public partial class EditaLocomotive : Form
    {
        int locoId = 0;
        MySQLHandler handler = new MySQLHandler("localhost", "train_tickets", "root", "joselito12345");
        public EditaLocomotive()
        {
            InitializeComponent();
            DisplayLocoInformation();
            this.ChangeLocoStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void SetLocomotiveID(int temp) { locoId = temp; }

        public void DisplayLocoInformation()
        {
            try
            {
                String retrieveLoco = "SELECT train_powered.power_source, locomotives.loco_brand, locomotives.loco_manufacturer, locomotives.power_kw, " +
                    "locomotives.tr_eff_kN, locomotives.weight_tons, locomotives.year_manufactured, locomotives.max_speed, locomotives.loco_status " +
                    "FROM locomotives INNER JOIN train_powered ON locomotives.loco_type_id = train_powered.power_id where locomotiveID = @id";

                MySqlParameter[] param =
                {
                    new MySqlParameter("@id", locoId)
                };

                using(MySqlDataReader read = handler.ExecuteQuery(retrieveLoco))
                {
                    if (read.Read())
                    {
                        //General Information
                        LocoBrand.Text = read["loco_brand"].ToString();
                        Manufacturer.Text = read["loco_manufacturer"].ToString();
                        LocomotiveType.Text = read["power_source"].ToString();
                        YearManufactured.Text = read["year_manufactured"].ToString();
                        CurrentLocoStatus.Text = read["loco_status"].ToString();
                        //Technical Specifications.
                        PowerinKW.Text = read["power_kw"].ToString();
                        TractiveEffort.Text = read["tr_eff_kN"].ToString();
                        WeightinTons.Text = read["weight_tons"].ToString();
                        MaxDesignedSpeed.Text = read["max_speed"].ToString();
                    }
                }
                /*
                 * Original Code:
                using (var con = new MySqlConnection(connect))
                {
                    con.Open();
                    String retrieveLoco = "SELECT train_powered.power_source, locomotives.loco_brand, locomotives.loco_manufacturer, locomotives.power_kw, " +
                        "locomotives.tr_eff_kN, locomotives.weight_tons, locomotives.year_manufactured, locomotives.max_speed, locomotives.loco_status " +
                        "FROM locomotives INNER JOIN train_powered ON locomotives.loco_type_id = train_powered.power_id where locomotiveID = @id";
                    MySqlCommand command = new MySqlCommand(retrieveLoco, con);
                    command.Parameters.AddWithValue("@id", locoId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //General Information
                            LocoBrand.Text = reader["loco_brand"].ToString();
                            Manufacturer.Text = reader["loco_manufacturer"].ToString();
                            LocomotiveType.Text = reader["power_source"].ToString();
                            YearManufactured.Text = reader["year_manufactured"].ToString();
                            CurrentLocoStatus.Text = reader["loco_status"].ToString();
                            //Technical Specifications.
                            PowerinKW.Text = reader["power_kw"].ToString();
                            TractiveEffort.Text = reader["tr_eff_kN"].ToString();
                            WeightinTons.Text = reader["weight_tons"].ToString();
                            MaxDesignedSpeed.Text = reader["max_speed"].ToString();
                        }
                    }
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("There is a problem connecting to the Database. Please Try Again. if the Problem Persists. Contact the System Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateaLocomotive_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you Sure the Information You Entered is Correct According to the Specifications?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == confirm)
            {
                try
                {
                    string updateQuery = "UPDATE locomotives SET loco_brand = @locoBrand, loco_manufacturer = @locoManufacturer, " +
                                         "power_kw = @powerKw, tr_eff_kN = @trEffKn, weight_tons = @weightTons, " +
                                         "year_manufactured = @yearManufactured, max_speed = @maxSpeed, loco_status = @status WHERE locomotiveID = @locoId";

                    MySqlParameter[] param =
                    {
                        new MySqlParameter("@locoBrand", LocoBrand.Text),
                        new MySqlParameter("@loco_manufacturer", Manufacturer.Text),
                        new MySqlParameter("@powerKw", Convert.ToInt32(PowerinKW.Text)),
                        new MySqlParameter("@trEffKn", Convert.ToDouble(TractiveEffort.Text)),
                        new MySqlParameter("@weightTons", Convert.ToDouble(WeightinTons.Text)),
                        new MySqlParameter("@yearManufactured", Convert.ToInt32(YearManufactured.Text)),
                        new MySqlParameter("@maxSpeed", Convert.ToInt32(MaxDesignedSpeed.Text)),
                        new MySqlParameter("@status", ChangeLocoStatus.SelectedItem.ToString()),
                        new MySqlParameter("@locoId", locoId)
                    };

                    bool IsExecuted = handler.ExecuteNonQuery(updateQuery, param);

                    if (IsExecuted)
                    {
                        MessageBox.Show("Locomotive information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        var dashboard = new MainDashboard();
                        dashboard.DatabaseTable();
                        return;
                    }
                    /*
                    using (var con = new MySqlConnection(connect))
                    {
                        con.Open();

                        // Update the locomotive information in the database
                        string updateQuery = "UPDATE locomotives SET loco_brand = @locoBrand, loco_manufacturer = @locoManufacturer, " +
                                             "power_kw = @powerKw, tr_eff_kN = @trEffKn, weight_tons = @weightTons, " +
                                             "year_manufactured = @yearManufactured, max_speed = @maxSpeed, loco_status = @status WHERE locomotiveID = @locoId";

                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, con))
                        {
                            updateCommand.Parameters.AddWithValue("@locoBrand", LocoBrand.Text);
                            updateCommand.Parameters.AddWithValue("@locoManufacturer", Manufacturer.Text);
                            updateCommand.Parameters.AddWithValue("@powerKw", Convert.ToInt32(PowerinKW.Text));
                            updateCommand.Parameters.AddWithValue("@trEffKn", Convert.ToDouble(TractiveEffort.Text));
                            updateCommand.Parameters.AddWithValue("@weightTons", Convert.ToDouble(WeightinTons.Text));
                            updateCommand.Parameters.AddWithValue("@yearManufactured", Convert.ToInt32(YearManufactured.Text));
                            updateCommand.Parameters.AddWithValue("@maxSpeed", Convert.ToInt32(MaxDesignedSpeed.Text));
                            updateCommand.Parameters.AddWithValue("@status", ChangeLocoStatus.SelectedItem.ToString());
                            updateCommand.Parameters.AddWithValue("@locoId", locoId);

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Locomotive information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                var dashboard = new MainDashboard();
                                dashboard.DatabaseTable();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Failed to update locomotive information. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("There is something wrong when adding a new Locomotive. If the Problem Persists, contact the System Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}
