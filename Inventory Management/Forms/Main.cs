using Inventory_Management.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Main : Form
    {
        public static string userID;
        private string name;
        public static ActionStack actionStack = new ActionStack(10);
        bool allowedClose;
        Timer idle = new Timer();

        public Main(string userid)
        {
            allowedClose = false;
            KeyPreview = true;
            idle.Interval = 900000;
            //idle.Interval = 10000; //Shorter interval for testing
            idle.Tick += Idle_Tick;
            userID = userid;
            InitializeComponent();
        }

        private void setEvents(Control c)
        {
            foreach (Control item in c.Controls)
            {
                if (item.HasChildren)
                {
                    setEvents(item);
                }
                item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
                item.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PanelContent.Controls.Add(MainUserControl.Instance);
            MainUserControl.Instance.Dock = DockStyle.Fill;
            MainUserControl.Instance.BringToFront();

            name = DatabaseTools.GetValueFromKey("Employee", "Employee Name", userID,"Employee Code");
            LabelName.Text = "Welcome, " + name;

            MainUserControl.Instance.SearchStarted += new EventHandler(OpenSearchResults);
            MainUserControl.Instance.SuppliersView += new EventHandler(ViewSuppliers);
            MainUserControl.Instance.EditsView += new EventHandler(ViewEdits);
            MainUserControl.Instance.AddOpen += new EventHandler(OpenAdd);
            SearchResultsUserControl.Instance.AddOpen += MainUserControl.Instance.AddOpen;
            SearchResultsUserControl.Instance.EditOpen += new EventHandler(OpenEdit);

            setEvents(this);

            actionStack.Push(actions.Main);
        }

        private void addControl(Control control)
        {
            PanelContent.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            setEvents(control);
        }

        private void ViewEdits(object sender, EventArgs e)
        {
            addControl(ViewEditsUserControl.Instance);
            actionStack.Push(actions.ViewEdits);
            UpdateBackButton();
        }

        private void ViewSuppliers(object sender, EventArgs e)
        {
            addControl(SuppliersUserControl.Instance);
            actionStack.Push(actions.Suppliers);
            UpdateBackButton();
        }

        private void OpenEdit(object sender, EventArgs e)
        {
            EditItemUserControl edit = new EditItemUserControl((e as ItemArgs).Item);
            addControl(edit);
            actionStack.Push(actions.Edit);
            UpdateBackButton();
        }

        private void OpenAdd(object sender, EventArgs e)
        {
            addControl(AddItemUserControl.Instance);
            actionStack.Push(actions.Add);
            UpdateBackButton();
        }

        private void OpenMain(object sender, EventArgs e)
        {
            addControl(MainUserControl.Instance);
            actionStack.Push(actions.Main);
            UpdateBackButton();
        }

        private void OpenSearchResults(object sender, EventArgs e)
        {
            SearchResultsUserControl search = SearchResultsUserControl.Instance;
            search.SearchTerm = (e as StringArgs).Value;
            addControl(search);
            actionStack.Push(actions.Search);
            setEvents(search);
            UpdateBackButton();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            actionStack.Pop();
            bool validBack = true;
            do
            {
                switch (actionStack.Pop())
                {
                    case actions.Main:
                        OpenMain(this, new EventArgs());
                        break;
                    case actions.Add:
                        OpenAdd(this, new EventArgs());
                        break;
                    case actions.Search:
                        OpenSearchResults(this, new StringArgs(SearchResultsUserControl.Instance.SearchTerm));
                        break;
                    case actions.Edit:
                        validBack = false;
                        break;
                    case actions.Suppliers:
                        ViewSuppliers(this, new EventArgs());
                        break;
                    case actions.ViewEdits:
                        ViewEdits(this,new EventArgs());
                        break;
                    default:
                        break;
                }
            } while (!validBack);
        }

        private void UpdateBackButton()
        {
            if (actionStack.IsEmpty())
            {
                ButtonBack.Enabled = false;
            }
            else
            {
                ButtonBack.Enabled = true;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowedClose)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (MessageBox.Show("Are you sure you would like to close? This is only reccomended if necessary!", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            ResetTimer();
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            ResetTimer();
        }

        private void ResetTimer()
        {
            idle.Stop();
            idle.Start();
        }

        private void Idle_Tick(object sender, EventArgs e)
        {
            LogOut();
            MessageBox.Show("User logged out due to inactivity");
        }

        private void LogOut()
        {
            idle.Dispose();
            allowedClose = true;
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form.GetType() == typeof(Form1))
                {
                    form.Show();
                }
                else
                {
                    form.Close();

                }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
