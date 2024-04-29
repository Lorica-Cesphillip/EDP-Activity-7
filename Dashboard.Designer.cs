namespace PNR_Locomotive_Management_System
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.currTime = new System.Windows.Forms.Timer(this.components);
            this.Options = new System.Windows.Forms.TabPage();
            this.PassengerLine = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.removeStation = new System.Windows.Forms.Button();
            this.changeStation = new System.Windows.Forms.Button();
            this.addStation = new System.Windows.Forms.Button();
            this.PNRPassengerLines = new System.Windows.Forms.DataGridView();
            this.lineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainsNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passenger_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electrified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainCars = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.delTrainCar = new System.Windows.Forms.Button();
            this.updateTrainCar = new System.Windows.Forms.Button();
            this.addTrainCar = new System.Windows.Forms.Button();
            this.RailCarTable = new System.Windows.Forms.DataGridView();
            this.railCarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatingCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passMaxSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MultiUnit = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.removeMultiUnit = new System.Windows.Forms.Button();
            this.changeMultiUnit = new System.Windows.Forms.Button();
            this.addMultiUnit = new System.Windows.Forms.Button();
            this.MultipleUnitTable = new System.Windows.Forms.DataGridView();
            this.multiUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locomotives = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.removeLoco = new System.Windows.Forms.Button();
            this.changeLoco = new System.Windows.Forms.Button();
            this.addLoco = new System.Windows.Forms.Button();
            this.LocoTable = new System.Windows.Forms.DataGridView();
            this.loco_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loco_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trEff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home = new System.Windows.Forms.TabPage();
            this.RollingStockPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InventorySummary = new System.Windows.Forms.DataGridView();
            this.BrowseDialog = new System.Windows.Forms.Button();
            this.FilePathTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StationStatus = new System.Windows.Forms.Button();
            this.PassengerLineStatus = new System.Windows.Forms.Button();
            this.RollingStockReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.TabControl();
            this.ExcelTemplateDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveExcelFile = new System.Windows.Forms.SaveFileDialog();
            this.RollingStockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollingStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InServiceCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnderMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PNRPassengerLines)).BeginInit();
            this.TrainCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RailCarTable)).BeginInit();
            this.MultiUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleUnitTable)).BeginInit();
            this.Locomotives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocoTable)).BeginInit();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollingStockPieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventorySummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // currTime
            // 
            this.currTime.Tick += new System.EventHandler(this.currTime_Tick);
            // 
            // Options
            // 
            this.Options.Location = new System.Drawing.Point(304, 4);
            this.Options.Margin = new System.Windows.Forms.Padding(2);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(1058, 685);
            this.Options.TabIndex = 5;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            // 
            // PassengerLine
            // 
            this.PassengerLine.Controls.Add(this.label3);
            this.PassengerLine.Controls.Add(this.removeStation);
            this.PassengerLine.Controls.Add(this.changeStation);
            this.PassengerLine.Controls.Add(this.addStation);
            this.PassengerLine.Controls.Add(this.PNRPassengerLines);
            this.PassengerLine.Location = new System.Drawing.Point(304, 4);
            this.PassengerLine.Margin = new System.Windows.Forms.Padding(2);
            this.PassengerLine.Name = "PassengerLine";
            this.PassengerLine.Size = new System.Drawing.Size(1058, 685);
            this.PassengerLine.TabIndex = 4;
            this.PassengerLine.Text = "Passenger Lines";
            this.PassengerLine.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 36);
            this.label3.TabIndex = 45;
            this.label3.Text = "PNR PASSENGER LINES\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeStation
            // 
            this.removeStation.BackColor = System.Drawing.Color.Navy;
            this.removeStation.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStation.ForeColor = System.Drawing.Color.Gold;
            this.removeStation.Location = new System.Drawing.Point(707, 580);
            this.removeStation.Margin = new System.Windows.Forms.Padding(2);
            this.removeStation.Name = "removeStation";
            this.removeStation.Size = new System.Drawing.Size(157, 66);
            this.removeStation.TabIndex = 15;
            this.removeStation.Text = "Remove a Train Station\r\n\r\n";
            this.removeStation.UseVisualStyleBackColor = false;
            // 
            // changeStation
            // 
            this.changeStation.BackColor = System.Drawing.Color.Navy;
            this.changeStation.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStation.ForeColor = System.Drawing.Color.Gold;
            this.changeStation.Location = new System.Drawing.Point(424, 580);
            this.changeStation.Margin = new System.Windows.Forms.Padding(2);
            this.changeStation.Name = "changeStation";
            this.changeStation.Size = new System.Drawing.Size(157, 66);
            this.changeStation.TabIndex = 14;
            this.changeStation.Text = "Change a Train Station";
            this.changeStation.UseVisualStyleBackColor = false;
            // 
            // addStation
            // 
            this.addStation.BackColor = System.Drawing.Color.Navy;
            this.addStation.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStation.ForeColor = System.Drawing.Color.Gold;
            this.addStation.Location = new System.Drawing.Point(138, 580);
            this.addStation.Margin = new System.Windows.Forms.Padding(2);
            this.addStation.Name = "addStation";
            this.addStation.Size = new System.Drawing.Size(157, 66);
            this.addStation.TabIndex = 13;
            this.addStation.Text = "Add a New Train Station";
            this.addStation.UseVisualStyleBackColor = false;
            // 
            // PNRPassengerLines
            // 
            this.PNRPassengerLines.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PNRPassengerLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PNRPassengerLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineID,
            this.name,
            this.km_length,
            this.maintenance,
            this.TrainsNum,
            this.passenger_volume,
            this.electrified});
            this.PNRPassengerLines.Location = new System.Drawing.Point(48, 114);
            this.PNRPassengerLines.Margin = new System.Windows.Forms.Padding(2);
            this.PNRPassengerLines.Name = "PNRPassengerLines";
            this.PNRPassengerLines.RowHeadersWidth = 51;
            this.PNRPassengerLines.RowTemplate.Height = 24;
            this.PNRPassengerLines.Size = new System.Drawing.Size(969, 434);
            this.PNRPassengerLines.TabIndex = 12;
            // 
            // lineID
            // 
            this.lineID.HeaderText = "Passenger Line ID";
            this.lineID.MinimumWidth = 6;
            this.lineID.Name = "lineID";
            this.lineID.Width = 75;
            // 
            // name
            // 
            this.name.HeaderText = "Line Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // km_length
            // 
            this.km_length.HeaderText = "KM_Length";
            this.km_length.MinimumWidth = 6;
            this.km_length.Name = "km_length";
            // 
            // maintenance
            // 
            this.maintenance.HeaderText = "Under Maintenance";
            this.maintenance.MinimumWidth = 6;
            this.maintenance.Name = "maintenance";
            this.maintenance.Width = 160;
            // 
            // TrainsNum
            // 
            this.TrainsNum.HeaderText = "Number of Trains";
            this.TrainsNum.MinimumWidth = 6;
            this.TrainsNum.Name = "TrainsNum";
            // 
            // passenger_volume
            // 
            this.passenger_volume.HeaderText = "Passenger Volume";
            this.passenger_volume.MinimumWidth = 6;
            this.passenger_volume.Name = "passenger_volume";
            this.passenger_volume.Width = 160;
            // 
            // electrified
            // 
            this.electrified.HeaderText = "Electrified";
            this.electrified.Name = "electrified";
            // 
            // TrainCars
            // 
            this.TrainCars.Controls.Add(this.label13);
            this.TrainCars.Controls.Add(this.delTrainCar);
            this.TrainCars.Controls.Add(this.updateTrainCar);
            this.TrainCars.Controls.Add(this.addTrainCar);
            this.TrainCars.Controls.Add(this.RailCarTable);
            this.TrainCars.Location = new System.Drawing.Point(304, 4);
            this.TrainCars.Margin = new System.Windows.Forms.Padding(2);
            this.TrainCars.Name = "TrainCars";
            this.TrainCars.Size = new System.Drawing.Size(1058, 685);
            this.TrainCars.TabIndex = 2;
            this.TrainCars.Text = "Train Cars";
            this.TrainCars.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(305, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(450, 27);
            this.label13.TabIndex = 44;
            this.label13.Text = "PNR PASSENGER CARS IN STOCK/SERVICE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delTrainCar
            // 
            this.delTrainCar.BackColor = System.Drawing.Color.Navy;
            this.delTrainCar.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delTrainCar.ForeColor = System.Drawing.Color.Gold;
            this.delTrainCar.Location = new System.Drawing.Point(670, 548);
            this.delTrainCar.Margin = new System.Windows.Forms.Padding(2);
            this.delTrainCar.Name = "delTrainCar";
            this.delTrainCar.Size = new System.Drawing.Size(157, 66);
            this.delTrainCar.TabIndex = 11;
            this.delTrainCar.Text = "Remove Train Cars";
            this.delTrainCar.UseVisualStyleBackColor = false;
            // 
            // updateTrainCar
            // 
            this.updateTrainCar.BackColor = System.Drawing.Color.Navy;
            this.updateTrainCar.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTrainCar.ForeColor = System.Drawing.Color.Gold;
            this.updateTrainCar.Location = new System.Drawing.Point(450, 548);
            this.updateTrainCar.Margin = new System.Windows.Forms.Padding(2);
            this.updateTrainCar.Name = "updateTrainCar";
            this.updateTrainCar.Size = new System.Drawing.Size(157, 66);
            this.updateTrainCar.TabIndex = 10;
            this.updateTrainCar.Text = "Update Train Cars";
            this.updateTrainCar.UseVisualStyleBackColor = false;
            // 
            // addTrainCar
            // 
            this.addTrainCar.BackColor = System.Drawing.Color.Navy;
            this.addTrainCar.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTrainCar.ForeColor = System.Drawing.Color.Gold;
            this.addTrainCar.Location = new System.Drawing.Point(229, 548);
            this.addTrainCar.Margin = new System.Windows.Forms.Padding(2);
            this.addTrainCar.Name = "addTrainCar";
            this.addTrainCar.Size = new System.Drawing.Size(157, 66);
            this.addTrainCar.TabIndex = 9;
            this.addTrainCar.Text = "Add a New Train Car";
            this.addTrainCar.UseVisualStyleBackColor = false;
            // 
            // RailCarTable
            // 
            this.RailCarTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.RailCarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RailCarTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.railCarID,
            this.carBrand,
            this.carManufacturer,
            this.year,
            this.seatingCapacity,
            this.passMaxSpeed,
            this.unitsAvailable,
            this.UnitsUsed});
            this.RailCarTable.Location = new System.Drawing.Point(130, 132);
            this.RailCarTable.Margin = new System.Windows.Forms.Padding(2);
            this.RailCarTable.Name = "RailCarTable";
            this.RailCarTable.RowHeadersWidth = 51;
            this.RailCarTable.RowTemplate.Height = 24;
            this.RailCarTable.Size = new System.Drawing.Size(799, 412);
            this.RailCarTable.TabIndex = 8;
            // 
            // railCarID
            // 
            this.railCarID.HeaderText = "Rail Car ID";
            this.railCarID.MinimumWidth = 6;
            this.railCarID.Name = "railCarID";
            this.railCarID.Width = 70;
            // 
            // carBrand
            // 
            this.carBrand.HeaderText = "Brand";
            this.carBrand.MinimumWidth = 6;
            this.carBrand.Name = "carBrand";
            this.carBrand.Width = 150;
            // 
            // carManufacturer
            // 
            this.carManufacturer.HeaderText = "Manufacturer";
            this.carManufacturer.MinimumWidth = 6;
            this.carManufacturer.Name = "carManufacturer";
            this.carManufacturer.Width = 150;
            // 
            // year
            // 
            this.year.HeaderText = "Year Manufactured";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.Width = 75;
            // 
            // seatingCapacity
            // 
            this.seatingCapacity.HeaderText = "Seating Capacity";
            this.seatingCapacity.MinimumWidth = 6;
            this.seatingCapacity.Name = "seatingCapacity";
            this.seatingCapacity.Width = 75;
            // 
            // passMaxSpeed
            // 
            this.passMaxSpeed.HeaderText = "Maximum Speed";
            this.passMaxSpeed.MinimumWidth = 6;
            this.passMaxSpeed.Name = "passMaxSpeed";
            this.passMaxSpeed.Width = 75;
            // 
            // unitsAvailable
            // 
            this.unitsAvailable.HeaderText = "Units Available";
            this.unitsAvailable.MinimumWidth = 6;
            this.unitsAvailable.Name = "unitsAvailable";
            this.unitsAvailable.Width = 75;
            // 
            // UnitsUsed
            // 
            this.UnitsUsed.HeaderText = "Units Currently in Use";
            this.UnitsUsed.MinimumWidth = 6;
            this.UnitsUsed.Name = "UnitsUsed";
            this.UnitsUsed.Width = 75;
            // 
            // MultiUnit
            // 
            this.MultiUnit.Controls.Add(this.label12);
            this.MultiUnit.Controls.Add(this.removeMultiUnit);
            this.MultiUnit.Controls.Add(this.changeMultiUnit);
            this.MultiUnit.Controls.Add(this.addMultiUnit);
            this.MultiUnit.Controls.Add(this.MultipleUnitTable);
            this.MultiUnit.Location = new System.Drawing.Point(304, 4);
            this.MultiUnit.Margin = new System.Windows.Forms.Padding(2);
            this.MultiUnit.Name = "MultiUnit";
            this.MultiUnit.Size = new System.Drawing.Size(1058, 685);
            this.MultiUnit.TabIndex = 3;
            this.MultiUnit.Text = "Multiple Units";
            this.MultiUnit.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(276, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(491, 27);
            this.label12.TabIndex = 43;
            this.label12.Text = "CURRENT MULTIPLE UNITS IN STOCK/SERVICE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeMultiUnit
            // 
            this.removeMultiUnit.BackColor = System.Drawing.Color.Navy;
            this.removeMultiUnit.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMultiUnit.ForeColor = System.Drawing.Color.Gold;
            this.removeMultiUnit.Location = new System.Drawing.Point(662, 541);
            this.removeMultiUnit.Margin = new System.Windows.Forms.Padding(2);
            this.removeMultiUnit.Name = "removeMultiUnit";
            this.removeMultiUnit.Size = new System.Drawing.Size(157, 66);
            this.removeMultiUnit.TabIndex = 7;
            this.removeMultiUnit.Text = "Remove a Multiple Unit";
            this.removeMultiUnit.UseVisualStyleBackColor = false;
            this.removeMultiUnit.Click += new System.EventHandler(this.removeMultiUnit_Click);
            // 
            // changeMultiUnit
            // 
            this.changeMultiUnit.BackColor = System.Drawing.Color.Navy;
            this.changeMultiUnit.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMultiUnit.ForeColor = System.Drawing.Color.Gold;
            this.changeMultiUnit.Location = new System.Drawing.Point(462, 541);
            this.changeMultiUnit.Margin = new System.Windows.Forms.Padding(2);
            this.changeMultiUnit.Name = "changeMultiUnit";
            this.changeMultiUnit.Size = new System.Drawing.Size(157, 66);
            this.changeMultiUnit.TabIndex = 6;
            this.changeMultiUnit.Text = "Change a Multiple Unit";
            this.changeMultiUnit.UseVisualStyleBackColor = false;
            this.changeMultiUnit.Click += new System.EventHandler(this.changeMultiUnit_Click);
            // 
            // addMultiUnit
            // 
            this.addMultiUnit.BackColor = System.Drawing.Color.Navy;
            this.addMultiUnit.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMultiUnit.ForeColor = System.Drawing.Color.Gold;
            this.addMultiUnit.Location = new System.Drawing.Point(264, 541);
            this.addMultiUnit.Margin = new System.Windows.Forms.Padding(2);
            this.addMultiUnit.Name = "addMultiUnit";
            this.addMultiUnit.Size = new System.Drawing.Size(157, 66);
            this.addMultiUnit.TabIndex = 5;
            this.addMultiUnit.Text = "Add a Multiple Unit";
            this.addMultiUnit.UseVisualStyleBackColor = false;
            this.addMultiUnit.Click += new System.EventHandler(this.addMultiUnit_Click);
            // 
            // MultipleUnitTable
            // 
            this.MultipleUnitTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MultipleUnitTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MultipleUnitTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.multiUnitID,
            this.powerSource,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.pass_Capacity,
            this.MStatus});
            this.MultipleUnitTable.Location = new System.Drawing.Point(87, 104);
            this.MultipleUnitTable.Margin = new System.Windows.Forms.Padding(2);
            this.MultipleUnitTable.Name = "MultipleUnitTable";
            this.MultipleUnitTable.RowHeadersWidth = 51;
            this.MultipleUnitTable.RowTemplate.Height = 24;
            this.MultipleUnitTable.Size = new System.Drawing.Size(878, 412);
            this.MultipleUnitTable.TabIndex = 4;
            // 
            // multiUnitID
            // 
            this.multiUnitID.HeaderText = "Multiple Unit ID";
            this.multiUnitID.MinimumWidth = 6;
            this.multiUnitID.Name = "multiUnitID";
            this.multiUnitID.Width = 70;
            // 
            // powerSource
            // 
            this.powerSource.HeaderText = "Power Source";
            this.powerSource.MinimumWidth = 6;
            this.powerSource.Name = "powerSource";
            this.powerSource.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "kW Power";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tractive Effort";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Weight in Tons";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Maximum Speed";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // pass_Capacity
            // 
            this.pass_Capacity.HeaderText = "Passenger Capacity";
            this.pass_Capacity.MinimumWidth = 6;
            this.pass_Capacity.Name = "pass_Capacity";
            this.pass_Capacity.Width = 70;
            // 
            // MStatus
            // 
            this.MStatus.HeaderText = "Status";
            this.MStatus.MinimumWidth = 6;
            this.MStatus.Name = "MStatus";
            this.MStatus.Width = 125;
            // 
            // Locomotives
            // 
            this.Locomotives.Controls.Add(this.label6);
            this.Locomotives.Controls.Add(this.removeLoco);
            this.Locomotives.Controls.Add(this.changeLoco);
            this.Locomotives.Controls.Add(this.addLoco);
            this.Locomotives.Controls.Add(this.LocoTable);
            this.Locomotives.Location = new System.Drawing.Point(304, 4);
            this.Locomotives.Margin = new System.Windows.Forms.Padding(2);
            this.Locomotives.Name = "Locomotives";
            this.Locomotives.Padding = new System.Windows.Forms.Padding(2);
            this.Locomotives.Size = new System.Drawing.Size(1058, 685);
            this.Locomotives.TabIndex = 1;
            this.Locomotives.Text = "Locomotives";
            this.Locomotives.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 27);
            this.label6.TabIndex = 42;
            this.label6.Text = "PNR CURRENT LOCOMOTIVES\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeLoco
            // 
            this.removeLoco.BackColor = System.Drawing.Color.Navy;
            this.removeLoco.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLoco.ForeColor = System.Drawing.Color.Gold;
            this.removeLoco.Location = new System.Drawing.Point(631, 586);
            this.removeLoco.Margin = new System.Windows.Forms.Padding(2);
            this.removeLoco.Name = "removeLoco";
            this.removeLoco.Size = new System.Drawing.Size(157, 66);
            this.removeLoco.TabIndex = 3;
            this.removeLoco.Text = "Remove a Locomotive";
            this.removeLoco.UseVisualStyleBackColor = false;
            this.removeLoco.Click += new System.EventHandler(this.removeLoco_Click);
            // 
            // changeLoco
            // 
            this.changeLoco.BackColor = System.Drawing.Color.Navy;
            this.changeLoco.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLoco.ForeColor = System.Drawing.Color.Gold;
            this.changeLoco.Location = new System.Drawing.Point(430, 586);
            this.changeLoco.Margin = new System.Windows.Forms.Padding(2);
            this.changeLoco.Name = "changeLoco";
            this.changeLoco.Size = new System.Drawing.Size(157, 66);
            this.changeLoco.TabIndex = 2;
            this.changeLoco.Text = "Change a Locomotive";
            this.changeLoco.UseVisualStyleBackColor = false;
            this.changeLoco.Click += new System.EventHandler(this.changeLoco_Click);
            // 
            // addLoco
            // 
            this.addLoco.BackColor = System.Drawing.Color.Navy;
            this.addLoco.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLoco.ForeColor = System.Drawing.Color.Gold;
            this.addLoco.Location = new System.Drawing.Point(233, 586);
            this.addLoco.Margin = new System.Windows.Forms.Padding(2);
            this.addLoco.Name = "addLoco";
            this.addLoco.Size = new System.Drawing.Size(157, 66);
            this.addLoco.TabIndex = 1;
            this.addLoco.Text = "Add a Locomotive";
            this.addLoco.UseVisualStyleBackColor = false;
            this.addLoco.Click += new System.EventHandler(this.addLoco_Click);
            // 
            // LocoTable
            // 
            this.LocoTable.AllowUserToResizeColumns = false;
            this.LocoTable.AllowUserToResizeRows = false;
            this.LocoTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.LocoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loco_ID,
            this.loco_Type,
            this.Brand,
            this.Manufacturer,
            this.kwPower,
            this.trEff,
            this.tonWeight,
            this.maxSpeed,
            this.Status});
            this.LocoTable.Location = new System.Drawing.Point(46, 129);
            this.LocoTable.Margin = new System.Windows.Forms.Padding(2);
            this.LocoTable.MultiSelect = false;
            this.LocoTable.Name = "LocoTable";
            this.LocoTable.ReadOnly = true;
            this.LocoTable.RowHeadersWidth = 51;
            this.LocoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LocoTable.RowTemplate.Height = 24;
            this.LocoTable.Size = new System.Drawing.Size(955, 412);
            this.LocoTable.TabIndex = 0;
            // 
            // loco_ID
            // 
            this.loco_ID.HeaderText = "Locomotive ID";
            this.loco_ID.MinimumWidth = 6;
            this.loco_ID.Name = "loco_ID";
            this.loco_ID.ReadOnly = true;
            this.loco_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.loco_ID.Width = 70;
            // 
            // loco_Type
            // 
            this.loco_Type.HeaderText = "Locomotive Type";
            this.loco_Type.MinimumWidth = 6;
            this.loco_Type.Name = "loco_Type";
            this.loco_Type.ReadOnly = true;
            this.loco_Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.loco_Type.Width = 125;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Brand.Width = 125;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Manufacturer.Width = 125;
            // 
            // kwPower
            // 
            this.kwPower.HeaderText = "kW Power";
            this.kwPower.MinimumWidth = 6;
            this.kwPower.Name = "kwPower";
            this.kwPower.ReadOnly = true;
            this.kwPower.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kwPower.Width = 70;
            // 
            // trEff
            // 
            this.trEff.HeaderText = "Tractive Effort";
            this.trEff.MinimumWidth = 6;
            this.trEff.Name = "trEff";
            this.trEff.ReadOnly = true;
            this.trEff.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trEff.Width = 70;
            // 
            // tonWeight
            // 
            this.tonWeight.HeaderText = "Weight in Tons";
            this.tonWeight.MinimumWidth = 6;
            this.tonWeight.Name = "tonWeight";
            this.tonWeight.ReadOnly = true;
            this.tonWeight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tonWeight.Width = 70;
            // 
            // maxSpeed
            // 
            this.maxSpeed.HeaderText = "Maximum Speed";
            this.maxSpeed.MinimumWidth = 6;
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.ReadOnly = true;
            this.maxSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maxSpeed.Width = 70;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Width = 175;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Gainsboro;
            this.Home.Controls.Add(this.RollingStockPieChart);
            this.Home.Controls.Add(this.InventorySummary);
            this.Home.Controls.Add(this.BrowseDialog);
            this.Home.Controls.Add(this.FilePathTxtBox);
            this.Home.Controls.Add(this.label5);
            this.Home.Controls.Add(this.StationStatus);
            this.Home.Controls.Add(this.PassengerLineStatus);
            this.Home.Controls.Add(this.RollingStockReport);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.label7);
            this.Home.Controls.Add(this.currentDate);
            this.Home.Controls.Add(this.label4);
            this.Home.Controls.Add(this.currentTime);
            this.Home.Controls.Add(this.label1);
            this.Home.Location = new System.Drawing.Point(304, 4);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(2);
            this.Home.Size = new System.Drawing.Size(1058, 685);
            this.Home.TabIndex = 0;
            this.Home.Text = "Dashboard";
            // 
            // RollingStockPieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.RollingStockPieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RollingStockPieChart.Legends.Add(legend1);
            this.RollingStockPieChart.Location = new System.Drawing.Point(594, 174);
            this.RollingStockPieChart.Name = "RollingStockPieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.RollingStockPieChart.Series.Add(series1);
            this.RollingStockPieChart.Size = new System.Drawing.Size(409, 355);
            this.RollingStockPieChart.TabIndex = 56;
            this.RollingStockPieChart.Text = "Rolling Stock Graph";
            // 
            // InventorySummary
            // 
            this.InventorySummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventorySummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RollingStockType,
            this.RollingStock,
            this.InServiceCnt,
            this.Idle,
            this.UnderMaintenance});
            this.InventorySummary.Location = new System.Drawing.Point(34, 174);
            this.InventorySummary.Name = "InventorySummary";
            this.InventorySummary.Size = new System.Drawing.Size(523, 355);
            this.InventorySummary.TabIndex = 55;
            // 
            // BrowseDialog
            // 
            this.BrowseDialog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseDialog.Location = new System.Drawing.Point(867, 545);
            this.BrowseDialog.Name = "BrowseDialog";
            this.BrowseDialog.Size = new System.Drawing.Size(94, 26);
            this.BrowseDialog.TabIndex = 54;
            this.BrowseDialog.Text = "Browse";
            this.BrowseDialog.UseVisualStyleBackColor = true;
            this.BrowseDialog.Click += new System.EventHandler(this.BrowseDialog_Click);
            // 
            // FilePathTxtBox
            // 
            this.FilePathTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathTxtBox.Location = new System.Drawing.Point(257, 545);
            this.FilePathTxtBox.Name = "FilePathTxtBox";
            this.FilePathTxtBox.Size = new System.Drawing.Size(604, 26);
            this.FilePathTxtBox.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 549);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Generate the Report Using: ";
            // 
            // StationStatus
            // 
            this.StationStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationStatus.Location = new System.Drawing.Point(679, 591);
            this.StationStatus.Name = "StationStatus";
            this.StationStatus.Size = new System.Drawing.Size(182, 47);
            this.StationStatus.TabIndex = 51;
            this.StationStatus.Text = "Station Status";
            this.StationStatus.UseVisualStyleBackColor = true;
            // 
            // PassengerLineStatus
            // 
            this.PassengerLineStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerLineStatus.Location = new System.Drawing.Point(450, 591);
            this.PassengerLineStatus.Name = "PassengerLineStatus";
            this.PassengerLineStatus.Size = new System.Drawing.Size(162, 47);
            this.PassengerLineStatus.TabIndex = 50;
            this.PassengerLineStatus.Text = "Passenger Line Status";
            this.PassengerLineStatus.UseVisualStyleBackColor = true;
            this.PassengerLineStatus.Click += new System.EventHandler(this.PassengerLineStatus_Click);
            // 
            // RollingStockReport
            // 
            this.RollingStockReport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollingStockReport.Location = new System.Drawing.Point(218, 591);
            this.RollingStockReport.Name = "RollingStockReport";
            this.RollingStockReport.Size = new System.Drawing.Size(162, 47);
            this.RollingStockReport.TabIndex = 49;
            this.RollingStockReport.Text = "Rolling Stock Count";
            this.RollingStockReport.UseVisualStyleBackColor = true;
            this.RollingStockReport.Click += new System.EventHandler(this.RollingStockReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PNR_Train_Management_System.Properties.Resources.Philippine_National_Railways__PNR_1;
            this.pictureBox1.InitialImage = global::PNR_Train_Management_System.Properties.Resources.Philippine_National_Railways__PNR_1;
            this.pictureBox1.Location = new System.Drawing.Point(186, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "WELCOME TO THE PNR RAILWAY MANAGEMENT SYSTEM\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 660);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Copyright 2024, All Rights Recived";
            // 
            // currentDate
            // 
            this.currentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(270, 136);
            this.currentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(166, 22);
            this.currentDate.TabIndex = 26;
            this.currentDate.Text = "February 23, 2024";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Today is:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currentTime
            // 
            this.currentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(734, 136);
            this.currentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(107, 22);
            this.currentTime.TabIndex = 24;
            this.currentTime.Text = "1:00:00 pm";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Time:";
            // 
            // Dashboard
            // 
            this.Dashboard.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Dashboard.Controls.Add(this.Home);
            this.Dashboard.Controls.Add(this.Locomotives);
            this.Dashboard.Controls.Add(this.MultiUnit);
            this.Dashboard.Controls.Add(this.TrainCars);
            this.Dashboard.Controls.Add(this.PassengerLine);
            this.Dashboard.Controls.Add(this.Options);
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Dashboard.ItemSize = new System.Drawing.Size(40, 300);
            this.Dashboard.Location = new System.Drawing.Point(0, 1);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard.Multiline = true;
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.SelectedIndex = 0;
            this.Dashboard.Size = new System.Drawing.Size(1366, 693);
            this.Dashboard.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Dashboard.TabIndex = 0;
            this.Dashboard.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Dashboard_Main);
            // 
            // ExcelTemplateDialog
            // 
            this.ExcelTemplateDialog.InitialDirectory = "C:/Users/loric/OneDrive/Documents/3rd year/2nd Sem/Event Driven Programming/Excel" +
    " Templates";
            this.ExcelTemplateDialog.Title = "Open an Excel Template";
            // 
            // SaveExcelFile
            // 
            this.SaveExcelFile.Filter = "Excel FIle|*.xlsx";
            this.SaveExcelFile.Title = "Save Report to:";
            // 
            // RollingStockType
            // 
            this.RollingStockType.HeaderText = "Rolling Stock Type";
            this.RollingStockType.Name = "RollingStockType";
            this.RollingStockType.ReadOnly = true;
            this.RollingStockType.Width = 125;
            // 
            // RollingStock
            // 
            this.RollingStock.HeaderText = "Rolling Stock Name";
            this.RollingStock.Name = "RollingStock";
            this.RollingStock.ReadOnly = true;
            this.RollingStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RollingStock.Width = 125;
            // 
            // InServiceCnt
            // 
            this.InServiceCnt.HeaderText = "In Service";
            this.InServiceCnt.Name = "InServiceCnt";
            this.InServiceCnt.ReadOnly = true;
            this.InServiceCnt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InServiceCnt.Width = 75;
            // 
            // Idle
            // 
            this.Idle.HeaderText = "In the Garage";
            this.Idle.Name = "Idle";
            this.Idle.ReadOnly = true;
            this.Idle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Idle.Width = 75;
            // 
            // UnderMaintenance
            // 
            this.UnderMaintenance.HeaderText = "Under Maintenance";
            this.UnderMaintenance.Name = "UnderMaintenance";
            this.UnderMaintenance.ReadOnly = true;
            this.UnderMaintenance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UnderMaintenance.Width = 75;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 687);
            this.Controls.Add(this.Dashboard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNR Ticketing Monitoring System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuitDashboard);
            this.PassengerLine.ResumeLayout(false);
            this.PassengerLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PNRPassengerLines)).EndInit();
            this.TrainCars.ResumeLayout(false);
            this.TrainCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RailCarTable)).EndInit();
            this.MultiUnit.ResumeLayout(false);
            this.MultiUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleUnitTable)).EndInit();
            this.Locomotives.ResumeLayout(false);
            this.Locomotives.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocoTable)).EndInit();
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollingStockPieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventorySummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer currTime;
        private System.Windows.Forms.TabPage Options;
        private System.Windows.Forms.TabPage PassengerLine;
        private System.Windows.Forms.Button removeStation;
        private System.Windows.Forms.Button changeStation;
        private System.Windows.Forms.Button addStation;
        private System.Windows.Forms.DataGridView PNRPassengerLines;
        private System.Windows.Forms.TabPage TrainCars;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button delTrainCar;
        private System.Windows.Forms.Button updateTrainCar;
        private System.Windows.Forms.Button addTrainCar;
        private System.Windows.Forms.DataGridView RailCarTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn railCarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn carManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatingCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn passMaxSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsUsed;
        private System.Windows.Forms.TabPage MultiUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button removeMultiUnit;
        private System.Windows.Forms.Button changeMultiUnit;
        private System.Windows.Forms.Button addMultiUnit;
        private System.Windows.Forms.DataGridView MultipleUnitTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MStatus;
        private System.Windows.Forms.TabPage Locomotives;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeLoco;
        private System.Windows.Forms.Button changeLoco;
        private System.Windows.Forms.Button addLoco;
        private System.Windows.Forms.DataGridView LocoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn loco_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn loco_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn trEff;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Button StationStatus;
        private System.Windows.Forms.Button PassengerLineStatus;
        private System.Windows.Forms.Button RollingStockReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Dashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn km_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainsNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn passenger_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn electrified;
        private System.Windows.Forms.Button BrowseDialog;
        private System.Windows.Forms.TextBox FilePathTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ExcelTemplateDialog;
        private System.Windows.Forms.DataGridView InventorySummary;
        private System.Windows.Forms.DataVisualization.Charting.Chart RollingStockPieChart;
        private System.Windows.Forms.SaveFileDialog SaveExcelFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollingStockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollingStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn InServiceCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idle;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnderMaintenance;
    }
}