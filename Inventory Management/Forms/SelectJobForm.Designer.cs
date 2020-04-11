namespace Inventory_Management.Forms
{
    partial class SelectJobForm
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
            this.gridJobs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxAddress = new System.Windows.Forms.TextBox();
            this.BoxPostCode = new System.Windows.Forms.TextBox();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.buttonNewJob = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridJobs
            // 
            this.gridJobs.AllowUserToAddRows = false;
            this.gridJobs.AllowUserToDeleteRows = false;
            this.gridJobs.BackgroundColor = System.Drawing.Color.White;
            this.gridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJobs.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridJobs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridJobs.Location = new System.Drawing.Point(0, 0);
            this.gridJobs.Margin = new System.Windows.Forms.Padding(4);
            this.gridJobs.Name = "gridJobs";
            this.gridJobs.ShowEditingIcon = false;
            this.gridJobs.Size = new System.Drawing.Size(1067, 556);
            this.gridJobs.TabIndex = 9;
            this.gridJobs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridJobs_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BoxAddress);
            this.panel1.Controls.Add(this.BoxPostCode);
            this.panel1.Controls.Add(this.BoxName);
            this.panel1.Controls.Add(this.buttonNewJob);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 230);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Can\'t find the job you\'re looking for?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(16, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Post Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Street Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Job Name:";
            // 
            // BoxAddress
            // 
            this.BoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.BoxAddress.Location = new System.Drawing.Point(184, 118);
            this.BoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.BoxAddress.Name = "BoxAddress";
            this.BoxAddress.Size = new System.Drawing.Size(355, 30);
            this.BoxAddress.TabIndex = 3;
            // 
            // BoxPostCode
            // 
            this.BoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPostCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.BoxPostCode.Location = new System.Drawing.Point(140, 162);
            this.BoxPostCode.Margin = new System.Windows.Forms.Padding(4);
            this.BoxPostCode.Name = "BoxPostCode";
            this.BoxPostCode.Size = new System.Drawing.Size(399, 30);
            this.BoxPostCode.TabIndex = 2;
            this.BoxPostCode.TextChanged += new System.EventHandler(this.BoxPostCode_TextChanged);
            // 
            // BoxName
            // 
            this.BoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.BoxName.Location = new System.Drawing.Point(137, 69);
            this.BoxName.Margin = new System.Windows.Forms.Padding(4);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(401, 30);
            this.BoxName.TabIndex = 1;
            // 
            // buttonNewJob
            // 
            this.buttonNewJob.AutoSize = true;
            this.buttonNewJob.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewJob.Enabled = false;
            this.buttonNewJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.buttonNewJob.Location = new System.Drawing.Point(643, 159);
            this.buttonNewJob.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewJob.Name = "buttonNewJob";
            this.buttonNewJob.Size = new System.Drawing.Size(142, 37);
            this.buttonNewJob.TabIndex = 0;
            this.buttonNewJob.Text = "Add New Job";
            this.buttonNewJob.UseVisualStyleBackColor = true;
            this.buttonNewJob.Click += new System.EventHandler(this.buttonNewJob_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.datePicker.CustomFormat = "";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(701, 74);
            this.datePicker.MinDate = new System.DateTime(2020, 3, 11, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(154, 22);
            this.datePicker.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(595, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Date:";
            // 
            // AddJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridJobs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddJobForm";
            this.Text = "AddJobForm";
            this.Load += new System.EventHandler(this.AddJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridJobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNewJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxAddress;
        private System.Windows.Forms.TextBox BoxPostCode;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}