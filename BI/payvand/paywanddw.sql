use PAYVANDDW





/*

select * from ConfigSet

select * from dimDate


select * from dimGeography where StateProvinceCode=1
select * from dimStores
select * from dimSuppliers

select * from dimProducts
where ProductName like N'%پاکستان%'

select * from dimcustomers

  select * from dimEmployees where 
  employeeId=10446
  -- and StoreKey=100 
  --FullName like N'%وحیدی%'
		





select s.*,e.FullName as employeeName,c.FirstName+ ' ' + c.LastName+ '-'+c.MobilePhone as customername, p.ProductName 
from factSales s
left join dimEmployees e on e.EmployeeKey=s.EmployeeKey
left join dimCustomers c on c.CustomerKey=s.CustomerKey
left join dimProducts p  on p.ProductKey=s.ProductKey
where s.CustomerKey is null
--e.EmployeeID=10446


select * from factInventory
WHERE DocDateKey=20230401

 select 
	count(*)   --16586628    20230621
    ,max(DocDateKey)  
	,sum(ProductQuantity)
	from  factInventory
where DocDateKey between  20210101 and 20210601


select 
	count(*) 	
	,max(TransactionKey)
	,max(SaleDateKey)  
	,sum(saleamount)
	from  factSales
where SaleDateKey between  20210101 and 20230707
--and TransactionType=1
--and TransactionType=0


update dimCustomers
set Gender=ISNULL(gender,1)
, MaritalStatus=ISNULL(MaritalStatus,1)


update dimEmployees
set Gender=ISNULL(gender,1)
, MaritalStatus=ISNULL(MaritalStatus,1)



update dimStores
set GeographyKey=108012
where GeographyKey is null


*/


select *
	
	from  factSales
where SaleDateKey >  20230729
--and TransactionKey=10040747


-- delete from  factSales where SaleDateKey >=  20230805



select * from dimGeography 
where GeographyKey=1

--StateProvinceCode=1



select 
	count(*) 	
	,max(TransactionKey)
	,max(SaleDateKey)  
	,sum(saleamount)
	from  factSales
where SaleDateKey between  20210101 and 20230707
--and TransactionType=1
--and TransactionType=0

select * from FactSales
where 
1=1
and SaleDateKey between  20230805 and 20230805
and ProductKey=48012572


select  * from dimstores s 
left join dimGeography g on g.GeographyKey=s.GeographyKey
where s.GeographyKey is null




 select --* 
	--count(*)   --16586628    20230621
    --,
	max(DocDateKey)  
	--,sum(ProductQuantity)
	from  factInventory
where DocDateKey between  20230805 and 20230805



 select stg.StartDateTime
 ,iif (stg.FinishDateTime>= CONVERT (date, GETDATE()),CONVERT (date, GETDATE()-1) , stg.FinishDateTime) as FinishDateTime
 from ConfigSet stg 
 where stg.tablename='inventory'