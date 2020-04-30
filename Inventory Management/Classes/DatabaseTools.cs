using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Inventory_Management.Classes;

namespace Inventory_Management
{
    static class DatabaseTools
    {
        static SqlConnection SqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\database.mdf\";Integrated Security=True");
        static SqlCommand cmd;
        static SqlDataReader reader;

        public static DataTable getReportData()
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable data = new DataTable();

            SqlConnection.Open();

            cmd = new SqlCommand("GetReportData", SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            reader = cmd.ExecuteReader();
            data.Load(reader);

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return data;
        }

        internal static void AddEmployee(int ID, string name, bool manager)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection.Open();

            cmd = new SqlCommand("AddEmployee", SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Manager", manager);

            cmd.ExecuteNonQuery();

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
        }

        internal static bool checkUserID(int ID)
        {
            bool result;
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection.Open();

            cmd = new SqlCommand("CheckID", SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.Add("@ReturnValue", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            result = Convert.ToBoolean(cmd.Parameters["@ReturnValue"].Value);

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return result;
        }

        public static int addSupplier(string name, string address, string postCode, DateTime endDate)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection.Open();

            cmd = new SqlCommand("AddJob", SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@PostCode", postCode);
            cmd.Parameters.AddWithValue("@End", endDate.Date);
            cmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            reader = cmd.ExecuteReader();
            int id = (int)cmd.Parameters["@returnValue"].Value;
            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return id;
        }

        public static void editItem(Item item, bool newSupplier, Supplier supplier = null)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection.Open();
            if (newSupplier)
            {
                cmd = new SqlCommand("AddSupplier", SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", supplier.Name);
                cmd.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmd.Parameters.AddWithValue("@Website", supplier.Website);
                cmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

                reader = cmd.ExecuteReader();
                item.SupplierID = (int)cmd.Parameters["@ReturnValue"].Value;
                reader.Close();
            }

            cmd = new SqlCommand("EditItem", SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemID", item.ItemID);
            cmd.Parameters.AddWithValue("@Description", item.ItemDescription);
            cmd.Parameters.AddWithValue("@Quantity", item.QuantityStored);
            cmd.Parameters.AddWithValue("@SupplierID", item.SupplierID);
            cmd.Parameters.AddWithValue("@Material", item.Material);
            cmd.Parameters.AddWithValue("@Location", item.Location);

            cmd.ExecuteNonQuery();

            addEdit(item.ItemID, 2);

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
        }

        internal static int AddOrder(string orderID, DateTime date, int jobID)
        {
            int ret;
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection.Open();

            cmd = new SqlCommand("EditItem", SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OrderID", orderID);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@JobID", jobID);
            cmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            ret = (int)cmd.Parameters["@ReturnValue"].Value;

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return ret;
        }

        private static void addEdit(int itemID, int type, int? quantity = null)
        {
            cmd = new SqlCommand("AddEdit", SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Employee",Main.userID);
            cmd.Parameters.AddWithValue("@Item",itemID);
            cmd.Parameters.AddWithValue("@Type",type);
            cmd.Parameters.AddWithValue("@Quantity",quantity);

            cmd.ExecuteNonQuery();
        }

        public static void updateQuantity(int ItemID, bool added, int amount, string orderID = null)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection.Open();

            if (orderID != null)
            {
                cmd = new SqlCommand("AddOrderItem", SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@ItemID", ItemID);
                cmd.Parameters.AddWithValue("@Quantity", amount);

                cmd.ExecuteNonQuery();
            }

            string op;

            switch (added)
            {
                case true:
                    op = "+";
                    break;
                case false:
                    op = "-";
                    break;
                default:
                    op = "";
                    break;
            }

            cmd = new SqlCommand("UPDATE dbo.Item SET Item.[Quantity Stored] " + op + "= "+amount.ToString()+"WHERE ItemID = @VALUE", SqlConnection);
            cmd.Parameters.AddWithValue("@VALUE", ItemID);

            cmd.ExecuteNonQuery();

            addEdit(ItemID, amount, added ? 1 : 0);

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
        }

        public static void addItem(Item item, bool newSupplier, Supplier supplier = null, string orderID = null)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection.Open();

            if (newSupplier)
            {
                cmd = new SqlCommand("AddSupplier",SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", supplier.Name);
                cmd.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmd.Parameters.AddWithValue("@Website", supplier.Website);
                cmd.Parameters.Add("@returnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();
                item.SupplierID = (int)cmd.Parameters["@returnValue"].Value;
            }

            cmd = new SqlCommand("AddItem", SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Description", item.ItemDescription);
            cmd.Parameters.AddWithValue("@Quantity", item.QuantityStored);
            cmd.Parameters.AddWithValue("@SupplierID", item.SupplierID);
            cmd.Parameters.AddWithValue("@Material", item.Material);
            cmd.Parameters.AddWithValue("@Location", item.Location);
            cmd.Parameters.AddWithValue("@Value", item.UnitValue);
            cmd.Parameters.AddWithValue("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            int ItemID = (int)cmd.Parameters["@ReturnValue"].Value;

            if (orderID != null)
            {
                cmd = new SqlCommand("AddOrderItem", SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@ItemID", ItemID);
                cmd.Parameters.AddWithValue("@Quantity", item.QuantityStored);

                cmd.ExecuteNonQuery();
            }

            addEdit(ItemID, 3, item.QuantityStored);

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
        }

        public static Item getItem(string itemID)
        {
            Cursor.Current = Cursors.WaitCursor;
            Item value = new Item();
            SqlConnection.Open();

            cmd = new SqlCommand("SELECT * FROM dbo.Item WHERE Item.ItemID = @VALUE",SqlConnection);
            cmd.Parameters.AddWithValue("@VALUE", itemID);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                value.ItemID = reader.GetInt32(0);
                value.ItemDescription = reader.GetString(1);
                value.QuantityStored = reader.GetInt32(2);
                value.SupplierID = reader.GetInt32(3);
                value.Material = reader.GetBoolean(4);
                if(!reader.IsDBNull(5))
                {
                    value.Location = reader.GetString(5);
                }
                else
                {
                    value.Location = "";
                }
            }

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return value;
        }

        public static DataTable GetAllValues(string value, string table)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable values = new DataTable();
            SqlConnection.Open();

            cmd = new SqlCommand("SELECT "+value+" FROM "+table, SqlConnection);
            
            reader = cmd.ExecuteReader();
            values.Load(reader);

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return values;
        }

        public static DataTable GetSearchRow(string SearchTerm)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable values = new DataTable();
            SqlConnection.Open();

            cmd = new SqlCommand("SELECT Item.ItemID, Item.[Item Description], Item.[Quantity Stored], Item.[Location], Supplier.[Supplier Name] FROM dbo.Item, dbo.Supplier WHERE Item.[Item Description] LIKE @VALUE AND Supplier.[SupplierID] = Item.[SupplierID]", SqlConnection);
            cmd.Parameters.AddWithValue("@VALUE","%"+SearchTerm+"%");

            reader = cmd.ExecuteReader();
            values.Load(reader);

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return values;
        }

        public static string GetValueFromKey(string table, string field, string key, string keyField)
        {
            Cursor.Current = Cursors.WaitCursor;
            string value;
            SqlConnection.Open();

            cmd = new SqlCommand("SELECT ["+field+"] FROM " + table + " WHERE ["+keyField+"] = @CODE", SqlConnection);
            cmd.Parameters.AddWithValue("@CODE", key);

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                value = reader[0].ToString();
            }
            else
            {
                value = "ERROR NO SUCH KEY";
            }

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return value;
        }


        public static bool IsInDatabase(string table, string field, string value)
        {
            Cursor.Current = Cursors.WaitCursor;
            bool inDatabase = false;
            SqlConnection.Open();

            cmd = new SqlCommand("SELECT * FROM " + table + " WHERE [" + field + "] = @CODE", SqlConnection);
            cmd.Parameters.AddWithValue("@CODE", value);

            reader = cmd.ExecuteReader();
            inDatabase = reader.HasRows;

            SqlConnection.Close();
            Cursor.Current = Cursors.Default;
            return inDatabase;
        }
    }
}
