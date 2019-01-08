namespace assessment
{
    partial class OptionsForm
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
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditData = new System.Windows.Forms.Button();
            this.btnViewGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewData
            // 
            this.btnViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewData.Location = new System.Drawing.Point(53, 200);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(115, 59);
            this.btnViewData.TabIndex = 0;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(195, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 59);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditData
            // 
            this.btnEditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditData.Location = new System.Drawing.Point(342, 200);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(115, 59);
            this.btnEditData.TabIndex = 2;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.UseVisualStyleBackColor = true;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // btnViewGraph
            // 
            this.btnViewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGraph.Location = new System.Drawing.Point(494, 200);
            this.btnViewGraph.Name = "btnViewGraph";
            this.btnViewGraph.Size = new System.Drawing.Size(115, 59);
            this.btnViewGraph.TabIndex = 3;
            this.btnViewGraph.Text = "View Graphs";
            this.btnViewGraph.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewGraph);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnViewData);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Button btnViewGraph;
    }
}