using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        string userID;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (DatabaseTools.IsInDatabase("Employee","Employee Code",BoxID.Text))
            {
                LabelError.Hide();
                userID = BoxID.Text;
                Main main = new Main(userID);
                main.Show();
                this.Hide();
                BoxID.Clear();
            }
            else
            {
                LabelError.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you would like to close? This is only reccomended if necessary!", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
