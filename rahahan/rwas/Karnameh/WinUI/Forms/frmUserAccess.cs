using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RWAS.BusinessRules;
using RWAS.Common;
using System.IO;
using System.Reflection;

namespace RWAS.WinUI
{
    public partial class frmUserAccess : Form
    {
        bool m_bFormLoading;

        DataView m_dvAccessRight = new DataView();
        DataView m_dvApplicationObject = new DataView();

        public frmUserAccess()
        {
            InitializeComponent();
        }

        private void ShowMaster()
        {
            m_bFormLoading = true;
            try
            {
                if (chkSelectUser.Checked)
                {
                    if (cboUserGroup.SelectedValue != null && cboUser.SelectedValue != null)
                        m_dvAccessRight.RowFilter = "GroupId=" + cboUserGroup.SelectedValue.ToString() + " AND UserId='" + cboUser.SelectedValue.ToString() + "'";

                    else
                        if (cboUserGroup.SelectedValue != null)
                            m_dvAccessRight.RowFilter = "GroupId=" + cboUserGroup.SelectedValue.ToString() + " AND UserId IS NULL";
                }
                else
                {
                    if (cboUserGroup.SelectedValue != null)
                        m_dvAccessRight.RowFilter = "GroupId=" + cboUserGroup.SelectedValue.ToString() + " AND UserId IS NULL";
                }


                m_dvAccessRight.Sort = "GroupId,UserId,ParentObjectId,ObjectType,ObjectId";

                grdMaster.DataSource = m_dvAccessRight;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            m_bFormLoading = false;
        }

        void ShowAccess()
        {
            int nRow;

            for (int i = 0; i < grdEditAccess.Rows.Count; i++)
            {
                grdEditAccess["colIsVisible", i].Value = false;
                grdEditAccess["colIsEnable", i].Value = false;
                grdEditAccess["colGrantSelect", i].Value = false;
                grdEditAccess["colGrantInsert", i].Value = false;
                grdEditAccess["colGrantUpdate", i].Value = false;
                grdEditAccess["colGrantDelete", i].Value = false;                
                grdEditAccess["colGrantExecute", i].Value = false;
            }

            for (int i = 0; i < m_dvAccessRight.Count; i++)
            {
                nRow = GetGridRow(m_dvAccessRight[i]["ObjectId"].ToString());
                
                if (nRow > -1)
                {
                    if (m_dvAccessRight[i]["IsVisible"] != DBNull.Value && m_dvAccessRight[i]["IsVisible"].ToString().ToLower() == "true")
                        grdEditAccess["colIsVisible", nRow].Value = true;

                    if (m_dvAccessRight[i]["IsEnable"] != DBNull.Value && m_dvAccessRight[i]["IsEnable"].ToString().ToLower() == "true")
                        grdEditAccess["colIsEnable", nRow].Value = true;

                    if (m_dvAccessRight[i]["GrantSelect"] != DBNull.Value && m_dvAccessRight[i]["GrantSelect"].ToString().ToLower() == "true")
                        grdEditAccess["colGrantSelect", nRow].Value = true;

                    if (m_dvAccessRight[i]["GrantInsert"] != DBNull.Value && m_dvAccessRight[i]["GrantInsert"].ToString().ToLower() == "true")
                        grdEditAccess["colGrantInsert", nRow].Value = true;

                    if (m_dvAccessRight[i]["GrantUpdate"] != DBNull.Value && m_dvAccessRight[i]["GrantUpdate"].ToString().ToLower() == "true")
                        grdEditAccess["colGrantUpdate", nRow].Value = true;

                    if (m_dvAccessRight[i]["GrantDelete"] != DBNull.Value && m_dvAccessRight[i]["GrantDelete"].ToString().ToLower() == "true")
                        grdEditAccess["colGrantDelete", nRow].Value = true;

                    if (m_dvAccessRight[i]["GrantExecute"] != DBNull.Value && m_dvAccessRight[i]["GrantExecute"].ToString().ToLower() == "true")
                        grdEditAccess["colGrantExecute", nRow].Value = true;                    
                }
            }
        }

        int GetGridRow(string objectid)
        {
            int nRes = -1;
            
            for (int i = 0; i < grdEditAccess.Rows.Count; i++)
            {
                if (grdEditAccess["colObjectId", i].Value.ToString() == objectid)
                {
                    nRes = i;
                    break;
                }
            }

            return nRes;
        }

        private void RefreshData()
        {

            m_dvAccessRight = UserAccessRight.GetAccessRight(-1, null).DefaultView;

            cboUserGroup.SelectedIndex = 0;
            cboRegion.SelectedIndex = -1;
            cboRegion.SelectedIndex = -1;
            cboUser.SelectedIndex = -1;
            cboUser.SelectedIndex = -1;
            
            ShowMaster();
        }

        private void FillControls()
        {

            dpHadiBusiness.FillUserGroupCombo(cboUserGroup);
            dpHadiBusiness.FillRegionCombo(cboRegion);
            dpHadiBusiness.FillUserCombo(cboUser);
        }

        private void setHotKey(System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    switch (this.ActiveControl.Name)
                    {

                        case "cboUserGroup":
                            //cboUserGroup.SelectedIndex = -1;
                            //cboUserGroup.SelectedItem = null;
                            break;
                        case "cboUser":
                            cboUser.SelectedIndex = -1;
                            cboUser.SelectedItem = null;
                            break;
                        case "cboRegion":
                            cboRegion.SelectedIndex = -1;
                            cboRegion.SelectedItem = null;
                            break;
                                                
                    }

                    break;
            }
        }

        private void frmUserAccess_Load(object sender, EventArgs e)
        {
            
            m_bFormLoading = true;

            FillControls();
            cboUserGroup.SelectedIndex = -1;

            m_bFormLoading = false;

            m_dvApplicationObject = ApplicationObject.GetApplicationObject().DefaultView;
            grdEditAccess.DataSource = m_dvApplicationObject;

            RefreshData();
            this.WindowState = FormWindowState.Maximized;
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_bFormLoading)
            {
                ShowMaster();
            }
        }

        private void cboUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_bFormLoading)
            {
                BindingSource myBindingsource = new BindingSource();
                myBindingsource.DataSource = cboUser.DataSource;
                cboUser.DataSource = myBindingsource;


                if (cboUserGroup.SelectedValue != null)
                {
                    if (cboRegion.SelectedValue != null)
                        myBindingsource.Filter = "Acc_Fld_GroupCode=" + cboUserGroup.SelectedValue.ToString() + " AND Acc_Fld_fk_Region=" + cboRegion.SelectedValue.ToString();
                    else
                        myBindingsource.Filter = "Acc_Fld_GroupCode=" + cboUserGroup.SelectedValue.ToString() + " AND Acc_Fld_fk_Region is null";
                }

                ShowMaster();
            }
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_bFormLoading)
            {
                if (cboRegion.SelectedValue != null)
                {
                    BindingSource myBindingsource = new BindingSource();
                    myBindingsource.DataSource = cboUser.DataSource;
                    cboUser.DataSource = myBindingsource;
                    if (cboUserGroup.SelectedValue != null)
                        myBindingsource.Filter = "Acc_Fld_GroupCode=" + cboUserGroup.SelectedValue.ToString() + " AND Acc_Fld_fk_Region=" + cboRegion.SelectedValue.ToString();
                    else
                        myBindingsource.Filter = "Acc_Fld_GroupCode is null and Acc_Fld_fk_Region=" + cboRegion.SelectedValue.ToString();
                }

                ShowMaster();
            }
        }

        private void chkSelectUser_CheckedChanged(object sender, EventArgs e)
        {
                cboUser.Visible = chkSelectUser.Checked;
                lbUser.Visible = chkSelectUser.Checked;
                cboRegion.Visible = chkSelectUser.Checked;
                
                ShowMaster();
        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboUserGroup.SelectedValue == null)
                {
                    MessageBox.Show("گروه کاربری را انتخاب نمایید");
                    return;

                }

                DialogResult myres = MessageBox.Show("آیا دسترسیها ذخیره شوند؟", "بروزرسانی", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (myres == DialogResult.Yes)
                {
                    UserAccessRight objUserAccessRight = new UserAccessRight();
                    string strRes = "";
                    string strUserId = null;

                    if (chkSelectUser.Checked && cboUser.SelectedValue != null)
                    {
                        strUserId = cboUser.SelectedValue.ToString();
                        UserAccessRight.DeleteAllAccess(Convert.ToInt32(cboUserGroup.SelectedValue.ToString()), strUserId);
                    }
                    else
                        UserAccessRight.DeleteAllAccess(Convert.ToInt32(cboUserGroup.SelectedValue.ToString()), "");


                    for (int i = 0; i < m_dvApplicationObject.Count; i++)
                    {
                        if (grdEditAccess["colObjectType", i].Value.ToString() == "MENU")
                        {
                            if ((grdEditAccess["colIsVisible", i].Value != null && grdEditAccess["colIsVisible", i].Value.ToString().ToLower() == "true") || (grdEditAccess["colIsEnable", i].Value != null && grdEditAccess["colIsEnable", i].Value.ToString().ToLower() == "true"))
                            {
                                objUserAccessRight = new UserAccessRight();
                                objUserAccessRight.GroupId = Convert.ToInt32(cboUserGroup.SelectedValue.ToString());
                                objUserAccessRight.UID = strUserId;
                                objUserAccessRight.ObjectId = grdEditAccess["colObjectId", i].Value.ToString();
                                objUserAccessRight.IsVisible = (grdEditAccess["colIsVisible", i].Value == null || grdEditAccess["colIsVisible", i].Value.ToString().ToLower()== "false") ? false : true;
                                objUserAccessRight.IsEnable = (grdEditAccess["colIsEnable", i].Value == null || grdEditAccess["colIsEnable", i].Value.ToString().ToLower() == "false") ? false : true;
                               
                                strRes = objUserAccessRight.dbInsert();
                                if (strRes != "")
                                    break;
                            }
                        }

                        else if (grdEditAccess["colObjectType", i].Value.ToString() == "FORM")
                        {
                            if ((grdEditAccess["colGrantSelect", i].Value != null && grdEditAccess["colGrantSelect", i].Value.ToString().ToLower() == "true") || (grdEditAccess["colGrantInsert", i].Value != null && grdEditAccess["colGrantInsert", i].Value.ToString().ToLower() == "true") || (grdEditAccess["colGrantUpdate", i].Value != null && grdEditAccess["colGrantUpdate", i].Value.ToString().ToLower() == "true") || (grdEditAccess["colGrantDelete", i].Value != null && grdEditAccess["colGrantDelete", i].Value.ToString().ToLower() == "true") )
                            {
                                objUserAccessRight = new UserAccessRight();
                                objUserAccessRight.GroupId = Convert.ToInt32(cboUserGroup.SelectedValue.ToString());
                                objUserAccessRight.UID = strUserId;
                                objUserAccessRight.ObjectId = grdEditAccess["colObjectId", i].Value.ToString();
                                objUserAccessRight.GrantSelect = (grdEditAccess["colGrantSelect", i].Value == null || grdEditAccess["colGrantSelect", i].Value.ToString().ToLower() == "false") ? false : true;
                                objUserAccessRight.GrantInsert = (grdEditAccess["colGrantInsert", i].Value == null || grdEditAccess["colGrantInsert", i].Value.ToString().ToLower() == "false") ? false : true;
                                objUserAccessRight.GrantUpdate = (grdEditAccess["colGrantUpdate", i].Value == null || grdEditAccess["colGrantUpdate", i].Value.ToString().ToLower() == "false") ? false : true;
                                objUserAccessRight.GrantDelete = (grdEditAccess["colGrantDelete", i].Value == null || grdEditAccess["colGrantDelete", i].Value.ToString().ToLower() == "false") ? false : true;
                                
                                strRes = objUserAccessRight.dbInsert();
                                if (strRes != "")
                                    break;
                            }
                        }
                        else if (grdEditAccess["colObjectType", i].Value.ToString() == "OPERATIONAL")
                        {
                            if ( (grdEditAccess["colGrantExecute", i].Value != null && grdEditAccess["colGrantExecute", i].Value.ToString().ToLower() == "true"))
                            {
                                objUserAccessRight.GrantExecute = (grdEditAccess["colGrantExecute", i].Value == null || grdEditAccess["colGrantExecute", i].Value.ToString().ToLower() == "false") ? false : true;

                                strRes = objUserAccessRight.dbInsert();
                                if (strRes != "")
                                    break;
                            }
                        }

                    }

                    if (strRes == "")
                        MessageBox.Show("اطلاعات ثبت شد");
                    else
                    {
                        MessageBox.Show(strRes);
                    }

                }
                RefreshData();

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbAdd.Show();
            grdMaster.Hide();
            btnAdd.Enabled = false;
            btnRefresh.Enabled = false;
            cboUserGroup.Enabled = false;
            cboUser.Enabled = false;
            chkSelectUser.Enabled = false;
            cboRegion.Enabled = false;
            btnClose.Enabled = false;
            ShowAccess();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbAdd.Hide();
            grdMaster.Show();
            btnAdd.Enabled = true;
            btnRefresh.Enabled = true;
            cboUserGroup.Enabled = true;
            cboUser.Enabled = true;
            chkSelectUser.Enabled = true;
            cboRegion.Enabled = true;
            btnClose.Enabled = true;
        }

        private void mniCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdEditAccess.SelectedCells.Count; i++)
            {
                if (grdEditAccess.SelectedCells[i].ValueType == System.Type.GetType("System.Boolean"))
                {
                    grdEditAccess.SelectedCells[i].Value = true;
                }
            }
        }

        private void mniUnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdEditAccess.SelectedCells.Count; i++)
            {
                if (grdEditAccess.SelectedCells[i].ValueType == System.Type.GetType("System.Boolean"))
                {
                    grdEditAccess.SelectedCells[i].Value = false;
                }
            }

        }

        private void cboUserGroup_KeyUp(object sender, KeyEventArgs e)
        {
            setHotKey(e);
        }

        private void cboRegion_KeyUp(object sender, KeyEventArgs e)
        {
            setHotKey(e);
        }

        private void cboUser_KeyUp(object sender, KeyEventArgs e)
        {
            setHotKey(e);
        }



        private void grdEditAccess_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdEditAccess["colObjectType", e.RowIndex].Value.ToString() == "FORM")
                {
                    grdEditAccess["colIsVisible", e.RowIndex].Value = false;
                    grdEditAccess["colIsEnable", e.RowIndex].Value = false;
                    grdEditAccess["colGrantExecute", e.RowIndex].Value = false;
                }

                else if (grdEditAccess["colObjectType", e.RowIndex].Value.ToString() == "MENU")
                {                    
                    grdEditAccess["colGrantSelect", e.RowIndex].Value = false;
                    grdEditAccess["colGrantInsert", e.RowIndex].Value = false;
                    grdEditAccess["colGrantUpdate", e.RowIndex].Value = false;
                    grdEditAccess["colGrantDelete", e.RowIndex].Value = false;
                    grdEditAccess["colGrantExecute", e.RowIndex].Value = false;
                }
                else if (grdEditAccess["colObjectType", e.RowIndex].Value.ToString() == "OPERATIONAL")
                {
                    grdEditAccess["colIsVisible", e.RowIndex].Value = false;
                    grdEditAccess["colIsEnable", e.RowIndex].Value = false;
                    grdEditAccess["colGrantSelect", e.RowIndex].Value = false;
                    grdEditAccess["colGrantInsert", e.RowIndex].Value = false;
                    grdEditAccess["colGrantUpdate", e.RowIndex].Value = false;
                    grdEditAccess["colGrantDelete", e.RowIndex].Value = false;
                }
            }

            catch
            {
            }
        }



    }
}
