using DbSQLSERVER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalCarSaleSystem.Screens.Orders;
using UniversalCarSaleSystem.Utilities;
using UniversalCarSaleSystem.Utilities.Lists;

namespace UniversalCarSaleSystem.Screens.Customers
{
    public partial class ManageCustomerHistoryForm : Template
    {
        public ManageCustomerHistoryForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageCustomerHistoryForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
           ListData.LoadDataIntoDataGridView(ManageCustomerHistoryDataGridView, "usp_OrderGetAllCustomerOrders");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Universal Car Sale System ","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void orderConfirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderInfoForm(0, false);
        }

        private void ShowOrderInfoForm(int id, bool isUpdate)
        {
            OrderInfoForm orderInfoForm = new OrderInfoForm();
            orderInfoForm.Id = id;
            orderInfoForm.IsUpdate = isUpdate;
            orderInfoForm.ShowDialog();

            LoadDataIntoDataGridView();
        }

        private void ManageCustomerHistoryDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int index = ManageCustomerHistoryDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int id =Convert.ToInt32(ManageCustomerHistoryDataGridView.Rows[index].Cells["OrderId"].Value);

            ShowOrderInfoForm(id, true); 
        }

        private void ManageCustomerHistoryDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hti = ManageCustomerHistoryDataGridView.HitTest(e.X, e.Y);
                    ManageCustomerHistoryDataGridView.Rows[hti.RowIndex].Selected = true;

                    contextMenuStrip1.Show(ManageCustomerHistoryDataGridView, e.X, e.Y);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Select An Order");
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = ManageCustomerHistoryDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int id = Convert.ToInt32(ManageCustomerHistoryDataGridView.Rows[index].Cells["OrderId"].Value);

            ShowOrderInfoForm(id, true);
        }

  
    }
}
