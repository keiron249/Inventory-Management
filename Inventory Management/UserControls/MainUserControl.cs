using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class MainUserControl : UserControl
    {
        static private MainUserControl instance;
        public event EventHandler SearchStarted;
        public event EventHandler EditsView;
        public EventHandler AddOpen;
        public event EventHandler SuppliersView;
        bool isAdmin;

        static public MainUserControl Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new MainUserControl();
                }
                return instance;
            }
        }
        public MainUserControl()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ButtonSearch.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BoxSearch_Enter(object sender, EventArgs e)
        {
            if (BoxSearch.Text == "Search...")
            {
                BoxSearch.Text = "";
                BoxSearch.ForeColor = TextBox.DefaultForeColor;
            }
        }

        private void BoxSearch_Leave(object sender, EventArgs e)
        {
            if (BoxSearch.Text == "")
            {
                BoxSearch.Text = "Search...";
                BoxSearch.ForeColor = SystemColors.GrayText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = BoxSearch.Text;
            this.SearchStarted?.Invoke(this, new StringArgs(searchTerm));
        }

        private void ButtonSuppliers_Click(object sender, EventArgs e)
        {
            this.SuppliersView?.Invoke(this, new EventArgs());
        }

        private void buttonEdits_Click(object sender, EventArgs e)
        {
            this.EditsView?.Invoke(this, new EventArgs());
        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {
            isAdmin = bool.Parse(DatabaseTools.GetValueFromKey("Employee", "Is Manager?", Main.userID, "Employee Code"));
            if (isAdmin)
            {
                panelManagers.Show();
            }
            else
            {
                panelManagers.Hide();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.AddOpen?.Invoke(this, new EventArgs());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Reports.xlsx");
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Forms.AddEmployeeForm form = new Forms.AddEmployeeForm();
            form.Show();
        }
    }
}
