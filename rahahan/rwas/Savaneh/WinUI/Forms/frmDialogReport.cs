using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using RWAS.Common;
using RWAS.BusinessRules;
using System.Data.SqlClient;

namespace RWAS.WinUI
{
    public partial class frmDialogReport : Form
    {
        EarlyAccidentMainData objEarlyAccidentMainData;
        EarlyAccidentLocationData objEarlyAccidentLocationData;
        EarlyAccidentTrainAttData objEarlyAccidentTrainAttData;
        CategoryData objDSCategory;
        AccidentReasonData objAccidentReasonData;

        public frmDialogReport()
        {
            InitializeComponent();
        }

        private void frmDialogReport_Load(object sender, EventArgs e)
        {
            this.Text = Program.m_objReport.Titr;
            txtTitr.Text = Program.m_objReport.Titr;
            faDatePickerBegin.SelectedDateTime = Program.m_dtmCurrentTime.AddDays(-30);
            faDatePickerEnd.Text = Program.m_strCurrentPDate;
            btnRefresh.Hide();

            if (Program.m_objReport.ReportId == classReport.ReportIdType.reportSeir)
            {
                gbSeir.Show();
                lbEndDate.Hide();
                faDatePickerEnd.Hide();
                gbAccidentParameters.Hide();
                gbOptions.Hide();
                btnParameters.Enabled = false;
                lbBeginDate.Text = "تاریخ تشکیل:";
                faDatePickerBegin.SelectedDateTime = Program.m_dtmCurrentTime;
            }

            Program.m_objReport.SortColumn1 = null;
            Program.m_objReport.SortColumn2 = null;
            Program.m_objReport.SortColumn3 = null;

            chkListAccident.Items.Clear();

            BindingSource myBindingsource = new BindingSource();
            myBindingsource.DataSource = CommonClass.datatableTableColumns;
            chkListAccident.DataSource = myBindingsource;
            chkListAccident.DisplayMember = "ColumnName";
            chkListAccident.ValueMember = "ColumnId";
            myBindingsource.Filter = "TableName = 'accident'";

            switch (Program.m_objReport.ReportId)
            {
                case classReport.ReportIdType.reportAccident:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'General'";
                    gbAccidentParameters.Show();
                    gbOptions.Show();
                    gbAccidentList.Hide();
                    break;
                case classReport.ReportIdType.reportAccidentStatistics:
                case classReport.ReportIdType.reportAccidentStatistics_Matrix:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'General'";
                    gbAccidentParameters.Show();
                    gbOptions.Show();
                    gbAccidentList.Hide();
                    cboLocation.Hide();
                    lbLocation.Hide();
                    gbGroupingField.Show();
                    break;
                case classReport.ReportIdType.reportAccidentBlockStatistics:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'General'";
                    gbAccidentParameters.Show();
                    gbOptions.Show();
                    gbAccidentList.Hide();
                    cboLocation.Hide();
                    lbLocation.Hide();
                    gbGroupingField.Show();
                    listboxGroupColumns.Items.Add("بلاک");
                    break;
                case classReport.ReportIdType.reportCroquis:
                case classReport.ReportIdType.reportTrainArrangement:
                    btnRefresh.Show();
                    gbAccidentParameters.Hide();
                    gbOptions.Hide();
                    gbAccidentList.Show();
                    gbColumns.Hide();
                    gbSort.Hide();
                    btnRefresh.PerformClick();
                    break;
                case classReport.ReportIdType.reportAccidentMedia:
                    btnRefresh.Show();
                    gbAccidentParameters.Hide();
                    gbOptions.Hide();
                    gbAccidentList.Show();
                    gbColumns.Hide();
                    gbSort.Hide();
                    btnRefresh.PerformClick();
                    btnEditImage.Hide();
                    pictureBox1.Hide();
                    break;

                case classReport.ReportIdType.reportHumanDelinquent:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'Blameful'";
                    break;
                case classReport.ReportIdType.reportHumanDelinquentStatistics:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'Blameful'";
                    gbGroupingField.Show();
                    break;
                case classReport.ReportIdType.reportWagonDelinquent:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'ExitRail'";
                    break;

                case classReport.ReportIdType.reportWagonDelinquentStatistics:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'ExitRail'";
                    gbGroupingField.Show();
                    break;
                case classReport.ReportIdType.reportLoss:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'Loss'";
                    break;

                case classReport.ReportIdType.reportLossStatistics:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'Loss'";
                    gbGroupingField.Show();
                    break;
                case classReport.ReportIdType.reportDieAndAfoul:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'DieAndAfoul'";
                    break;

                case classReport.ReportIdType.reportDieAndAfoulStatistics:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'DieAndAfoul'";
                    gbGroupingField.Show();
                    break;
                case classReport.ReportIdType.reportAgentDieAndAfoul:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'AgentDieAndAfoul'";
                    break;

                case classReport.ReportIdType.reportAgentDieAndAfoulStatistics:
                    myBindingsource.Filter = "TableName = 'accident' OR TableName = 'AgentDieAndAfoul'";
                    gbGroupingField.Show();
                    break;

            }

            int nLength = chkListAccident.Items.Count;

            chkListAccident.ClearSelected();

            /*
            for (int i = 0; i < nLength; i++)
            {
                chkListAccident.SetItemChecked(i, true);
            }
            */

            FillInfo();

            chkcboCategory.CheckedValues = null;
            chkcboAccidentKind.CheckedValues = null;
            chkcboRegion.CheckedValues = null;
            chkcboEffective.CheckedValues = null;
            chkcboReason.CheckedValues = null;
            chkcboDegree.CheckedValues = null;            
            chkcboRailVehicleKind.CheckedValues = null;
            cboLocation.SelectedIndex = -1;

            InitializeParameters();
        }

        private void setHotKey(System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    SendKeys.Send("{Tab}");
                    break;
                case Keys.F5:
                    break;
                case Keys.Delete:
                    switch (this.ActiveControl.Name)
                    {
                        case "chkcboCategory":
                            chkcboCategory.CheckedValues = null;
                            break;
                        case "chkcboAccidentKind":
                            chkcboAccidentKind.CheckedValues = null;
                            break;
                        case "chkcboDegree":
                            chkcboDegree.CheckedValues = null;
                            break;
                        case "chkcboEffective":
                            chkcboEffective.CheckedValues = null;
                            break;
                        case "cboLocation":
                            cboLocation.SelectedIndex = 0;
                            break;
                        case "chkcboRailVehicleKind":
                            chkcboRailVehicleKind.CheckedValues = null;
                            break;
                        case "chkcboReason":
                            chkcboReason.CheckedValues = null;
                            break;
                        case "chkcboRegion":
                            chkcboRegion.CheckedValues = null;
                            break;
                        case "listboxSortColumns":
                            if (listboxSortColumns.SelectedItem != null)
                                listboxSortColumns.Items.Remove(listboxSortColumns.SelectedItem);
                            break;
                        case "listboxGroupColumns":
                            if (listboxGroupColumns.SelectedItem != null && listboxGroupColumns.Text != "بلاک")
                                listboxGroupColumns.Items.Remove(listboxGroupColumns.SelectedItem);

                            break;
                    }
                    break;
                case Keys.Escape:
                    break;
            }
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                        break;
                }
            }
        }

        private string ExtractFileName(string strPath)
        {
            short shrPosition = Convert.ToInt16(strPath.LastIndexOf("\\"));
            string strFileName = strPath.Substring(shrPosition, strPath.Length - shrPosition);
            return strFileName;
        }

        private void FillInfo()
        {
            EarlyAccident objEarlyAccident = new EarlyAccident();
            BusinessRules.Category objBRCategory = new Category();
            AccidentReason objAccidentReason = new AccidentReason();

            try
            {
                objEarlyAccident.GetEarlyAccident(out objEarlyAccidentMainData, out objEarlyAccidentTrainAttData, out objEarlyAccidentLocationData);
                objDSCategory = objBRCategory.GetCategory();
                objAccidentReasonData = objAccidentReason.GetAccidentReason();

                //CreateConcatination();

                //grdEarlyAccident.ColumnCount = 3;
                FillControls();

            }
            catch (Exception ocException)
            {
                MessageBox.Show(ocException.Message);
            }
        }

        private void FillControls()
        {
            //			DataRow[] drowSelect;
            chkcboCategory.DropDownDataSource = objEarlyAccidentMainData.Rws_Sp_Sel_All_AccidentCategory;
            chkcboCategory.DropDownDisplayMember = EarlyAccidentMainData.Rws_Fld_CategoryDescribe;
            chkcboCategory.DropDownValueMember = EarlyAccidentMainData.Rws_Fld_CategoryNo;


            chkcboRegion.DropDownDataSource = objEarlyAccidentMainData.Rws_Sp_Sel_All_Region;
            chkcboRegion.DropDownDisplayMember = EarlyAccidentMainData.Rws_Fld_Describe;
            chkcboRegion.DropDownValueMember = EarlyAccidentMainData.Rws_Fld_Code;



            chkcboDegree.DropDownDataSource = objEarlyAccidentMainData.Rws_Sp_Sel_All_AccidentDegree;
            chkcboDegree.DropDownDisplayMember = EarlyAccidentMainData.Rws_Fld_Describe;
            chkcboDegree.DropDownValueMember = EarlyAccidentMainData.Rws_Fld_Code;

            chkcboRailVehicleKind.DropDownDataSource = objEarlyAccidentMainData.Rws_Sp_Sel_All_RailWayVehicleKind;
            chkcboRailVehicleKind.DropDownDisplayMember = EarlyAccidentMainData.Rws_Fld_Describe;
            chkcboRailVehicleKind.DropDownValueMember = EarlyAccidentMainData.Rws_Fld_Code;

            chkcboAccidentKind.DropDownDataSource = objDSCategory.Rws_Sp_Sel_All_AccidentKind;
            chkcboAccidentKind.DropDownDisplayMember = CategoryData.Rws_Fld_Describe;
            chkcboAccidentKind.DropDownValueMember = CategoryData.Rws_Fld_Code;


            chkcboEffective.DropDownDataSource = objAccidentReasonData.Rws_Sp_Sel_All_AccidentEffective;            
            chkcboEffective.DropDownDisplayMember = AccidentReasonData.Rws_Fld_Describe;
            chkcboEffective.DropDownValueMember = AccidentReasonData.Rws_Fld_Code;
        }

        private void InitializeParameters()
        {
            switch (Program.m_objReport.ReportId)
            {
                case classReport.ReportIdType.reportAccident:
                case classReport.ReportIdType.reportAccidentStatistics:
                case classReport.ReportIdType.reportAccidentStatistics_Matrix:
                case classReport.ReportIdType.reportAccidentBlockStatistics:
                case classReport.ReportIdType.reportHumanDelinquent:
                case classReport.ReportIdType.reportHumanDelinquentStatistics:
                case classReport.ReportIdType.reportWagonDelinquent:
                case classReport.ReportIdType.reportWagonDelinquentStatistics:
                case classReport.ReportIdType.reportLoss:
                case classReport.ReportIdType.reportLossStatistics:
                case classReport.ReportIdType.reportDieAndAfoul:
                case classReport.ReportIdType.reportDieAndAfoulStatistics:
                case classReport.ReportIdType.reportAgentDieAndAfoul:
                case classReport.ReportIdType.reportAgentDieAndAfoulStatistics:



                    Program.m_objReport.SortColumn1 = "Rws_Fld_AccidentDate";
                    Program.m_objReport.SortColumn2 = "RegionDesc";
                    Program.m_objReport.SortColumn3 = "DegreeDesc";

                    Program.m_objReport.ShowColumn = 85663;

                    txtHeaderTitle.Text = "";
                    Program.m_objReport.BeginDate = CommonClass.GetDateWithoutSlash(faDatePickerBegin.Text);
                    Program.m_objReport.EndDate = CommonClass.GetDateWithoutSlash(faDatePickerEnd.Text);

                    if (CommonClass.GetDateValue(faDatePickerBegin.Text) != 0)
                    {
                        //txtHeaderTitle.Text += "از تاریخ:" + faDatePickerBegin.Text;
                    }

                    if (CommonClass.GetDateValue(faDatePickerEnd.Text) != 0)
                    {
                        //txtHeaderTitle.Text += "تا تاریخ:" + faDatePickerEnd.Text;
                    }

                    Program.m_objReport.CategoryList = null;
                    Program.m_objReport.AccidentKindList = null;
                    Program.m_objReport.RegionList = null;
                    Program.m_objReport.RailWayVehicleKindList = null;
                    Program.m_objReport.EffectiveList = null;
                    Program.m_objReport.ReasonList = null;
                    Program.m_objReport.DegreeList = null;


                    Program.m_objReport.LocationList = "";

                    Program.m_objReport.HasLoss = -1;
                    Program.m_objReport.HasAfoul = -1;

                    Program.m_objReport.HasBlameful = -1;
                    Program.m_objReport.HasDie = -1;
                    Program.m_objReport.HasBarred = -1;
                    Program.m_objReport.HasManouver = -1;

                    if (Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentStatistics_Matrix || Program.m_objReport.ReportId == classReport.ReportIdType.reportHumanDelinquentStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportWagonDelinquentStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportLossStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportDieAndAfoulStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportAgentDieAndAfoulStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentBlockStatistics)
                    {
                        if (Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentBlockStatistics)
                        {
                            txtHeaderTitle.Text += "/" + "گروه اول: بلاک";
                            Program.m_objReport.GroupColumn1 = "BlockString";
                            Program.m_objReport.GroupColumn2 = "RegionDesc";
                            Program.m_objReport.GroupColumn3 = "AccidentKindDesc";
                            Program.m_objReport.GroupColumn4 = "DegreeDesc";

                            Program.m_objReport.GroupDesc1 = "بلوک";
                            Program.m_objReport.GroupDesc2 = "ناحیه";
                            Program.m_objReport.GroupDesc3 = "نوع حادثه";
                            Program.m_objReport.GroupDesc4 = "درجه حادثه";

                        }
                        else
                        {
                            Program.m_objReport.GroupColumn1 = "RegionDesc";
                            Program.m_objReport.GroupColumn2 = "AccidentKindDesc";
                            Program.m_objReport.GroupColumn3 = "DegreeDesc";
                            Program.m_objReport.GroupColumn4 = "EffectiveDesc";

                            Program.m_objReport.GroupDesc1 = "ناحیه";
                            Program.m_objReport.GroupDesc2 = "نوع حادثه";
                            Program.m_objReport.GroupDesc3 = "درجه حادثه";
                            Program.m_objReport.GroupDesc4 = "عامل حادثه";

                        }

                    }
                    break;

                case classReport.ReportIdType.reportCroquis:
                    Program.m_objReport.PKEarlyAccident = -1;
                    break;
                case classReport.ReportIdType.reportTrainArrangement:
                    Program.m_objReport.PrintPDate = Program.m_strCurrentPDate;
                    Program.m_objReport.PKEarlyAccident = -1;

                    break;

                case classReport.ReportIdType.reportAccidentMedia:
                    Program.m_objReport.PrintPDate = Program.m_strCurrentPDate;
                    Program.m_objReport.PKEarlyAccident = -1;

                    break;

                case classReport.ReportIdType.reportSeir:
                    Program.m_objReport.BeginDate = CommonClass.GetDateWithoutSlash(faDatePickerBegin.Text);

                    if (Program.m_objReport.BeginDate.StartsWith("13"))
                        Program.m_objReport.BeginDate = Program.m_objReport.BeginDate.Remove(0, 2);

                    try
                    {
                        Program.m_objReport.TrainNo = int.Parse(txtTrainNo.Text);
                    }
                    catch
                    {
                        Program.m_objReport.TrainNo = 0;
                    }
                    break;
            }

            Program.m_objReport.PrintPDate = Program.m_strCurrentPDate;
            Program.m_objReport.Titr = txtTitr.Text;
            Program.m_objReport.SubTitle = txtHeaderTitle.Text;
            Program.m_objReport.Footer = txtFooterTitle.Text;
        }

        private void CheckParameters()
        {
            switch (Program.m_objReport.ReportId)
            {
                case classReport.ReportIdType.reportAccident:
                case classReport.ReportIdType.reportAccidentStatistics:
                case classReport.ReportIdType.reportAccidentStatistics_Matrix:
                case classReport.ReportIdType.reportAccidentBlockStatistics:
                case classReport.ReportIdType.reportHumanDelinquent:
                case classReport.ReportIdType.reportHumanDelinquentStatistics:
                case classReport.ReportIdType.reportWagonDelinquent:
                case classReport.ReportIdType.reportWagonDelinquentStatistics:
                case classReport.ReportIdType.reportLoss:
                case classReport.ReportIdType.reportLossStatistics:
                case classReport.ReportIdType.reportDieAndAfoul:
                case classReport.ReportIdType.reportDieAndAfoulStatistics:
                case classReport.ReportIdType.reportAgentDieAndAfoul:
                case classReport.ReportIdType.reportAgentDieAndAfoulStatistics:

                    double nShowColumn = 0;
                    
                    if (chkListAccident.CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < chkListAccident.Items.Count; i++)
                        {
                            if (chkListAccident.GetItemChecked(i))
                                nShowColumn += Math.Pow(2.0, i);
                        }

                        Program.m_objReport.ShowColumn = nShowColumn;
                    }
                    else
                        Program.m_objReport.ShowColumn = 85663;

                    if (listboxSortColumns.Items.Count == 0)
                        Program.m_objReport.SortColumn1 = "Rws_Fld_AccidentDate";
                    else
                    {
                        Program.m_objReport.SortColumn1 = ((DataRowView)listboxSortColumns.Items[0])["ColumnId"].ToString();

                        if (listboxSortColumns.Items.Count == 1)
                            Program.m_objReport.SortColumn2 = "RegionDesc";
                        else
                        {
                            Program.m_objReport.SortColumn2 = ((DataRowView)listboxSortColumns.Items[1])["ColumnId"].ToString();

                            if (listboxSortColumns.Items.Count == 2)
                                Program.m_objReport.SortColumn3 = "DegreeDesc";
                            else
                                Program.m_objReport.SortColumn3 = ((DataRowView)listboxSortColumns.Items[2])["ColumnId"].ToString();
                        }
                    }

                    Program.m_objReport.BeginDate = CommonClass.GetDateWithoutSlash(faDatePickerBegin.Text);
                    Program.m_objReport.EndDate = CommonClass.GetDateWithoutSlash(faDatePickerEnd.Text);

                    if (chkcboCategory.CheckedValues != null)
                        Program.m_objReport.CategoryList = string.Join(",", chkcboCategory.CheckedValues);
                    else
                        Program.m_objReport.CategoryList = null;

                    if (chkcboAccidentKind.CheckedValues != null)
                        Program.m_objReport.AccidentKindList = string.Join(",", chkcboAccidentKind.CheckedValues);
                    else
                        Program.m_objReport.AccidentKindList = null;

                    if (chkcboRegion.CheckedValues != null)
                        Program.m_objReport.RegionList = string.Join(",", chkcboRegion.CheckedValues);
                    else
                        Program.m_objReport.RegionList = null;

                    if (chkcboRailVehicleKind.CheckedValues != null)
                        Program.m_objReport.RailWayVehicleKindList = string.Join(",", chkcboRailVehicleKind.CheckedValues);
                    else
                        Program.m_objReport.RailWayVehicleKindList = null;

                    if (chkcboEffective.CheckedValues != null)
                        Program.m_objReport.EffectiveList = string.Join(",", chkcboEffective.CheckedValues);
                    else
                        Program.m_objReport.EffectiveList = null;

                    if (chkcboReason.CheckedValues != null)
                        Program.m_objReport.ReasonList = string.Join(",", chkcboReason.CheckedValues);
                    else
                        Program.m_objReport.ReasonList = null;

                    if (chkcboDegree.CheckedValues != null)
                        Program.m_objReport.DegreeList = string.Join(",", chkcboDegree.CheckedValues);
                    else
                        Program.m_objReport.DegreeList = null;


                    switch (cboLocation.Text.Trim())
                    {
                        case "سوزن":
                            Program.m_objReport.LocationList = "0";
                            break;
                        case "بلاک":
                            Program.m_objReport.LocationList = "1";
                            break;
                        default:
                            Program.m_objReport.LocationList = "";
                            break;
                    }

                    if (rdoLossYes.Checked)
                        Program.m_objReport.HasLoss = 1;
                    else if (rdoLossNo.Checked)
                        Program.m_objReport.HasLoss = 0;
                    else
                        Program.m_objReport.HasLoss = -1;

                    if (rdoAfoulYes.Checked)
                        Program.m_objReport.HasAfoul = 1;
                    else if (rdoAfoulNo.Checked)
                        Program.m_objReport.HasAfoul = 0;
                    else
                        Program.m_objReport.HasAfoul = -1;

                    if (rdoBlamefulYes.Checked)
                        Program.m_objReport.HasBlameful = 1;
                    else if (rdoBlamefulNo.Checked)
                        Program.m_objReport.HasBlameful = 0;
                    else
                        Program.m_objReport.HasBlameful = -1;

                    if (rdoDieYes.Checked)
                        Program.m_objReport.HasDie = 1;
                    else if (rdoDieNo.Checked)
                        Program.m_objReport.HasDie = 0;
                    else
                        Program.m_objReport.HasDie = -1;

                    if (rdoBarredYes.Checked)
                        Program.m_objReport.HasBarred = 1;
                    else if (rdoBarredNo.Checked)
                        Program.m_objReport.HasBarred = 0;
                    else
                        Program.m_objReport.HasBarred = -1;

                    if (rdoManouverYes.Checked)
                        Program.m_objReport.HasManouver = 1;
                    else if (rdoManouverNo.Checked)
                        Program.m_objReport.HasManouver = 0;
                    else
                        Program.m_objReport.HasManouver = -1;

                    if (Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentStatistics_Matrix || Program.m_objReport.ReportId == classReport.ReportIdType.reportHumanDelinquentStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportWagonDelinquentStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportLossStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportDieAndAfoulStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportAgentDieAndAfoulStatistics || Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentBlockStatistics)
                    {


                        if (Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentBlockStatistics)
                        {
                            Program.m_objReport.GroupColumn1 = "BlockString";
                            Program.m_objReport.GroupColumn2 = "RegionDesc";
                            Program.m_objReport.GroupColumn3 = "AccidentKindDesc";
                            Program.m_objReport.GroupColumn4 = "DegreeDesc";

                            Program.m_objReport.GroupDesc1 = "بلوک";
                            Program.m_objReport.GroupDesc2 = "ناحیه";
                            Program.m_objReport.GroupDesc3 = "نوع حادثه";
                            Program.m_objReport.GroupDesc4 = "درجه حادثه";
                        }
                        else
                        {
                            try
                            {
                                Program.m_objReport.GroupColumn1 = ((DataRowView)listboxGroupColumns.Items[0])["ColumnId"].ToString();
                                Program.m_objReport.GroupDesc1 = ((DataRowView)listboxGroupColumns.Items[0])["ColumnName"].ToString();                                
                            }
                            catch
                            {
                                Program.m_objReport.GroupColumn1 = "RegionDesc";
                                Program.m_objReport.GroupDesc1 = "ناحیه";
                            }

                            try
                            {
                                Program.m_objReport.GroupColumn2 = ((DataRowView)listboxGroupColumns.Items[1])["ColumnId"].ToString();
                                Program.m_objReport.GroupDesc2 = ((DataRowView)listboxGroupColumns.Items[1])["ColumnName"].ToString();                                
                            }
                            catch
                            {
                                Program.m_objReport.GroupColumn2 = "AccidentKindDesc";
                                Program.m_objReport.GroupDesc2 = "نوع حادثه";
                            }

                            try
                            {
                                Program.m_objReport.GroupColumn3 = ((DataRowView)listboxGroupColumns.Items[2])["ColumnId"].ToString();
                                Program.m_objReport.GroupDesc3 = ((DataRowView)listboxGroupColumns.Items[2])["ColumnName"].ToString();                                
                            }
                            catch
                            {
                                Program.m_objReport.GroupColumn3 = "DegreeDesc";
                                Program.m_objReport.GroupDesc3 = "درجه حادثه";
                            }

                            try
                            {
                                Program.m_objReport.GroupColumn4 = ((DataRowView)listboxGroupColumns.Items[3])["ColumnId"].ToString();
                                Program.m_objReport.GroupDesc4 = ((DataRowView)listboxGroupColumns.Items[3])["ColumnName"].ToString();                                
                            }
                            catch
                            {
                                Program.m_objReport.GroupColumn4 = "EffectiveDesc";
                                Program.m_objReport.GroupDesc4 = "عامل حادثه";
                            }

                        }

                    }
                    break;
                case classReport.ReportIdType.reportCroquis:
                    if (grdEarlyAccident.Rows.Count > 0)
                        Program.m_objReport.PKEarlyAccident = Int32.Parse(grdEarlyAccident[colRws_Fld_pk_EarlyAccident.Name, grdEarlyAccident.CurrentCell.RowIndex].Value.ToString());
                    else
                        Program.m_objReport.PKEarlyAccident = -1;

                    break;

                case classReport.ReportIdType.reportTrainArrangement:
                    Program.m_objReport.PrintPDate = Program.m_strCurrentPDate;
                    if (grdEarlyAccident.Rows.Count > 0)
                        Program.m_objReport.PKEarlyAccident = Int32.Parse(grdEarlyAccident[colRws_Fld_pk_EarlyAccident.Name, grdEarlyAccident.CurrentCell.RowIndex].Value.ToString());
                    else
                        Program.m_objReport.PKEarlyAccident = -1;

                    break;

                case classReport.ReportIdType.reportAccidentMedia:
                    Program.m_objReport.PrintPDate = Program.m_strCurrentPDate;
                    if (grdEarlyAccident.Rows.Count > 0)
                        Program.m_objReport.PKEarlyAccident = Int32.Parse(grdEarlyAccident[colRws_Fld_pk_EarlyAccident.Name, grdEarlyAccident.CurrentCell.RowIndex].Value.ToString());
                    else
                        Program.m_objReport.PKEarlyAccident = -1;

                    break;

                case classReport.ReportIdType.reportSeir:
                    Program.m_objReport.BeginDate = CommonClass.GetDateWithoutSlash(faDatePickerBegin.Text);

                    if (Program.m_objReport.BeginDate.StartsWith("13"))
                        Program.m_objReport.BeginDate = Program.m_objReport.BeginDate.Remove(0, 2);

                    try
                    {
                        Program.m_objReport.TrainNo = int.Parse(txtTrainNo.Text);
                    }
                    catch
                    {
                        Program.m_objReport.TrainNo = 0;
                    }
                    break;
            }

            Program.m_objReport.PrintPDate = Program.m_strCurrentPDate;
            Program.m_objReport.Titr = txtTitr.Text;
            Program.m_objReport.SubTitle = txtHeaderTitle.Text;
            Program.m_objReport.Footer = txtFooterTitle.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHideParameterGroup_Click(object sender, EventArgs e)
        {
            gbReportParameters.Hide();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            CheckParameters();

            if (Program.m_objReport.ReportId == classReport.ReportIdType.reportAccidentMedia)
            {
                /*
                byte[] bytBlob;
                FileStream flsOutput;
                try
                {
                    short nRow = 0;
                    nRow = Convert.ToInt16(grdEarlyAccident["colRow", grdEarlyAccident.CurrentRow.Index].Value);
                    clsBRAccidentMedia objBRAccidentMedia = new clsBRAccidentMedia();

                    bytBlob = objBRAccidentMedia.GetSpecialAccidentMedia(Program.m_objReport.PKEarlyAccident,nRow);

                    flsOutput = new FileStream(Environment.GetEnvironmentVariable("TEMP").ToString() + ExtractFileName(txtPath.Text), FileMode.OpenOrCreate, FileAccess.Write);
                    flsOutput.Write(bytBlob, 0, bytBlob.Length);

                    flsOutput.Close();

                    Process.Start(Environment.GetEnvironmentVariable("TEMP").ToString() + ExtractFileName(txtPath.Text));
                }
                catch (Exception ocException)
                {


                }

                 */
                return;
            }

            frmReportViewer objChild = new frmReportViewer();
            objChild.MdiParent = this.MdiParent;
            objChild.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dtAccidentList = new DataTable();

            try
            {
                switch (Program.m_objReport.ReportId)
                {
                    case classReport.ReportIdType.reportCroquis:
                        dtAccidentList = dpHadiBusiness.GetAccidentImages(CommonClass.GetDateWithoutSlash(faDatePickerBegin.Text), CommonClass.GetDateWithoutSlash(faDatePickerEnd.Text), false, true);
                        break;
                    case classReport.ReportIdType.reportTrainArrangement:
                        dtAccidentList = dpHadiBusiness.GetAccidentImages(CommonClass.GetDateWithoutSlash(faDatePickerBegin.Text), CommonClass.GetDateWithoutSlash(faDatePickerEnd.Text), true, false);
                        break;
                    case classReport.ReportIdType.reportAccidentMedia:
                        dtAccidentList = dpHadiBusiness.GetAccidentMedia(CommonClass.GetDateWithoutSlash(faDatePickerBegin.Text), CommonClass.GetDateWithoutSlash(faDatePickerEnd.Text));
                        break;
                }

                grdEarlyAccident.DataSource = dtAccidentList.DefaultView;
                txtCount.Text = grdEarlyAccident.Rows.Count.ToString();

                //grdEarlyAccident.ColumnCount = 3;
                //for (int i = 3; i < dtAccidentList.Columns.Count; i++)
                //  grdEarlyAccident.Columns[i].Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkListAccident_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                //txtFooterTitle.Text = chkListAccident.Items[e.Index].ToString();
            }
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            txtTitr.Text = Program.m_objReport.Titr;
            txtHeaderTitle.Text = Program.m_objReport.SubTitle;
            txtFooterTitle.Text = Program.m_objReport.Footer;

            gbReportParameters.Visible = true;
            gbReportParameters.BringToFront();            
        }


        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == mniClear)
            {
                for (int i = 0; i < chkListAccident.Items.Count; i++)
                    chkListAccident.SetItemChecked(i, false);
            }
            else if (e.ClickedItem == mniAll)
            {
                for (int i = 0; i < chkListAccident.Items.Count; i++)
                    chkListAccident.SetItemChecked(i, true);
            }

        }

        private void chkListAccident_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    chkListAccident.DoDragDrop(chkListAccident.CheckedItems[0], DragDropEffects.Copy);
            }
            catch
            {
            }
        }

        private void listboxSortColumns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listboxSortColumns_DragDrop(object sender, DragEventArgs e)
        {

            listboxSortColumns.DisplayMember = "ColumnName";
            listboxSortColumns.ValueMember = "ColumnId";

            if (listboxSortColumns.Items.Count == 3)
            {
                MessageBox.Show("حداکثر 3 ستون می توانید انتخاب کنید");
            }
            else
            {
                if (listboxSortColumns.Items.Contains(((DataRowView)chkListAccident.SelectedItem)) == false)
                    //listboxSortColumns.Items.Add(((DataRowView)e.Data.GetData(typeof(DataRowView)))["ColumnName"]);
                    listboxSortColumns.Items.Add((DataRowView)chkListAccident.SelectedItem);
            }
        }

        private void listboxGroupColumns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listboxGroupColumns_DragDrop(object sender, DragEventArgs e)
        {

            listboxGroupColumns.DisplayMember = "ColumnName";
            listboxGroupColumns.ValueMember = "ColumnId";

            if (listboxGroupColumns.Items.Count == 4)
            {
                MessageBox.Show("حداکثر 4 گروه می توانید انتخاب کنید");
            }
            else
            {
                if (listboxGroupColumns.Items.Contains(((DataRowView)chkListAccident.SelectedItem)) == false)
                    listboxGroupColumns.Items.Add(((DataRowView)chkListAccident.SelectedItem));
            }
        }

        private void frmDialogReport_KeyUp(object sender, KeyEventArgs e)
        {
            setHotKey(e);
        }

        private void ShowImage(int nRow)
        {
            MemoryStream myStream = new MemoryStream();
            byte[] arrPicture;

            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter objbinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            Cursor = Cursors.WaitCursor;

            try
            {
                if (Program.m_objReport.ReportId == classReport.ReportIdType.reportCroquis)
                    arrPicture = (byte[])dpHadiBusiness.GetAccidentImageValue((int)(grdEarlyAccident["colRws_Fld_pk_EarlyAccident", nRow].Value), true);
                else
                    arrPicture = (byte[])dpHadiBusiness.GetAccidentImageValue((int)(grdEarlyAccident["colRws_Fld_pk_EarlyAccident", nRow].Value), false);

                myStream = new MemoryStream(arrPicture);

                ///<newformat>
                pictureBox1.Image = Image.FromStream(myStream);
            }
            catch (Exception ex)
            {
                if (myStream.Length > 0)
                {
                    /// <oldformat>
                    object obj = objbinaryFormatter.Deserialize(myStream);
                    this.pictureBox1.Image = (System.Drawing.Image)obj;
                }
                else
                    this.pictureBox1.Image = null;
            }

            Cursor = Cursors.Default;
        }

        private void grdEarlyAccident_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowImage(e.RowIndex);
            }
        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            MemoryStream myStream = new MemoryStream();

            if (grdEarlyAccident.CurrentRow.Index > -1)
            {
                ShowImage(grdEarlyAccident.CurrentRow.Index);

                try
                {
                    pictureBox1.Image.Save(myStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                    if (Program.m_objReport.ReportId == classReport.ReportIdType.reportCroquis)

                        dpHadiBusiness.UpdateAccidentMediaData((int)(grdEarlyAccident["colRws_Fld_pk_EarlyAccident", grdEarlyAccident.CurrentRow.Index].Value), (byte[])myStream.ToArray(), true);
                    else
                        dpHadiBusiness.UpdateAccidentMediaData((int)(grdEarlyAccident["colRws_Fld_pk_EarlyAccident", grdEarlyAccident.CurrentRow.Index].Value), (byte[])myStream.ToArray(), false);

                    myStream.Close();
                    MessageBox.Show("اطلاعات ذخیره شد");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
        private void chkcboEffective_CloseUp(object sender, EventArgs e)
        {
            DataView ocDataView;
            ocDataView = new DataView();


            ocDataView = objAccidentReasonData.Rws_Sp_Sel_All_AccidentReason.DefaultView;
            if (chkcboEffective.CheckedValues == null)
                ocDataView.RowFilter = "Rws_Fld_fk_AccidentEffective is null";
            else
                ocDataView.RowFilter = "Rws_Fld_fk_AccidentEffective in (" + string.Join(",", chkcboEffective.CheckedValues) + ")";

            chkcboReason.DropDownDataSource = ocDataView;
            chkcboReason.DropDownDisplayMember = AccidentReasonData.Rws_Fld_Reason;
            chkcboReason.DropDownValueMember = AccidentReasonData.Rws_Fld_Code;
            chkcboReason.CheckedValues = null;
        }



    }


}
