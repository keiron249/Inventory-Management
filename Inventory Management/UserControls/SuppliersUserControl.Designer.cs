namespace Inventory_Management.UserControls
{
    partial class SuppliersUserControl
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
            this.gridSuppliers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.AllowUserToAddRows = false;
            this.gridSuppliers.AllowUserToDeleteRows = false;
            this.gridSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.gridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridSuppliers.Location = new System.Drawing.Point(0, 0);
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.ShowEditingIcon = false;
            this.gridSuppliers.Size = new System.Drawing.Size(800, 425);
            this.gridSuppliers.TabIndex = 7;
            // 
            // SuppliersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSuppliers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SuppliersUserControl";
            this.Size = new System.Drawing.Size(800, 425);
            this.Load += new System.EventHandler(this.SuppliersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSuppliers;
    }
}
