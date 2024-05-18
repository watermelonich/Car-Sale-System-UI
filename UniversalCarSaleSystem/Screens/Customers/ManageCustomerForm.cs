using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalCarSaleSystem.Utilities.Lists;

namespace UniversalCarSaleSystem.Screens.Customers
{
    public partial class ManageCustomerForm : Template
    {
        public ManageCustomerForm()
        {
            InitializeComponent();
        }

        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();

        }

        private void LoadDataIntoDataGridView()
        {
            string cmd = "SELECT CustomerId,CustomerName,FatherName,CNIC,Address,Mobile,Comments FROM Customer";
            ListData.LoadDataIntoDataGridView(ManageCustomerDataGridView,cmd,false);
        }

        private void ManageCustomerDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int index = ManageCustomerDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int id =Convert.ToInt16(ManageCustomerDataGridView.Rows[index].Cells["CustomerId"].Value);

            ShowCustomerInfoForm(id,true);
        }

        private void ShowCustomerInfoForm(int id, bool isUpdate)
        {
            CustomerInfoForm customerInfoform = new CustomerInfoForm();
            customerInfoform.Id = id;
            customerInfoform.IsUpdate = isUpdate;
            customerInfoform.ShowDialog();

            LoadDataIntoDataGridView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCustomerInfoForm(0, false);
        }
    }
}
