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
using UniversalCarSaleSystem.Utilities;
using UniversalCarSaleSystem.Utilities.Lists;

namespace UniversalCarSaleSystem.Screens.CarStock
{
    public partial class CarStockForm : Template
    {
        public CarStockForm()
        {
            InitializeComponent();
        }

        private void CarStockForm_Load(object sender, EventArgs e)
        {
            
            CategoryComboBox.SelectedValueChanged -= new EventHandler(CategoryComboBox_SelectedValueChanged);
            LoadDataIntoComboBox();
            CategoryComboBox.SelectedValueChanged += new EventHandler(CategoryComboBox_SelectedValueChanged);
        }

        private void LoadDataIntoComboBox()
        {
            ListData.LoadDataIntoComboBoxes(CategoryComboBox, "usp_StockGetAllCarCategories");
        }

        private void LoadDataIntoListBox()
        {
            string cmd = "SELECT StockId AS 'Id',CarName AS 'Description' FROM Stock WHERE CarCategory=@CarCategory";
            ListData.LoadDataIntoListBox(CarStockListBox,cmd,false,new DbSQLSERVER.DbParameter { Parameter = "@CarCategory", Value = CategoryComboBox.Text });
        }

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CarStockListBox.SelectedValueChanged -= new EventHandler(CarStockListBox_SelectedValueChanged);
            LoadDataIntoListBox();
            CarStockListBox.SelectedValueChanged += new EventHandler(CarStockListBox_SelectedValueChanged);
        }

        private void CarStockListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadAndBindDataToControls();
        }

        private void LoadAndBindDataToControls()
        {
            try {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                string cmd = "SELECT * FROM Stock WHERE CarName=@CarName";
                DataTable dtStock = db.GetDataList(cmd, false, new DbParameter { Parameter = "@CarName", Value = CarStockListBox.Text });
                DataRow row = dtStock.Rows[0];

                CarNameLbl.Text = row["CarName"].ToString();
                CarPriceLbl.Text = row["CarPrice"].ToString();
                CarModelLbl.Text = row["CarModal"].ToString();
                CarCategoryLbl.Text = row["CarCategory"].ToString();
                CurrentStockLbl.Text = row["InStock"].ToString();
                CarPictureBox.Image = (row["CarImage"] is DBNull) ? null : ImageManipulations.PutPhoto((byte[])row["CarImage"]);


                db = null;
                dtStock = null;
                row = null;
            }
            catch(Exception)
            {
                MessageBox.Show("Please Select An Item");
            }

        }
    }
}
