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
    public partial class ViewEditsUserControl : UserControl
    {
        public ViewEditsUserControl()
        {
            InitializeComponent();
        }

        static private ViewEditsUserControl instance;

        static public ViewEditsUserControl Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new ViewEditsUserControl();
                }
                return instance;
            }
        }

        private void SuppliersUserControl_Load(object sender, EventArgs e)
        {
            gridEdits.DataSource = DatabaseTools.GetAllValues("Edit.[Employee Code], Employee.[Employee Name], [Edit Types].[Type], Item.[Item Description], Edit.[Quantity], Edit.[Time]", "Edit, Employee, Item, [Edit Types] WHERE Edit.[Employee Code] = Employee.[Employee Code] AND Edit.[ItemID] = Item.[ItemID] AND [Edit Types].Id = Edit.Type");
            foreach (DataGridViewColumn column in gridEdits.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            gridEdits.Columns[0].Visible = false;
        }

    }
}
