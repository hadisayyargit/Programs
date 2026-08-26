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
    public partial class frmKala : Form
    {
        int m_KalaGridRow = -1;

        public frmKala()
        {
            InitializeComponent();
        }

        enum KalaGridColumns
        {
            colKalasn_Ordinal = 0
            ,
            colForooshcode_Ordinal = 1
                ,
            colKalads_Ordinal = 2
                ,
            colMojoodi_Ordinal = 3
                ,
            colTaminKonandehDs_Ordinal = 4
                ,
            colMinDarkhast_Ordinal = 5
                ,
            colNerkheForoosh_Ordinal = 6
                ,
            colNerkhemasraf_Ordinal = 7
                ,
            colVahedeSanjeshds_Ordinal = 8
                , colKalaStatus_Ordinal = 9
        }

        int GetKalaGridRow(int nForooshcode)
        {
            int nRes = -1;
            int i = 0;

            try
            {
                while (grdKala[i, (int)KalaGridColumns.colForooshcode_Ordinal] != null)
                {
                    if (grdKala[i, (int)KalaGridColumns.colForooshcode_Ordinal].ToString() == nForooshcode.ToString())
                    {
                        nRes = i;
                        break;
                    }
                    i++;
                }
            }
            catch
            {
            }

            return nRes;
        }

        int GetKalaGridRow(string strKalads, int nCurrentIndex)
        {
            int nRes = -1;
            int i = nCurrentIndex + 1;

            try
            {
                while (grdKala[i, (int)KalaGridColumns.colKalads_Ordinal] != null)
                {
                    if (grdKala[i, (int)KalaGridColumns.colKalads_Ordinal].ToString().Contains(strKalads))
                    {
                        nRes = i;
                        break;
                    }
                    i++;
                }
            }
            catch
            {
            }

            return nRes;
        }

        public void FillKalaGrid()
        {
            try
            {
                ///روش سریعتر
                DataTable dt1 = new DataTable();

                SqlCeDataReader dr1 = Kala.GetAllKalaReader();
                dt1.Load(dr1);
                grdKala.DataSource = dt1;

                /*
                SqlCeResultSet objSqlceResultset = null;
                objSqlceResultset = Kala.GetAllKala();
                if ((objSqlceResultset != null) && (objSqlceResultset.HasRows))
                {
                    grdKala.DataSource = objSqlceResultset;                    
                }
                 */


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmKala_Load(object sender, EventArgs e)
        {
            FillKalaGrid();

            this.WindowState = FormWindowState.Maximized;
        }

        private void inputPanel1_EnabledChanged(object sender, EventArgs e)
        {
            panelMain.Height = inputPanel1.Enabled ? inputPanel1.VisibleDesktop.Height +40 : this.Height;
        }

        private void ibtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKey1.Text != "" && GeneralClass.IsNumeric(txtKey1.Text))
                {
                    int nForooshcode = int.Parse(txtKey1.Text);
                    m_KalaGridRow = GetKalaGridRow(nForooshcode);
                    if (m_KalaGridRow != -1)
                        grdKala.CurrentRowIndex = m_KalaGridRow;

                    return;
                }

                if (txtKey2.Text != "")
                {

                    m_KalaGridRow = GetKalaGridRow(txtKey2.Text, grdKala.CurrentRowIndex);
                    if (m_KalaGridRow != -1)
                        grdKala.CurrentRowIndex = m_KalaGridRow;

                }
            }

            catch
            {
            }

        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}