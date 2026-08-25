using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using shahriarco.Anbar.Models;
using System.Data;

namespace shahriarco.Anbar
{
    public partial class ReportViewerPage : System.Web.UI.Page
    {

        AnbarEntities db = new AnbarEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReportModel myReportModel = new ReportModel();


                try
                {

                    myReportModel = (ReportModel)Session[shahriarco.CommonUnit.GeneralModule.m_ReportModel];

                    ReportViewer1.ProcessingMode = ProcessingMode.Local;

                    ReportViewer1.LocalReport.ReportPath = myReportModel.UrlPath;

                    ReportViewer1.LocalReport.DataSources.Clear();

                    switch (myReportModel.ReportName.ToLower())
                    {
                        case "rptanbar":
                            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetAnbar"));
                            //var myReportData1= db.QAnbar.ToList();

                            /*
                            int n = 0;
                            object[] pp = new object[mySqlParameters.Count];
                            foreach (SqlParameter p in mySqlParameters)
                            {
                                myQuery = myQuery + "," + p.ParameterName + "={" + n.ToString() + "}";

                                pp[n] = p.Value;
                                n++;
                            }

                            if (myQuery[0] == ',')
                                myQuery = myQuery.Substring(1);

                            myQuery = myReportModel.StoredProcedure + " " + myQuery;
                            Session[CommonUnits.GeneralModule.m_postReportData] = db.Database.SqlQuery<postReportData>(myQuery, pp).ToList();
                            */

                            string myQuery = "select * from QAnbar";

                            ///روش مستقیم
                            /// نمیتوان استفاده کرد برای ستونهای دارای نام عددی چون نوع باید مشخص باشد 

                            //object[] pp = new object[1];
                            //var myReportData1 = db.Database.SqlQuery<PostData>(myQuery, pp).ToList();
                            //var tt = Type.GetType("MyProject.DAL." + vo.objReport.sBaseView);

                            ///روش linq
                            DataTable dt = new DataTable();
                            System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand();
                            System.Data.SqlClient.SqlDataAdapter myAdapter = new System.Data.SqlClient.SqlDataAdapter();
                            myCommand.Connection = (System.Data.SqlClient.SqlConnection)db.Database.Connection;
                            myCommand.CommandText = myQuery;
                            myAdapter.SelectCommand = myCommand;
                            myAdapter.Fill(dt);



                            /// روش حلقه
                            /// کند ولی جواب میدهد
                            var myReportData1 = new List<PostData>();
                            for (int i = 0; i < dt.Rows.Count; i++)
                                myReportData1.Add(new PostData { RowNo = 1, column1Name = "AnbarName", column1Value = "انبار1", column1Type = "string", column2Name = "TedadKala", column2Value = "12345", column2Type = "int" });



                            //var list1 = (from DataRow row in dt.Rows
                            //             select new PostData
                            //             {                                            
                            //                 column1Name = row.Table.Columns[1].ColumnName.ToString()
                            //                 ,
                            //                 column1Value = row[1].ToString()
                            //                 ,
                            //                 column2Name = row.Table.Columns[2].ColumnName.ToString()
                            //                 ,
                            //                 column2Value = row[2].ToString()
                            //             }).ToList();


                            //dt.Columns[2].ColumnName = "column2Value";
                            //var list2 = dt.AsEnumerable().ToList();




                            ReportViewer1.LocalReport.DataSources[0].Value = myReportData1;

                            break;
                        case "rptkala":
                            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetKala"));
                            var myReportData2 = db.QKala.ToList();

                            //string myQuery2 = "select * from QKala";
                            ReportViewer1.LocalReport.DataSources[0].Value = myReportData2;

                            break;
                    }


                    this.ReportViewer1.DataBind();


                    //ReportParameterInfoCollection myParameters = ReportViewer1.LocalReport.GetParameters();
                    //if (myParameters.Count() > 0)
                    //    ReportViewer1.LocalReport.SetParameters(myReportModel.ReportParameters);

                    //Session["localreport"] = ReportViewer1.LocalReport;

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}