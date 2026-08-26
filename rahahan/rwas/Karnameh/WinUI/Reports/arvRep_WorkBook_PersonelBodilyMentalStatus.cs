using System;
using System.Data;
using System.Collections;
using DataDynamics.ActiveReports;
using RWAS.BusinessRules;
using RWAS.Common;

namespace RWAS.WinUI
{
	public class arvRep_WorkBook_PersonelBodilyMentalStatus : ActiveReport
	{
		int intRepID;
		int _iRow;

		ArrayList arrValues;

		DS_Rep_WorkBookPersonelBodilyMentalStatus ocDS_Rep_WorkBookPersonelBodilyMentalStatus;

		#region arvRep_WorkBook_PersonelBodilyMentalStatus

		public arvRep_WorkBook_PersonelBodilyMentalStatus(int intRepID, string strRepTitle, ArrayList arrLstValues, string strHeader, string strFooter)
		{
			InitializeReport();

			this.intRepID = intRepID;
			arrValues = new ArrayList();
			this.arrValues = arrLstValues;

			lblRegion.Text = RWAS.WinUI.frmParent.strUserRegion;
			this.Document.Name = "";
		}
		#endregion arvRep_WorkBook_PersonelBodilyMentalStatus

		#region arvRep_WorkBook_PersonelBodilyMentalStatus_DataInitialize

        string[] GetStringArray(Array myArray)
        {
            string[] arrayResult = null;

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

		private void arvRep_WorkBook_PersonelBodilyMentalStatus_DataInitialize(object sender, System.EventArgs eArgs)
		{
			clsBRReportHandler objBRReportHandler = new clsBRReportHandler();
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

			try
			{
				ocDS_Rep_WorkBookPersonelBodilyMentalStatus = objBRReportHandler.SearchDataWorkBookPersonelBodilyMentalStatus(
					intRepID,
					arrayRegion,
					Convert.ToInt32(arrValues[1]),
					arrValues[2].ToString(),
					arrValues[3].ToString(),
					arraySubContractor,
					arrayEmployeeStatus,
					arrayStudyStatus,
					arrayOrgUnit,
					arrayJob,
					"",
					"",
					0
				);
				this.DataSource = ocDS_Rep_WorkBookPersonelBodilyMentalStatus.Rws_Sp_Rep_WorkBookPersonelBodilyMentalStatus.DefaultView;

				DataRow[] dr;
				dr = ocDS_Rep_WorkBookPersonelBodilyMentalStatus.Rws_Sp_Rep_WorkBookPersonelBodilyMentalStatus.Select("");
				if (dr.Length>0)
				{
					rowCount.Text = dr[0]["PersonelCount"].ToString();
					dayDate.Text = dr[0]["CurrentDate"].ToString();
				}
			}
			catch(Exception ocException)
			{
				throw (ocException);
			}
		}
		#endregion arvRep_WorkBook_PersonelBodilyMentalStatus_DataInitialize

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
		private DataDynamics.ActiveReports.Label Label3 = null;
		private DataDynamics.ActiveReports.Picture Picture1 = null;
		private DataDynamics.ActiveReports.Label Label4 = null;
		private DataDynamics.ActiveReports.TextBox dayDate = null;
		private DataDynamics.ActiveReports.Label lblRepTitle = null;
		private DataDynamics.ActiveReports.TextBox rowCount = null;
		private DataDynamics.ActiveReports.Label Label15 = null;
		private DataDynamics.ActiveReports.Label lblRegion = null;
		private DataDynamics.ActiveReports.GroupHeader ghPersonel = null;
		private DataDynamics.ActiveReports.Shape Shape1 = null;
		private DataDynamics.ActiveReports.Label Label20 = null;
		private DataDynamics.ActiveReports.TextBox TextBox14 = null;
		private DataDynamics.ActiveReports.Label Label11 = null;
		private DataDynamics.ActiveReports.TextBox TextBox6 = null;
		private DataDynamics.ActiveReports.Label Label6 = null;
		private DataDynamics.ActiveReports.TextBox TextBox5 = null;
		private DataDynamics.ActiveReports.Label Label7 = null;
		private DataDynamics.ActiveReports.TextBox TextBox3 = null;
		private DataDynamics.ActiveReports.GroupHeader ghDetail = null;
		private DataDynamics.ActiveReports.Shape Shape = null;
		private DataDynamics.ActiveReports.Label Label8 = null;
		private DataDynamics.ActiveReports.Label Label13 = null;
		private DataDynamics.ActiveReports.Label Label = null;
        private DataDynamics.ActiveReports.Label Label00 = null;
		private DataDynamics.ActiveReports.Label Label1 = null;
		private DataDynamics.ActiveReports.Detail Detail = null;		
		private DataDynamics.ActiveReports.Line Line7 = null;
		private DataDynamics.ActiveReports.Line Line8 = null;
		private DataDynamics.ActiveReports.TextBox txtRow = null;
        private DataDynamics.ActiveReports.TextBox txtDate = null;
		private DataDynamics.ActiveReports.TextBox TextBox1 = null;
        private DataDynamics.ActiveReports.TextBox txtHealthItem = null;
		private DataDynamics.ActiveReports.TextBox TextBox2 = null;
		private DataDynamics.ActiveReports.Line Line1 = null;
		private DataDynamics.ActiveReports.GroupFooter gfDetail = null;
		private DataDynamics.ActiveReports.GroupFooter gfPersonel = null;
		private DataDynamics.ActiveReports.ReportFooter ReportFooter = null;
		public void InitializeReport()
		{
            this.LoadLayout(this.GetType(), "RWAS.WinUI.Reports.arvRep_WorkBook_PersonelBodilyMentalStatus.rpx");
            
			this.ReportHeader = ((DataDynamics.ActiveReports.ReportHeader)(this.Sections["ReportHeader"]));
			this.ghPersonel = ((DataDynamics.ActiveReports.GroupHeader)(this.Sections["ghPersonel"]));
			this.ghDetail = ((DataDynamics.ActiveReports.GroupHeader)(this.Sections["ghDetail"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.gfDetail = ((DataDynamics.ActiveReports.GroupFooter)(this.Sections["gfDetail"]));
			this.gfPersonel = ((DataDynamics.ActiveReports.GroupFooter)(this.Sections["gfPersonel"]));
			this.ReportFooter = ((DataDynamics.ActiveReports.ReportFooter)(this.Sections["ReportFooter"]));
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[0]));
			this.Picture1 = ((DataDynamics.ActiveReports.Picture)(this.ReportHeader.Controls[1]));
			this.Label4 = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[2]));
			this.dayDate = ((DataDynamics.ActiveReports.TextBox)(this.ReportHeader.Controls[3]));
			this.lblRepTitle = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[4]));
			this.rowCount = ((DataDynamics.ActiveReports.TextBox)(this.ReportHeader.Controls[5]));
			this.Label15 = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[6]));
			this.lblRegion = ((DataDynamics.ActiveReports.Label)(this.ReportHeader.Controls[7]));
			this.Shape1 = ((DataDynamics.ActiveReports.Shape)(this.ghPersonel.Controls[0]));
			this.Label20 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[1]));
			this.TextBox14 = ((DataDynamics.ActiveReports.TextBox)(this.ghPersonel.Controls[2]));
			this.Label11 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[3]));
			this.TextBox6 = ((DataDynamics.ActiveReports.TextBox)(this.ghPersonel.Controls[4]));
			this.Label6 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[5]));
			this.TextBox5 = ((DataDynamics.ActiveReports.TextBox)(this.ghPersonel.Controls[6]));
			this.Label7 = ((DataDynamics.ActiveReports.Label)(this.ghPersonel.Controls[7]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.ghPersonel.Controls[8]));
			this.Shape = ((DataDynamics.ActiveReports.Shape)(this.ghDetail.Controls[0]));
			this.Label8 = ((DataDynamics.ActiveReports.Label)(this.ghDetail.Controls[1]));
			this.Label13 = ((DataDynamics.ActiveReports.Label)(this.ghDetail.Controls[2]));
			this.Label = ((DataDynamics.ActiveReports.Label)(this.ghDetail.Controls[3]));
            this.Label00 = ((DataDynamics.ActiveReports.Label)(this.ghDetail.Controls[4]));
			this.Label1 = ((DataDynamics.ActiveReports.Label)(this.ghDetail.Controls[5]));			
			this.Line7 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[0]));
			this.Line8 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[1]));
			this.txtRow = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[2]));
            this.txtDate = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[3]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[4]));
            this.txtHealthItem = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[5]));
			this.TextBox2 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[6]));
            
			this.Line1 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[7]));
			// Attach Report Events
			this.DataInitialize += new System.EventHandler(this.arvRep_WorkBook_PersonelBodilyMentalStatus_DataInitialize);
			this.ghPersonel.Format += new System.EventHandler(this.ghPersonel_Format);
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
		}

		#endregion
	}
}

