--kooroshdb
--Personnel
/**
پرسنلی -> 
امور اداری (
بسته به بخشی که گزارش گیرنده در آن قرار دارد ممکن است متفاوت باشد) 
-> گزارش سیستم -> طراحی گزارش -> حالت وضعیت غیر فعال را انتخاب کرده 
و ارسال به اکسل را انتخاب میکنیم.


**/



SELECT 
                V_rptpersonel.PersonelID AS Personelid, 
                V_rptpersonel.KartId AS KartId, 
                V_rptpersonel.PersOnelName AS PersOnelName, 
                V_rptpersonel.PersonelFamily AS PersonelFamily, 
                V_rptpersonel.IDNumber AS IDNumber, 
                V_rptpersonel.codemelli AS codeMelli, 
                V_rptpersonel.BirthDate AS BirthDate, 
                V_rptpersonel.realBirthDate AS realBirthDate, 
                V_rptpersonel.CityCode AS CityCode, 
                V_rptpersonel.CitySodoor AS CitySodoor, 
                V_rptpersonel.FatherName AS FatherName, 
                V_rptpersonel.jensiat AS jensiat, 
                V_rptpersonel.Vazeaitfamilly AS Vazeaitfamilly, 
                V_rptpersonel.WeddingDate AS WeddingDate, 
                V_rptpersonel.num_Chiled AS num_Chiled, 
                V_rptpersonel.VazeaitKhedmat AS vazeaitkhedmat, 
                V_rptpersonel.ResonMoeaf AS Resonmoeaf, 
                V_rptpersonel.Tel AS Tel, 
                V_rptpersonel.Mobile AS Mobile, 
                V_rptpersonel.TelZarory AS TelZarory, 
                V_rptpersonel.citysokonat AS citysokonat, 
                V_rptpersonel.Address AS Address, 
                V_rptpersonel.Address2 AS Address2, 
                V_rptpersonel.TypeOFSokonat AS TypeOfSokonat, 
                V_rptpersonel.Rahn AS Rahn, 
                V_rptpersonel.Ejareh AS Ejareh, 
                V_rptpersonel.BimehId AS BimehId, 
                V_rptpersonel.NumBimeh AS NumBimeh, 
                V_rptpersonel.HireDate AS HireDate, 
                V_rptpersonel.BooldGroup AS BooldGroup, 
                V_rptpersonel.Din AS Din, 
                V_rptpersonel.status AS status, 
                V_rptpersonel.Body AS Body, 
                V_rptpersonel.Semat AS Semat, 
                V_rptpersonel.appoint_date AS appoint_date, 
                V_rptpersonel.promotion_date AS promotion_date, 
                V_rptpersonel.flagBimehOlad AS flagBimehOlad, 
                V_rptpersonel.AccountNo AS AccountNo, 
                V_rptpersonel.BankName AS BankName, 
                V_rptpersonel.isjanbaz AS isjanbaz, 
                V_rptpersonel.perslastStekhdamname AS perslastStekhdamname, 
                V_rptpersonel.perslastSecname AS perslastSecname, 
                V_rptpersonel.LastDeparteman AS LastDeparteman, 
                V_rptpersonel.CodeMarkaz AS CodeMarkaz, 
                V_rptpersonel.Rotbeh AS Rotbeh, 
                V_rptpersonel.PerLastDepatmat AS PerLastDepatmat, 
                V_rptpersonel.Madrak AS Madrak, 
                V_rptpersonel.ReshteTahsili AS ReshteTahsili, 
                V_rptpersonel.MozdeMabna AS MozdeMabna, 
                V_rptpersonel.Mazaya AS Mazaya, 
                V_rptpersonel.MozdAndMazaya AS MozdAndMazaya, 
                V_rptpersonel.tarkdate AS Tarkdate, 
                V_rptpersonel.AlatTark AS alatTark, 
                V_rptpersonel.ActivityName AS ActivityName, 
                V_rptpersonel.Nationality AS Nationality, 
                V_rptpersonel.HireDate_GIG AS HireDate_GIG, 
                V_rptpersonel.BirthCertificateID AS BirthCertificateID, 
                V_rptpersonel.GharardaSdate AS GharardaSdate, 
                V_rptpersonel.GharardaEdate AS GharardaEdate, 
                V_rptpersonel.CodePosti AS CodePosti, 
                V_rptpersonel.tafzilijamecode AS tafzilijamecode, 
                V_rptpersonel.moeinjamecode AS moeinjamecode, 
                V_rptpersonel.perstafzili AS perstafzili, 
                V_rptpersonel.mamor AS mamor, 
                V_rptpersonel.CodeBors AS CodeBors, 
                V_rptpersonel.CodeRahgiri AS CodeRahgiri, 
                NULL
                FROM V_rptpersonel AS V_rptpersonel
WHERE (Status = 'غير فعال' and (isnull(dbo.PersLastsectionPid(PersonelID),0) = 0 or isnull(dbo.PersLastsectionPid(PersonelID),0) in(Select sectionid From section where (sectionid in(select sectionid from usersections where SourceId = 3 and userid = 1594)))))
ORDER BY personelid
