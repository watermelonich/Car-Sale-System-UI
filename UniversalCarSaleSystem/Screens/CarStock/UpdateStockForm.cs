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

namespace UniversalCarSaleSystem.Screens.CarStock
{
    public partial class UpdateStockForm : Template
    {
        public UpdateStockForm()
        {
            InitializeComponent();
        }

        private void UpdateStockForm_Load(object sender, EventArgs e)
        {
            //This Method Will Load All Car Stock in this DataGridView
            LoadDataIntoUpdatStockeDataGridView();

        }

        private void LoadDataIntoUpdatStockeDataGridView()
        {
            ListData.LoadDataIntoDataGridView(UpdateStockDataGridView, "usp_StockGetAllStockDetails");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddNewCarForm(0, false);
        }

        private void ShowAddNewCarForm(int id, bool isUpdate)
        {
            AddNewCarForm addNewCarForm = new AddNewCarForm();
            addNewCarForm.Id = id;
            addNewCarForm.IsUpdate = isUpdate;
            addNewCarForm.ShowDialog();


            LoadDataIntoUpdatStockeDataGridView();
        }

        private void UpdateStockDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int index = UpdateStockDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int id =Convert.ToInt32(UpdateStockDataGridView.Rows[index].Cells["StockId"].Value);

            ShowAddNewCarForm(id, true);
        }
    }
}
