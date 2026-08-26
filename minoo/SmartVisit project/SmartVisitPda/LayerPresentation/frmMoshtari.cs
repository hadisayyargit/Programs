using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using layerBusiness;
using GlobalUnit;

namespace layerPresentation
{
    public partial class frmMoshtari : Form
    {        
        string m_strMoshtarino, m_strMoshtarids;
        decimal m_nMoshtariInfosn;
        decimal m_nMoshtariStatus;
        bool m_IsReport = false;

        public string MoshtariNo
        {
            get
            {
                return m_strMoshtarino;
            }
            set
            {
                m_strMoshtarino = value;
            }
        }

        public string MoshtariDs
        {
            get
            {
                return m_strMoshtarids;
            }
            set
            {
                m_strMoshtarids = value;
            }
        }
        public decimal MoshtariInfosn
        {
            get
            {
                return m_nMoshtariInfosn;
            }
            set
            {
                m_nMoshtariInfosn = value;
            }
        }

        void ShowInfo()
        {
            Customer objCustomer = new Customer();
            try
            {
                objCustomer.FetchMoshtariByMoshtariNo(m_strMoshtarino);

                txtMoshtarino.Text = m_strMoshtarino;
                txtMoshtarids.Text = objCustomer.Moshtarids;
                txtTel.Text = objCustomer.Tel;
                txtMobilephone.Text = objCustomer.MobilePhone;
                txtAddress.Text = objCustomer.Address;
                txtMandehEtebar.Text = objCustomer.MandehEtebar.ToString();
                txtMandehMoavagh.Text = objCustomer.MandehMoavagh.ToString();
                txtMandehAsnadi.Text = objCustomer.MandehAsnadi.ToString();
                txtMandehBargashti.Text = objCustomer.MandehBargashti.ToString();
                txtCountMoavagh.Text = objCustomer.CountMoavagh.ToString();
                txtCountBargashti.Text = objCustomer.CountBargashti.ToString();
                chkStatus.Checked = (objCustomer.MoshtariStatus == 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frmMoshtari()
        {
            InitializeComponent();
            m_strMoshtarino = "";
        }

        public frmMoshtari(string moshtarino)
        {
            m_strMoshtarino = moshtarino;

            InitializeComponent();
        }

        public frmMoshtari(bool IsReport)
        {
            InitializeComponent();
            m_strMoshtarino = "";
            m_IsReport = IsReport;
        }

        private void frmMoshtari_Load(object sender, EventArgs e)
        {
            panelMaster.Visible = (m_strMoshtarino=="");
            panelDetail.Visible = (m_strMoshtarino != "");
            this.WindowState = FormWindowState.Maximized;

            GeneralClass.m_PrgMod = GeneralClass.PrgMod.Normal;


            if (m_strMoshtarino == "")
            {
                GeneralClass.m_PrgMod = GeneralClass.PrgMod.BindingData;
                cboMasir.DataSource = Customer.GetAllMasir();
                GeneralClass.m_PrgMod = GeneralClass.PrgMod.Normal;

                cboMasir.ValueMember = "masirno";
                cboMasir.DisplayMember = "masirds";
                cboMasir.SelectedIndex = -1;
            }
            else
            {
                ShowInfo();
            }
        }

        private void cboMasir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GeneralClass.m_PrgMod != GeneralClass.PrgMod.BindingData)
            {
                //                GeneralClass.m_PrgMod = GeneralClass.PrgMod.BindingData;

                SqlCeResultSet objSqlceResultset = null;
                string strFilter = "";

                Customer objCustomer = new Customer();
                if (cboMasir.SelectedValue != null)
                {
                    if (cboMasir.Items.Count == 0 || cboMasir.SelectedValue.ToString() == "0")
                        strFilter = "";
                    else
                        strFilter = "masirno='" + cboMasir.SelectedValue.ToString()+"'";

                    objSqlceResultset = Customer.GetAllCustomer(strFilter);
                    if ((objSqlceResultset != null) && (objSqlceResultset.HasRows))
                        grdMoshtari.DataSource = objSqlceResultset;
                    else
                        grdMoshtari.DataSource = null;
                }
                else
                    grdMoshtari.DataSource = null;
            }
        }

        private void grdMoshtari_DoubleClick(object sender, EventArgs e)
        {
            if (grdMoshtari.CurrentRowIndex >= 0)
            {
                m_strMoshtarino = grdMoshtari[grdMoshtari.CurrentRowIndex, 0].ToString();
                m_strMoshtarids = grdMoshtari[grdMoshtari.CurrentRowIndex, 1].ToString();
                m_nMoshtariInfosn = Convert.ToDecimal(grdMoshtari[grdMoshtari.CurrentRowIndex, 2]);

                if (m_IsReport)
                {
                    panelMaster.Hide();
                    panelDetail.Show();
                    ShowInfo();
                }
                else
                {
                    this.Close();
                }
            }
            
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputPanel1_EnabledChanged(object sender, EventArgs e)
        {
            //panelMain.Height = inputPanel1.Enabled ? panelMain.Height - 180 : this.Height;
            panelMain.Height = inputPanel1.Enabled ? inputPanel1.VisibleDesktop.Height + 40 : this.Height;
        }

        private void mniClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMoshtari_GotFocus(object sender, EventArgs e)
        {
            inputPanel1.Enabled = false;
        }


   

      
    }
}