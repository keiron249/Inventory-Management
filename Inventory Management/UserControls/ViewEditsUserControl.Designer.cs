namespace Inventory_Management.UserControls
{
    partial class ViewEditsUserControl
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
            this.gridEdits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEdits)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEdits
            // 
            this.gridEdits.AllowUserToAddRows = false;
            this.gridEdits.AllowUserToDeleteRows = false;
            this.gridEdits.BackgroundColor = System.Drawing.Color.White;
            this.gridEdits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEdits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEdits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridEdits.Location = new System.Drawing.Point(0, 0);
            this.gridEdits.Name = "gridEdits";
            this.gridEdits.ShowEditingIcon = false;
            this.gridEdits.Size = new System.Drawing.Size(800, 425);
            this.gridEdits.TabIndex = 8;
            // 
            // ViewEditsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridEdits);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewEditsUserControl";
            this.Size = new System.Drawing.Size(800, 425);
            this.Load += new System.EventHandler(this.SuppliersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEdits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEdits;
    }
}
