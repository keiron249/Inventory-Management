using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.UserControls
{
    public partial class SuppliersUserControl : UserControl
    {
        static private SuppliersUserControl instance;

        static public SuppliersUserControl Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new SuppliersUserControl();
                }
                return instance;
            }
        }

        public SuppliersUserControl()
        {
            InitializeComponent();
        }

        private void SuppliersUserControl_Load(object sender, EventArgs e)
        {
            gridSuppliers.DataSource = DatabaseTools.GetAllValues("*","Supplier");
            foreach (DataGridViewColumn column in gridSuppliers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            gridSuppliers.Columns[0].Visible = false;
        }
    }
}
