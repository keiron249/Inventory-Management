using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.Forms
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            int ID;
            bool unique;
            Random random = new Random();
            do
            {
                ID = random.Next(1000, 10000);
                unique = DatabaseTools.checkUserID(ID);
            } while (!unique);
            BoxID.Text = ID.ToString();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(BoxID.Text);
            string name = BoxName.Text;
            bool manager = BoxManager.Checked;
            DatabaseTools.AddEmployee(ID, name, manager);
            MessageBox.Show("Successfully Added Employee");
            this.Close();
        }

        private void BoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(BoxID.Text);
                if (DatabaseTools.checkUserID(ID))
                {
                    ButtonSubmit.Enabled = true;
                    labelError.Visible = false;
                }
                else
                {
                    ButtonSubmit.Enabled = false;
                    labelError.Text = "ID is not unique";
                    labelError.Visible = true;
                }
            }
            catch
            {
                ButtonSubmit.Enabled = false;
                labelError.Text = "ID must only be numbers";
                labelError.Visible = true;
            }
        }

        private void AddEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
