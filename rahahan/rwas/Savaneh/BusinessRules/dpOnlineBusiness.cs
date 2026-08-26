using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using RWAS.DataAccess;


namespace RWAS.BusinessRules
{
    public class dpOnlineBusiness
    {
        #region OnlineTransaction


        public static DataView GetOnlinePersonnel()
        {
            DataView dtResult=new DataView();

            try
            {
                dtResult = dpHadiData.GetDataTable(dpHadiData.m_OnlinePersonnelConnection, "uv_current_prs_main_info_shaghelin", "*", "", "").DefaultView;
            }
            catch
            {
            }

            return dtResult;
        }

        public static DataView GetOnlineTrain(int nTrainNo)
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwTrainInfo", "*", "grp_fld_trainno=" + nTrainNo.ToString(), "").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public static DataView GetOnlineTrain(int nTrainNo, string FromDate, string UntilDate)
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwTrainInfo", "*", "grp_fld_trainno=" + nTrainNo.ToString() + " And Grp_Fld_CreatedDate>='" + FromDate + "' And Grp_Fld_CreatedDate<='"+UntilDate+"'", "").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public static DataView GetOnlineDiesel(int nTrainNo)
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwDiesel", "*", "FromNo<=" + nTrainNo.ToString()+" And ToNo>="+nTrainNo.ToString(), "").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public static DataView GetOnlineWagon(int nTrainNo)
        {
            DataView dvResult = new DataView();

            try
            {
                //dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwWagonIdentity", "*", "Mms_Fld_fk_Wagon=" + nTrainNo.ToString(), "").DefaultView;
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwWagonIdentity", "*", "Mms_Fld_pk_serialno='" + nTrainNo.ToString()+"'", "").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public static DataView GetOnlineOtherRailvehicle(int nTrainNo, int VehicleKind)
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwTrainInfo", "*", "grp_fld_trainno=" + nTrainNo.ToString(), "").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }


        public static string GetRailwayVehiclePK(int RailwayVehicleNo, int VehicleKind)
        {
            string strResult = "";
            DataView myView = new DataView();

            switch (VehicleKind)
            {
                case 0:
                    break;

                ///مسافری
                case 1:
                case 2:
                    myView = dpOnlineBusiness.GetOnlineTrain(RailwayVehicleNo);
                    if (myView.Count > 0)
                        //strResult = myView[0]["Grp_Fld_pk_Train"].ToString();
                        strResult = myView[0]["Grp_Fld_TrainNo"].ToString();
                    break;

                ///لکوموتیو
                case 3:
                    myView = dpOnlineBusiness.GetOnlineDiesel(RailwayVehicleNo);
                    if (myView.Count > 0)
                        strResult = RailwayVehicleNo.ToString();
                    break;

                ///واگن باری
                case 7:
                    myView = dpOnlineBusiness.GetOnlineWagon(RailwayVehicleNo);
                    if (myView.Count > 0)
                        strResult = myView[0]["Mms_Fld_pk_SerialNo"].ToString();

                    break;
                default:
                    myView = dpOnlineBusiness.GetOnlineOtherRailvehicle(RailwayVehicleNo, 0);
                    if (myView.Count > 0)
                        //strResult = myView[0]["Grp_Fld_pk_Train"].ToString();
                        strResult = myView[0]["Grp_Fld_TrainNo"].ToString();
                    break;
            }

            return strResult;

        }

        public static string GetRailwayVehicleRepairDateBase(int RailwayVehicleNo, int VehicleKind)
        {
            string strResult = "";

            switch (VehicleKind)
            {

                ///لکوموتیو
                case 3:
                    try
                    {
                        strResult = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "vwRepairBase_Diesel", "Ent_Date_Shamsi", "Dizel_No=" + RailwayVehicleNo.ToString()).ToString();
                    }
                    catch
                    {
                    }
                    break;

                ///واگن باری
                case 7:
                    try
                    {
                        strResult = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "vwRepairBase_Wagon", "mms_fld_date", "Mms_Fld_fk_WagonNo=" + RailwayVehicleNo.ToString()).ToString();
                    }
                    catch
                    {
                    }

                    break;
         
            }

            return strResult;

        }

        public static string GetRailwayVehicleRepairDateSpecial(int RailwayVehicleNo, int VehicleKind)
        {
            string strResult = "";

            switch (VehicleKind)
            {

                ///لکوموتیو
                case 3:
                    try
                    {
                        strResult = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "vwRepairSpecial_Diesel", "Ent_Date_Shamsi", "Dizel_No=" + RailwayVehicleNo.ToString()).ToString();
                    }
                    catch
                    {
                    }
                     break;

                ///واگن باری
                case 7:
                     try
                     {
                         strResult = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "vwRepairSpecial_Wagon", "Mms_Fld_SpecialRepairDate", "Mms_Fld_fk_WagonNo=" + RailwayVehicleNo.ToString()).ToString();
                     }
                     catch
                     {
                     }

                    break;

            }

            return strResult;

        }

        #endregion
    }
}
