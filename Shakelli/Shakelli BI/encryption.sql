
/*
select *
from  AppUser


update appUser
set EncryptedPassword=ENCRYPTBYPASSPHRASE('123',[password])

select *,ENCRYPTBYPASSPHRASE('123',[password])   as pass2 ,cast(decryptBYPASSPHRASE('123',ENCRYPTBYPASSPHRASE('123',[password])) as varchar)
from AppUser 

create symmetric key skey1
with algorithm =triple_des
encryption by password='hx_1323027'

open symmetric key skey1 decryption by password='hx_1323027' 

update appUser
set EncryptedPassword=ENCRYPTBYkey(KEY_GUID('skey11'),[Password])   

select *,cast(decryptbykey(EncryptedPassword) as varchar)
from AppUser

close symmetric key skey1


--create master key encryption by password='123'


create asymmetric key pkey1
--FROM FILE = 'c:\PacSales\Managers\ChristinaCerts.tmp'  
with algorithm =rsa_512
encryption by password='hx_1323027'



update appUser
set EncryptedPassword=ENCRYPTBYasymkey(asymKEY_ID('pkey1'),[Password])   


select *,cast(decryptbyasymkey(asymKEY_ID('pkey1'),EncryptedPassword, N'hx_1323027') as varchar)
from AppUser


create certificate cert1
encryption by password='hx_1323027' 
with subject='hadi certificate'
,start_date='2015-02-01', expiry_date='2015-03-01'


update appUser
set EncryptedPassword=ENCRYPTBYCERT(cert_ID('cert1'),[Password])   


select *,cast(decryptbycert(cert_ID('cert1'),EncryptedPassword, N'hx_1323027') as varchar)
from AppUser

*/