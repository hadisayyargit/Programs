select d.JalaliDate, p.* from 
hr.dimPersonnelInfo p
inner join bi.dimDate d on d.DateKey=p.BirthDateKey
where p.LastName like N'%پرچ%'
-------------

USE IRANIANKHODRO

; with cte1 as
(
select ROW_NUMBER() over (partition by [کد پرسنلی] order by p.[کد پرسنلی]) as rowno, *
from [dbo].[Employee_Information] p
)
select * from cte1

----------------

select distinct isnull( p.[دپارتمان] , N'نامشخص') as departmentName, isnull(p.[شناسه دپارتمان],0) as departmentid
, case when p.دپارتمان in (N'واحد فروش',N'واحد لیزینگ',N'واحد جایگزینی و خودرو کارکرده',N'تعمیرگاه ') then N'صف'
else N'ستاد'
end as deptype
from [dbo].[employee_st] p  --342


--------------------------------------------------------------------------


 select * from employee_st
 
---------------------------
select * from hr.EmployeeOrder e
where e.PersonnelId=10974

select * from hr.PersonnelInfo p
WHERE
p.LastDepartment=N'واحد طرح و برنامه-IT'
--PersonnelId='10974'
 --LastName like N'%اسکند%'


select * from HR.EmployeeAttendance
select * from hr.LookupTable
select * from hr.vw_EducationLevel
select distinct * from hr.Job
select distinct * from hr.Department
---------------------------------
 -- فعال
    WITH cte1 AS
(
    SELECT
        ROW_NUMBER() OVER(PARTITION BY personnelid ORDER BY OrderDateKey DESC) AS rowno,
        p.*
    FROM hr.EmployeeOrder p
    WHERE p.OrderDateKey <= 20251111  -- می‌توانی پارامترگذاری کنی در SQL
)
SELECT *
FROM cte1
WHERE rowno = 1
    AND DepartmentId = 13
    AND OrderTypeId <> 10;


  /*
    CountOfActive:=

VAR maxDate = [SelectedToDate]
VAR dept    = SELECTEDVALUE('Department'[DepartmentId])
RETURN
COUNTROWS (
    FILTER (
        VALUES('EmployeeOrder'[PersonnelId]),
        VAR lastKey =
            CALCULATE (
                MAX('EmployeeOrder'[OrderDateKey]),
                KEEPFILTERS('EmployeeOrder'[OrderDateKey] <= maxDate),
                ALLEXCEPT('EmployeeOrder','EmployeeOrder'[PersonnelId])
            )
        VAR lastType =
            CALCULATE (
                MIN('EmployeeOrder'[OrderTypeId]),
                KEEPFILTERS('EmployeeOrder'[OrderDateKey] = lastKey),
                ALLEXCEPT('EmployeeOrder','EmployeeOrder'[PersonnelId])
            )
        VAR lastDept =
            CALCULATE (
                SELECTEDVALUE('EmployeeOrder'[DepartmentId]),
                KEEPFILTERS('EmployeeOrder'[OrderDateKey] = lastKey),
                ALLEXCEPT('EmployeeOrder','EmployeeOrder'[PersonnelId])
            )
        RETURN
            NOT ISBLANK(lastType) &&
            lastType <> 10 &&
            ( ISBLANK(dept) || lastDept = dept )
    )
)

  */

   --- قطع همکاری
  ;with cte1 as
  (
  select ROW_NUMBER() over (partition by personnelid order by sentencedatekey) as rowno, p.* from hr.PersonnelSentence p 
  where 
  --p.personnelid=10364
  --p.personnelid=10974  
    --and 
    p.sentencedatekey =
    (
      select max(p2.sentencedatekey) from hr.PersonnelSentence p2   
      where  p2.sentencedatekey between 20250622  and 20250922
      and  p2.personnelid=p.personnelid
  )
)
select * from cte1
where rowno=1
--and Department=N'واحد طرح و برنامه-IT'
and SentenceTypeId=10

-------------------------

  -------------------------------------

  use IRKBIZ

select * from Education.EducationCalandar
where id=220

select *
from Education.EducationCourse ec
where 
ec.Title like  
--CalendarId=220

select * from Education.CourseRegister cr
where 
--EducationCourseId=20
cr.PersonId=10862




select cl.id, cl.Calandar, cl.Title, cl.IsDelete, cl.DepartmentId, CL.IsDelete
, cl.Year, EC.ID, EC.StartDate, EC.EndDate, EC.Duration, EC.Title, EC.IsDelete
, CR.PersonId, CR.State
from Education.EducationCalandar cl
left join Education.EducationCourse ec on ec.CalendarId=cl.Id
left join Education.CourseRegister cr on cr.EducationCourseId=ec.Id
where 
--ec.StartDate>= '2025-03-21' and ec.EndDate <='2025-11-11'
--and 
cl.Title like '%UI%'


AND Isnull(CL.IsDelete,0)<>1
AND isnull(EC.IsDelete,0)<>1 
and CL.DepartmentId=13


/*
;with cte1 as
(
select * , DATEDIFF(MINUTE,a.fromdatetime, a.ToDatetime) as totalminutes
from hr.EmployeeAttendancePermit a
where 
a.fromdatekey between 20250923 and 20251022
and a.RequestType=N'مرخصی'
--and a.PersonnelId=10974
)
select 
--*
sum(totalminutes)/60.0 
from cte1


select sum(DATEDIFF(MINUTE,a.fromdatetime, a.ToDatetime))/60.0 as totalminutes
from hr.EmployeeAttendancePermit a
where 
a.fromdatekey between 20251023 and 20251121
and a.RequestType=N'مرخصی'


select * from bi.dimDate d
where d.JalaliYear=1404 and d.JalaliMonth=7
*/


-----------
select * from taradod a
where a.تاریخ='2025-12-01' and a.[کد پرسنلی]='10862'


---------------------


----------------
select * from hr.EmployeeAttendance a
where a.AttendanceDateKey=20251201 and a.PersonnelId=10862


-----------------------

/*
 IF OBJECT_ID('tempdb.dbo.##cte1') IS NOT NULL 
  DROP TABLE ##cte1

CREATE TABLE ##cte1
(
    Department	NVARCHAR(50),
    EmployeeID	int,
    CurrentDate	NVARCHAR(50),
    DayName	NVARCHAR(50),
    PersianDate	NVARCHAR(50),
    SpecialDayTitle	NVARCHAR(50),
    AttendanceFactorRef	NVARCHAR(50),
    CalcType	NVARCHAR(50),
    FactorTitle	NVARCHAR(50),
    [Value]	NVARCHAR(50),
    MeasurementUnitCode	NVARCHAR(50),
    IsHoliday	NVARCHAR(50),
    FactorOrder	NVARCHAR(50),
    Enter	NVARCHAR(50),
    EnterGate	NVARCHAR(50),
    [Exit] NVARCHAR(50),
    ExitGate	NVARCHAR(50),
    AttendanceStatus	NVARCHAR(50),
    ErrorMessage	NVARCHAR(50),
    RowNumber	NVARCHAR(50),
    EmployeeRef	NVARCHAR(50),
    AccessLevelDate	NVARCHAR(50),
    ShiftStartTime	NVARCHAR(50),
    ShiftEndTime	NVARCHAR(50),
    EmployeeCode	NVARCHAR(50),
    EmploymentNumber	NVARCHAR(50),
    FirstName	NVARCHAR(50),
    LastName NVARCHAR(50),

);
 INSERT INTO ##cte1
EXEC [sp_GetAttendance] 
     
@startdate = '2025-12-01'
, @enddate='2025-12-03'
, @employees = 856


SELECT * FROM ##cte1;






*/
-- برداشتن کرکترهای خاص برای تمیزکاری
select *, try_cast( replace(f.ShiftStartTime, nchar(8207), '') as time) as ConvertedShiftStartTime
-- ‏ 08:30
from hr.stageEmployeeAttendanceRow f
where f.EmployeeID=711
and f.CurrentDate >='2025-12-05'

---------------------------------




select sum(t.RowTotalHour)
from 
(
select  d.JalaliDate ,f.* 
, IIF( f.entertime<f.shiftstarttime and f.exittime>f.shiftendtime, DATEDIFF(hour, f.shiftstarttime,f.shiftendtime),RowTotalHour) as rowtotalhour2
from hr.factEmployeeAttendanceRow f
inner join bi.dimDate d on d.DateKey=f.AttendanceDateKey
where d.JalaliYear=1404 and d.JalaliMonth=8 
--and d.JalaliDateKey=14040901
and f.PersonnelId=10862

--and f.FactorTitle=N'pair' and f.AttendanceStatus=N'حضور'
--t.FactorTitle like N'%اضافه%'
--and AttendanceStatus like N'%مرخص%'
order by AttendanceDateKey


) t
--where 
-------------------
select a.* from hr.factEmployeeOrder a
inner join bi.dimDate d on d.DateKey=a.OrderDateKey
where
d.JalaliDateKey between 14040101 and 14040930
and a.OrderTypeId=3


select * from hr.dimJob
where JobPosition like N'%مشاور%'

select count(distinct c.personnelid) from
(
select b.* from hr.factEmployeeOrder b
inner join 
(
-- تاریخ آخرین حکم
select PersonnelId, max(OrderDateKey) as lastdatekey
from hr.factEmployeeOrder 
WHERE  --OrderDateKey <= 20250321
OrderDateKey <= 20251221
GROUP BY PersonnelId

) a on a.PersonnelId=b.PersonnelId and a.lastdatekey =b.OrderDateKey

where 
b.OrderTypeId<>10

--and b.PersonnelId=10974
) c

----------------
--- تبدیل ستون varbinary  به base64
    update hr.dimPersonnelInfo 
    set   PictureDataBase64='data:image/png;base64,' + CAST(CAST(N'' AS XML).value( 'xs:base64Binary(sql:column("PictureData"))',  'VARBINARY(MAX)') AS VARCHAR(MAX))
        where PersonnelId=10974

