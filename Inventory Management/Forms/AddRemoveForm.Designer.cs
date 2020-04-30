namespace Inventory_Management.Forms
{
    partial class AddRemoveForm
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.boxAmount = new System.Windows.Forms.TextBox();
            this.BoxOrder = new System.Windows.Forms.CheckBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.BoxOrderNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.JobButton = new System.Windows.Forms.Button();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.AutoSize = true;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(156, 55);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 39);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label.Location = new System.Drawing.Point(16, 11);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(168, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Remove Quantity:";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxAmount
            // 
            this.boxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAmount.Location = new System.Drawing.Point(204, 7);
            this.boxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.boxAmount.Name = "boxAmount";
            this.boxAmount.Size = new System.Drawing.Size(225, 30);
            this.boxAmount.TabIndex = 0;
            this.boxAmount.TextChanged += new System.EventHandler(this.boxAmount_TextChanged);
            // 
            // BoxOrder
            // 
            this.BoxOrder.AutoSize = true;
            this.BoxOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.BoxOrder.Location = new System.Drawing.Point(347, 105);
            this.BoxOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BoxOrder.Name = "BoxOrder";
            this.BoxOrder.Size = new System.Drawing.Size(18, 17);
            this.BoxOrder.TabIndex = 17;
            this.BoxOrder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BoxOrder.UseVisualStyleBackColor = true;
            this.BoxOrder.Visible = false;
            this.BoxOrder.CheckedChanged += new System.EventHandler(this.BoxOrder_CheckedChanged);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.labelOrder.Location = new System.Drawing.Point(16, 98);
            this.labelOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(293, 25);
            this.labelOrder.TabIndex = 16;
            this.labelOrder.Text = "Is this item part of a larger order?";
            this.labelOrder.Visible = false;
            this.labelOrder.Click += new System.EventHandler(this.labelOrder_Click);
            // 
            // panelOrder
            // 
            this.panelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrder.AutoSize = true;
            this.panelOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrder.Controls.Add(this.BoxOrderNum);
            this.panelOrder.Controls.Add(this.label10);
            this.panelOrder.Controls.Add(this.labelJob);
            this.panelOrder.Controls.Add(this.JobButton);
            this.panelOrder.Controls.Add(this.label9);
            this.panelOrder.Controls.Add(this.dateOrder);
            this.panelOrder.Controls.Add(this.OrderLabel);
            this.panelOrder.Location = new System.Drawing.Point(21, 128);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(387, 235);
            this.panelOrder.TabIndex = 18;
            this.panelOrder.Visible = false;
            // 
            // BoxOrderNum
            // 
            this.BoxOrderNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BoxOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOrderNum.Location = new System.Drawing.Point(153, 43);
            this.BoxOrderNum.Margin = new System.Windows.Forms.Padding(4);
            this.BoxOrderNum.MaxLength = 11;
            this.BoxOrderNum.Name = "BoxOrderNum";
            this.BoxOrderNum.Size = new System.Drawing.Size(226, 30);
            this.BoxOrderNum.TabIndex = 19;
            this.BoxOrderNum.TextChanged += new System.EventHandler(this.BoxOrderNum_TextChanged);
            this.BoxOrderNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxOrderNum_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(3, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Order Number:";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.labelJob.Location = new System.Drawing.Point(4, 201);
            this.labelJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJob.MaximumSize = new System.Drawing.Size(375, 25);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(146, 25);
            this.labelJob.TabIndex = 16;
            this.labelJob.Text = "No job selected";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(3, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Order Date:";
            // 
            // dateOrder
            // 
            this.dateOrder.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.dateOrder.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.dateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOrder.Location = new System.Drawing.Point(132, 92);
            this.dateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(247, 30);
            this.dateOrder.TabIndex = 14;
            // 
            // OrderLabel
            // 
            this.OrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.OrderLabel.Location = new System.Drawing.Point(152, 2);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(62, 25);
            this.OrderLabel.TabIndex = 13;
            this.OrderLabel.Text = "Order";
            // 
            // JobButton
            // 
            this.JobButton.AutoSize = true;
            this.JobButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.JobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.JobButton.Location = new System.Drawing.Point(112, 147);
            this.JobButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JobButton.Name = "JobButton";
            this.JobButton.Size = new System.Drawing.Size(117, 37);
            this.JobButton.TabIndex = 16;
            this.JobButton.Text = "Select Job";
            this.JobButton.UseVisualStyleBackColor = true;
            this.JobButton.Click += new System.EventHandler(this.JobButton_Click);
            // 
            // AddRemoveForm
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 369);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.BoxOrder);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.boxAmount);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonSubmit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRemoveForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRemove";
            this.TopMost = true;
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox boxAmount;
        private System.Windows.Forms.CheckBox BoxOrder;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.TextBox BoxOrderNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Button JobButton;
    }
}