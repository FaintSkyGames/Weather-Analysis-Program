namespace assessment
{
    partial class Graphs
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
            this.lbLocation = new System.Windows.Forms.Label();
            this.cmbxLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(12, 153);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(191, 13);
            this.lbLocation.TabIndex = 6;
            this.lbLocation.Text = "Which location would you like to view?";
            // 
            // cmbxLocation
            // 
            this.cmbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLocation.FormattingEnabled = true;
            this.cmbxLocation.Location = new System.Drawing.Point(37, 169);
            this.cmbxLocation.Name = "cmbxLocation";
            this.cmbxLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbxLocation.TabIndex = 5;
            this.cmbxLocation.SelectedIndexChanged += new System.EventHandler(this.cmbxLocation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Which year would you like to view?";
            // 
            // cmbxYear
            // 
            this.cmbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYear.FormattingEnabled = true;
            this.cmbxYear.Location = new System.Drawing.Point(37, 235);
            this.cmbxYear.Name = "cmbxYear";
            this.cmbxYear.Size = new System.Drawing.Size(121, 21);
            this.cmbxYear.TabIndex = 7;
            this.cmbxYear.SelectedIndexChanged += new System.EventHandler(this.cmbxYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Maximum Temprature";
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxYear);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.cmbxLocation);
            this.Controls.Add(this.btnMenu);
            this.Name = "Graphs";
            this.Text = "Graphs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Graphs_FormClosed);
            this.Load += new System.EventHandler(this.Graphs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.ComboBox cmbxLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxYear;
        private System.Windows.Forms.Label label2;
    }
}