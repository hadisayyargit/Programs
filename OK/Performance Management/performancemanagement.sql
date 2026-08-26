/*

-- server: OKDC32016
use AXDB
select * from hcmgoal
where 


--DESCRIPTION like N'%server%'
startdate between '2025-03-21' and '2025-04-20'
and OVERVIEW in ('G39','G49')

*/

select g.ACTUALVALUE,g.* 
--, d.PersianYearMonthInt
from hrm.Fact_HCMGOAL g with(nolock)
inner join com.DIM_Date d with(nolock) on d.id=g.[COM_DIM_DATE_StartDateRef]
where 
1=1 
and g.overview in ('G16')
and d.PersianYearMonthInt=140403
--and g.DESCRIPTION like N'%ارزیابی%'


select g.TARGETVALUE,ACTUALVALUE,d.persianyearmonthint,g.* , h.DESCRIPTION, p.Lastname
-- delete 
from hrm.Fact_HCMGOAL g
inner join hrm.DIM_HCMGOALHEADING h on h.ID=g.HRM_DIM_HCMGOALHEADINGRef
left join hrm.DIM_Personnel p on p.PersonnelCode=g.HRM_WorkerPersonnelCode
inner join com.DIM_Date d on d.id=g.[COM_DIM_DATE_StartDateRef]
Where 
1=1 
and g.OVERVIEW in ('g1')
 and d.persianyearmonthint=140307
order by OVERVIEW


/*


 select * from [FIN].[Dim_PLMainAccountGroups]
where 
1=1
--and ProfitLossGroupDS like N'%ثابت%'
 and MainAccountGroupDS like N'%ملک%'

 
select * from OKDWH_STG.Extract.HCMProfitLossMainAccount m 
where 
--m.NAME like N'%ملک%'
BKMAINACCOUNTID in ('82113201','7214','7208','821132')



 select d.PersianYearMonthInt,sum(amount) as sumofAmount from fin.Fact_ProfitLoss f with(nolock)
inner join com.DIM_Date d with(nolock) on d.id=f.COM_DIM_DateRef
inner join [FIN].[Dim_PLMainAccountGroups] g with(nolock) on g.id=f.FIN_DIM_MainAccountGroupRef
inner join OKDWH_STG.Extract.HCMProfitLossMainAccount m with(nolock) on m.ID=f.FIN_DIM_MainAccountRef
inner join [FIN].[DIM_CostCenter] c on c.ID=f.FIN_DIM_CostCenterRef
where d.PersianYearMonthInt=140303
and g.ProfitLossGroupDS=N'هزينه هاي ثابت'
and g.MainAccountGroupDS in (N'هزينه رهن واجاره')
and m.BKMAINACCOUNTID in ('82113201','7214','7208','821132')
and c.mdCostCenterTypeDS='انبار'
group by d.PersianYearMonthInt


*/



/*
;with cte1 as (select  ...)
 , cte2 as (select ...)
 , cte3 as (select cte1...., cte2... from cte1 inner join cte2 on cte1.)


 OKDC34027.OKSRV.IR\NODE
			*/

SELECT    {[Gross Weight], [Measures].[Amount]} ON 0,          {[Date].[Persian Year Month Int].[Persian Year Month Int].&[140403]} ON 1 FROM [WarehouseInputOutPut] WHERE (    {[To Location].[Type Name].[Type Name].[عادی]} *   {[Item].[Level1].[Level1].&[Beverages],    [Item].[Level1].[Level1].&[DPH],    [Item].[Level1].[Level1].&[Dry Food],    [Item].[Level1].[Level1].&[LHH],    [Item].[Level1].[Level1].&[OPSS],    [Item].[Level1].[Level1].&[Textile],    [Item].[Level1].[Level1].&[Tobacco Products]} *   {[Load Direction].[LoadDirection].[LoadDirection].[صادره]} *   {[From Location].[Type Name].[Type Name].&[انبار سرد],    [From Location].[Type Name].[Type Name].&[انبار خشک],    [From Location].[Type Name].[Type Name].&[انبار فریزری]}* EXCEPT([Item].[Level3].[Level3].MEMBERS,{[Item].[Level3].[Level3].[برنج ایرانی],[Item].[Level3].[Level3].[برنج خارجی],[Item].[Level3].[Level3].[آلایش گوساله],[Item].[Level3].[Level3].[آلایش گوسفند],[Item].[Level3].[Level3].[آلایش مرغ],[Item].[Level3].[Level3].[گوشت چرخ کرده],[Item].[Level3].[Level3].[گوشت سایر پرندگان],[Item].[Level3].[Level3].[گوشت گاو و گوساله],[Item].[Level3].[Level3].[گوشت گوسفند],[Item].[Level3].[Level3].[گوشت مرغ]}) )

 select * from com.dim_date d1 where d1.PersianYearMonthInt=140403
 
--  truncate table OKDWH_STG.Extract.hcmkpi1 
 select * from OKDWH_STG.Extract.hcmkpi1 k1  
 select * from OKDWH_STG.Extract.hcmkpi2 k2  
  select * from OKDWH_STG.Extract.hcmkpi3 k3  

 select * from OKDWH_STG.Extract.hcmkpi
  select * from OKDWH_STG.Extract.HCMKPIINFO
 select * from OKDWH_STG.Extract.HCMKPIICT

 -- truncate table OKDWH_STG.Extract.HCMKPI


select * from com.DIM_InventLocation l
where l.BKInventLocationId='OKS07257'


--okdc33027_node BI_InventTrend OKDWH_InventTrend 
--sp_TransactionsReport 

--IF OBJECT_ID('tempdb.dbo.##TransactionsReport') IS NOT NULL   DROP TABLE ##TransactionsRepo*rt
   DROP TABLE IF EXISTS ##TransactionsReport   
 CREATE TABLE ##TransactionsReport
(
    ITEMID VARCHAR(40),
 QTY decimal(12,3),
 DateFinancial nvarchar(10)

)

 INSERT INTO ##TransactionsReport
exec sp_TransactionsReport_BI @Warehouse='000901', @ReferenceID='0', @ItemID='',@Location = '',@InventSiteID = ''
,@IssueStatus = '',@ReceiptStatus = '',@Reference = '',@StartDate = '',@EndDate = ''   


select * from ##TransactionsReport

------------------------------------

  select * 
  ,ROW_NUMBER() over(partition by HRM_DIM_PersonnelRef  order by id desc ) as rownumber
  from okdwh.HRM.DIM_PersonnelHokm h
  where HRM_DIM_PersonnelRef=920301846
  and H.PersianStartYearMonth<=140306 and H.PersianEndYearMonth>=140306

  -------------------------------
  
select d.PersianYearMonthInt,sum(amount) as sumofAmount 
  from fin.Fact_ProfitLoss f with(nolock)
inner join com.DIM_Date d on d.id=f.COM_DIM_DateRef
where d.PersianYearMonthInt=140305
and f.FIN_DIM_MainAccountGroupRef in (118,119)
and f.FIN_DIM_MainAccountRef in (845)
group by d.PersianYearMonthInt 
--------------------------------
DROP TABLE IF EXISTS #Final
  select d.PersianYearMonthInt,amount 
  into #final 
  from fin.Fact_ProfitLoss f with(nolock)
inner join com.DIM_Date d on d.id=f.COM_DIM_DateRef
where d.PersianYearMonthInt=?
and f.FIN_DIM_MainAccountGroupRef in (118,119)
and f.FIN_DIM_MainAccountRef in (845)

select f.PersianYearMonthInt,sum(f.amount) as sumofAmount from #Final f with(nolock)
group by f.PersianYearMonthInt

-----------------------


select * from OKDWH_STG.Extract.HCMProfitLossMainAccount m with(nolock)
where  
m.BKMAINACCOUNTID  in ('612136')
    --m.name IN( N'درآمد خدمات پرتال')

---------------------------


select * from 
OKDWH_STG.Extract.HCMCommandment c
 inner join OKDWH.hrm.DIM_Department dep on dep.ID=c.DepId
where c.PersonnelId=6629
				 and dep.HRM_DIM_DistrictRef=4   --DistrictName='ستاد مرکزي'  
        and  dep.DepTypeSN=1    --and DepTypeDS='ستاد' 


select * from OKDWH_STG.extract.hcmkpiict



update hrm.Fact_HCMGOAL
set weight=?, targetvalue=?
where overview=? and COM_DIM_DATE_StartDateRef=?


select g.OVERVIEW, g.WEIGHT, g.TARGETVALUE, g.COM_DIM_DATE_StartDateRef, g.*
from okdwh.hrm.Fact_HCMGOAL g
where g.OVERVIEW in ('G5','G29','G43','G46','G31','G33','G36','G39','G40','G41','G49','G50','G52', 'G1606','G1607','G1614','G1615')


select g.OVERVIEW,d.ID as startdateref,g.WEIGHT, g.TARGET, g.WORKER, g.kpiunit
from Extract.HCMGOAL g
inner join OKDWH.COM.DIM_Date d on d.GregorianDate=g.STARTDATE


update hrm.Fact_HCMGOAL
set weight=?, targetvalue=?, KPIUNIT=?
where overview=? and COM_DIM_DATE_StartDateRef=?

 [RetailPos].ax.RetailTransactionPaymentTrans 

 -----------


  select d.PersianYearMonthInt,sum(amount) as sumofAmount from fin.Fact_ProfitLoss f with(nolock)
inner join com.DIM_Date d with(nolock) on d.id=f.COM_DIM_DateRef
inner join [FIN].[Dim_PLMainAccountGroups] g with(nolock) on g.id=f.FIN_DIM_MainAccountGroupRef
inner join OKDWH_STG.Extract.HCMProfitLossMainAccount m with(nolock) on m.ID=f.FIN_DIM_MainAccountRef
inner join [FIN].[DIM_CostCenter] c on c.ID=f.FIN_DIM_CostCenterRef
--where d.PersianYearMonthInt=140303
--and g.ProfitLossGroupDS=N'هزينه هاي ثابت'
--and g.MainAccountGroupDS in (N'هزينه رهن واجاره')
--and m.BKMAINACCOUNTID in ('82113201','7214','7208','821132')
--and c.mdCostCenterTypeDS='انبار'
where 
--m.BKMAINACCOUNTID='641132'
m.NAME like N'%انهدام%'
group by d.PersianYearMonthInt



select * from OKDWH_STG.Extract.HCMProfitLossMainAccount m
where m.BKMAINACCOUNTID='641132'
--m.NAME like N'%انهدام%'


;with cte1 as
( select actualvalue as TrolleyExit from OKDWH_STG.Extract.hcmkpi1 )
select count(*) as total , (select count(*)  from cte1 where  cte1.TrolleyExit<8) as under8
from cte1



