using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management.Forms;

namespace Inventory_Management
{
    public partial class SearchResultsUserControl : UserControl
    {
        static private SearchResultsUserControl instance;
        public EventHandler AddOpen;
        public EventHandler EditOpen;
        static private string searchTerm;

        static public SearchResultsUserControl Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new SearchResultsUserControl();
                }
                return instance;
            }
        }

        public string SearchTerm { get => searchTerm; set => searchTerm = value; }

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
            searchTerm = BoxSearch.Text;
            FillGrid();
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

        public SearchResultsUserControl()
        {
            InitializeComponent();
        }


        private void GridSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillGrid()
        {
            gridResults.DataSource = DatabaseTools.GetSearchRow(searchTerm);
            foreach (DataGridViewColumn column in gridResults.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            gridResults.Columns[0].Visible = false;
        }

        private void SearchResultsUserControl_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void gridResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridResults.ContextMenuStrip.Show(MousePosition);
            }
        }

        private void gridResults_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right &&e.RowIndex >= 0)
            {
                gridResults.CurrentCell = gridResults[e.ColumnIndex, e.RowIndex];
            }
        }

        private void itemInsert_Click(object sender, EventArgs e)
        {
            int insertAmount;
            string orderID;
            using (var form = new AddRemoveForm(true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    insertAmount = form.amount;
                    orderID = form.orderID;
                    DatabaseTools.updateQuantity(int.Parse(gridResults.CurrentRow.Cells[0].Value.ToString()), true, insertAmount, orderID);
                }
            }
            FillGrid();
        }

        private void itemRemove_Click(object sender, EventArgs e)
        {
            int insertAmount;
            using (var form = new AddRemoveForm(false))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    insertAmount = form.amount;
                    if (insertAmount > (int)gridResults.CurrentRow.Cells[2].Value)
                    {
                        MessageBox.Show("Cannot remove an amount greater than what is currently stored");
                    }
                    else
                    {
                        DatabaseTools.updateQuantity(int.Parse(gridResults.CurrentRow.Cells[0].Value.ToString()), false, insertAmount);
                    }
                }
            }
            FillGrid();
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            Item toEdit = DatabaseTools.getItem(gridResults.CurrentRow.Cells[0].Value.ToString());
            this.EditOpen?.Invoke(this, new ItemArgs(toEdit));
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            this.AddOpen?.Invoke(this, new EventArgs());
            FillGrid();
        }

        private void SearchResultsUserControl_Enter(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
