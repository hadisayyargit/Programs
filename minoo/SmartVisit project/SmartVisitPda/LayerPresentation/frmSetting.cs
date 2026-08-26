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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void inputPanel1_EnabledChanged(object sender, EventArgs e)
        {
            panelMain.Height = inputPanel1.Enabled ? inputPanel1.VisibleDesktop.Height + 40 : this.Height;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PdaSetting objPdaSetting = new PdaSetting();

            bool bResult = true;

            //txtQuantity.Text=txtQuantity.Text.Replace("=","");
            if (txtSim.Text == "")
            {
                txtSim.Text = MainBusiness.GetUserPhone();
            }

            if (!GeneralClass.IsNumeric(txtLastSerial.Text))
            {
                bResult = false;
                MessageBox.Show("لطفا مقدار عددی وارد نمایید");
                txtLastSerial.Focus();
                return;
            }


            if (!GeneralClass.IsNumeric(txtLastSerialMarjoo.Text))
            {
                bResult = false;
                MessageBox.Show("لطفا مقدار عددی وارد نمایید");
                txtLastSerialMarjoo.Focus();
                return;
            } 
            
            try
            {
                objPdaSetting.LastSerial = Convert.ToDecimal(txtLastSerial.Text);
                objPdaSetting.LastSerialMarjoo = Convert.ToDecimal(txtLastSerialMarjoo.Text);
                objPdaSetting.ServerIP = txtIp.Text;
                objPdaSetting.SmsPhone = txtSMS.Text;
                objPdaSetting.Sim = txtSim.Text;
                objPdaSetting.dbInsert();
                MainCommon.m_ServerIp = objPdaSetting.ServerIP;
                MainCommon.m_SmsPhone = objPdaSetting.SmsPhone;
                MainCommon.m_Sim = objPdaSetting.Sim;

                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");
                this.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            PdaSetting objPdaSetting = new PdaSetting();
            objPdaSetting.FetchSetting();
            
            try
            {
                txtLastSerial.Text = objPdaSetting.LastSerial.ToString();
                txtLastSerialMarjoo.Text = objPdaSetting.LastSerialMarjoo.ToString();
                txtIp.Text = objPdaSetting.ServerIP;
                txtSMS.Text = objPdaSetting.SmsPhone;
                txtSim.Text = objPdaSetting.Sim;
            }
            catch
            {
            }
        }
    }
}