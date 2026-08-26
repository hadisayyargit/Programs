using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using layerBusiness;
using Common;

namespace layerPresentation
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirm.Text != txtNewPassword.Text)
                {
                    MessageBox.Show("تکرار رمز عبور اشتباه است");
                }
                else
                {
                    MainBusiness.ChangePassword(MainCommon.m_UserSN, txtNewPassword.Text);
                    MessageBox.Show("رمز عبور تغییر یافت");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}