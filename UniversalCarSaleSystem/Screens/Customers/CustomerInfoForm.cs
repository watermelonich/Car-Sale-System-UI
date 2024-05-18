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
using UniversalCarSaleSystem.Models.Customers;
using UniversalCarSaleSystem.Utilities;
using UniversalCarSaleSystem.Utilities.SystemEnums;

namespace UniversalCarSaleSystem.Screens.Customers
{
    public partial class CustomerInfoForm : Template
    {
        public CustomerInfoForm()
        {
            InitializeComponent();
        }
        public int Id { get; set; }

        private void CustomerInfoForm_Load(object sender, EventArgs e)
        {
            if(this.IsUpdate)
            {
                LoadAndBindDataToControls();

            }
        }

        private void LoadAndBindDataToControls()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            DataTable dtCustomer = db.GetDataList("SELECT * FROM Customer WHERE CustomerId=@CustomerId", false, new DbParameter { Parameter = "@CustomerId", Value = this.Id });
            DataRow row = dtCustomer.Rows[0];

            CustomerNameTextBox.Text = row["CustomerName"].ToString();
            FatherNameTextBox.Text = row["FatherName"].ToString();
            NICTextBox.Text = row["CNIC"].ToString();
            AddressTextBox.Text = row["Address"].ToString();
            MobileTextBox.Text = row["Mobile"].ToString();
            CustomerPictureBox.Image = (row["CustomerImage"] is DBNull) ? null : ImageManipulations.PutPhoto((byte[])row["CustomerImage"]);
            CommentsTextBox.Text = row["Comments"].ToString();
                    

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            CustomerNameTextBox.Clear();
            FatherNameTextBox.Clear();
            NICTextBox.Clear();
            MobileTextBox.Clear();
            AddressTextBox.Clear();
            CustomerPictureBox.Image = null;
            CommentsTextBox.Clear();

            CustomerNameTextBox.Focus();
        }

        private void ClearCustomerPictureBoxButton_Click(object sender, EventArgs e)
        {
            CustomerPictureBox.Image = null;
        }

        private void ChooseCustomerPictureButton_Click(object sender, EventArgs e)
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
                    CustomerPictureBox.Image = new Bitmap(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CustomerPictureBox_DoubleClick(object sender, EventArgs e)
        {
            AddPictureIntoPictureBox();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(IsValidate())
            {
                if(this.IsUpdate)
                {
                    //Update
                    SaveOrUpdateCustomerRecord("usp_CustomerSaveOrUpdateCustomerRecord");
                    MessageBox.Show("Record Has Been Updated Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    //Save
                    SaveOrUpdateCustomerRecord("usp_CustomerSaveOrUpdateCustomerRecord");
                    MessageBox.Show("New Record Has Been Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void SaveOrUpdateCustomerRecord(string storedProce)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord(storedProce, GetObject());
        }

        private Customer GetObject()
        {
            Customer customer = new Customer();
            customer.ProcessType = (this.IsUpdate) ? (int)ProcessType.Update : (int)ProcessType.Save;
            customer.Id = (this.IsUpdate) ? this.Id : 0;
            customer.CustomerName = CustomerNameTextBox.Text.Trim();
            customer.FatherName = FatherNameTextBox.Text.Trim();
            customer.CNIC = NICTextBox.Text.Trim();
            customer.Mobile = MobileTextBox.Text.Trim();
            customer.Address = AddressTextBox.Text.Trim();

            customer.CustomerImage = (CustomerPictureBox.Image == null) ? null : ImageManipulations.GetPhoto(CustomerPictureBox);
            customer.Comments = CommentsTextBox.Text.Trim();


            return customer;
        }

        private bool IsValidate()
        {
            if(CustomerNameTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Customer Name Is Required","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                CustomerNameTextBox.Clear();
                CustomerNameTextBox.Focus();
                return false;
            }
            if (CustomerNameTextBox.Text.Length > 30)
            {
                MessageBox.Show("Customer Name should  be less than 30 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerNameTextBox.Clear();
                CustomerNameTextBox.Focus();
                return false;
            }

            if (FatherNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Father Name Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FatherNameTextBox.Clear();
                FatherNameTextBox.Focus();
                return false;
            }
            if (FatherNameTextBox.Text.Length > 30)
            {
                MessageBox.Show("Father Name should  be less than 30 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FatherNameTextBox.Clear();
                FatherNameTextBox.Focus();
                return false;
            }
            if (NICTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("NIC Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NICTextBox.Clear();
                NICTextBox.Focus();
                return false;
            }
            else
            {
                if (NICTextBox.Text.Length != 13)
                {
                    MessageBox.Show("NICT must be equal to 13 Characters without Dashes Like 3120312345678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NICTextBox.Clear();
                    NICTextBox.Focus();
                    return false;
                }
                else
                {
                    long i;
                    bool res=long.TryParse(NICTextBox.Text.Trim(), out i);
                    if(!res)
                    {
                        MessageBox.Show("NICT Should be Numeric Value Like 3120312345678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NICTextBox.Clear();
                        NICTextBox.Focus();
                        return false;

                    }
                }

            }

            if (MobileTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mobile Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MobileTextBox.Clear();
                MobileTextBox.Focus();
                return false;
            }
            else
            {
                if (MobileTextBox.Text.Length != 11)
                {
                    MessageBox.Show("Mobile Number must be equal to 11 Characters without Dashes Like 03001234567", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MobileTextBox.Clear();
                    MobileTextBox.Focus();
                    return false;
                }
                else
                {
                    long i;
                    bool res = long.TryParse(MobileTextBox.Text.Trim(), out i);
                    if (!res)
                    {
                        MessageBox.Show("NICT Should be Numeric Value Like 3120312345678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MobileTextBox.Clear();
                        MobileTextBox.Focus();
                        return false;

                    }
                }

            }
            return true;  
        }
    }


}
