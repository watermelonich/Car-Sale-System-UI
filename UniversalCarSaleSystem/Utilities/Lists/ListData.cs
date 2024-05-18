using DbSQLSERVER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversalCarSaleSystem.Utilities.Lists
{
   public class ListData
    {
        public static void LoadDataIntoDataGridView(DataGridView dgv,string storedProce)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            dgv.DataSource = dbSqlServer.GetDataList(storedProce,true);
             dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.MultiSelect = false;

        }

        public static void LoadDataIntoDataGridView(DataGridView dgv, string storedProce,DbParameter para)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            dgv.DataSource = dbSqlServer.GetDataList(storedProce, new DbParameter { Parameter = para.Parameter, Value = para.Value });
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.MultiSelect = false;

        }

        public static void LoadDataIntoDataGridView(DataGridView dgv, string cmdText,bool IsStoredProce)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            dgv.DataSource= dbSqlServer.GetDataList(cmdText,IsStoredProce);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.MultiSelect = false;
        }
        public static void LoadDataIntoComboBoxes(ComboBox cbx,DbParameter para)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            cbx.DataSource = dbSqlServer.GetDataList("usp_ListTypeDataGetDataByListTypeDataId",para);
            cbx.DisplayMember = "Description";
            cbx.ValueMember = "Id";

            cbx.SelectedIndex = -1;
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static void LoadDataIntoComboBoxes(ComboBox cbx,string StoredProceName, DbParameter para)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            cbx.DataSource = dbSqlServer.GetDataList(StoredProceName, para);
            cbx.DisplayMember = "Description";
            cbx.ValueMember = "Id";

            cbx.SelectedIndex = -1;
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void LoadDataIntoComboBoxes(ComboBox cbx, string StoredProceName, DbParameter[] parameters)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            cbx.DataSource = dbSqlServer.GetDataList(StoredProceName, parameters);
            cbx.DisplayMember = "Description";
            cbx.ValueMember = "Id";

            cbx.SelectedIndex = -1;
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static void LoadDataIntoComboBoxes(ComboBox cbx, string StoredProceName)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            cbx.DataSource = dbSqlServer.GetDataList(StoredProceName,true);
            cbx.DisplayMember = "Description";
            //cbx.ValueMember = "Id";

            cbx.SelectedIndex = -1;
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void LoadDataIntoComboBoxes(ComboBox cbx, string cmd,bool isStoredProce)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            cbx.DataSource = dbSqlServer.GetDataList(cmd, false);
            cbx.DisplayMember = "Description";
            //cbx.ValueMember = "Id";

            cbx.SelectedIndex = -1;
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void LoadDataIntoComboBoxes(ComboBox cbx, string cmd, bool isStoredProce,DbParameter para)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            cbx.DataSource = dbSqlServer.GetDataList(cmd, false,para);
            cbx.DisplayMember = "Description";
            //cbx.ValueMember = "Id";

            cbx.SelectedIndex = -1;
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void LoadDataIntoListBox(ListBox Lbx, string proceName,bool IsStoredProce,DbParameter para)
        {
            DbSQLServer dbSqlServer = new DbSQLServer(AppSetting.ConnectionString());
            Lbx.DataSource = dbSqlServer.GetDataList(proceName, IsStoredProce,para);
            Lbx.DisplayMember = "Description";
            Lbx.ValueMember = "Id";

            Lbx.SelectedIndex = -1;
        }
    }
}
