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
using UniversalCarSaleSystem.Models.Stock;
using UniversalCarSaleSystem.Utilities;
using UniversalCarSaleSystem.Utilities.Lists;
using UniversalCarSaleSystem.Utilities.SystemEnums;

namespace UniversalCarSaleSystem.Screens.CarStock
{
    public partial class AddNewCarForm : Template
    {
        public AddNewCarForm()
        {
            InitializeComponent();
        }
        public int Id { get; set; }
        private void AddNewCarForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoCategoryComboBox();
            if (this.IsUpdate)
            {
                //UpdateProcess
                LoadAndBindDataToControls();
            }
            else
            {
                //Other Process
            }


        }

        private void LoadAndBindDataToControls()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            DataTable dtStock = db.GetDataList("SELECT * FROM Stock WHERE StockId = @StockId", false, new DbParameter { Parameter = "@StockId", Value = this.Id });
            DataRow row = dtStock.Rows[0];

            CarNameTextBox.Text = row["CarName"].ToString();
            CategoryComboBox.Text = row["CarCategory"].ToString();
            CarModelTextBox.Text = row["CarModal"].ToString();
            CarPriceTextBox.Text = row["CarPrice"].ToString();
            CarColorTextBox.Text = row["Color"].ToString();
            CurrentStockTextBox.Text = row["InStock"].ToString();
            NewCarPictureBox.Image = (row["CarImage"] is DBNull) ? null : ImageManipulations.PutPhoto((byte[])row["CarImage"]);
            CommentsTextBox.Text = row["Comments"].ToString();


        }

        private void LoadDataIntoCategoryComboBox()
        {
            ListData.LoadDataIntoComboBoxes(CategoryComboBox, "usp_StockGetAllCarCategories");
        }

        private void CarNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelCarNameLabel.Text = CarNameTextBox.Text.Trim();
        }

        private void NewCarPictureBox_DoubleClick(object sender, EventArgs e)
        {
            AddPictureIntoPictureBox();
        }

        private void AddPictureIntoPictureBox()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.img;*.png;*.jpg;*.jpeg;*.bmp;*.gif) |*.img;*.png;*.jpg;*.jpeg;*.bmp;*.gif; |All Files (*.*) |*.*";
                ofd.InitialDirectory = "C:";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    NewCarPictureBox.Image = new Bitmap(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void AddPictureBoxButton_Click(object sender, EventArgs e)
        {
            AddPictureIntoPictureBox();
        }

        private void RemovePictureBoxButton_Click(object sender, EventArgs e)
        {
            NewCarPictureBox.Image=null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(IsFormOk())
            {
                if(this.IsUpdate)
                {
                    //Update
                    SaveOrUpdateRecord("usp_StockSaveOrUpdateStockDetails");
                    MessageBox.Show("Product Has Been Updated Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    //Save Process
                    SaveOrUpdateRecord("usp_StockSaveOrUpdateStockDetails");
                    MessageBox.Show("New Product Has Been Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void SaveOrUpdateRecord(string storedProceName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord(storedProceName, GetObject());
        }

        private ProductStock GetObject()
        {
            ProductStock stock = new ProductStock();
            stock.ProcessType = (this.IsUpdate) ? (int)ProcessType.Update : (int)ProcessType.Save;
            stock.StockId = (this.IsUpdate) ? this.Id : 0;
            stock.CarName = CarNameTextBox.Text.Trim();
            stock.CarModal =Convert.ToInt32(CarModelTextBox.Text.Trim());
            stock.CarPrice = CarPriceTextBox.Text.Trim();
            stock.CarCategory = CategoryComboBox.Text.ToString();
            stock.Color = CarColorTextBox.Text.Trim();
            stock.InStock =Convert.ToInt32(CurrentStockTextBox.Text);
            stock.CarImage = (NewCarPictureBox.Image == null) ? null : ImageManipulations.GetPhoto(NewCarPictureBox);
            stock.Comments = CommentsTextBox.Text.Trim();

            return stock;
        }

        private bool IsFormOk()
        {
           if(CarNameTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please Enter Car Name ..","Error");
                CarNameTextBox.Clear();
                CarNameTextBox.Focus();
                return false;
            }
           else
            {
                if(CarNameTextBox.Text.Length > 40)
                {
                    MessageBox.Show("Car Name maximum Should be 40 characters ..", "Error");
                    CarNameTextBox.SelectAll();
                    CarNameTextBox.Focus();
                    return false;
                }
            }
            if (CarModelTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Car Model ..", "Error");
                CarModelTextBox.Clear();
                CarModelTextBox.Focus();
                return false;
            }
            if (CarPriceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Car Price ..", "Error");
                CarPriceTextBox.Clear();
                CarPriceTextBox.Focus();
                return false;
            }
            else
            {
                    int a;
                    bool res = int.TryParse(CarPriceTextBox.Text.Trim(), out a);
                    if (!res)
                    {
                        MessageBox.Show("Car Price Should be numeric value like 12");
                    CarPriceTextBox.Clear();
                    CarPriceTextBox.Focus();
                        return false;
                    }
                if (CarPriceTextBox.Text.Length > 30)
                {
                    MessageBox.Show("Car Price maximum Should be 30 characters ..", "Error");
                    CarPriceTextBox.SelectAll();
                    CarPriceTextBox.Focus();
                    return false;
                }
            }
            if (CarColorTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Car Color ..", "Error");
                CarColorTextBox.Clear();
                CarColorTextBox.Focus();
                return false;
            }
            else
            {
                if (CarPriceTextBox.Text.Length > 20)
                {
                    MessageBox.Show("Car Color maximum Should be 20 characters ..", "Error");
                    CarColorTextBox.SelectAll();
                    CarColorTextBox.Focus();
                    return false;
                }
            }

            if (CurrentStockTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Car Stock ..", "Error");
                CurrentStockTextBox.Clear();
                CurrentStockTextBox.Focus();
                return false;
            }
            else
            {
                int a;
                bool res = int.TryParse(CurrentStockTextBox.Text.Trim(), out a);
                if(!res)
                {
                    MessageBox.Show("Stock Should be numeric value like 12");
                    CurrentStockTextBox.Clear();
                    CurrentStockTextBox.Focus();
                    return false;
                }
            }
            if (CategoryComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select Car Category ..", "Error");
                CategoryComboBox.Focus();
                return false;
            }


            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
