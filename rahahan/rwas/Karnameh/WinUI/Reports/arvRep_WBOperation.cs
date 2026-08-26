using System;
using System.Data;
using System.Collections;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using RWAS.BusinessRules;
using RWAS.Common;


namespace RWAS.WinUI
{
	public class arvRep_WBOperation : ActiveReport
	{
		int intRepID;
		ArrayList arrValues;
        ArrayList arrChartOption;
		//Row Count
		private int _iRow;

		DS_Rep_Operation ocDS_Rep_Operation;

		#region arvRep_WBOperation
        public arvRep_WBOperation(int intRepID, string strRepTitle, ArrayList arrLstValues, ArrayList arrChartOption, string strHeader, string strFooter)
		{
			InitializeReport();

			arrValues = new ArrayList();
			this.arrValues = arrLstValues;
            this.arrChartOption = arrChartOption;
			this.intRepID = intRepID;

			lblRepTitle.Text = strRepTitle;
			if (strHeader.Trim()!= "")
				lblRepTitle.Text = strHeader;
			if (strFooter.Trim()!="")
				lblFooter.Text = strFooter;


			lblRegion.Text = RWAS.WinUI.frmParent.strUserRegion;
			this.Document.Name = "";
		}
		#endregion arvRep_WBOperation

		#region arvRep_WBOperation_DataInitialize

        string[] GetStringArray(Array myArray)
        {
            string[] arrayResult=null;

            if (myArray != null)
            {
                arrayResult = new string[myArray.Length];

                int i = 0;
                foreach (object myelement in myArray)
                {
                    arrayResult.SetValue(myelement.ToString(), i);
                    i++;
                }
            }

            return arrayResult;
        }

        private void arvRep_WBOperation_DataInitialize(object sender, System.EventArgs eArgs)
        {
            clsBRReportHandler objBRReportHandler = new clsBRReportHandler();
            try
            {
                string[] arrayRegion = null;
                string[] arraySubContractor = null;
                string[] arrayEmployeeStatus = null;
                string[] arrayStudyStatus = null;
                string[] arrayOrgUnit = null;
                string[] arrayJob = null;

                arrayRegion = GetStringArray((object[])arrValues[0]);
                arraySubContractor = GetStringArray((object[])arrValues[4]);
                arrayEmployeeStatus = GetStringArray((object[])arrValues[5]);
                arrayStudyStatus = GetStringArray((object[])arrValues[6]);
                arrayOrgUnit = GetStringArray((object[])arrValues[7]);
                arrayJob = GetStringArray((object[])arrValues[8]);

                /*
                if (arrValues[0] != null)
                {
                    arrayRegion=new byte[((object[])arrValues[0]).Length];
                    ((object[])arrValues[0]).CopyTo(arrayRegion, 0);
                }

                                               
                */
                
                ocDS_Rep_Operation = objBRReportHandler.SearchDataOperation(
                    intRepID,arrayRegion,Convert.ToInt32(arrValues[1]),arrValues[2].ToString(),arrValues[3].ToString(),
                    arraySubContractor,
                    arrayEmployeeStatus                    ,
                    arrayStudyStatus,
                    arrayOrgUnit,
                    arrayJob
                    );

                
                this.DataSource = ocDS_Rep_Operation.Rws_Sp_Rep_Operation.DefaultView;
                DataRow[] dr;
                dr = ocDS_Rep_Operation.Rws_Sp_Rep_Operation.Select("");
                if (dr.Length > 0)
                {
                    rowCount.Text = dr[0]["PersonelCount"].ToString();
                    dayDate.Text = dr[0]["CurrentDate"].ToString();
                }
            }
            catch (Exception ocException)
            {
                throw (ocException);
            }
        }

		#endregion arvRep_WBOperation_DataInitialize

		private void arvRep_WBOperation_ReportStart(object sender, System.EventArgs eArgs)
		{
			//Set row count to 0.
//			this._iRow = 0;
		}

		private void ghPersonel_Format(object sender, System.EventArgs eArgs)
		{
			_iRow = 0;
		}

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			// Check _iRow value to see if we need to highlight the row or not.
			//			if(this._iRow%2 == 0)
			//				this.Detail.BackColor = Color.Transparent; 
			//			else
			//				this.Detail.BackColor = Color.LightYellow;
			this._iRow++;
			this.txtRow.Text = this._iRow.ToString(System.Globalization.CultureInfo.CurrentCulture);
		}

		#region ActiveReports Designer generated code

		private DataDynamics.ActiveReports.ReportHeader ReportHeader = null;
		private DataDynamics.ActiveReports.Label Label1 = null;
		private DataDynamics.ActiveReports.Picture Picture1 = null;
		private DataDynamics.ActiveReports.Label Label3 = null;
		private DataDynamics.ActiveReports.TextBox dayDate = null;
		private DataDynamics.ActiveReports.Label lblRepTitle = null;
		private DataDynamics.ActiveReports.TextBox rowCount = null;
		private DataDynamics.ActiveReports.Label Label15 = null;
		private DataDynamics.ActiveReports.Label lblRegion = null;
		private DataDynamics.ActiveReports.PageHeader PageHeader = null;
		private DataDynamics.ActiveReports.GroupHeader ghPersonel = null;
		private DataDynamics.ActiveReports.Shape shpPGHeader = null;
		private DataDynamics.ActiveReports.Label Label6 = null;
		private DataDynamics.ActiveReports.TextBox TextBox1 = null;
		private DataDynamics.ActiveReports.TextBox TextBox2 = null;
		private DataDynamics.ActiveReports.Label Label7 = null;
		private DataDynamics.ActiveReports.TextBox TextBox3 = null;
		private DataDynamics.ActiveReports.Label Label11 = null;
		private DataDynamics.ActiveReports.Shape Shape = null;
		private DataDynamics.ActiveReports.Label Label2 = null;
		private DataDynamics.ActiveReports.Label Label9 = null;
		private DataDynamics.ActiveReports.Label Label10 = null;
		private DataDynamics.ActiveReports.Label Label12 = null;
		private DataDynamics.ActiveReports.Label Label = null;
		private DataDynamics.ActiveReports.Label Label5 = null;
		private DataDynamics.ActiveReports.Label Label8 = null;
		private DataDynamics.ActiveReports.Label Label13 = null;
		private DataDynamics.ActiveReports.Label Label14 = null;
		private DataDynamics.ActiveReports.Label Label16 = null;
		private DataDynamics.ActiveReports.Detail Detail = null;
		private DataDynamics.ActiveReports.TextBox txtLeaveWithoutPay = null;
		private DataDynamics.ActiveReports.TextBox txtUID = null;
		private DataDynamics.ActiveReports.TextBox txtPID = null;
		private DataDynamics.ActiveReports.TextBox txtName = null;
		private DataDynamics.ActiveReports.TextBox txtYearMonth = null;
		private DataDynamics.ActiveReports.Line Line8 = null;
		private DataDynamics.ActiveReports.TextBox TextBox = null;
		private DataDynamics.ActiveReports.TextBox TextBox4 = null;
		private DataDynamics.ActiveReports.TextBox TextBox5 = null;
		private DataDynamics.ActiveReports.TextBox TextBox6 = null;
		private DataDynamics.ActiveReports.Line Line1 = null;
		private DataDynamics.ActiveReports.Line Line7 = null;
		private DataDynamics.ActiveReports.TextBox txtRow = null;
		private DataDynamics.ActiveReports.GroupFooter gfPersonel = null;
		private DataDynamics.ActiveReports.PageFooter PageFooter = null;
		private DataDynamics.ActiveReports.Label lblFooter = null;
		private DataDynamics.ActiveReports.ReportFooter ReportFooter = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "RWAS.WinUI.Reports.arvRep_WBOperation.rpx");
			this.ReportHeader = ((DataDynamics.ActiveReports.ReportHeader)(this.Sections["ReportHeader"]));
			this.PageHeader = ((DataDynamics.ActiveReports.PageHeader)(this.Sections["PageHeader"]));
			this.ghPersonel = ((DataDynamics.ActiveReports.GroupHeader)(this.Sections["ghPersonel"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.gfPersonel = ((DataDynamics.ActiveReports.GroupFooter)(this.Sections["gfPersonel"]));
			this.PageFooter = ((DataDynamics.ActiveReports.PageFooter)(this.Sections["PageFooter"]));
			this.ReportFooter = ((DataDynamics.ActiveReports.ReportFooter)(this.Sections["ReportFooter"]));
			this.Label1 = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[0]));
			this.Picture1 = ((DataDynamics.ActiveReports.Picture)(this.ReportHeader.Controls[1]));
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[2]));
			this.dayDate = ((DataDynamics.ActiveReports.TextBox)(this.ReportHeader.Controls[3]));
			this.lblRepTitle = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[4]));
			this.rowCount = ((DataDynamics.ActiveReports.TextBox)(this.ReportHeader.Controls[5]));
			this.Label15 = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[6]));
			this.lblRegion = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[7]));
			this.shpPGHeader = ((DataDynamics.ActiveReports.Shape)(this.ghPersonel.Controls[0]));
			this.Label6 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[1]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.ghPersonel.Controls[2]));
			this.TextBox2 = ((DataDynamics.ActiveReports.TextBox)(this.ghPersonel.Controls[3]));
			this.Label7 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[4]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.ghPersonel.Controls[5]));
			this.Label11 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[6]));
			this.Shape = ((DataDynamics.ActiveReports.Shape)(this.ghPersonel.Controls[7]));
			this.Label2 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[8]));
			this.Label9 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[9]));
			this.Label10 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[10]));
			this.Label12 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[11]));
			this.Label = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[12]));
			this.Label5 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[13]));
			this.Label8 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[14]));
			this.Label13 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[15]));
			this.Label14 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[16]));
			this.Label16 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[17]));
			this.txtLeaveWithoutPay = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[0]));
			this.txtUID = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[1]));
			this.txtPID = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[2]));
			this.txtName = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[3]));
			this.txtYearMonth = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[4]));
			this.Line8 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[5]));
			this.TextBox = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[6]));
			this.TextBox4 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[7]));
			this.TextBox5 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[8]));
			this.TextBox6 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[9]));
			this.Line1 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[10]));
			this.Line7 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[11]));
			this.txtRow = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[12]));
			this.lblFooter = ((DataDynamics.ActiveReports.Label)(this.PageFooter.Controls[0]));
			// Attach Report Events
			this.DataInitialize += new System.EventHandler(this.arvRep_WBOperation_DataInitialize);
			this.ReportStart += new System.EventHandler(this.arvRep_WBOperation_ReportStart);
			this.ghPersonel.Format += new System.EventHandler(this.ghPersonel_Format);
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
		}

		#endregion
	}
}

