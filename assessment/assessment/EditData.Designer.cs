namespace assessment
{
    partial class EditData
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.cmbxSelectLocation = new System.Windows.Forms.ComboBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbEdit = new System.Windows.Forms.Label();
            this.cmBxEdit = new System.Windows.Forms.ComboBox();
            this.gpBxLocation = new System.Windows.Forms.GroupBox();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.txtBxLongitude = new System.Windows.Forms.TextBox();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.txtBxLatitude = new System.Windows.Forms.TextBox();
            this.lbPostcode = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtBxPostcode = new System.Windows.Forms.TextBox();
            this.txtBxCountry = new System.Windows.Forms.TextBox();
            this.txtBxStreet = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnRemoveLocation = new System.Windows.Forms.Button();
            this.gpBxYear = new System.Windows.Forms.GroupBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbYearID = new System.Windows.Forms.Label();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.txtBxYearID = new System.Windows.Forms.TextBox();
            this.btnSaveYear = new System.Windows.Forms.Button();
            this.btnRemoveYear = new System.Windows.Forms.Button();
            this.gpBxMonth = new System.Windows.Forms.GroupBox();
            this.lbHoursSun = new System.Windows.Forms.Label();
            this.txtBxHoursSun = new System.Windows.Forms.TextBox();
            this.lbMilRain = new System.Windows.Forms.Label();
            this.txtBxMilRain = new System.Windows.Forms.TextBox();
            this.lbDaysFrost = new System.Windows.Forms.Label();
            this.lbMinTemp = new System.Windows.Forms.Label();
            this.lbMaxTemp = new System.Windows.Forms.Label();
            this.lbMonthID = new System.Windows.Forms.Label();
            this.txtBxNumDaysFrost = new System.Windows.Forms.TextBox();
            this.txtBxMinTemp = new System.Windows.Forms.TextBox();
            this.txtBxMaxTemp = new System.Windows.Forms.TextBox();
            this.txtBxMonthID = new System.Windows.Forms.TextBox();
            this.btnSaveMonth = new System.Windows.Forms.Button();
            this.lbYearEdit = new System.Windows.Forms.Label();
            this.cmbxSelectYear = new System.Windows.Forms.ComboBox();
            this.cmbxSelectMonth = new System.Windows.Forms.ComboBox();
            this.lbMonthEdit = new System.Windows.Forms.Label();
            this.gpBxLocation.SuspendLayout();
            this.gpBxYear.SuspendLayout();
            this.gpBxMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // cmbxSelectLocation
            // 
            this.cmbxSelectLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectLocation.FormattingEnabled = true;
            this.cmbxSelectLocation.Location = new System.Drawing.Point(213, 84);
            this.cmbxSelectLocation.Name = "cmbxSelectLocation";
            this.cmbxSelectLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbxSelectLocation.TabIndex = 3;
            this.cmbxSelectLocation.SelectedIndexChanged += new System.EventHandler(this.cmBxSelectLocation_SelectedIndexChanged);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(21, 87);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(186, 13);
            this.lbLocation.TabIndex = 4;
            this.lbLocation.Text = "Which location would you like to edit?";
            // 
            // lbEdit
            // 
            this.lbEdit.AutoSize = true;
            this.lbEdit.Location = new System.Drawing.Point(21, 121);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(141, 13);
            this.lbEdit.TabIndex = 5;
            this.lbEdit.Text = "What would you like to edit?";
            // 
            // cmBxEdit
            // 
            this.cmBxEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxEdit.FormattingEnabled = true;
            this.cmBxEdit.Items.AddRange(new object[] {
            "Location",
            "Year",
            "Month"});
            this.cmBxEdit.Location = new System.Drawing.Point(213, 118);
            this.cmBxEdit.Name = "cmBxEdit";
            this.cmBxEdit.Size = new System.Drawing.Size(121, 21);
            this.cmBxEdit.TabIndex = 6;
            this.cmBxEdit.SelectedIndexChanged += new System.EventHandler(this.cmBxEdit_SelectedIndexChanged);
            // 
            // gpBxLocation
            // 
            this.gpBxLocation.Controls.Add(this.lbLongitude);
            this.gpBxLocation.Controls.Add(this.txtBxLongitude);
            this.gpBxLocation.Controls.Add(this.lbLatitude);
            this.gpBxLocation.Controls.Add(this.txtBxLatitude);
            this.gpBxLocation.Controls.Add(this.lbPostcode);
            this.gpBxLocation.Controls.Add(this.lbCountry);
            this.gpBxLocation.Controls.Add(this.lbStreet);
            this.gpBxLocation.Controls.Add(this.lbName);
            this.gpBxLocation.Controls.Add(this.txtBxPostcode);
            this.gpBxLocation.Controls.Add(this.txtBxCountry);
            this.gpBxLocation.Controls.Add(this.txtBxStreet);
            this.gpBxLocation.Controls.Add(this.txtBxName);
            this.gpBxLocation.Controls.Add(this.btnSaveLocation);
            this.gpBxLocation.Controls.Add(this.btnRemoveLocation);
            this.gpBxLocation.Location = new System.Drawing.Point(24, 171);
            this.gpBxLocation.Name = "gpBxLocation";
            this.gpBxLocation.Size = new System.Drawing.Size(234, 237);
            this.gpBxLocation.TabIndex = 7;
            this.gpBxLocation.TabStop = false;
            this.gpBxLocation.Text = "gpBxLocation";
            // 
            // lbLongitude
            // 
            this.lbLongitude.AutoSize = true;
            this.lbLongitude.Location = new System.Drawing.Point(8, 163);
            this.lbLongitude.Name = "lbLongitude";
            this.lbLongitude.Size = new System.Drawing.Size(57, 13);
            this.lbLongitude.TabIndex = 27;
            this.lbLongitude.Text = "Longitude:";
            // 
            // txtBxLongitude
            // 
            this.txtBxLongitude.Location = new System.Drawing.Point(97, 160);
            this.txtBxLongitude.Name = "txtBxLongitude";
            this.txtBxLongitude.Size = new System.Drawing.Size(117, 20);
            this.txtBxLongitude.TabIndex = 26;
            // 
            // lbLatitude
            // 
            this.lbLatitude.AutoSize = true;
            this.lbLatitude.Location = new System.Drawing.Point(8, 137);
            this.lbLatitude.Name = "lbLatitude";
            this.lbLatitude.Size = new System.Drawing.Size(48, 13);
            this.lbLatitude.TabIndex = 25;
            this.lbLatitude.Text = "Latitude:";
            // 
            // txtBxLatitude
            // 
            this.txtBxLatitude.Location = new System.Drawing.Point(97, 134);
            this.txtBxLatitude.Name = "txtBxLatitude";
            this.txtBxLatitude.Size = new System.Drawing.Size(117, 20);
            this.txtBxLatitude.TabIndex = 23;
            // 
            // lbPostcode
            // 
            this.lbPostcode.AutoSize = true;
            this.lbPostcode.Location = new System.Drawing.Point(8, 111);
            this.lbPostcode.Name = "lbPostcode";
            this.lbPostcode.Size = new System.Drawing.Size(55, 13);
            this.lbPostcode.TabIndex = 21;
            this.lbPostcode.Text = "Postcode:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(8, 85);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(46, 13);
            this.lbCountry.TabIndex = 20;
            this.lbCountry.Text = "Country:";
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(8, 59);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(79, 13);
            this.lbStreet.TabIndex = 19;
            this.lbStreet.Text = "Street Address:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(8, 33);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Name:";
            // 
            // txtBxPostcode
            // 
            this.txtBxPostcode.Location = new System.Drawing.Point(97, 108);
            this.txtBxPostcode.Name = "txtBxPostcode";
            this.txtBxPostcode.Size = new System.Drawing.Size(117, 20);
            this.txtBxPostcode.TabIndex = 18;
            // 
            // txtBxCountry
            // 
            this.txtBxCountry.Location = new System.Drawing.Point(97, 82);
            this.txtBxCountry.Name = "txtBxCountry";
            this.txtBxCountry.Size = new System.Drawing.Size(117, 20);
            this.txtBxCountry.TabIndex = 17;
            // 
            // txtBxStreet
            // 
            this.txtBxStreet.Location = new System.Drawing.Point(97, 56);
            this.txtBxStreet.Name = "txtBxStreet";
            this.txtBxStreet.Size = new System.Drawing.Size(117, 20);
            this.txtBxStreet.TabIndex = 16;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(97, 30);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(117, 20);
            this.txtBxName.TabIndex = 15;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(164, 201);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(50, 23);
            this.btnSaveLocation.TabIndex = 1;
            this.btnSaveLocation.Text = "Save";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            // 
            // btnRemoveLocation
            // 
            this.btnRemoveLocation.Location = new System.Drawing.Point(11, 201);
            this.btnRemoveLocation.Name = "btnRemoveLocation";
            this.btnRemoveLocation.Size = new System.Drawing.Size(102, 23);
            this.btnRemoveLocation.TabIndex = 0;
            this.btnRemoveLocation.Text = "Remove Location";
            this.btnRemoveLocation.UseVisualStyleBackColor = true;
            this.btnRemoveLocation.Click += new System.EventHandler(this.btnRemoveLocation_Click);
            // 
            // gpBxYear
            // 
            this.gpBxYear.Controls.Add(this.lbDescription);
            this.gpBxYear.Controls.Add(this.lbYearID);
            this.gpBxYear.Controls.Add(this.txtBxDescription);
            this.gpBxYear.Controls.Add(this.txtBxYearID);
            this.gpBxYear.Controls.Add(this.btnSaveYear);
            this.gpBxYear.Controls.Add(this.btnRemoveYear);
            this.gpBxYear.Location = new System.Drawing.Point(274, 171);
            this.gpBxYear.Name = "gpBxYear";
            this.gpBxYear.Size = new System.Drawing.Size(234, 237);
            this.gpBxYear.TabIndex = 28;
            this.gpBxYear.TabStop = false;
            this.gpBxYear.Text = "gpBxYear";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(8, 59);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(63, 13);
            this.lbDescription.TabIndex = 19;
            this.lbDescription.Text = "Description:";
            // 
            // lbYearID
            // 
            this.lbYearID.AutoSize = true;
            this.lbYearID.Location = new System.Drawing.Point(8, 33);
            this.lbYearID.Name = "lbYearID";
            this.lbYearID.Size = new System.Drawing.Size(46, 13);
            this.lbYearID.TabIndex = 14;
            this.lbYearID.Text = "Year ID:";
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(97, 56);
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(117, 20);
            this.txtBxDescription.TabIndex = 16;
            // 
            // txtBxYearID
            // 
            this.txtBxYearID.Location = new System.Drawing.Point(97, 30);
            this.txtBxYearID.Name = "txtBxYearID";
            this.txtBxYearID.Size = new System.Drawing.Size(117, 20);
            this.txtBxYearID.TabIndex = 15;
            // 
            // btnSaveYear
            // 
            this.btnSaveYear.Location = new System.Drawing.Point(164, 201);
            this.btnSaveYear.Name = "btnSaveYear";
            this.btnSaveYear.Size = new System.Drawing.Size(50, 23);
            this.btnSaveYear.TabIndex = 1;
            this.btnSaveYear.Text = "Save";
            this.btnSaveYear.UseVisualStyleBackColor = true;
            // 
            // btnRemoveYear
            // 
            this.btnRemoveYear.Location = new System.Drawing.Point(11, 201);
            this.btnRemoveYear.Name = "btnRemoveYear";
            this.btnRemoveYear.Size = new System.Drawing.Size(102, 23);
            this.btnRemoveYear.TabIndex = 0;
            this.btnRemoveYear.Text = "Remove Year";
            this.btnRemoveYear.UseVisualStyleBackColor = true;
            // 
            // gpBxMonth
            // 
            this.gpBxMonth.Controls.Add(this.lbHoursSun);
            this.gpBxMonth.Controls.Add(this.txtBxHoursSun);
            this.gpBxMonth.Controls.Add(this.lbMilRain);
            this.gpBxMonth.Controls.Add(this.txtBxMilRain);
            this.gpBxMonth.Controls.Add(this.lbDaysFrost);
            this.gpBxMonth.Controls.Add(this.lbMinTemp);
            this.gpBxMonth.Controls.Add(this.lbMaxTemp);
            this.gpBxMonth.Controls.Add(this.lbMonthID);
            this.gpBxMonth.Controls.Add(this.txtBxNumDaysFrost);
            this.gpBxMonth.Controls.Add(this.txtBxMinTemp);
            this.gpBxMonth.Controls.Add(this.txtBxMaxTemp);
            this.gpBxMonth.Controls.Add(this.txtBxMonthID);
            this.gpBxMonth.Controls.Add(this.btnSaveMonth);
            this.gpBxMonth.Location = new System.Drawing.Point(524, 171);
            this.gpBxMonth.Name = "gpBxMonth";
            this.gpBxMonth.Size = new System.Drawing.Size(248, 237);
            this.gpBxMonth.TabIndex = 29;
            this.gpBxMonth.TabStop = false;
            this.gpBxMonth.Text = "gpBxMonth";
            // 
            // lbHoursSun
            // 
            this.lbHoursSun.AutoSize = true;
            this.lbHoursSun.Location = new System.Drawing.Point(8, 163);
            this.lbHoursSun.Name = "lbHoursSun";
            this.lbHoursSun.Size = new System.Drawing.Size(72, 13);
            this.lbHoursSun.TabIndex = 27;
            this.lbHoursSun.Text = "Hours of Sun:";
            // 
            // txtBxHoursSun
            // 
            this.txtBxHoursSun.Location = new System.Drawing.Point(119, 160);
            this.txtBxHoursSun.Name = "txtBxHoursSun";
            this.txtBxHoursSun.Size = new System.Drawing.Size(117, 20);
            this.txtBxHoursSun.TabIndex = 26;
            // 
            // lbMilRain
            // 
            this.lbMilRain.AutoSize = true;
            this.lbMilRain.Location = new System.Drawing.Point(8, 137);
            this.lbMilRain.Name = "lbMilRain";
            this.lbMilRain.Size = new System.Drawing.Size(106, 13);
            this.lbMilRain.TabIndex = 25;
            this.lbMilRain.Text = "Millimeters of Rainful:";
            // 
            // txtBxMilRain
            // 
            this.txtBxMilRain.Location = new System.Drawing.Point(119, 134);
            this.txtBxMilRain.Name = "txtBxMilRain";
            this.txtBxMilRain.Size = new System.Drawing.Size(117, 20);
            this.txtBxMilRain.TabIndex = 23;
            // 
            // lbDaysFrost
            // 
            this.lbDaysFrost.AutoSize = true;
            this.lbDaysFrost.Location = new System.Drawing.Point(8, 111);
            this.lbDaysFrost.Name = "lbDaysFrost";
            this.lbDaysFrost.Size = new System.Drawing.Size(112, 13);
            this.lbDaysFrost.TabIndex = 21;
            this.lbDaysFrost.Text = "Number of Days Frost:";
            // 
            // lbMinTemp
            // 
            this.lbMinTemp.AutoSize = true;
            this.lbMinTemp.Location = new System.Drawing.Point(8, 85);
            this.lbMinTemp.Name = "lbMinTemp";
            this.lbMinTemp.Size = new System.Drawing.Size(78, 13);
            this.lbMinTemp.TabIndex = 20;
            this.lbMinTemp.Text = "Min Tempature";
            // 
            // lbMaxTemp
            // 
            this.lbMaxTemp.AutoSize = true;
            this.lbMaxTemp.Location = new System.Drawing.Point(8, 59);
            this.lbMaxTemp.Name = "lbMaxTemp";
            this.lbMaxTemp.Size = new System.Drawing.Size(84, 13);
            this.lbMaxTemp.TabIndex = 19;
            this.lbMaxTemp.Text = "Max Tempature:";
            // 
            // lbMonthID
            // 
            this.lbMonthID.AutoSize = true;
            this.lbMonthID.Location = new System.Drawing.Point(8, 33);
            this.lbMonthID.Name = "lbMonthID";
            this.lbMonthID.Size = new System.Drawing.Size(54, 13);
            this.lbMonthID.TabIndex = 14;
            this.lbMonthID.Text = "Month ID:";
            // 
            // txtBxNumDaysFrost
            // 
            this.txtBxNumDaysFrost.Location = new System.Drawing.Point(119, 108);
            this.txtBxNumDaysFrost.Name = "txtBxNumDaysFrost";
            this.txtBxNumDaysFrost.Size = new System.Drawing.Size(117, 20);
            this.txtBxNumDaysFrost.TabIndex = 18;
            // 
            // txtBxMinTemp
            // 
            this.txtBxMinTemp.Location = new System.Drawing.Point(119, 82);
            this.txtBxMinTemp.Name = "txtBxMinTemp";
            this.txtBxMinTemp.Size = new System.Drawing.Size(117, 20);
            this.txtBxMinTemp.TabIndex = 17;
            // 
            // txtBxMaxTemp
            // 
            this.txtBxMaxTemp.Location = new System.Drawing.Point(119, 56);
            this.txtBxMaxTemp.Name = "txtBxMaxTemp";
            this.txtBxMaxTemp.Size = new System.Drawing.Size(117, 20);
            this.txtBxMaxTemp.TabIndex = 16;
            // 
            // txtBxMonthID
            // 
            this.txtBxMonthID.Location = new System.Drawing.Point(119, 30);
            this.txtBxMonthID.Name = "txtBxMonthID";
            this.txtBxMonthID.Size = new System.Drawing.Size(117, 20);
            this.txtBxMonthID.TabIndex = 15;
            // 
            // btnSaveMonth
            // 
            this.btnSaveMonth.Location = new System.Drawing.Point(186, 201);
            this.btnSaveMonth.Name = "btnSaveMonth";
            this.btnSaveMonth.Size = new System.Drawing.Size(50, 23);
            this.btnSaveMonth.TabIndex = 1;
            this.btnSaveMonth.Text = "Save";
            this.btnSaveMonth.UseVisualStyleBackColor = true;
            // 
            // lbYearEdit
            // 
            this.lbYearEdit.AutoSize = true;
            this.lbYearEdit.Location = new System.Drawing.Point(368, 87);
            this.lbYearEdit.Name = "lbYearEdit";
            this.lbYearEdit.Size = new System.Drawing.Size(169, 13);
            this.lbYearEdit.TabIndex = 30;
            this.lbYearEdit.Text = "Which year would you like to edit?";
            // 
            // cmbxSelectYear
            // 
            this.cmbxSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectYear.FormattingEnabled = true;
            this.cmbxSelectYear.Location = new System.Drawing.Point(560, 84);
            this.cmbxSelectYear.Name = "cmbxSelectYear";
            this.cmbxSelectYear.Size = new System.Drawing.Size(121, 21);
            this.cmbxSelectYear.TabIndex = 31;
            this.cmbxSelectYear.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectYear_SelectedIndexChanged);
            // 
            // cmbxSelectMonth
            // 
            this.cmbxSelectMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectMonth.FormattingEnabled = true;
            this.cmbxSelectMonth.Location = new System.Drawing.Point(560, 118);
            this.cmbxSelectMonth.Name = "cmbxSelectMonth";
            this.cmbxSelectMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbxSelectMonth.TabIndex = 32;
            this.cmbxSelectMonth.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectMonth_SelectedIndexChanged);
            // 
            // lbMonthEdit
            // 
            this.lbMonthEdit.AutoSize = true;
            this.lbMonthEdit.Location = new System.Drawing.Point(368, 121);
            this.lbMonthEdit.Name = "lbMonthEdit";
            this.lbMonthEdit.Size = new System.Drawing.Size(178, 13);
            this.lbMonthEdit.TabIndex = 33;
            this.lbMonthEdit.Text = "Which month would you like to edit?";
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMonthEdit);
            this.Controls.Add(this.cmbxSelectMonth);
            this.Controls.Add(this.cmbxSelectYear);
            this.Controls.Add(this.lbYearEdit);
            this.Controls.Add(this.gpBxMonth);
            this.Controls.Add(this.gpBxYear);
            this.Controls.Add(this.gpBxLocation);
            this.Controls.Add(this.cmBxEdit);
            this.Controls.Add(this.lbEdit);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.cmbxSelectLocation);
            this.Controls.Add(this.btnMenu);
            this.Name = "EditData";
            this.Text = "EditData";
            this.gpBxLocation.ResumeLayout(false);
            this.gpBxLocation.PerformLayout();
            this.gpBxYear.ResumeLayout(false);
            this.gpBxYear.PerformLayout();
            this.gpBxMonth.ResumeLayout(false);
            this.gpBxMonth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ComboBox cmbxSelectLocation;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbEdit;
        private System.Windows.Forms.ComboBox cmBxEdit;
        private System.Windows.Forms.GroupBox gpBxLocation;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Button btnRemoveLocation;
        private System.Windows.Forms.Label lbLongitude;
        private System.Windows.Forms.TextBox txtBxLongitude;
        private System.Windows.Forms.Label lbLatitude;
        private System.Windows.Forms.TextBox txtBxLatitude;
        private System.Windows.Forms.Label lbPostcode;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtBxPostcode;
        private System.Windows.Forms.TextBox txtBxCountry;
        private System.Windows.Forms.TextBox txtBxStreet;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.GroupBox gpBxYear;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbYearID;
        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.TextBox txtBxYearID;
        private System.Windows.Forms.Button btnSaveYear;
        private System.Windows.Forms.Button btnRemoveYear;
        private System.Windows.Forms.GroupBox gpBxMonth;
        private System.Windows.Forms.Label lbHoursSun;
        private System.Windows.Forms.TextBox txtBxHoursSun;
        private System.Windows.Forms.Label lbMilRain;
        private System.Windows.Forms.TextBox txtBxMilRain;
        private System.Windows.Forms.Label lbDaysFrost;
        private System.Windows.Forms.Label lbMinTemp;
        private System.Windows.Forms.Label lbMaxTemp;
        private System.Windows.Forms.Label lbMonthID;
        private System.Windows.Forms.TextBox txtBxNumDaysFrost;
        private System.Windows.Forms.TextBox txtBxMinTemp;
        private System.Windows.Forms.TextBox txtBxMaxTemp;
        private System.Windows.Forms.TextBox txtBxMonthID;
        private System.Windows.Forms.Button btnSaveMonth;
        private System.Windows.Forms.Label lbYearEdit;
        private System.Windows.Forms.ComboBox cmbxSelectYear;
        private System.Windows.Forms.ComboBox cmbxSelectMonth;
        private System.Windows.Forms.Label lbMonthEdit;
    }
}