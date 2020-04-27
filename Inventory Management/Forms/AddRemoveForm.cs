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
    public partial class AddRemoveForm : Form
    {
        public int amount { get; private set; }
        public int jobID { get; private set; }
        public string orderID { get; private set; } = null;

        public AddRemoveForm(bool addRemove /* true = insert, false = remove */)
        {
            InitializeComponent();
            switch (addRemove)
            {
                case true:
                    label.Text = "Insert Quantity";
                    this.Size = new Size(351, 150);
                    labelOrder.Show();
                    BoxOrder.Show();
                    break;
                case false:
                    label.Text = "Remove Quantity";
                    this.Size = new Size(351, 128);
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoxOrder.Checked)
            {
                int orderValidity = DatabaseTools.AddOrder(BoxOrderNum.Text, dateOrder.Value, jobID);
                switch (orderValidity)
                {
                    case 2:
                        //Order didn't exist but has been added
                        Submit();
                        break;
                    case 1:
                        //Order exists but date/job don't match
                        MessageBox.Show("Order number exists but input date and/or job does not match what is stored!");
                        break;
                    case 0:
                        //Order exists
                        Submit();
                        break;
                }
            }
            else
            {
                Submit();
            }
        }

        private void Submit()
        {
            if (BoxOrder.Checked)
            {
                orderID = BoxOrderNum.Text;
            }
            amount = int.Parse(boxAmount.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void boxAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(boxAmount.Text);
                buttonSubmit.Enabled = true;
                boxAmount.BackColor = SystemColors.Window;
            }
            catch
            {
                buttonSubmit.Enabled = false;
                boxAmount.BackColor = Color.Red;
            }
        }

        private void BoxOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxOrder.Checked)
            {
                this.Size = new Size(351, 339);
                panelOrder.Show();
            }
            else
            {
                this.Size = new Size(351, 150);
                panelOrder.Hide();
            }
        }

        private void JobButton_Click(object sender, EventArgs e)
        {
            string jobName = "NO JOB";
            using (var form = new SelectJobForm())
            {
                this.TopMost = false;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    jobID = form.JobID;
                    jobName = form.JobName;
                }
                this.TopMost = true;
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

        private void labelOrder_Click(object sender, EventArgs e)
        {
            BoxOrder.Checked = !BoxOrder.Checked;
        }
    }
}
