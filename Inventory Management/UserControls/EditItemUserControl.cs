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

namespace Inventory_Management.UserControls
{
    public partial class EditItemUserControl : UserControl
    {
        Item original;
        bool newSupplier = false;

        public EditItemUserControl(Item Original)
        {
            this.original = Original;
            InitializeComponent();
            BoxName.Text = original.ItemDescription;
            BoxQuantity.Text = original.QuantityStored.ToString();
            BoxTool.Checked = !original.Material;
            comboSuppliers.SelectedValue = original.SupplierID;
            BoxLocation.Text = original.Location;

            DataTable suppliers = DatabaseTools.GetAllValues("SupplierID, [Supplier Name]", "Supplier");
            DataRow other = suppliers.NewRow();
            other["SupplierID"] = -1;
            other["Supplier Name"] = "Other";
            suppliers.Rows.Add(other);
            comboSuppliers.DisplayMember = "Supplier Name";
            comboSuppliers.ValueMember = "SupplierID";
            comboSuppliers.DataSource = suppliers;
            int otherLocation = comboSuppliers.Items.Count;
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
            Item item = original;
            item.ItemDescription = BoxName.Text;
            item.Location = BoxLocation.Text;
            item.Material = !BoxTool.Checked;
            item.QuantityStored = int.Parse(BoxQuantity.Text);
            item.SupplierID = (int)comboSuppliers.SelectedValue;
            if (newSupplier)
            {
                Supplier supplier = new Supplier();
                supplier.Name = BoxSupplierName.Text;
                supplier.Phone = BoxSupplierNumber.Text;
                supplier.Website = BoxSupplierWebsite.Text;
                DatabaseTools.editItem(item, true, supplier);
            }
            else
            {
                DatabaseTools.editItem(item, false);
            }
            this.Dispose();
            SearchResultsUserControl.Instance.Focus();
        }

        private void BoxQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(BoxQuantity.Text);
                BoxQuantity.BackColor = SystemColors.Window;
                buttonSubmit.Enabled = true;
            }
            catch
            {

                BoxQuantity.BackColor = Color.Red;
                buttonSubmit.Enabled = false;
            }
        }
    }
}
