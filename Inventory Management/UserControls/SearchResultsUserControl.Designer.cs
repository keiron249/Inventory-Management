namespace Inventory_Management
{
    partial class SearchResultsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.BoxSearch = new System.Windows.Forms.TextBox();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.ItemStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.ItemStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxSearch
            // 
            this.BoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BoxSearch.Location = new System.Drawing.Point(297, 25);
            this.BoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BoxSearch.Multiline = true;
            this.BoxSearch.Name = "BoxSearch";
            this.BoxSearch.Size = new System.Drawing.Size(321, 36);
            this.BoxSearch.TabIndex = 4;
            this.BoxSearch.Text = "Search...";
            this.BoxSearch.Enter += new System.EventHandler(this.BoxSearch_Enter);
            this.BoxSearch.Leave += new System.EventHandler(this.BoxSearch_Leave);
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResults.BackgroundColor = System.Drawing.Color.White;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.ContextMenuStrip = this.ItemStrip;
            this.gridResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridResults.Location = new System.Drawing.Point(8, 84);
            this.gridResults.Margin = new System.Windows.Forms.Padding(4);
            this.gridResults.Name = "gridResults";
            this.gridResults.ShowEditingIcon = false;
            this.gridResults.Size = new System.Drawing.Size(1059, 330);
            this.gridResults.TabIndex = 6;
            this.gridResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResults_CellClick);
            this.gridResults.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridResults_CellMouseDown);
            // 
            // ItemStrip
            // 
            this.ItemStrip.BackColor = System.Drawing.Color.White;
            this.ItemStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ItemStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemInsert,
            this.itemRemove,
            this.toolStripSeparator1,
            this.itemEdit});
            this.ItemStrip.Name = "ItemStrip";
            this.ItemStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ItemStrip.ShowImageMargin = false;
            this.ItemStrip.Size = new System.Drawing.Size(142, 82);
            // 
            // itemInsert
            // 
            this.itemInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.itemInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(84)))));
            this.itemInsert.Name = "itemInsert";
            this.itemInsert.Size = new System.Drawing.Size(141, 24);
            this.itemInsert.Text = "Insert Item";
            this.itemInsert.Click += new System.EventHandler(this.itemInsert_Click);
            // 
            // itemRemove
            // 
            this.itemRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.itemRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(84)))));
            this.itemRemove.Name = "itemRemove";
            this.itemRemove.Size = new System.Drawing.Size(141, 24);
            this.itemRemove.Text = "Remove Item";
            this.itemRemove.Click += new System.EventHandler(this.itemRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // itemEdit
            // 
            this.itemEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(84)))));
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(141, 24);
            this.itemEdit.Text = "Edit Item";
            this.itemEdit.Click += new System.EventHandler(this.itemEdit_Click);
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
            this.ButtonSearch.Location = new System.Drawing.Point(628, 25);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(30, 30);
            this.ButtonSearch.TabIndex = 5;
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(161, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Can\'t find what you want to deposit?";
            // 
            // buttonInsert
            // 
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.buttonInsert.Location = new System.Drawing.Point(519, 439);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(158, 37);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Insert New Item";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // SearchResultsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.BoxSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchResultsUserControl";
            this.Size = new System.Drawing.Size(1067, 523);
            this.Load += new System.EventHandler(this.SearchResultsUserControl_Load);
            this.Enter += new System.EventHandler(this.SearchResultsUserControl_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ItemStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox BoxSearch;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.ContextMenuStrip ItemStrip;
        private System.Windows.Forms.ToolStripMenuItem itemInsert;
        private System.Windows.Forms.ToolStripMenuItem itemRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsert;
    }
}
