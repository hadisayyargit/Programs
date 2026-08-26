using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using RWAS.BusinessRules;
using RWAS.Common;

namespace RWAS.WinUI
{
    public partial class frmAppObject: Form
    {

        DataTable m_dtApplicationObject = new DataTable();

        TreeNode nodeRoot;
        TreeNode nodeMenu;
        TreeNode nodeForm;

        public frmAppObject()
        {
            InitializeComponent();
        }


        private void ShowMaster()
        {

            m_dtApplicationObject.DefaultView.Sort = "objecttype,pname";
            grdApplicationObject.DataSource = m_dtApplicationObject.DefaultView;

        }
    
        private void RefreshData()
        {
            m_dtApplicationObject = ApplicationObject.GetApplicationObject();
            
            grdApplicationObject.DataSource = m_dtApplicationObject.DefaultView;

            ShowMaster();
        }

        private bool IsPreviousSiblingNodeChecked(TreeNode myNode)
        {
            bool bres = myNode.Checked;

            if (myNode.PrevNode != null)
            {
                if (myNode.PrevNode.Checked)
                    bres = true;

                else
                    bres = IsPreviousSiblingNodeChecked(myNode.PrevNode);
            }


            return bres;
        }

        private bool IsNextSiblingNodeChecked(TreeNode myNode)
        {
            bool bres=myNode.Checked;

            if (myNode.NextNode != null)
            {
                if (myNode.NextNode.Checked)
                    bres = true;

                else
                    bres = IsNextSiblingNodeChecked(myNode.NextNode);
            }

            
            return bres;
        }

        private void TickParentsNode(TreeNode myNode, bool flag)
        {
            if (myNode.Parent != null)
            {
                myNode.Parent.Checked = flag;
                TickParentsNode(myNode.Parent, flag);
            }
        }

        private void TickChildrenNode(TreeNode myNode, bool flag)
        {
            for (int i = 0; i < myNode.Nodes.Count; i++)
            {
                myNode.Nodes[i].Checked = flag;
                TickChildrenNode(myNode.Nodes[i], flag);
            }
        }

        private void AddNodeToDataTableRow(TreeNode myNode, string ObjectType)
        {

            if (myNode.Parent != null && myNode.Parent != nodeRoot && myNode.Checked)
            {
                DataRow drNew = m_dtApplicationObject.NewRow();

                drNew["ObjectType"] = ObjectType;
                drNew["IsSecurable"] = true;
                drNew["ParentObjectId"] = myNode.Parent.Name;
                drNew["ObjectId"] = myNode.Name;
                drNew["Pname"] = myNode.Text;
                drNew["ApplicationId"] = Common.CommonClass.m_ApplicationId;

                m_dtApplicationObject.Rows.Add(drNew);

            }

            for (int i = 0; i < myNode.Nodes.Count; i++)
                AddNodeToDataTableRow(myNode.Nodes[i], ObjectType);

        }

        private void AddToDataTableRow(string ObjectId,string Pname,string ParentObjectId,bool IsSecurable, string ObjectType, string ApplicationId)
        {

            if (ObjectId!="")
            {
                DataRow drNew = m_dtApplicationObject.NewRow();

                drNew["ObjectType"] = ObjectType;
                drNew["IsSecurable"] = IsSecurable;
                drNew["ParentObjectId"] = ParentObjectId;
                drNew["ObjectId"] = ObjectId;
                drNew["Pname"] =Pname;
                drNew["ApplicationId"] = ApplicationId;

                m_dtApplicationObject.Rows.Add(drNew);

            }
        }

        private void makeLeaf(ToolStripMenuItem myItem, TreeNode myNode)
        {
            
            TreeNode newNode = myNode.Nodes.Add(Common.CommonClass.m_ApplicationId+"_"+myItem.Name,myNode.Text+"-"+ myItem.Text);

            for (int i = 0; i < myItem.DropDownItems.Count; i++)
                if (myItem.DropDownItems[i].CanSelect)
                {
                    makeLeaf((ToolStripMenuItem)myItem.DropDownItems[i], newNode);
                }
            
        }

        private void makeTreeMenu()
        {
            frmParent objForm = new frmParent();

            treeObjects.Nodes.Clear();

            nodeRoot = treeObjects.Nodes.Add(Common.CommonClass.m_ApplicationId, "سوانح");
            nodeMenu = nodeRoot.Nodes.Add(Common.CommonClass.m_ApplicationId, "منوها");
            nodeForm = nodeRoot.Nodes.Add(Common.CommonClass.m_ApplicationId, "فرمها");

            //RootNode.Name = 1.01;

            ///لیست منوها

            for (int i = 0; i < objForm.MainMenuStrip.Items.Count; i++)
            {
                makeLeaf((ToolStripMenuItem)objForm.MainMenuStrip.Items[i], nodeMenu);
            }

            ///لیست فرمها
            ///کد زیر کند است
            Assembly SampleAssembly;
            SampleAssembly = Assembly.LoadFile(Application.ExecutablePath);
            Type[] ts = SampleAssembly.GetTypes();

            for (int i = 0; i < ts.Length; i++)
            {
                if (ts[i].BaseType == typeof(Form))
                {
                    Form obj1;
                    try
                    {
                        obj1 = (Form)SampleAssembly.CreateInstance(ts[i].ToString());
                        if (obj1.Text != "")
                            nodeForm.Nodes.Add(Common.CommonClass.m_ApplicationId + "_" + obj1.Name, obj1.Text);
                    }
                    catch
                    {
                    }
                }
            }            


            treeObjects.Nodes[0].Expand();
        }

        private void FillControls()
        {

            makeTreeMenu();
        }

        private void frmAppObject_Load(object sender, EventArgs e)
        {
            FillControls();
            RefreshData();
            
        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
            UserAccessRight objUserAccessRight = new UserAccessRight();
            string strRes = "";
            DataRow[] myRows;
            string strFilter = "";

            Cursor = Cursors.WaitCursor;

            if (rdoAppObject.Checked)
            {
                myRows = m_dtApplicationObject.Select(strFilter);

                for (int i = 0; i < myRows.Length; i++)
                    myRows[i].Delete();

                AddNodeToDataTableRow(nodeMenu, "MENU");
                AddNodeToDataTableRow(nodeForm, "FORM");
                
            }
            else
            {
                string strName = txtEname.Text;
                if (strName.ToUpper().StartsWith(Common.CommonClass.m_ApplicationId+"_") == false)
                    strName = Common.CommonClass.m_ApplicationId+"_" + strName;

                AddToDataTableRow(strName, txtPname.Text, Common.CommonClass.m_ApplicationId, true, "OPERATIONAL", Common.CommonClass.m_ApplicationId);

            }

            ApplicationObject.UpdateApplicationObject(m_dtApplicationObject);

            if (strRes == "")
                MessageBox.Show("اطلاعات ثبت شد");
            else
            {
                MessageBox.Show(strRes);
            }


            RefreshData();

            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void treeObjects_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse)
            {
                if (e.Node.Checked)
                    TickParentsNode(e.Node, e.Node.Checked);

                else
                    TickChildrenNode(e.Node, e.Node.Checked);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            gbAdd.Hide();
            gbMaster.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbMaster.Hide();
            gbAdd.Show();

        }

        private void rdoOperational_CheckedChanged(object sender, EventArgs e)
        {
            treeObjects.Enabled = rdoAppObject.Checked;
            gbOperationalObject.Enabled = rdoOperational.Checked;
        }

        private void rdoAppObject_CheckedChanged(object sender, EventArgs e)
        {
            treeObjects.Enabled = rdoAppObject.Checked;
            gbOperationalObject.Enabled = rdoOperational.Checked;
        }

        private void mniCheckAll_Click(object sender, EventArgs e)
        {
            if (treeObjects.SelectedNode != null)
            {
                treeObjects.SelectedNode.Checked = true;
                TickChildrenNode(treeObjects.SelectedNode, true);
            }
        }


    }
}
