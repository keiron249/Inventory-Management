namespace Inventory_Management
{
    partial class MainUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserControl));
            this.BoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSuppliers = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.buttonEdits = new System.Windows.Forms.Button();
            this.panelManagers = new System.Windows.Forms.Panel();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.panelManagers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxSearch
            // 
            this.BoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BoxSearch.Location = new System.Drawing.Point(4, 98);
            this.BoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BoxSearch.Multiline = true;
            this.BoxSearch.Name = "BoxSearch";
            this.BoxSearch.Size = new System.Drawing.Size(631, 36);
            this.BoxSearch.TabIndex = 0;
            this.BoxSearch.Text = "Search...";
            this.BoxSearch.Enter += new System.EventHandler(this.BoxSearch_Enter);
            this.BoxSearch.Leave += new System.EventHandler(this.BoxSearch_Leave);
            // 
            // ButtonSuppliers
            // 
            this.ButtonSuppliers.AutoSize = true;
            this.ButtonSuppliers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ButtonSuppliers.Location = new System.Drawing.Point(451, 142);
            this.ButtonSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSuppliers.Name = "ButtonSuppliers";
            this.ButtonSuppliers.Size = new System.Drawing.Size(267, 41);
            this.ButtonSuppliers.TabIndex = 2;
            this.ButtonSuppliers.Text = "View Suppliers Details";
            this.ButtonSuppliers.UseVisualStyleBackColor = true;
            this.ButtonSuppliers.Click += new System.EventHandler(this.ButtonSuppliers_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AutoSize = true;
            this.ButtonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSearch.BackColor = System.Drawing.Color.White;
            this.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonSearch.FlatAppearance.BorderSize = 0;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSearch.Image = global::Inventory_Management.Properties.Resources.Search;
            this.ButtonSearch.Location = new System.Drawing.Point(644, 97);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(30, 30);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEdits
            // 
            this.buttonEdits.AutoSize = true;
            this.buttonEdits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.buttonEdits.Location = new System.Drawing.Point(70, 85);
            this.buttonEdits.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdits.Name = "buttonEdits";
            this.buttonEdits.Size = new System.Drawing.Size(199, 50);
            this.buttonEdits.TabIndex = 3;
            this.buttonEdits.Text = "View Edits";
            this.buttonEdits.UseVisualStyleBackColor = true;
            this.buttonEdits.Click += new System.EventHandler(this.buttonEdits_Click);
            // 
            // panelManagers
            // 
            this.panelManagers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManagers.Controls.Add(this.buttonEmployee);
            this.panelManagers.Controls.Add(this.buttonReports);
            this.panelManagers.Controls.Add(this.label1);
            this.panelManagers.Controls.Add(this.buttonEdits);
            this.panelManagers.Location = new System.Drawing.Point(738, 142);
            this.panelManagers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelManagers.Name = "panelManagers";
            this.panelManagers.Size = new System.Drawing.Size(326, 302);
            this.panelManagers.TabIndex = 4;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.AutoSize = true;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.buttonEmployee.Location = new System.Drawing.Point(50, 201);
            this.buttonEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(239, 50);
            this.buttonEmployee.TabIndex = 6;
            this.buttonEmployee.Text = "Add New Employee";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.AutoSize = true;
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.buttonReports.Location = new System.Drawing.Point(58, 143);
            this.buttonReports.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(223, 50);
            this.buttonReports.TabIndex = 5;
            this.buttonReports.Text = "Open Reports File";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manager-Only Controls";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 192);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 329);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(713, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Help and How To";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(713, 327);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInsert
            // 
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.buttonInsert.Location = new System.Drawing.Point(252, 142);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(192, 41);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert New Item";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelManagers);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.BoxSearch);
            this.Controls.Add(this.ButtonSuppliers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(1067, 523);
            this.Load += new System.EventHandler(this.MainUserControl_Load);
            this.panelManagers.ResumeLayout(false);
            this.panelManagers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonSuppliers;
        private System.Windows.Forms.Button buttonEdits;
        private System.Windows.Forms.Panel panelManagers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonEmployee;
    }
}
