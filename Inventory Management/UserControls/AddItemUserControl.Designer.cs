namespace Inventory_Management
{
    partial class AddItemUserControl
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
            this.BoxName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.BoxQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxTool = new System.Windows.Forms.CheckBox();
            this.comboSuppliers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxSupplierWebsite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxSupplierNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxSupplierName = new System.Windows.Forms.TextBox();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.BoxOrderNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.JobButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.BoxOrder = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BoxValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelSupplier.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxName
            // 
            this.BoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxName.Location = new System.Drawing.Point(245, 105);
            this.BoxName.Margin = new System.Windows.Forms.Padding(4);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(199, 30);
            this.BoxName.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.labelTitle.Location = new System.Drawing.Point(393, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(184, 31);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Add New Item";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.labelDescription.Location = new System.Drawing.Point(4, 108);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(215, 25);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description\\Item Name:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.labelQuantity.Location = new System.Drawing.Point(5, 150);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(91, 25);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Quantity:";
            // 
            // BoxQuantity
            // 
            this.BoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxQuantity.Location = new System.Drawing.Point(109, 146);
            this.BoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.BoxQuantity.Name = "BoxQuantity";
            this.BoxQuantity.Size = new System.Drawing.Size(199, 30);
            this.BoxQuantity.TabIndex = 4;
            this.BoxQuantity.TextChanged += new System.EventHandler(this.BoxQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(4, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Is this item a tool?";
            // 
            // BoxTool
            // 
            this.BoxTool.AutoSize = true;
            this.BoxTool.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.BoxTool.Location = new System.Drawing.Point(195, 251);
            this.BoxTool.Margin = new System.Windows.Forms.Padding(4);
            this.BoxTool.Name = "BoxTool";
            this.BoxTool.Size = new System.Drawing.Size(18, 17);
            this.BoxTool.TabIndex = 6;
            this.BoxTool.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BoxTool.UseVisualStyleBackColor = true;
            // 
            // comboSuppliers
            // 
            this.comboSuppliers.FormattingEnabled = true;
            this.comboSuppliers.Location = new System.Drawing.Point(107, 294);
            this.comboSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.comboSuppliers.Name = "comboSuppliers";
            this.comboSuppliers.Size = new System.Drawing.Size(249, 24);
            this.comboSuppliers.TabIndex = 7;
            this.comboSuppliers.SelectedIndexChanged += new System.EventHandler(this.comboSuppliers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(3, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Supplier:";
            // 
            // BoxLocation
            // 
            this.BoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLocation.Location = new System.Drawing.Point(109, 345);
            this.BoxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.BoxLocation.Name = "BoxLocation";
            this.BoxLocation.Size = new System.Drawing.Size(199, 30);
            this.BoxLocation.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(3, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.AutoSize = true;
            this.buttonSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.buttonSubmit.Location = new System.Drawing.Point(465, 442);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(85, 37);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSupplier
            // 
            this.panelSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSupplier.AutoSize = true;
            this.panelSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSupplier.Controls.Add(this.label7);
            this.panelSupplier.Controls.Add(this.BoxSupplierWebsite);
            this.panelSupplier.Controls.Add(this.label6);
            this.panelSupplier.Controls.Add(this.BoxSupplierNumber);
            this.panelSupplier.Controls.Add(this.label5);
            this.panelSupplier.Controls.Add(this.label4);
            this.panelSupplier.Controls.Add(this.BoxSupplierName);
            this.panelSupplier.Location = new System.Drawing.Point(627, 6);
            this.panelSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(387, 235);
            this.panelSupplier.TabIndex = 12;
            this.panelSupplier.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(4, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Website:";
            // 
            // BoxSupplierWebsite
            // 
            this.BoxSupplierWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxSupplierWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierWebsite.Location = new System.Drawing.Point(107, 149);
            this.BoxSupplierWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.BoxSupplierWebsite.Name = "BoxSupplierWebsite";
            this.BoxSupplierWebsite.Size = new System.Drawing.Size(273, 30);
            this.BoxSupplierWebsite.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(4, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone Number:";
            // 
            // BoxSupplierNumber
            // 
            this.BoxSupplierNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxSupplierNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierNumber.Location = new System.Drawing.Point(171, 113);
            this.BoxSupplierNumber.Margin = new System.Windows.Forms.Padding(4);
            this.BoxSupplierNumber.Name = "BoxSupplierNumber";
            this.BoxSupplierNumber.Size = new System.Drawing.Size(209, 30);
            this.BoxSupplierNumber.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(4, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name*:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(152, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Supplier";
            // 
            // BoxSupplierName
            // 
            this.BoxSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSupplierName.Location = new System.Drawing.Point(93, 70);
            this.BoxSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.BoxSupplierName.Name = "BoxSupplierName";
            this.BoxSupplierName.Size = new System.Drawing.Size(287, 30);
            this.BoxSupplierName.TabIndex = 13;
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
            this.panelOrder.Location = new System.Drawing.Point(627, 246);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(387, 235);
            this.panelOrder.TabIndex = 13;
            this.panelOrder.Visible = false;
            // 
            // BoxOrderNum
            // 
            this.BoxOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOrderNum.Location = new System.Drawing.Point(153, 43);
            this.BoxOrderNum.Margin = new System.Windows.Forms.Padding(4);
            this.BoxOrderNum.Name = "BoxOrderNum";
            this.BoxOrderNum.Size = new System.Drawing.Size(226, 30);
            this.BoxOrderNum.TabIndex = 19;
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
            // BoxOrder
            // 
            this.BoxOrder.AutoSize = true;
            this.BoxOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.BoxOrder.Location = new System.Drawing.Point(335, 409);
            this.BoxOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BoxOrder.Name = "BoxOrder";
            this.BoxOrder.Size = new System.Drawing.Size(18, 17);
            this.BoxOrder.TabIndex = 15;
            this.BoxOrder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BoxOrder.UseVisualStyleBackColor = true;
            this.BoxOrder.CheckedChanged += new System.EventHandler(this.BoxOrder_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label12.Location = new System.Drawing.Point(4, 402);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Is this item part of a larger order?";
            // 
            // BoxValue
            // 
            this.BoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxValue.Location = new System.Drawing.Point(121, 195);
            this.BoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.BoxValue.Name = "BoxValue";
            this.BoxValue.Size = new System.Drawing.Size(187, 30);
            this.BoxValue.TabIndex = 17;
            this.BoxValue.TextChanged += new System.EventHandler(this.BoxValue_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(5, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Unit Value:";
            // 
            // AddItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BoxValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BoxOrder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.BoxLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSuppliers);
            this.Controls.Add(this.BoxTool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.BoxName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddItemUserControl";
            this.Size = new System.Drawing.Size(1067, 523);
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox BoxQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BoxTool;
        private System.Windows.Forms.ComboBox comboSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BoxSupplierWebsite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BoxSupplierNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxSupplierName;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.CheckBox BoxOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.Button JobButton;
        private System.Windows.Forms.TextBox BoxValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BoxOrderNum;
        private System.Windows.Forms.Label label10;
    }
}
