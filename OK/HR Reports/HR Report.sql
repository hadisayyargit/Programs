 --server: KOOROSHDB   
 use PERSONNEL

select * from vw_Personel_BPM p
where 
--p.Personelid=920301846
p.PersonelFamily like N'%ميرزا%' and p.PersOnelName like N'%%'
and StatusId=1
and Jensiat=1
and TitelJob not like '%فروشگاه%'


  --KOOROSHDB

  select 0,-1,p.depId ,p.EMail,  p.PersOnelName+' ' +p.PersonelFamily as fullname , p.Semat, p.JobId, p.TitelJob, p.sName, p.SectionName 
  From vw_Personel_BPM p
		  where StatusId=1 and 
		  --p.PersonelFamily like N'%اسدال%'
		  (
			  Semat like '%انبار%' 
			--Semat like '%hr%' 
			--Semat like '%منابع%' or 
			--Semat like '%hr%'
		  )
		  and email is not null and p.EMail <>''		
		   

------------------------------Overtime---اضافه کار----------------------
/*
select  a.Personelid,concat(PersOnelName,' ',PersonelFamily)PersonelName,TitelJob,
isnull(mdDistrictDS,Modirdep) as District,isnull(mdInventLocationAXDS,dep) as Location,round(ADDKar,0) Overtime
,(select round(avg(ADDKar),0)  from karkard where Datek between '0201' and '0205' and a.Personelid=Personelid)AvgOvertime1402
from karkard a 
inner join vw_Personel_BPM b on a.Personelid=b.Personelid
left join district c on b.depId=c.mddepsn
where datek='0207' 
and a.Personelid=205539


*/

-- Hadi 
--server: KOOROSHDB   DB: PERSONNEL

select top 30 a.Personelid,concat(PersOnelName,' ',PersonelFamily)PersonelName,TitelJob
,isnull(mdDistrictDS,Modirdep) as District,isnull(mdInventLocationAXDS,dep) as Location,round(ADDKar,0) Overtime140206
,(select round(avg(ADDKar),0)  from karkard where Datek between  Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgOvertime1402
from karkard a 
inner join vw_Personel_BPM b on a.Personelid=b.Personelid
left join district c on b.depId=c.mddepsn
where datek= Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') 
		--and a.Personelid=920301846
	and isnull(mdInventLocationAXDS,'')  like '%فروشگاه%'
	--and isnull(mdInventLocationAXDS,'')  like '%فرانچ%'
	--and isnull(mdInventLocationAXDS,dep)  like '%انبار%'

	--ستاد
	--and isnull(mdInventLocationAXDS,'')  not like '%فروشگاه%' and isnull(mdInventLocationAXDS,'')  not like '%فرانچ%' and isnull(mdInventLocationAXDS,dep) not like '%انبار%'
order by ADDKar desc

------------------------------------UnderTime----کسر کار---------------------
select top 30 a.Personelid,concat(PersOnelName,' ',PersonelFamily)PersonelName,TitelJob,
isnull(mdDistrictDS,Modirdep) as District,isnull(mdInventLocationAXDS,dep) as Location,dbo.inttotime(Kaserkar) UnderTime140205
,dbo.inttotime((select round(avg(Kaserkar),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid))UnderTime1402
from karkard a 
inner join vw_Personel_BPM b on a.Personelid=b.Personelid
left join district c on b.depId=c.mddepsn
where datek=Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR')  
and isnull(mdInventLocationAXDS,'') not like '%فروشگاه%'
--and isnull(mdDistrictDS,Modirdep) not like N'%عمليات زنجيره تامين%'
and isnull(mdInventLocationAXDS,dep) not like '%انبار%'
and StatusId=1
order by Kaserkar desc

-------------------------OffTime-----مرخصی-----------------

select top 30 a.Personelid,concat(PersOnelName,' ',PersonelFamily)PersonelName,TitelJob,
isnull(mdDistrictDS,Modirdep) as District,isnull(mdInventLocationAXDS,dep) as Location,dbo.inttotime(Morakhasi) OffTime140205
,dbo.inttotime((select round(avg(Morakhasi),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR')  and a.Personelid=Personelid))AvgOffTime1402
from karkard a 
inner join vw_Personel_BPM b on a.Personelid=b.Personelid
left join district c on b.depId=c.mddepsn
where datek=Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR')   
and isnull(mdInventLocationAXDS,'') not like '%فروشگاه%'
--and isnull(mdDistrictDS,Modirdep) not like N'%عمليات زنجيره تامين%'
and isnull(mdInventLocationAXDS,dep) not like '%انبار%'
and StatusId=1
order by Morakhasi desc  

------------------------------------Mission------ماموریت-----------------------------------
select top 30 a.Personelid,concat(PersOnelName,' ',PersonelFamily)PersonelName,TitelJob,
isnull(mdDistrictDS,Modirdep) as District,isnull(mdInventLocationAXDS,dep) as Location,(Mamoriat) missionDay140205
,((select round(avg(Mamoriat),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid))missionDay1402
from karkard a 
inner join vw_Personel_BPM b on a.Personelid=b.Personelid
left join district c on b.depId=c.mddepsn
where datek=Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and isnull(mdInventLocationAXDS,'') not like '%فروشگاه%'
--and isnull(mdDistrictDS,Modirdep) not like N'%عمليات زنجيره تامين%'
and isnull(mdInventLocationAXDS,dep) not like '%انبار%'
and StatusId=1
order by Mamoriat desc


-----------------Distance-------------
select top 30 A.[کد پرسنلی] AS PersonCode, A.نام + '' + a.[نام خانوادگی] as PersonFullName ,A.[فاصله تا فروشگاه فعلی] as Distance, A.[دپارتمان/فروشگاه فعلی] as StoreName
from AppRep_PIDAdress a
order by a.[فاصله تا فروشگاه فعلی] desc


----------Khorooji(Rizesh)-----------

--server= okcentralwh1
select   B.* from 
(
select A.tarkyear,A.tarkmonth,A.mdDistrictDS   , A.dep,count(A.hrPersonelCode)  as pcount  from
(select   md.hrPersonelName, md.hrPersonelFamily,md.dep, md.depId, md.DepTypeDS, md.DepTypeSN , md.hrPersonelCode,  md.hrPersonelTarkDate,md.hrUnActiveTypeDS, md.hrUnActiveTypeSN	
 ,md.SectionDS,md.RegionDS, left(md.hrPersonelTarkDate,4) as tarkyear, substring(md.hrPersonelTarkDate,5,2) as tarkmonth
 --,md.mdStoreSN,md.mdStoreDS
 ,m.mdDistrictDS
from OKMasterData.[dbo].[mdVWPersonel] md 
inner join mdDep d on d.mdDepNO=md.depId
inner join mdDistrict m on d.mdDistrictSN=m.mdDistrictSN
where md.hrUnActiveTypeSN is not null 
	and md.DepTypeSN not in (2,3)
) A		
	Group by A.tarkyear, A.tarkmonth,A.mdDistrictDS,A.dep
	
	) B
	order by B.tarkyear,B.pcount desc 
	

----------------- Extra Personnel -------------
-- server=OKDC34012\NODE
/*
select top 30 district.District,A.Location_ID,l.Location,A.YearMonth,A.ProposedPersonelCount, A.PersCountEnd,  A.ExtraPersonCount  from 
(
select     h.StoreID,h.Location_ID, h.YearMonth,h.ProposedPersonelCount, h.PersCountEnd, h.PersCountEnd-h.ProposedPersonelCount as ExtraPersonCount ,ROW_NUMBER() over(partition by storeid  order by yearmonth desc ) as rownumber
from BIETL..HRM_Fact2 H
where --h.StoreID in ('10.199')   and 
	YearMonth between  Format(GETDATE(), 'yyyy01','fa-IR') and Format(GETDATE(), 'yyyyMM','fa-IR')
	and PersCountEnd is not null
	
	) A
	inner  join OKDW.dim.Location L on A.storeid=L.StoreID AND L.FLAG='TRUE' and l.IsFranchise=0 and l.IsWHS=0
	inner join pos.dbo.InventLocationDistrict district on district.InventLocationId=A.Location_ID
	where a.rownumber=1 and a.ExtraPersonCount>0
	order by A.ExtraPersonCount  desc


select top 30 district.District,A.Location_ID,l.Location,A.YearMonth,A.ProposedPersonelCount, A.PersCountEnd,  A.ExtraPersonCount  from 
(
select     h.StoreID,h.Location_ID, h.YearMonth,h.ProposedPersonelCount, h.PersCountEnd, h.PersCountEnd-h.ProposedPersonelCount as ExtraPersonCount ,ROW_NUMBER() over(partition by storeid  order by yearmonth desc ) as rownumber
from BIETL..HRM_Fact2 H
where --h.StoreID in ('10.199')   and 
	YearMonth between  Format(GETDATE(), 'yyyy01','fa-IR') and Format(GETDATE(), 'yyyyMM','fa-IR')
	and PersCountEnd is not null
	
	) A
	inner  join OKDW.dim.Location L on A.storeid=L.StoreID AND L.FLAG='TRUE' and l.IsFranchise=0 and l.IsWHS=0
	inner join pos.dbo.InventLocationDistrict district on district.InventLocationId=A.Location_ID
	where a.rownumber=1 and a.ExtraPersonCount<0
	order by A.ExtraPersonCount  asc
	
	*/

select  district.District
--, iif(sum(h.PersCountEnd-h.ProposedPersonelCount)>0,sum(h.PersCountEnd-h.ProposedPersonelCount),0) as ExtraPersonCount
--, iif(sum(h.PersCountEnd-h.ProposedPersonelCount)<0,sum(h.PersCountEnd-h.ProposedPersonelCount),0) as  shortagePersonCount 
, COUNT(  distinct cast(H.STOREID as nvarchar(10))  ) StoreCount
, COUNT(distinct IIF ( h.PersCountEnd-h.ProposedPersonelCount >0 , cast(H.STOREID as nvarchar(10)) ,null ) ) ExtraStoreCount
, COUNT(distinct IIF ( h.PersCountEnd-h.ProposedPersonelCount < 0 , cast(H.STOREID as nvarchar(10)) , null ) ) shortageStoreCount
, SUM  (IIF ( h.PersCountEnd-h.ProposedPersonelCount >0 , h.PersCountEnd-h.ProposedPersonelCount , 0 )) ExtraPersonCount
, SUM (IIF ( h.PersCountEnd-h.ProposedPersonelCount <0 , h.PersCountEnd-h.ProposedPersonelCount , 0 )) shortagePersonCount
--,ROW_NUMBER() over(partition by district.District  order by h.yearmonth desc ) as rownumber
from BIETL..HRM_Fact2 H
inner  join OKDW.dim.Location L on h.storeid=L.StoreID AND L.FLAG='TRUE' and l.IsFranchise=0 and l.IsWHS=0
inner join pos.dbo.InventLocationDistrict district on district.InventLocationId=h.Location_ID
where --h.StoreID in ('10.199')   and 
	--h.YearMonth between  FORMAT(DATEADD(MONTH, -1, getdate()),'yyyyMM', 'fa-IR') and FORMAT(DATEADD(MONTH, -1, getdate()),'yyyyMM', 'fa-IR')
	h.YearMonth between  '140206' and '140206'	
	--and district.District='کهگيلويه و بوير احمد'
	--and h.PersCountEnd<>h.ProposedPersonelCount
	group by district.District,h.YearMonth
	--order by h.PersCountEnd-h.ProposedPersonelCount  desc
	---------------------------
	select  district.District,h.Location_ID,l.Location
, SUM  (IIF ( h.PersCountEnd-h.ProposedPersonelCount >0 , h.PersCountEnd-h.ProposedPersonelCount , 0 )) ExtraPersonCount
, SUM (IIF ( h.PersCountEnd-h.ProposedPersonelCount <0 , h.PersCountEnd-h.ProposedPersonelCount , 0 )) shortagePersonCount

from BIETL..HRM_Fact2 H
inner  join OKDW.dim.Location L on h.storeid=L.StoreID AND L.FLAG='TRUE' and l.IsFranchise=0 and l.IsWHS=0
inner join pos.dbo.InventLocationDistrict district on district.InventLocationId=h.Location_ID
where --h.StoreID in ('10.199')   and 
	h.YearMonth between  FORMAT(DATEADD(MONTH, -1, getdate()),'yyyyMM', 'fa-IR') and FORMAT(DATEADD(MONTH, -1, getdate()),'yyyyMM', 'fa-IR')
	group by district.District,h.Location_ID,l.Location,h.YearMonth


----------------------All Statistics--------------

select dstrct1.mdDistrictDS, isnull(S1.locationcount,'') CountOfStores,isnull(S1.personnelcount,'') CountOfPersonnel, isnull(S1.avgovertime,'') AverageOfOverTime, isnull(S1.avgUndertime,'') AverageOfUnderTime, isnull(S1.avgofftime,'') AverageOfOffTime
, isnull(s2.ExtraPersonCount,'') StoresOverStaff,isnull(s2.shortagePersonCount,'') StoresUnderStaff
, isnull(setad.locationcount,'') CountOfSetadUnit,isnull(setad.personnelcount,'') CountOfSetadPersonnel, isnull(setad.avgovertime,'') AverageOfSetadOverTime, isnull(setad.avgUndertime,'') AverageOfSetadUnderTime, isnull(setad.avgofftime,'') AverageOfSetadOffTime
, isnull(R1.pcount,'') as CountofLoss, isnull(R2.pcount,'') as CountOfTend


from centralwh.OKMasterData.dbo.mddistrict dstrct1 
left join 
(
select 
M.mdDistrictSN
,Count(distinct M.Location) as locationcount
, count(distinct m.Personelid) personnelcount
,round( SUM(M.AvgOvertime1402)/count(distinct m.Personelid),0) as avgovertime
,dbo.inttotime( SUM(M.AvgUnderTime1402)/count(distinct m.Personelid)) as avgUndertime
,dbo.inttotime( SUM(M.AvgOffTime1402)/count(distinct m.Personelid)) as avgofftime
--,m.mdDepActivityTypeDS
--,M.mdDepActivityTypeSN
from
(
select  a.Personelid
,dep as Location
, dstrct.mdDistrictSN 
,deptyp.mdDepActivityTypeSN
,deptyp.mdDepActivityTypeDS
,(select round(avg(ADDKar),0)  from karkard where Datek between  Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgOverTime1402
,(select round(avg(Kaserkar),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgUnderTime1402
,(select round(avg(Morakhasi),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR')  and a.Personelid=Personelid) AvgOffTime1402

 from centralwh.OKMasterData.dbo.mddistrict dstrct 
 left join centralwh.okmasterdata.dbo.mdDep d  on d.mdDistrictSN=dstrct.mdDistrictSN
 left join karkard A on a.depid =d.mddepsn
 left join centralwh.OKMasterData.dbo.mdDepActivityType deptyp on deptyp.mdDepActivityTypeSN=d.mdDepActivityTypeSN 
 left join vw_Personel_BPM b on a.Personelid=b.Personelid
 
 where datek= Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') 
--and a.Personelid in (805002,920301846,920301094)
and StatusId=1
and deptyp.mdDepActivityTypeSN in (3)
--and dstrct.mdDistrictSN=20
)  M
Group by m.mdDistrictSN--,M.mdDepActivityTypeSN, M.mdDepActivityTypeDS
) S1  on S1.mdDistrictSN=dstrct1.mdDistrictsn

left join 
(
select 
M.mdDistrictSN
,Count(distinct M.Location) as locationcount, count(distinct m.Personelid) personnelcount
,round( SUM(M.AvgOvertime1402)/count(distinct m.Personelid),0) as avgovertime
,dbo.inttotime( SUM(M.AvgUnderTime1402)/count(distinct m.Personelid)) as avgUndertime
,dbo.inttotime( SUM(M.AvgOffTime1402)/count(distinct m.Personelid)) as avgofftime
--,m.mdDepActivityTypeDS
--,M.mdDepActivityTypeSN
from
(
select  a.Personelid
,dep as Location
,case dstrct.mdDistrictSN 
	when 38 then 36
	when 39 then 34
	when 40 then 31
	when 41 then 27
	when 42 then 23
	when 43 then 21
	when 44 then 19
	when 45 then 17
	else dstrct.mdDistrictSN
end mdDistrictSN
,deptyp.mdDepActivityTypeSN
,deptyp.mdDepActivityTypeDS
,(select round(avg(ADDKar),0)  from karkard where Datek between  Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgOverTime1402
,(select round(avg(Kaserkar),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgUnderTime1402
,(select round(avg(Morakhasi),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR')  and a.Personelid=Personelid) AvgOffTime1402

 from centralwh.OKMasterData.dbo.mddistrict dstrct 
 left join centralwh.okmasterdata.dbo.mdDep d  on d.mdDistrictSN=dstrct.mdDistrictSN
 left join karkard A on a.depid =d.mddepsn
 left join centralwh.OKMasterData.dbo.mdDepActivityType deptyp on deptyp.mdDepActivityTypeSN=d.mdDepActivityTypeSN 
 left join vw_Personel_BPM b on a.Personelid=b.Personelid
 
 where datek= Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') 
--and a.Personelid in (805002,920301846,920301094)
and StatusId=1
and deptyp.mdDepActivityTypeSN in (8)
)  M
Group by m.mdDistrictSN--,M.mdDepActivityTypeSN, M.mdDepActivityTypeDS
) setad  on setad.mdDistrictSN=dstrct1.mdDistrictsn

left join 
(select  district.District
, SUM  (IIF ( h.PersCountEnd-h.ProposedPersonelCount >0 , h.PersCountEnd-h.ProposedPersonelCount , 0 )) ExtraPersonCount
, SUM (IIF ( h.PersCountEnd-h.ProposedPersonelCount <0 , h.PersCountEnd-h.ProposedPersonelCount , 0 )) shortagePersonCount
--,ROW_NUMBER() over(partition by district.District  order by h.yearmonth desc ) as rownumber
from [OKBI].BIETL.dbo.HRM_Fact2 H
inner  join [OKBI].OKDW.dim.Location L on h.storeid=L.StoreID AND L.FLAG='TRUE' and l.IsFranchise=0 and l.IsWHS=0
inner join [OKBI].pos.dbo.InventLocationDistrict district on district.InventLocationId=h.Location_ID
where 
	h.YearMonth  between  Format(dateadd(month,-1,GETDATE()) , 'yyyyMM','fa-IR') and Format(dateadd(month,-1,GETDATE()) , 'yyyyMM','fa-IR')
	group by district.District,h.YearMonth
	--order by h.PersCountEnd-h.ProposedPersonelCount  desc
	) s2 on s2.District=dstrct1.mdDistrictDS

left join (
select A.tarkyear,A.mdDistrictSN  ,count(A.hrPersonelCode)  as pcount  from
(select   md.hrPersonelName, md.hrPersonelFamily, md.depId, md.DepTypeDS, md.DepTypeSN , md.hrPersonelCode,  md.hrPersonelTarkDate,md.hrUnActiveTypeDS, md.hrUnActiveTypeSN	
 ,md.SectionDS,md.RegionDS, left(md.hrPersonelTarkDate,4) as tarkyear, substring(md.hrPersonelTarkDate,5,2) as tarkmonth
 --,md.mdStoreSN,md.mdStoreDS
 ,m.mdDistrictDS, m.mdDistrictSN
from centralwh.OKMasterData.[dbo].[mdVWPersonel] md 
inner join centralwh.OKMasterData.[dbo].mdDep d on d.mdDepNO=md.depId
inner join centralwh.OKMasterData.[dbo].mdDistrict m on d.mdDistrictSN=m.mdDistrictSN
where md.hrUnActiveTypeSN is not null 
	and md.DepTypeSN not in (2,3)
	and md.hrPersonelTarkDate between  Format(dateadd(month,-1,GETDATE()) , 'yyyyMM01','fa-IR') and Format(dateadd(month,-1,GETDATE()) , 'yyyyMM31','fa-IR')
	

	) A		
	Group by A.tarkyear, A.mdDistrictsn
) R1 on R1.mdDistrictSN=dstrct1.mdDistrictSN
left join (
	select A.estekhdamyear,A.mdDistrictSN  ,count(A.hrPersonelCode)  as pcount  from
	(select md.hrPersonelCode, md.hrPersonelName, md.hrPersonelFamily,md.hrPersonelEstekhdamDate, md.hrPersonelIsActive, md.hrUnActiveTypeSN,md.hrUnActiveTypeDS
	, left(md.hrPersonelEstekhdamDate,4) as estekhdamyear
	 --,md.mdStoreSN,md.mdStoreDS
	 ,m.mdDistrictSN
	from centralwh.OKMasterData.[dbo].[mdVWPersonel] md 
	inner join centralwh.OKMasterData.[dbo].mdDep d on d.mdDepNO=md.depId
	inner join centralwh.OKMasterData.[dbo].mdDistrict m on d.mdDistrictSN=m.mdDistrictSN
	where --md.hrUnActiveTypeSN is not null 
		--and md.DepTypeSN not in (2,3)
		  md.hrPersonelEstekhdamDate between  Format(dateadd(month,-1,GETDATE()) , 'yyyyMM01','fa-IR') and Format(dateadd(month,-1,GETDATE()) , 'yyyyMM31','fa-IR')
	) A		
	Group by A.estekhdamyear, A.mdDistrictsn
)R2 on R2.mdDistrictsn=dstrct1.mdDistrictsn


where dstrct1.mdDistrictSN not in(4,37,38,39,40,41,42,43,44,45)
order by dstrct1.mdDistrictds


 -----------انبارها-----------
 select dtl.Location, count(distinct dtl.Personelid) personnelcount
,round( SUM(dtl.AvgOvertime1402)/count(distinct dtl.Personelid),0) as avgovertime
,dbo.inttotime( SUM(dtl.AvgUnderTime1402)/count(distinct dtl.Personelid)) as avgUndertime
,dbo.inttotime( SUM(dtl.AvgOffTime1402)/count(distinct dtl.Personelid)) as avgofftime  
from 
(select  a.Personelid
,dep as Location
, dstrct.mdDistrictds
,d.mdDepActivityTypeSN

,(select round(avg(ADDKar),0)  from karkard where Datek between  Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgOverTime1402
,(select round(avg(Kaserkar),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgUnderTime1402
,(select round(avg(Morakhasi),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR')  and a.Personelid=Personelid) AvgOffTime1402

 from karkard A
 left join vw_Personel_BPM b on a.Personelid=b.Personelid
 left join centralwh.okmasterdata.dbo.mdDep d on a.depid =d.mddepsn
 left join centralwh.OKMasterData.dbo.mddistrict dstrct on d.mdDistrictSN=dstrct.mdDistrictSN
 
 where datek= Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') 
--and a.Personelid in (805002,920301846,920301094)
and StatusId=1
and d.mdDepActivityTypeSN in (2,6,9)
--and A.Personelid=409027
) dtl
Group by dtl.Location


------------------------JOB-------------------

select dtl.TitelJob, count(distinct dtl.Personelid) personnelcount
,round( SUM(dtl.AvgOvertime1402)/count(distinct dtl.Personelid),0) as avgovertime
,dbo.inttotime( SUM(dtl.AvgUnderTime1402)/count(distinct dtl.Personelid)) as avgUndertime
,dbo.inttotime( SUM(dtl.AvgOffTime1402)/count(distinct dtl.Personelid)) as avgofftime  
from 
(

select  a.Personelid
,dep as Location
, dstrct.mdDistrictds
,d.mdDepActivityTypeSN

,(select round(avg(ADDKar),0)  from karkard where Datek between  Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgOverTime1402
,(select round(avg(Kaserkar),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') and a.Personelid=Personelid) AvgUnderTime1402
,(select round(avg(Morakhasi),0)  from karkard where Datek between Format(GETDATE(), 'yy01','fa-IR') and  Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR')  and a.Personelid=Personelid) AvgOffTime1402

, B.TitelJob
 from karkard A
 left join vw_Personel_BPM b on a.Personelid=b.Personelid
 left join centralwh.okmasterdata.dbo.mdDep d on a.depid =d.mddepsn
 left join centralwh.OKMasterData.dbo.mddistrict dstrct on d.mdDistrictSN=dstrct.mdDistrictSN
 
 where datek= Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') 
--and a.Personelid in (805002,920301846,920301094)
and StatusId=1
--and d.mdDepActivityTypeSN in (2,6,9)
--and A.Personelid=409027

) dtl
Group by dtl.TitelJob

------------------------------

-------------- New 
/*
select * from 
 HRM.Fact_FunctionDuty


select  i.DistrictDS
, SUM  (IIF(ExtraPersonCount>0,i.ExtraPersonCount,0)) overstaff
, SUM  (IIF(ExtraPersonCount<0,i.ExtraPersonCount,0)) understaff
-- select * 
from 
 HRM.Fact_InventLocation i
where 
	persianYearMonth  between  Format(dateadd(month,-1,GETDATE()) , 'yyyyMM','fa-IR') and Format(dateadd(month,-1,GETDATE()) , 'yyyyMM','fa-IR')
	group by Districtds,persianYearMonth

*/


/*
38	ستاد منطقه 18
39	ستاد منطقه 10
40	ستاد منطقه 9
41	ستاد منطقه 4
42	ستاد منطقه 6
43	ستاد منطقه 7
44	ستاد منطقه 3
45	ستاد منطقه 8

	when 38 then 36 --
	when 39 then 34
	when 40 then 31
	when 41 then 27
	when 42 then 23
	when 43 then 21
	when 44 then 19
	when 45 then 17

	*/


	/*
	
/*
select  a.Personelid,  A.depid,140000+ a.DateK as Jalaliyearmonth
,b.JobId, b.TitelJob, b.PersOnelName,b.PersonelFamily
,A.ADDKar, a.Kaserkar/3600.0 as Kaserkar,a.Morakhasi/3600.0 as Morakhasi,a.Mamoriat
 from karkard A
 left join vw_Personel_BPM b on a.Personelid=b.Personelid
  where datek between Format(dateadd(month,-1, getdate()), 'yy01','fa-IR') and Format(dateadd(month,-1, getdate()), 'yyMM','fa-IR') 
and StatusId=1
and A.Personelid=5420
*/

select * from 
--vw_InventLocation
hrm.vw_mdDistrictUser
where OKUserId like N'%say%'


select * from hrm.mdDISTRICT

select  distinct a.Personnelid
/*
,a.DepartmentName
,a.DistrictId
, a.DistrictDS
,a.DepActivityTypeId
,a.OverTime,a.UnderTime,a.OffTime
, a.TitleJob
,PersianYearMonth
*/
--avg (a.OverTime)
 from [HRM].[Fact_PersonnelFunction] A
 where 
[DepActivityTypeId] in (3,4,5,7,8)
and JobId=3609
--3617
and PersianYearMonth=140208


select * from hrm.Fact_PersonnelFunction p
where p.Personnelid=5420 and PersianYearMonth=140207
	
	*/

	select * from 
	vw_InventLocation l
	where id=2380
	--OKS00803


	select * from 
	--vw_InventLocation l
	HRM.mdDepartment
	--where mddepds like N'%نكا%'
	--N'%انبار%'



--	select * from com.DIM_InventLocation where bkinventlocationid not like '%oks%' and right(BKInventLocationId,3) in ('101','102','103','104','201','301')
	--OKS06360