using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management.Classes;
using Inventory_Management.Forms;

namespace Inventory_Management
{
    public partial class AddItemUserControl : UserControl
    {
        static private AddItemUserControl instance;
        bool newSupplier = false;
        int jobID;
        string jobName;

        static public AddItemUserControl Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new AddItemUserControl();
                }
                return instance;
            }
        }

        public AddItemUserControl()
        {
            InitializeComponent();
            DataTable suppliers = DatabaseTools.GetAllValues("SupplierID, [Supplier Name]", "Supplier");
            DataRow other = suppliers.NewRow();
            other["SupplierID"] = -1;
            other["Supplier Name"] = "Other";
            suppliers.Rows.Add(other);
            comboSuppliers.DisplayMember = "Supplier Name";
            comboSuppliers.ValueMember = "SupplierID";
            comboSuppliers.DataSource = suppliers;
        }

        private void comboSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSuppliers.SelectedValue.Equals(-1))
            {
                panelSupplier.Show();
                newSupplier = true;
            }
            else
            {
                panelSupplier.Hide();
                newSupplier = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoxName.Text == "")
            {
                MessageBox.Show("Name/description cannot be empty!");
            }
            else
            {
                if(BoxOrder.Checked)
                {
                    int orderValidity = DatabaseTools.AddOrder(BoxOrderNum.Text, dateOrder.Value, jobID);
                    switch (orderValidity)
                    {
                        case 2:
                            //Order didn't exist but has been added
                            AddItem();
                            break;
                        case 1:
                            //Order exists but date/job don't match
                            MessageBox.Show("Order number exists but input date and/or job does not match what is stored!");
                            break;
                        case 0:
                            //Order exists
                            AddItem();
                            break;
                    }
                }
                else
                {
                    AddItem();
                }
            }
        }

        private void AddItem()
        {
            Item item = new Item();
            item.ItemDescription = BoxName.Text;
            item.Location = BoxLocation.Text;
            item.Material = !BoxTool.Checked;
            item.QuantityStored = int.Parse(BoxQuantity.Text);
            item.UnitValue = float.Parse(BoxValue.Text);
            item.SupplierID = (int)comboSuppliers.SelectedValue;
            if (newSupplier)
            {
                Supplier supplier = new Supplier();
                supplier.Name = BoxSupplierName.Text;
                supplier.Phone = BoxSupplierNumber.Text;
                supplier.Website = BoxSupplierWebsite.Text;
                DatabaseTools.addItem(item, true, supplier);
            }
            else
            {
                DatabaseTools.addItem(item, false);
            }
            instance.Dispose();
            MessageBox.Show("ITEM ADDED SUCCESFULLY");
        }

        private void BoxQuantity_TextChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            try
            {
                int.Parse(box.Text);
                box.BackColor = SystemColors.Window;
                buttonSubmit.Enabled = true;
            }
            catch
            {
                box.BackColor = Color.Red;
                buttonSubmit.Enabled = false;
            }
        }

        private void BoxValue_TextChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            try
            {
                float.Parse(box.Text);
                box.BackColor = SystemColors.Window;
                buttonSubmit.Enabled = true;
            }
            catch
            {
                box.BackColor = Color.Red;
                buttonSubmit.Enabled = false;
            }
        }

        private void BoxOrder_CheckedChanged(object sender, EventArgs e)
        {
            panelOrder.Visible = BoxOrder.Checked;
        }

        private void JobButton_Click(object sender, EventArgs e)
        {
            using (var form = new SelectJobForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    jobID = form.JobID;
                    jobName = form.JobName;
                }
            }
            labelJob.Text = "Selected Job: " + jobName;
        }

        private void BoxOrderNum_TextChanged(object sender, EventArgs e)
        {
            if (!(BoxOrderNum.Tag.ToString() == "backspace"))
            {
                switch (BoxOrderNum.TextLength)
                {
                    case 5:
                    case 8:
                        BoxOrderNum.AppendText("/");
                        break;
                }
            }
        }

        private void BoxOrderNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                BoxOrderNum.Tag = "backspace";
                switch (BoxOrderNum.TextLength)
                {
                    case 6:
                    case 9:
                        BoxOrderNum.Text = BoxOrderNum.Text.Substring(0, BoxOrderNum.TextLength - 1);
                        BoxOrderNum.SelectionStart = BoxOrderNum.TextLength;
                        break;
                }
            }
            else
            {
                BoxOrderNum.Tag = "";
            }
        }
    }
}
