select top 100 * from 
[D00001].[STOK]

select top 100 * from 
[D00001].[STOK_BARKODLARI]

select top 100 * from  --warehouses
[D00001].DEPO

select top 100 * from     --vendors
[D00001].MUSTERILER    

select top 100 * from    --orders
[D00001].ALINAN_VERILEN_SIPARIS_B

select top 100 * from --orders
[d00001].ALINAN_VERILEN_SIPARIS_S


select *  from  [D00001].[STOK] mstr
right join [D00001].[STOK_BARKODLARI] dtl on dtl.STOK_ID=mstr.STOK_ID
--where mstr.STOK_ID is null




