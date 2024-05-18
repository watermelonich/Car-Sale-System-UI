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
using UniversalCarSaleSystem.Models.Users;
using UniversalCarSaleSystem.Utilities;

namespace UniversalCarSaleSystem.Screens
{
    public partial class PasswordChangeForm : Template
    {
        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(IsValidate())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_LoginChangePassword", GetObject());

                MessageBox.Show("Password Has Been Changed Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }

        private User GetObject()
        {
            User user = new User();
            user.Password = NewPasswordTextBox.Text.Trim();

            return user;
            
        }

        private bool IsValidate()
        {
            if(NewPasswordTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please Enter New password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                NewPasswordTextBox.Clear();
                NewPasswordTextBox.Focus();
                return false;
            }
            if (ReEnterPasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Re-Enter New password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReEnterPasswordTextBox.Clear();
                ReEnterPasswordTextBox.Focus();
                return false;
            }

            if(NewPasswordTextBox.Text.Trim().ToLower() != ReEnterPasswordTextBox.Text.Trim().ToLower())
            {
                MessageBox.Show("New Password And Re-Enter password Not Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewPasswordTextBox.Clear();
                ReEnterPasswordTextBox.Clear();
                NewPasswordTextBox.Focus();
                return false;
            }

            return true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
