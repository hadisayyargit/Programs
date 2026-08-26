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
    public partial class frmDetail : Form
    {

        decimal m_nDarkhastSN = 0, m_nDarkhastMarjooSN=0;
        bool m_IsOrder;
        int m_KalaGridRow = -1, m_KalaListRow=-1;
        bool m_ModifyFlag = false;

        enum KalaGridColumns
        {
            colKalasn_Ordinal = 0
            ,colForooshcode_Ordinal = 1
            ,colKalads_Ordinal = 2
            ,colMojoodi_Ordinal = 3
            , colTaminKonandehDs_Ordinal = 4
            , colMinDarkhast_Ordinal = 5
            , colNerkheForoosh_Ordinal = 6
            , colNerkhemasraf_Ordinal = 7
            , colVahedeSanjeshds_Ordinal = 8
            , colKalaStatus_Ordinal = 9
        }

        enum KalaListColumns
        {
            colKalasn_Ordinal = 0
            ,colForooshcode_Ordinal = 1
            ,colKalads_Ordinal = 2            
            ,colQuantity_Ordinal = 3
            ,colNerkheForoosh_Ordinal = 4
            ,colMablagh_Ordinal = 5
        }

        public frmDetail()
        {
            InitializeComponent();
        }

        public frmDetail(decimal nDarkhastsn, bool IsOrder)
        {
            InitializeComponent();
            m_IsOrder = IsOrder;

            if(IsOrder)
                m_nDarkhastSN = nDarkhastsn;
            else
                m_nDarkhastMarjooSN = nDarkhastsn;
        }

        void HandleUpdate()
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();

            Darkhast objDarkhast = new Darkhast();
            Darkhastha objDarkhastha = new Darkhastha();
            try
            {
                if (m_IsOrder)
                {
                    objDarkhast.Darkhastsn = m_nDarkhastSN;
                    objDarkhast.dbDeleteDetails();
                }
                else
                {
                    objDarkhast.Darkhastsn = m_nDarkhastMarjooSN;
                    objDarkhast.dbDeleteDetailsMarjoo();
                }
                for (int i = 0; i < listViewDetails.Items.Count; i++)
                {
                    objDarkhastha = new Darkhastha();
                    objDarkhastha.Kalasn = Convert.ToDecimal(listViewDetails.Items[i].SubItems[(int)KalaListColumns.colKalasn_Ordinal].Text);
                    objDarkhastha.Darkhastsn = objDarkhast.Darkhastsn;
                    objDarkhastha.Tedad = Convert.ToInt32(listViewDetails.Items[i].SubItems[(int)KalaListColumns.colQuantity_Ordinal].Text);

                    if (m_IsOrder)
                        objDarkhastha.dbInsert();
                    else
                        objDarkhastha.dbInsertMarjoo();
                }

                BindDetail();
                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor.Current = Cursors.Default;
            Cursor.Hide();

        }

        int GetDetailListRow(int nForooshcode)
        {
            int nRes = -1;

            for (int i = 0; i < listViewDetails.Items.Count; i++)
            {
                if (listViewDetails.Items[i].SubItems[(int) KalaListColumns.colForooshcode_Ordinal].Text == nForooshcode.ToString())
                {
                    nRes = i;
                    break;
                }
            }

            return nRes;
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

        private void ClearDetailBoxes()
        {
            txtKalads.Text = "";
            txtForooshcode.Text = "";
            txtQuantity.Text = "";
            txtMojoodi.Text = "";
            txtMinDarkhast.Text = "";
            //lbSum.Text = "0";
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

        private void HandleKalaList()
        {

            if (GeneralClass.IsNumeric(txtForooshcode.Text))
            {
                int nForooshcode = int.Parse(txtForooshcode.Text);

                m_KalaListRow = GetDetailListRow(nForooshcode);
                m_KalaGridRow = GetKalaGridRow(nForooshcode);

                if (m_KalaListRow != -1)
                {
                    txtKalasn.Text = listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colKalasn_Ordinal].Text;
                    txtKalads.Text = listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colKalads_Ordinal].Text;
                    txtQuantity.Text = listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colQuantity_Ordinal].Text;
                    txtMojoodi.Text = grdKala[m_KalaGridRow, (int)KalaGridColumns.colMojoodi_Ordinal].ToString();
                    txtMinDarkhast.Text = grdKala[m_KalaGridRow, (int)KalaGridColumns.colMinDarkhast_Ordinal].ToString();
                    txtQuantity.Focus();
                }
                else
                {
                    if (m_KalaGridRow > -1)
                    {
                        //txtForooshcode.Text = grdKala[nRow, (int)KalaGridColumns.colForooshcode_Ordinal].ToString();
                        txtKalads.Text = grdKala[m_KalaGridRow, (int)KalaGridColumns.colKalads_Ordinal].ToString();
                        txtKalasn.Text = grdKala[m_KalaGridRow, (int)KalaGridColumns.colKalasn_Ordinal].ToString();
                        txtMojoodi.Text = grdKala[m_KalaGridRow, (int)KalaGridColumns.colMojoodi_Ordinal].ToString();
                        txtMinDarkhast.Text = grdKala[m_KalaGridRow, (int)KalaGridColumns.colMinDarkhast_Ordinal].ToString();
                        txtQuantity.Text = "";
                        txtQuantity.Focus();
                    }
                    else
                    {
                        ClearDetailBoxes();
                        txtForooshcode.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("کد فروش نامعتبر است");
                ClearDetailBoxes();
                txtForooshcode.Focus();
            }

        }

        private void HandleAddToList()
        {
            m_ModifyFlag = true;

            if (IsValidateDetail())
            {
                
                //grdDetail[0, (int)DetailColumns.colKalads_Ordinal] = "mm";
                int nForooshcode = int.Parse(txtForooshcode.Text);
                long nSum = 0;

                try
                {
                    nSum = long.Parse(lbSum.Text.Replace(",", ""));
                }
                catch
                {
                }

                long nOldMablagh = 0;

                if (m_KalaListRow != -1)
                {
                    if (txtQuantity.Text == "0")
                    {
                        nOldMablagh = long.Parse(listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colMablagh_Ordinal].Text);
                        nSum -= nOldMablagh;
                        listViewDetails.Items.RemoveAt(m_KalaListRow);
                    }
                    else
                    {
                        if (CheckKalaValidation())
                        {
                            nOldMablagh = long.Parse(listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colMablagh_Ordinal].Text);
                            string strNerkh = listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colNerkheForoosh_Ordinal].Text;
                            string strMablagh = (Convert.ToInt32(strNerkh) * Convert.ToInt32(txtQuantity.Text)).ToString();

                            listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colQuantity_Ordinal].Text = txtQuantity.Text;
                            listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colMablagh_Ordinal].Text = strMablagh;
                            nSum += long.Parse(listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colMablagh_Ordinal].Text) - nOldMablagh;
                        }
                    }
                }
                else
                {
                    if (txtQuantity.Text != "0")
                    {
                        if (CheckKalaValidation())
                        {
                            string strNerkh = grdKala[m_KalaGridRow, (int)KalaGridColumns.colNerkheForoosh_Ordinal].ToString();
                            string strMablagh = (Convert.ToInt32(strNerkh) * Convert.ToInt32(txtQuantity.Text)).ToString();
                            ListViewItem li = new ListViewItem(new string[] { txtKalasn.Text, txtForooshcode.Text, txtKalads.Text, txtQuantity.Text, strNerkh, strMablagh });
                            listViewDetails.Items.Add(li);
                            nSum += long.Parse(strMablagh);
                        }
                        else
                            return;
                    }
                }
                lbSum.Text = nSum.ToString("###,###");

                //SqlCeUpdatableRecord rec = objSqlceResultset.CreateRecord();

                //objSqlceResultset.Insert(rec);

                /*
                 SqlCeResultSet rs = cmd.ExecuteResultSet(ResultSetOptions.Updatable |

                ResultSetOptions.Scrollable);

                rec.SetInt32(0, 34);

                rec.SetDecimal(1, (decimal)44.66);

                rec.SetString(2, "Sample text 1");

                 */

                ClearDetailBoxes();
                txtForooshcode.Focus();
            }
        }

        bool IsValidateDetail()
        {
            bool bResult = true;

            //txtQuantity.Text=txtQuantity.Text.Replace("=","");

            if (!GeneralClass.IsNumeric(txtForooshcode.Text))
            {
                bResult = false;
                MessageBox.Show("لطفا مقدار عددی وارد نمایید");
                txtForooshcode.Focus();
                return bResult;
            }

            if (!GeneralClass.IsNumeric(txtQuantity.Text) || int.Parse(txtQuantity.Text)<0)
            {
                bResult = false;
                MessageBox.Show("لطفا مقدار عددی درست وارد نمایید");
                txtQuantity.Focus();
                return bResult;
            }

            if (txtKalads.Text == "")
            {
                bResult = false;
                MessageBox.Show("لطفا نام کالا وارد نمایید");
                txtForooshcode.Focus();
                return bResult;
            }

            return bResult;
        }

        bool CheckKalaValidation()
        {
            bool bResult = true;
            int nMojoodi = Convert.ToInt32(grdKala[m_KalaGridRow, (int)KalaGridColumns.colMojoodi_Ordinal]);
            int nMinDarkhast = Convert.ToInt32(grdKala[m_KalaGridRow, (int)KalaGridColumns.colMinDarkhast_Ordinal]);
            byte nKalaStatus = Convert.ToByte(grdKala[m_KalaGridRow, (int)KalaGridColumns.colKalaStatus_Ordinal]);

            int nTedad = int.Parse(txtQuantity.Text);

            if (m_IsOrder && nKalaStatus == 0)
            {
                MessageBox.Show("این کالا بلوکه است");                
                ///فقط هشدار دهنده
                bResult = true;

            }

            if (m_IsOrder && nTedad > nMojoodi)
            {
                MessageBox.Show("مقدار وارد شده بیشتر از میزان موجودی است. میزان موجودی = "+nMojoodi.ToString());

                ///فقط هشدار دهنده
                bResult = true;

            }

            if (m_IsOrder && (nTedad < nMinDarkhast || nTedad % nMinDarkhast != 0))
            {

                MessageBox.Show("مقدار وارد شده باید بزرگتر و بصورت مضربی از حداقل درخواست باشد. حداقل درخواست = " + nMinDarkhast.ToString());

                txtQuantity.Focus();
                ///باز دارنده
                bResult = false;
            }


            return bResult;
        }

        private void BindDetail()
        {
            SqlCeResultSet objSqlceResultset = null;

            try
            {
                if (m_IsOrder)
                    objSqlceResultset = Darkhastha.GetDarkhastha(m_nDarkhastSN);
                else
                    objSqlceResultset = Darkhastha.GetDarkhastMarjooha(m_nDarkhastMarjooSN);

                string strKalasn, strKalads, strForooshcode, strTedad, strNerkh, strMablagh;
                long nSum = 0;

                try
                {
                    listViewDetails.Items.Clear();

                    while (objSqlceResultset.Read())
                    {

                        strKalasn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("kalasn")).ToString();
                        strKalads = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("kalads"));
                        strForooshcode = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("forooshcode")).ToString();
                        strTedad = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("tedad")).ToString();
                        strNerkh = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("nerkheforoosh")).ToString();
                        strMablagh = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mablagh")).ToString();
                        nSum += long.Parse(strMablagh);

                        ListViewItem li = new ListViewItem(new string[] { strKalasn, strForooshcode, strKalads, strTedad,strNerkh,strMablagh });
                        listViewDetails.Items.Add(li);

                    }

                    lbSum.Text = nSum.ToString("###,###");
                    lbCount.Text = listViewDetails.Items.Count.ToString();

                    m_ModifyFlag = false;
                }
                catch(Exception ex)
                {
                }
            }

            catch (Exception ex)
            {

            }

        }

        private void ShowImage(string strPath)
        {
            //picKalaImage.Image=
        }

        private void mniDeleteRow_Click(object sender, EventArgs e)
        {
            if (listViewDetails.Items.Count > 0)
            {
                m_ModifyFlag = true;
                long nSum = long.Parse(lbSum.Text.Replace(",", ""));
                long nOldMablagh = 0;

                //listViewDetails.Items.RemoveAt(listViewDetails.SelectedIndices[0]);
                nOldMablagh = long.Parse(listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colMablagh_Ordinal].Text);
                nSum -= nOldMablagh;
                listViewDetails.Items.RemoveAt(m_KalaListRow);
                lbSum.Text = nSum.ToString("###,###");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HandleAddToList();

        }

        private void grdKala_DoubleClick(object sender, EventArgs e)
        {
            txtForooshcode.Text = grdKala[grdKala.CurrentRowIndex, (int)KalaGridColumns.colForooshcode_Ordinal].ToString();
            m_KalaListRow = GetDetailListRow(int.Parse(txtForooshcode.Text));

            if (m_KalaListRow > -1)
                txtQuantity.Text = listViewDetails.Items[m_KalaListRow].SubItems[(int)KalaListColumns.colQuantity_Ordinal].Text;
            else
                txtQuantity.Text = "";

            txtKalads.Text = grdKala[grdKala.CurrentRowIndex, (int)KalaGridColumns.colKalads_Ordinal].ToString();
            
            txtKalasn.Text = grdKala[grdKala.CurrentRowIndex, (int)KalaGridColumns.colKalasn_Ordinal].ToString();
            txtMojoodi.Text = grdKala[grdKala.CurrentRowIndex, (int)KalaGridColumns.colMojoodi_Ordinal].ToString();
            txtMinDarkhast.Text = grdKala[grdKala.CurrentRowIndex, (int)KalaGridColumns.colMinDarkhast_Ordinal].ToString();

            m_KalaGridRow = grdKala.CurrentRowIndex;
            


            txtQuantity.Focus();
        }

        private void frmKala_Load(object sender, EventArgs e)
        {
            FillKalaGrid();

            BindDetail();

            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();

            Darkhast objDarkhast = new Darkhast();
            Darkhastha objDarkhastha = new Darkhastha();
            try
            {
                if (m_IsOrder)
                {
                    objDarkhast.Darkhastsn = m_nDarkhastSN;
                    objDarkhast.dbDeleteDetails();
                }
                else
                {
                    objDarkhast.Darkhastsn = m_nDarkhastMarjooSN;
                    objDarkhast.dbDeleteDetailsMarjoo();
                }
                for (int i = 0; i < listViewDetails.Items.Count; i++)
                {
                    objDarkhastha = new Darkhastha();
                    objDarkhastha.Kalasn = Convert.ToDecimal(listViewDetails.Items[i].SubItems[(int)KalaListColumns.colKalasn_Ordinal].Text);
                    objDarkhastha.Darkhastsn = objDarkhast.Darkhastsn;
                    objDarkhastha.Tedad = Convert.ToInt32(listViewDetails.Items[i].SubItems[(int)KalaListColumns.colQuantity_Ordinal].Text);
                    
                    if (m_IsOrder)
                        objDarkhastha.dbInsert();
                    else
                        objDarkhastha.dbInsertMarjoo();
                }

                BindDetail();
                MessageBox.Show("اطلاعات با موفقیت بروزرسانی شد");                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor.Current = Cursors.Default;
            Cursor.Hide();

        }

        private void listViewKala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDetails.SelectedIndices.Count != 0)
            {
                txtForooshcode.Text = listViewDetails.Items[listViewDetails.SelectedIndices[0]].SubItems[(int)KalaListColumns.colForooshcode_Ordinal].Text;
                txtKalads.Text = listViewDetails.Items[listViewDetails.SelectedIndices[0]].SubItems[(int)KalaListColumns.colKalads_Ordinal].Text;
                txtKalasn.Text = listViewDetails.Items[listViewDetails.SelectedIndices[0]].SubItems[(int)KalaListColumns.colKalasn_Ordinal].Text;
                txtQuantity.Text = listViewDetails.Items[listViewDetails.SelectedIndices[0]].SubItems[(int)KalaListColumns.colQuantity_Ordinal].Text;                

                m_KalaListRow = listViewDetails.SelectedIndices[0];
                m_KalaGridRow = GetKalaGridRow(int.Parse(txtForooshcode.Text));
                txtMojoodi.Text = grdKala[m_KalaGridRow, (int)KalaGridColumns.colMojoodi_Ordinal].ToString();
                txtMinDarkhast.Text = grdKala[m_KalaGridRow, (int)KalaGridColumns.colMinDarkhast_Ordinal].ToString();
            }
        }


        private void txtForooshcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar=='=')
            {
                
                ///پس دادن کرکتر
                e.Handled = true;
                HandleKalaList();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar=='=')
            {
                ///پس دادن کرکتر
                e.Handled = true;
                HandleAddToList();
            }
        }

        private void listViewKala_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void inputPanel1_EnabledChanged(object sender, EventArgs e)
        {
            panelMain.Height = inputPanel1.Enabled ? inputPanel1.VisibleDesktop.Height+40 : this.Height;
        }

        private void frmKala_GotFocus(object sender, EventArgs e)
        {
            //inputPanel1.Enabled = false;
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

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

            if (e.Button == tbtnDetail)
            {
                panelDetail.Show();
                panelKala.Hide();
            }
            else if (e.Button == tbtnKala)
            {
                panelDetail.Hide();
                panelKala.Show();
            }
            else if (e.Button == tbtnOk)
            {
                HandleUpdate();
            }
            else if (e.Button == tbtnClose)
            {
                if(m_ModifyFlag)
                    HandleUpdate();

                this.Close();
            }

        }
        
      
      
    }
}