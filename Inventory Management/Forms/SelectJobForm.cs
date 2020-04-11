using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management.Forms
{
    public partial class SelectJobForm : Form
    {
        public int JobID;
        public string JobName;
        Regex postCode = new Regex("^(([gG][iI][rR] {0,}0[aA]{2})|((([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y]?[0-9][0-9]?)|(([a-pr-uwyzA-PR-UWYZ][0-9][a-hjkstuwA-HJKSTUW])|([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y][0-9][abehmnprv-yABEHMNPRV-Y]))) {0,}[0-9][abd-hjlnp-uw-zABD-HJLNP-UW-Z]{2}))$");
        // Taken from https://stackoverflow.com/questions/164979/regex-for-matching-uk-postcodes

        public SelectJobForm()
        {
            InitializeComponent();
            datePicker.MinDate = DateTime.Now;
        }

        private void AddJobForm_Load(object sender, EventArgs e)
        {
            gridJobs.DataSource = DatabaseTools.GetAllValues("Job.[JobID], Job.[Name], Job.[Street Address], Job.[Post Code]", "Job WHERE Job.[End Date] >= GETDATE()");
            foreach (DataGridViewColumn column in gridJobs.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            gridJobs.Columns[0].Visible = false;
        }

        private void buttonNewJob_Click(object sender, EventArgs e)
        {
            JobName = BoxName.Text;
            JobID = DatabaseTools.addSupplier(JobName, BoxAddress.Text, BoxPostCode.Text, datePicker.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            JobID = (int)gridJobs.CurrentRow.Cells[0].Value;
            JobName = (string)gridJobs.CurrentRow.Cells[1].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BoxPostCode_TextChanged(object sender, EventArgs e)
        {
            if (!postCode.IsMatch(BoxPostCode.Text))
            {
                buttonNewJob.Enabled = false;
                BoxPostCode.BackColor = Color.Red;
            }
            else
            {
                buttonNewJob.Enabled = true;
                BoxPostCode.BackColor = SystemColors.Window;
            }
        }
    }
}