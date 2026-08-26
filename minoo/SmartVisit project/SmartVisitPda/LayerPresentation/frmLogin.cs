using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GlobalUnit;
using layerBusiness;
using Common;

namespace layerPresentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool AutenticateUser()
        {
            bool bResult = true;

            if (txtUserid.Text == "" || !GeneralClass.IsNumeric(txtUserid.Text))
            {
                MessageBox.Show("کد کاربری را درست وارد نمایید");
                return false;                
            }

            /*
            if (txtPassword.Text == "")
            {
                MessageBox.Show("گذرواژه را وارد نمایید");
                return false;
            }
            */

            try
            {
                string strResult = MainBusiness.FetchVisitorInfo(Convert.ToInt32(txtUserid.Text), txtPassword.Text);

                if (strResult != "")
                {
                    MessageBox.Show(strResult);
                    bResult = false;
                }
            }
            catch
            {
                MessageBox.Show("کاربر نامعتبر است");
                bResult = false;
            }

            return bResult;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            try
            {
                MainBusiness.PrepareMainConnection();
                txtUserid.Text = MainBusiness.GetUserNo().ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("خطا در اتصال به بانک اطلاعات فشرده" + " " + myConnectionString);
            }

        }

        private void inputPanel1_EnabledChanged(object sender, EventArgs e)
        {
            panelMain.Height = inputPanel1.Enabled ? inputPanel1.VisibleDesktop.Height + 40 : this.Height;
        }

        private void frmLogin_GotFocus(object sender, EventArgs e)
        {
            inputPanel1.Enabled = false;
       }

        private void mniOk_Click(object sender, EventArgs e)
        {
            //Application.Run(new frmParent());


            if (AutenticateUser())
            {
                PdaSetting objPdaSetting = new PdaSetting();
                objPdaSetting.FetchSetting();

                try
                {
                    MainCommon.m_ServerIp = objPdaSetting.ServerIP;
                    MainCommon.m_SmsPhone = objPdaSetting.SmsPhone;
                    MainCommon.m_Sim = objPdaSetting.Sim;
                }
                catch
                {
                    MessageBox.Show("تنظيمات را دوباره انجام دهيد");
                }

                frmParent objForm = new frmParent();
                objForm.Show();
                this.Hide();
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}