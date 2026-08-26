

 /*
   

  select * from com.DIM_Item
  where 
  --BKItemId='6260447114997'
  id=5847
  -- i.Name like N'%کوکا%'


   select * from COM.DIM_Date
   where id=20230321

select * from [Conf].[ModuleNames] 
where PackageName='Package_FactInternalReceipt' and TableName='Fact_InternalReceipt'

--update [Conf].[ModuleNames] set LastValue=20230321  where PackageName='Package_FactInternalReceipt' and TableName='Fact_InternalReceipt'

 select * from com.DIM_Vendor
 where VendName like N'%آوا پروت%' or VendName like N'%سبوس%'

select * from com.DIM_InventLocation
where [name] like N'%آبشناسان%'


select FORMAT(getdate(), 'yyyyMM')
SELECT FORMAT(DATEADD(MONTH, -1, getdate()),'yyyyMM')

--SELECT Format(GETDATE(), 'yyMM','fa-IR')

--SELECT MONTH(DATEADD(MONTH, -1, CURRENT_TIMESTAMP));

--SELECT Format(GETDATE(), 'yyMM','fa-IR'),Format(GETDATE(), 'yy01','fa-IR')

select MONTH(getdate()-30)
--select CAST('2023-01-01' as date)


select * from [SCM].[Fact_VendorServiceLevel] sl
where sl.PurchId='POL99111616438'  and COM_DIM_ItemRef=1318



*/




