using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;
using PNR_Train_Management_System;

namespace PNR_Locomotive_Management_System
{
    public partial class MainDashboard : Form
    {
        int locomotiveID = 0;

        MySQLHandler handler = new MySQLHandler("localhost", "train_tickets", "root", "joselito12345");
        string filePath = "";

        public MainDashboard()
        {
            InitializeComponent();
            DatabaseTable();
        }

        /*To color the Tab Buttons. To change the background color.*/
        private void Dashboard_Main(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = Dashboard.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = Dashboard.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Gold);
                g.FillRectangle(Brushes.LightBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 14.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        public void DatabaseTable()
        {
            /*To Load the Locomotive Database.*/
            try
            {
                 string Locoquery = "SELECT locomotives.locomotiveID, train_powered.power_source, locomotives.loco_brand, " +
                    "locomotives.loco_manufacturer, locomotives.power_kw, locomotives.tr_eff_kN, locomotives.weight_tons, " +
                    "locomotives.max_speed, locomotives.loco_status FROM locomotives INNER JOIN train_powered ON " +
                    "locomotives.loco_type_id = train_powered.power_id;";

                 MySqlDataReader reader = handler.ExecuteQuery(Locoquery);

                 if (reader != null)
                 {
                     while(reader.Read())
                     {
                         LocoTable.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                         reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5),
                         reader.GetInt32(6), reader.GetInt32(7), reader.GetString(8));
                     }
                 }


                /*
                using (MySqlCommand command = new MySqlCommand(Locoquery, con))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the result set and add rows to the DataTable
                        while (reader.Read())
                        {
                            LocoTable.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5),
                                reader.GetInt32(6), reader.GetInt32(7), reader.GetString(8));
                        }
                    }
                }
                */



                /*To Load the Multiple Units Database.*/
                string MultiUnitQuery = "select multiple_units.multi_unit_id, train_powered.power_source, multiple_units.unit_brand, multiple_units.power_KW, " +
                    "multiple_units.trac_eff, multiple_units.weight_tons,multiple_units.max_speed, multiple_units.max_capacity, multiple_units.status " +
                    "from multiple_units inner join train_powered on multiple_units.power_source_id = train_powered.power_id;";
                
                MySqlDataReader reader2 = handler.ExecuteQuery(MultiUnitQuery);

                if (reader2 != null)
                {
                    while (reader2.Read())
                    {
                        MultipleUnitTable.Rows.Add(reader2.GetInt32(0), reader2.GetString(1), reader2.GetString(2),
                            reader2.GetInt32(3), reader2.GetInt32(4), reader2.GetInt32(5),
                            reader2.GetInt32(6), reader2.GetInt32(7), reader2.GetString(8));
                    }
                }
                /*
                using (MySqlCommand command2 = new MySqlCommand(MultiUnitQuery, con))
                {
                    using (MySqlDataReader reader2 = command2.ExecuteReader())
                    {
                        // Iterate through the result set and add rows to the DataTable
                        while (reader2.Read())
                        {
                            MultipleUnitTable.Rows.Add(reader2.GetInt32(0), reader2.GetString(1), reader2.GetString(2),
                                reader2.GetString(3), reader2.GetInt32(4), reader2.GetInt32(5),
                                reader2.GetInt32(6), reader2.GetInt32(7), reader2.GetInt32(8), reader2.GetInt32(9));
                        }
                    }
                }
                */
                /*To Load All PNR Stations Database.*/
                string Stationquery = "select * from rail_lines;";

                MySqlDataReader reader4 = handler.ExecuteQuery(Stationquery);

                if (reader4 != null)
                {
                    while (reader4.Read())
                    {
                        string isUnderMaintenance = reader4.GetBoolean(3) ? "Under Maintenance" : "Operational";
                        string isElectrified = reader4.GetBoolean(6) ? "Yes" : "No";
                        PNRPassengerLines.Rows.Add(reader4.GetInt32(0), reader4.GetString(1), reader4.GetInt32(2),
                            isUnderMaintenance, reader4.GetInt32(4), reader4.GetInt32(5), isElectrified);
                    }
                }

                string RollingStocksQuery = "select rolling_stock_type, rolling_stock_name, in_service_count, idle_count, maintenance_count from rolling_stock_inventory;";

                MySqlDataReader reader5 = handler.ExecuteQuery(RollingStocksQuery);

                if (reader5 != null)
                {
                    while (reader5.Read())
                    {
                        InventorySummary.Rows.Add(reader5.GetString(0), reader5.GetString(1), reader5.GetInt32(2), reader5.GetInt32(3), reader5.GetInt32(4));
                    }
                }

                handler.CloseCon();
                    /*
                    using(MySqlCommand command4 = new MySqlCommand(Stationquery, con))
                    {
                        using(MySqlDataReader reader4 = command4.ExecuteReader())
                        {
                            while (reader4.Read())
                            {
                                StationsRevenueTable.Rows.Add(reader4.GetInt32(0), reader4.GetString(1), reader4.GetInt32(2),
                                    reader4.GetInt32(3), reader4.GetInt32(4), reader4.GetInt32(5));
                            }
                        }
                    }
                    */
            }
            catch (Exception ex)
            {
                /*To debug, put the first line in comment mode.*/
                MessageBox.Show("There is a problem retrieving ftom the Database. Please Try Again. if the Problem Persists. Contact the System Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*To Load the Passenger Car Database.*/
            
        }

        private void QuitDashboard(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void currTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime date = dt.Date;
            TimeSpan time = dt.TimeOfDay;

            currentDate.Text = date.ToString();
            currentTime.Text = time.ToString();
        }

        private void addLoco_Click(object sender, EventArgs e)
        {
            var LocoAdd = new AddLocomotive();
            LocoAdd.Show();
        }

        private void changeLoco_Click(object sender, EventArgs e)
        {
            if (LocoTable.SelectedRows.Count > 0)
            {
                var selectedRow = LocoTable.SelectedRows[0];
                if (selectedRow.Cells["loco_ID"].Value != null)
                {
                    int locomotiveID;
                    if (int.TryParse(selectedRow.Cells["loco_ID"].Value.ToString(), out locomotiveID))
                    {
                        var LocoEdit = new EditaLocomotive();
                        LocoEdit.SetLocomotiveID(locomotiveID);
                        LocoEdit.Show();
                        LocoEdit.DisplayLocoInformation();
                    }
                    else
                    {
                        MessageBox.Show("An error Occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Handle null value in cell
                    MessageBox.Show("Selected cell value is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle no selected rows
                MessageBox.Show("Please Select a Locomotive to Edit/Update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeLoco_Click(object sender, EventArgs e)
        {
            if (LocoTable.SelectedRows.Count > 0)
            {
                // Retrieve the locomotiveID of the selected row
                locomotiveID = Convert.ToInt32(LocoTable.SelectedRows[0].Cells["loco_ID"].Value);

                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to dispose this locomotive?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Call method to delete the locomotive from the database
                    DeleteLocomotive(locomotiveID);
                }
            }
            else
            {
                MessageBox.Show("Please select a locomotive to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteLocomotive(int locomotiveID)
        {
            try
            {
                string del = "DELETE FROM locomotives WHERE locomotiveID = @locomotiveID";

                MySqlParameter[] p =
                {
                    new MySqlParameter("@locomotiveID", locomotiveID)
                };

                bool result = handler.ExecuteNonQuery(del, p);

                if (result)
                {
                    MessageBox.Show("The Locomotive has Now Been Removed from the Fleet.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LocoTable.Rows.Clear();
                    DatabaseTable();
                }
                else
                {
                    MessageBox.Show("No locomotive found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@locomotiveID", locomotiveID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The Locomotive has Now Been Removed from the Fleet.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LocoTable.Rows.Clear();
                        DatabaseTable();
                    }
                    else
                    {
                        MessageBox.Show("No locomotive found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the locomotive. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addMultiUnit_Click(object sender, EventArgs e)
        {

        }

        private void changeMultiUnit_Click(object sender, EventArgs e)
        {
            if (MultipleUnitTable.SelectedRows.Count > 0)
            {
                var selectedRow = MultipleUnitTable.SelectedRows[0];
                if (selectedRow.Cells["multiUnitID"].Value != null)
                {
                    int locomotiveID;
                    if (int.TryParse(selectedRow.Cells["multiUnitID"].Value.ToString(), out locomotiveID))
                    {
                        var LocoEdit = new EditaLocomotive();
                        LocoEdit.SetLocomotiveID(locomotiveID);
                        LocoEdit.Show();
                        LocoEdit.DisplayLocoInformation();
                    }
                    else
                    {
                        MessageBox.Show("An error Occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Handle null value in cell
                    MessageBox.Show("Selected cell value is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle no selected rows
                MessageBox.Show("Please Select a Locomotive to Edit/Update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeMultiUnit_Click(object sender, EventArgs e)
        {

        }

        private void RollingStockReport_Click(object sender, EventArgs e)
        {
            ReportGeneration report = new ReportGeneration();

            if(SaveExcelFile.ShowDialog() == DialogResult.OK)
            {
                string SavedFileAs = SaveExcelFile.FileName;

                if (string.IsNullOrEmpty(SavedFileAs))
                {
                    MessageBox.Show("Please enter the file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }

                bool isGenerated = report.GenerateReport(InventorySummary, filePath, SavedFileAs);

                if (isGenerated) 
                {
                    MessageBox.Show("Successfully Generated the File saved as: " + SavedFileAs, "Report Generated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occured while generating the report.", "Error Generating the Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PassengerLineStatus_Click(object sender, EventArgs e)
        {

        }

        private void BrowseDialog_Click(object sender, EventArgs e)
        {
            if(ExcelTemplateDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = ExcelTemplateDialog.FileName;
                FilePathTxtBox.Text = filePath;
            }
        }
    }
}
