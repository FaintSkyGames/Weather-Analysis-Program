namespace assessment
{
    partial class ViewData
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
            this.cmbxLocations = new System.Windows.Forms.ComboBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.cmbxYears = new System.Windows.Forms.ComboBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.cmbxMonths = new System.Windows.Forms.ComboBox();
            this.txtBxLocation = new System.Windows.Forms.RichTextBox();
            this.txtBxYear = new System.Windows.Forms.RichTextBox();
            this.txtBxMonth = new System.Windows.Forms.RichTextBox();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // cmbxLocations
            // 
            this.cmbxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLocations.FormattingEnabled = true;
            this.cmbxLocations.Location = new System.Drawing.Point(89, 217);
            this.cmbxLocations.Name = "cmbxLocations";
            this.cmbxLocations.Size = new System.Drawing.Size(122, 21);
            this.cmbxLocations.TabIndex = 1;
            this.cmbxLocations.SelectedIndexChanged += new System.EventHandler(this.cmbxLocations_SelectedIndexChanged);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(10, 215);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(70, 20);
            this.lbLocation.TabIndex = 2;
            this.lbLocation.Text = "Location";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(37, 259);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(43, 20);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "Year";
            // 
            // cmbxYears
            // 
            this.cmbxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYears.FormattingEnabled = true;
            this.cmbxYears.Location = new System.Drawing.Point(89, 261);
            this.cmbxYears.Name = "cmbxYears";
            this.cmbxYears.Size = new System.Drawing.Size(122, 21);
            this.cmbxYears.TabIndex = 4;
            this.cmbxYears.SelectedIndexChanged += new System.EventHandler(this.cmbxYears_SelectedIndexChanged);
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(26, 302);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(54, 20);
            this.lbMonth.TabIndex = 5;
            this.lbMonth.Text = "Month";
            // 
            // cmbxMonths
            // 
            this.cmbxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMonths.FormattingEnabled = true;
            this.cmbxMonths.Location = new System.Drawing.Point(89, 304);
            this.cmbxMonths.Name = "cmbxMonths";
            this.cmbxMonths.Size = new System.Drawing.Size(122, 21);
            this.cmbxMonths.TabIndex = 6;
            this.cmbxMonths.SelectedIndexChanged += new System.EventHandler(this.cmbxMonths_SelectedIndexChanged);
            // 
            // txtBxLocation
            // 
            this.txtBxLocation.Location = new System.Drawing.Point(291, 15);
            this.txtBxLocation.Name = "txtBxLocation";
            this.txtBxLocation.ReadOnly = true;
            this.txtBxLocation.Size = new System.Drawing.Size(476, 125);
            this.txtBxLocation.TabIndex = 7;
            this.txtBxLocation.Text = "";
            // 
            // txtBxYear
            // 
            this.txtBxYear.Location = new System.Drawing.Point(291, 154);
            this.txtBxYear.Name = "txtBxYear";
            this.txtBxYear.ReadOnly = true;
            this.txtBxYear.Size = new System.Drawing.Size(476, 125);
            this.txtBxYear.TabIndex = 8;
            this.txtBxYear.Text = "";
            // 
            // txtBxMonth
            // 
            this.txtBxMonth.Location = new System.Drawing.Point(291, 302);
            this.txtBxMonth.Name = "txtBxMonth";
            this.txtBxMonth.ReadOnly = true;
            this.txtBxMonth.Size = new System.Drawing.Size(476, 125);
            this.txtBxMonth.TabIndex = 9;
            this.txtBxMonth.Text = "";
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBxSearch.Location = new System.Drawing.Point(12, 154);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(199, 20);
            this.txtBxSearch.TabIndex = 10;
            this.txtBxSearch.TextChanged += new System.EventHandler(this.txtBxSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(8, 120);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(125, 20);
            this.lbSearch.TabIndex = 11;
            this.lbSearch.Text = "Search Location";
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.txtBxMonth);
            this.Controls.Add(this.txtBxYear);
            this.Controls.Add(this.txtBxLocation);
            this.Controls.Add(this.cmbxMonths);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.cmbxYears);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.cmbxLocations);
            this.Controls.Add(this.btnMenu);
            this.Name = "ViewData";
            this.Text = "ViewData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewData_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ComboBox cmbxLocations;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.ComboBox cmbxYears;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.ComboBox cmbxMonths;
        private System.Windows.Forms.RichTextBox txtBxLocation;
        private System.Windows.Forms.RichTextBox txtBxYear;
        private System.Windows.Forms.RichTextBox txtBxMonth;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Label lbSearch;
    }
}