VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "MoraseleCost"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "SavedWithClassBuilder6" ,"Yes"
Attribute VB_Ext_KEY = "Top_Level" ,"Yes"
Option Explicit
Option Base 1

Dim GroundCityLetter(7)                     As New GroundMoraseleClass
Dim GroundInterCityLetter(7)                As New GroundMoraseleClass
Dim GroundInternationalLetter(6)            As New GroundMoraseleClass
Dim GroundCityNewsLetter(7)                 As New GroundMoraseleClass
Dim GroundInterCityNewsLetter(7)            As New GroundMoraseleClass
Dim GroundInternationalNewsLetter(6)        As New GroundMoraseleClass
Dim GroundCitySmallPackage(7)               As New GroundMoraseleClass
Dim GroundInterCitySmallPackage(7)          As New GroundMoraseleClass
Dim GroundInternationalSmallPackage(6)      As New GroundMoraseleClass
Dim GroundCityPostalCard(7)                 As New GroundMoraseleClass
Dim GroundInterCityPostalCard(7)            As New GroundMoraseleClass
Dim GroundInternationalPostalCard(6)        As New GroundMoraseleClass
Dim GroundCitySpecialBag                    As New GroundMoraseleClass
Dim GroundInterCitySpecialBag               As New GroundMoraseleClass
Dim GroundInternationalSpecialBag           As New GroundMoraseleClass
Dim GroundInternationalAirogram(6)          As New GroundMoraseleClass
Dim GroundInternationalKoponReponse(6)      As New GroundMoraseleClass
Dim AirLocalMorasele(2)                     As New AirMoraseleClass
Dim AirInternationalMorasele(3)             As New AirMoraseleClass

Dim BooshehrIslandNames(2)                  As String
Dim HormozganIslandNames(13)                As String

Dim LocalAmanat                             As New Amanat
Dim KnownValueCashIranInsurance             As New Insurance
Dim KnownValueOthersIranInsurance           As New Insurance
Dim ForeignInsurance                        As New Insurance
''</> Iran Insurance

Dim LSpecialServices                        As New LocalSpecialServices
Dim ISpecialServices                        As New InternationalSpecialServices

Dim strSQL As String
Dim adoConn As ADODB.Connection
Dim adoRst As ADODB.Recordset
Dim intCounter As Long

Public FinalCost As Long
Public SourcePCode As String
Public SourcePName As String
Public SourceCCode As String
Public SourceCName As String
Public IsEMSType As Boolean
Public MoraseleType As String
Public TransportType As String
Public DestinationType As String
Public Weight As Long
Public Cost As Long
Public CountryGroup As Long
Public EMSCountryGroup As Long
Public ConsigneeCountryGroup As Long
Public DestinationCountryName As String
Public DestinationProvinceName As String
Public DestinationCityName As String
Public IntraProvince As Boolean
Public ParcelCount As Long
Public ISOutOfSize As Boolean
Public ISOutOfStandardPackage As Boolean
Public IsMayeOrBreak As Boolean
Public IsBankAndMoney As Boolean
Public Amanat_Tejari As Boolean
Public Amanat_Anbooh As Boolean
Public ToldValue As Long
'<hadi date=87/3/7>
Public ParcelIndex As Integer
'</hadi>

Public HasKnownValueCashIranInsurance As Boolean
Public HasKnownValueOthersIranInsurance As Boolean
Public HasUnknownValueEnvelopeIranInsurance As Boolean
Public HasUnknownValuePackIranInsurance As Boolean
Public HasForeignInsurance As Boolean

Public IsRegistered As Boolean
Public IsExpress As Boolean
Public Is2Receipt As Boolean
Public IsRestant As Boolean
Public IsChangeAddress As Boolean
Public IsEMS2Receipt As Boolean
Public IsDayOutOfTime As Boolean
Public IsNightOutOfTime As Boolean
Public IsSendPlace As Boolean
Public IsFareInDest As Boolean
Public HasCN22 As Boolean
Public IsCustoms As Boolean
Public IsDispatched As Boolean
Public PackingPrice As Long
Public OtherPrice As Long
Public CustomerStampPrice As Long
Public TotalCost As Long
Public InsuranceCost As Long
Public PostalCost As Long
Public UnsizeCost As Long
Public UnstandardPackageCost As Long
Public MySendPlaceCost As Long

Private Sub InitClass()
        BooshehrIslandNames(1) = "Œ«—ﬂ"
        BooshehrIslandNames(2) = "‘Ì›"
        HormozganIslandNames(1) = "ﬁ‘„"
        HormozganIslandNames(2) = "Â—„“"
        HormozganIslandNames(3) = "·«—ﬂ"
        HormozganIslandNames(4) = "Â‰ê«„"
        HormozganIslandNames(5) = "ﬂÌ‘"
        HormozganIslandNames(6) = "·«Ê«‰"
        HormozganIslandNames(7) = "‘ÌœÊ—"
        HormozganIslandNames(8) = "«»Ê„Ê”Ì"
        HormozganIslandNames(9) = " ‰» »“—ê"
        HormozganIslandNames(10) = " ‰» ﬂÊçﬂ"
        HormozganIslandNames(11) = "”Ì—Ì"
        HormozganIslandNames(12) = "›—Ê—"
        HormozganIslandNames(13) = "»‰Ì ›—Ê—"
        
        
        '***** Ground Letter *****
        'City
        GroundCityLetter(1).WeightLimit = 5000
        GroundCityLetter(1).Weight = 20
        GroundCityLetter(1).WeightCalcMethod = 0  'Up to the weight
        GroundCityLetter(1).Price = 300
        
        GroundCityLetter(2).WeightLimit = 5000
        GroundCityLetter(2).Weight = 100
        GroundCityLetter(2).WeightCalcMethod = 0  'Up to the weight
        GroundCityLetter(2).Price = 400
        
        GroundCityLetter(3).WeightLimit = 5000
        GroundCityLetter(3).Weight = 250
        GroundCityLetter(3).WeightCalcMethod = 0  'Up to the weight
        GroundCityLetter(3).Price = 400
        
        GroundCityLetter(4).WeightLimit = 5000
        GroundCityLetter(4).Weight = 500
        GroundCityLetter(4).WeightCalcMethod = 0  'Up to the weight
        GroundCityLetter(4).Price = 500
        
        GroundCityLetter(5).WeightLimit = 5000
        GroundCityLetter(5).Weight = 1000
        GroundCityLetter(5).WeightCalcMethod = 0  'Up to the weight
        'GroundCityLetter(5).Price = 450
        GroundCityLetter(5).Price = 500
        ''GroundCityLetter(5).Price = 550
        
        GroundCityLetter(6).WeightLimit = 5000
        GroundCityLetter(6).Weight = 2000
        GroundCityLetter(6).WeightCalcMethod = 0  'Up to the weight
        'GroundCityLetter(6).Price = 800
        ''<>
        ''Change in price list
        ''GroundCityLetter(6).Price = 850
        GroundCityLetter(6).Price = 700
        ''GroundCityLetter(6).Price = 940
        ''</>
        
        GroundCityLetter(7).WeightLimit = 5000
        GroundCityLetter(7).Weight = 1000
        GroundCityLetter(7).WeightCalcMethod = 1  'More than
        GroundCityLetter(7).Price = -1
        'Intercity
        GroundInterCityLetter(1).WeightLimit = 5000
        GroundInterCityLetter(1).Weight = 20
        GroundInterCityLetter(1).WeightCalcMethod = 0  'Up to the weight
        'GroundInterCityLetter(1).Price = 350
        ''<>
        ''Change in price list
        ''GroundInterCityLetter(1).Price = 400
        GroundInterCityLetter(1).Price = 650
        ''GroundInterCityLetter(1).Price = 440
        ''</>
        
        GroundInterCityLetter(2).WeightLimit = 5000
        GroundInterCityLetter(2).Weight = 100
        GroundInterCityLetter(2).WeightCalcMethod = 0  'Up to the weight
        'GroundInterCityLetter(2).Price = 350
        ''<>
        ''Change in price list
        ''GroundInterCityLetter(2).Price = 450
        GroundInterCityLetter(2).Price = 750
        ''GroundInterCityLetter(2).Price = 500
        ''</>
        
        GroundInterCityLetter(3).WeightLimit = 5000
        GroundInterCityLetter(3).Weight = 250
        GroundInterCityLetter(3).WeightCalcMethod = 0  'Up to the weight
        'GroundInterCityLetter(3).Price = 400
        ''<>
        ''Change in price list
        ''GroundInterCityLetter(3).Price = 500
        GroundInterCityLetter(3).Price = 750
        ''GroundInterCityLetter(3).Price = 550
        ''</>
        
        GroundInterCityLetter(4).WeightLimit = 5000
        GroundInterCityLetter(4).Weight = 500
        GroundInterCityLetter(4).WeightCalcMethod = 0  'Up to the weight
        'GroundInterCityLetter(4).Price = 450
        ''<>
        ''Change in price list
        ''GroundInterCityLetter(4).Price = 550
        GroundInterCityLetter(4).Price = 850
        ''GroundInterCityLetter(4).Price = 600
        ''</>
        
        GroundInterCityLetter(5).WeightLimit = 5000
        GroundInterCityLetter(5).Weight = 1000
        GroundInterCityLetter(5).WeightCalcMethod = 0  'Up to the weight
        'GroundInterCityLetter(5).Price = 550
        ''<>
        ''Change in price list
        ''GroundInterCityLetter(5).Price = 650
        GroundInterCityLetter(5).Price = 850
        ''GroundInterCityLetter(5).Price = 660
        ''</>
        
        GroundInterCityLetter(6).WeightLimit = 5000
        GroundInterCityLetter(6).Weight = 2000
        GroundInterCityLetter(6).WeightCalcMethod = 0  'Up to the weight
        'GroundInterCityLetter(6).Price = 1100
        ''<>
        ''Change in price list
        ''GroundInterCityLetter(6).Price = 1200
        GroundInterCityLetter(6).Price = 950
        ''GroundInterCityLetter(6).Price = 1320
        ''</>
        
        GroundInterCityLetter(7).WeightLimit = 5000
        GroundInterCityLetter(7).Weight = 1000
        GroundInterCityLetter(7).WeightCalcMethod = 1  'More than
        GroundInterCityLetter(7).Price = -1
        'International
        GroundInternationalLetter(1).WeightLimit = 2000
        GroundInternationalLetter(1).Weight = 20
        GroundInternationalLetter(1).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalLetter(1).Price = 2500
        GroundInternationalLetter(1).Price = 4200
        ''GroundInternationalLetter(1).Price = 2750
        ''<>
        
        GroundInternationalLetter(2).WeightLimit = 2000
        GroundInternationalLetter(2).Weight = 100
        GroundInternationalLetter(2).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalLetter(2).Price = 5900
        GroundInternationalLetter(2).Price = 9900
        ''GroundInternationalLetter(2).Price = 6500
        ''</>
        
        GroundInternationalLetter(3).WeightLimit = 2000
        GroundInternationalLetter(3).Weight = 250
        GroundInternationalLetter(3).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        GroundInternationalLetter(3).Price = 20200
        ''GroundInternationalLetter(3).Price = 13200
        ''</>
        
        GroundInternationalLetter(4).WeightLimit = 2000
        GroundInternationalLetter(4).Weight = 500
        GroundInternationalLetter(4).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalLetter(4).Price = 23000
        GroundInternationalLetter(4).Price = 38600
        ''GroundInternationalLetter(4).Price = 25300
        ''</>
        
        GroundInternationalLetter(5).WeightLimit = 2000
        GroundInternationalLetter(5).Weight = 1000
        GroundInternationalLetter(5).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalLetter(5).Price = 39000
        GroundInternationalLetter(5).Price = 65500
        ''GroundInternationalLetter(5).Price = 42900
        ''</>
        
        GroundInternationalLetter(6).WeightLimit = 2000
        GroundInternationalLetter(6).Weight = 2000
        GroundInternationalLetter(6).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalLetter(6).Price = 65000
        GroundInternationalLetter(6).Price = 109200
        ''GroundInternationalLetter(6).Price = 71500
        ''</>
        
        
        '***** Ground NewsLetter *****
        'City
        GroundCityNewsLetter(1).WeightLimit = 5000
        GroundCityNewsLetter(1).Weight = 20
        GroundCityNewsLetter(1).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundCityNewsLetter(1).Price = 40
        ''GroundCityNewsLetter(1).Price = 100
        GroundCityNewsLetter(1).Price = 100
        ''</>
        
        GroundCityNewsLetter(2).WeightLimit = 5000
        GroundCityNewsLetter(2).Weight = 100
        GroundCityNewsLetter(2).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundCityNewsLetter(2).Price = 50
        ''GroundCityNewsLetter(2).Price = 100
        GroundCityNewsLetter(2).Price = 100
        ''</>
        
        GroundCityNewsLetter(3).WeightLimit = 5000
        GroundCityNewsLetter(3).Weight = 250
        GroundCityNewsLetter(3).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundCityNewsLetter(3).Price = 70
        ''GroundCityNewsLetter(3).Price = 200
        GroundCityNewsLetter(3).Price = 200
        ''</>
        
        GroundCityNewsLetter(4).WeightLimit = 5000
        GroundCityNewsLetter(4).Weight = 500
        GroundCityNewsLetter(4).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundCityNewsLetter(4).Price = 150
        ''GroundCityNewsLetter(4).Price = 300
        GroundCityNewsLetter(4).Price = 300
        ''</>
        
        GroundCityNewsLetter(5).WeightLimit = 5000
        GroundCityNewsLetter(5).Weight = 1000
        GroundCityNewsLetter(5).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundCityNewsLetter(5).Price = 200
        ''GroundCityNewsLetter(5).Price = 400
        GroundCityNewsLetter(5).Price = 400
        ''</>
        
        GroundCityNewsLetter(6).WeightLimit = 5000
        GroundCityNewsLetter(6).Weight = 2000
        GroundCityNewsLetter(6).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundCityNewsLetter(6).Price = 250
        ''GroundCityNewsLetter(6).Price = 400
        GroundCityNewsLetter(6).Price = 400
        ''</>
        
        GroundCityNewsLetter(7).WeightLimit = 5000
        GroundCityNewsLetter(7).Weight = 1000
        GroundCityNewsLetter(7).WeightCalcMethod = 1  'More than
        ''<>
        ''Change in price list
        ''GroundCityNewsLetter(7).Price = 250
        ''GroundCityNewsLetter(7).Price = 300
        GroundCityNewsLetter(7).Price = 320
        ''</>
        'Intercity
        GroundInterCityNewsLetter(1).WeightLimit = 5000
        GroundInterCityNewsLetter(1).Weight = 20
        GroundInterCityNewsLetter(1).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInterCityNewsLetter(1).Price = 100
        ''GroundInterCityNewsLetter(1).Price = 200
        GroundInterCityNewsLetter(1).Price = 200
        ''</>
        
        GroundInterCityNewsLetter(2).WeightLimit = 5000
        GroundInterCityNewsLetter(2).Weight = 100
        GroundInterCityNewsLetter(2).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInterCityNewsLetter(2).Price = 100
        ''GroundInterCityNewsLetter(2).Price = 200
        GroundInterCityNewsLetter(2).Price = 200
        ''</>
        
        GroundInterCityNewsLetter(3).WeightLimit = 5000
        GroundInterCityNewsLetter(3).Weight = 250
        GroundInterCityNewsLetter(3).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInterCityNewsLetter(3).Price = 150
        ''GroundInterCityNewsLetter(3).Price = 300
        GroundInterCityNewsLetter(3).Price = 300
        ''</>
        
        GroundInterCityNewsLetter(4).WeightLimit = 5000
        GroundInterCityNewsLetter(4).Weight = 500
        GroundInterCityNewsLetter(4).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInterCityNewsLetter(4).Price = 200
        ''GroundInterCityNewsLetter(4).Price = 300
        GroundInterCityNewsLetter(4).Price = 300
        ''</>
        
        GroundInterCityNewsLetter(5).WeightLimit = 5000
        GroundInterCityNewsLetter(5).Weight = 1000
        GroundInterCityNewsLetter(5).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInterCityNewsLetter(5).Price = 250
        ''GroundInterCityNewsLetter(5).Price = 400
        GroundInterCityNewsLetter(5).Price = 400
        ''</>
        
        GroundInterCityNewsLetter(6).WeightLimit = 5000
        GroundInterCityNewsLetter(6).Weight = 2000
        GroundInterCityNewsLetter(6).WeightCalcMethod = 0  'Up to the weight
        ''GroundInterCityNewsLetter(6).Price = 400
        GroundInterCityNewsLetter(6).Price = 400
        
        GroundInterCityNewsLetter(7).WeightLimit = 5000
        GroundInterCityNewsLetter(7).Weight = 1000
        GroundInterCityNewsLetter(7).WeightCalcMethod = 1  'More than
        ''<>
        ''Change in price list
        ''GroundInterCityNewsLetter(7).Price = 300
        ''GroundInterCityNewsLetter(7).Price = 400
        GroundInterCityNewsLetter(7).Price = 420
        ''</>
        'International
        GroundInternationalNewsLetter(1).WeightLimit = 2000
        GroundInternationalNewsLetter(1).Weight = 20
        GroundInternationalNewsLetter(1).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalNewsLetter(1).Price = 1200
        ''GroundInternationalNewsLetter(1).Price = 1920
        GroundInternationalNewsLetter(1).Price = 2000
        ''</>
        
        GroundInternationalNewsLetter(2).WeightLimit = 2000
        GroundInternationalNewsLetter(2).Weight = 100
        GroundInternationalNewsLetter(2).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalNewsLetter(2).Price = 2700
        ''GroundInternationalNewsLetter(2).Price = 4320
        GroundInternationalNewsLetter(2).Price = 4500
        ''</>
        
        GroundInternationalNewsLetter(3).WeightLimit = 2000
        GroundInternationalNewsLetter(3).Weight = 250
        GroundInternationalNewsLetter(3).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalNewsLetter(3).Price = 5100
        ''GroundInternationalNewsLetter(3).Price = 8160
        GroundInternationalNewsLetter(3).Price = 8500
        ''</>
        
        GroundInternationalNewsLetter(4).WeightLimit = 2000
        GroundInternationalNewsLetter(4).Weight = 500
        GroundInternationalNewsLetter(4).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalNewsLetter(4).Price = 9000
        ''GroundInternationalNewsLetter(4).Price = 14400
        GroundInternationalNewsLetter(4).Price = 15000
        ''</>
        
        GroundInternationalNewsLetter(5).WeightLimit = 2000
        GroundInternationalNewsLetter(5).Weight = 1000
        GroundInternationalNewsLetter(5).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalNewsLetter(5).Price = 15000
        ''GroundInternationalNewsLetter(5).Price = 24000
        GroundInternationalNewsLetter(5).Price = 25200
        ''</>
        
        GroundInternationalNewsLetter(6).WeightLimit = 2000
        GroundInternationalNewsLetter(6).Weight = 2000
        GroundInternationalNewsLetter(6).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalNewsLetter(6).Price = 7000
        ''GroundInternationalNewsLetter(6).Price = 14000
        GroundInternationalNewsLetter(6).Price = 7000
        ''</>


        '***** Ground Small Bag *****
        'City
        GroundCitySmallPackage(1).WeightLimit = 2000
        GroundCitySmallPackage(1).Weight = 20
        GroundCitySmallPackage(1).WeightCalcMethod = 0  'Up to the weight
        GroundCitySmallPackage(1).Price = 200
        ''</>
        
        GroundCitySmallPackage(2).WeightLimit = 2000
        GroundCitySmallPackage(2).Weight = 100
        GroundCitySmallPackage(2).WeightCalcMethod = 0  'Up to the weight
        GroundCitySmallPackage(2).Price = 200
        ''GroundCitySmallPackage(2).Price = 170
        ''</>
        
        GroundCitySmallPackage(3).WeightLimit = 2000
        GroundCitySmallPackage(3).Weight = 250
        GroundCitySmallPackage(3).WeightCalcMethod = 0  'Up to the weight
        GroundCitySmallPackage(3).Price = 300
        
        GroundCitySmallPackage(4).WeightLimit = 2000
        GroundCitySmallPackage(4).Weight = 500
        GroundCitySmallPackage(4).WeightCalcMethod = 0  'Up to the weight
        GroundCitySmallPackage(4).Price = 400
        
        GroundCitySmallPackage(5).WeightLimit = 2000
        GroundCitySmallPackage(5).Weight = 1000
        GroundCitySmallPackage(5).WeightCalcMethod = 0  'Up to the weight
        GroundCitySmallPackage(5).Price = 600
        
        GroundCitySmallPackage(6).WeightLimit = 2000
        GroundCitySmallPackage(6).Weight = 2000
        GroundCitySmallPackage(6).WeightCalcMethod = 0  'Up to the weight
        GroundCitySmallPackage(6).Price = 700
        
        GroundCitySmallPackage(7).WeightLimit = 2000
        GroundCitySmallPackage(7).Weight = 1000
        GroundCitySmallPackage(7).WeightCalcMethod = 1  'More than
        GroundCitySmallPackage(7).Price = -1
        
        
        'Intercity   »Ì‰ ‘Â—Ì
        GroundInterCitySmallPackage(1).WeightLimit = 2000
        GroundInterCitySmallPackage(1).Weight = 20
        GroundInterCitySmallPackage(1).WeightCalcMethod = 0  'Up to the weight
        GroundInterCitySmallPackage(1).Price = 300
        
        GroundInterCitySmallPackage(2).WeightLimit = 2000
        GroundInterCitySmallPackage(2).Weight = 100
        GroundInterCitySmallPackage(2).WeightCalcMethod = 0  'Up to the weight
        GroundInterCitySmallPackage(2).Price = 300
        
        GroundInterCitySmallPackage(3).WeightLimit = 2000
        GroundInterCitySmallPackage(3).Weight = 250
        GroundInterCitySmallPackage(3).WeightCalcMethod = 0  'Up to the weight
        GroundInterCitySmallPackage(3).Price = 400
        
        GroundInterCitySmallPackage(4).WeightLimit = 2000
        GroundInterCitySmallPackage(4).Weight = 500
        GroundInterCitySmallPackage(4).WeightCalcMethod = 0  'Up to the weight
        GroundInterCitySmallPackage(4).Price = 500
        
        GroundInterCitySmallPackage(5).WeightLimit = 2000
        GroundInterCitySmallPackage(5).Weight = 1000
        GroundInterCitySmallPackage(5).WeightCalcMethod = 0  'Up to the weight
        GroundInterCitySmallPackage(5).Price = 700
        
        GroundInterCitySmallPackage(6).WeightLimit = 2000
        GroundInterCitySmallPackage(6).Weight = 2000
        GroundInterCitySmallPackage(6).WeightCalcMethod = 0  'Up to the weight
        GroundInterCitySmallPackage(6).Price = 800
        
        GroundInterCitySmallPackage(7).WeightLimit = 2000
        GroundInterCitySmallPackage(7).Weight = 1000
        GroundInterCitySmallPackage(7).WeightCalcMethod = 1  'More than
        GroundInterCitySmallPackage(7).Price = -1
        
        'International
        GroundInternationalSmallPackage(1).WeightLimit = 2000
        GroundInternationalSmallPackage(1).Weight = 20
        GroundInternationalSmallPackage(1).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalSmallPackage(1).Price = 6000
        
        GroundInternationalSmallPackage(2).WeightLimit = 2000
        GroundInternationalSmallPackage(2).Weight = 100
        GroundInternationalSmallPackage(2).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalSmallPackage(2).Price = 6000
        
        GroundInternationalSmallPackage(3).WeightLimit = 2000
        GroundInternationalSmallPackage(3).Weight = 250
        GroundInternationalSmallPackage(3).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalSmallPackage(3).Price = 15000
        
        GroundInternationalSmallPackage(4).WeightLimit = 2000
        GroundInternationalSmallPackage(4).Weight = 500
        GroundInternationalSmallPackage(4).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalSmallPackage(4).Price = 28600
        
        GroundInternationalSmallPackage(5).WeightLimit = 2000
        GroundInternationalSmallPackage(5).Weight = 1000
        GroundInternationalSmallPackage(5).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalSmallPackage(5).Price = 60500
        
        GroundInternationalSmallPackage(6).WeightLimit = 2000
        GroundInternationalSmallPackage(6).Weight = 2000
        GroundInternationalSmallPackage(6).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalSmallPackage(6).Price = 121000

        '***** Ground PostalCard *****
        'City
        GroundCityPostalCard(1).WeightLimit = 5000
        GroundCityPostalCard(1).Weight = 20
        GroundCityPostalCard(1).WeightCalcMethod = 0  'Up to the weight
        GroundCityPostalCard(1).Price = 200
        
        GroundCityPostalCard(2).WeightLimit = 5000
        GroundCityPostalCard(2).Weight = 100
        GroundCityPostalCard(2).WeightCalcMethod = 0  'Up to the weight
        GroundCityPostalCard(2).Price = -1
        
        GroundCityPostalCard(3).WeightLimit = 5000
        GroundCityPostalCard(3).Weight = 250
        GroundCityPostalCard(3).WeightCalcMethod = 0  'Up to the weight
        GroundCityPostalCard(3).Price = -1
        
        GroundCityPostalCard(4).WeightLimit = 5000
        GroundCityPostalCard(4).Weight = 500
        GroundCityPostalCard(4).WeightCalcMethod = 0  'Up to the weight
        GroundCityPostalCard(4).Price = -1
        
        GroundCityPostalCard(5).WeightLimit = 5000
        GroundCityPostalCard(5).Weight = 1000
        GroundCityPostalCard(5).WeightCalcMethod = 0  'Up to the weight
        GroundCityPostalCard(5).Price = -1
        
        GroundCityPostalCard(6).WeightLimit = 5000
        GroundCityPostalCard(6).Weight = 2000
        GroundCityPostalCard(6).WeightCalcMethod = 0  'Up to the weight
        GroundCityPostalCard(6).Price = -1
        
        GroundCityPostalCard(7).WeightLimit = 5000
        GroundCityPostalCard(7).Weight = 1000
        GroundCityPostalCard(7).WeightCalcMethod = 1  'More than
        GroundCityPostalCard(7).Price = -1
        
        'Intercity
        GroundInterCityPostalCard(1).WeightLimit = 5000
        GroundInterCityPostalCard(1).Weight = 20
        GroundInterCityPostalCard(1).WeightCalcMethod = 0  'Up to the weight
        GroundInterCityPostalCard(1).Price = 200
        ''GroundInterCityPostalCard(1).Price = 220
        
        GroundInterCityPostalCard(2).WeightLimit = 5000
        GroundInterCityPostalCard(2).Weight = 100
        GroundInterCityPostalCard(2).WeightCalcMethod = 0  'Up to the weight
        GroundInterCityPostalCard(2).Price = -1
        
        GroundInterCityPostalCard(3).WeightLimit = 5000
        GroundInterCityPostalCard(3).Weight = 250
        GroundInterCityPostalCard(3).WeightCalcMethod = 0  'Up to the weight
        GroundInterCityPostalCard(3).Price = -1
        
        GroundInterCityPostalCard(4).WeightLimit = 5000
        GroundInterCityPostalCard(4).Weight = 500
        GroundInterCityPostalCard(4).WeightCalcMethod = 0  'Up to the weight
        GroundInterCityPostalCard(4).Price = -1
        
        GroundInterCityPostalCard(5).WeightLimit = 5000
        GroundInterCityPostalCard(5).Weight = 1000
        GroundInterCityPostalCard(5).WeightCalcMethod = 0  'Up to the weight
        GroundInterCityPostalCard(5).Price = -1
        
        GroundInterCityPostalCard(6).WeightLimit = 5000
        GroundInterCityPostalCard(6).Weight = 2000
        GroundInterCityPostalCard(6).WeightCalcMethod = 0  'Up to the weight
        GroundInterCityPostalCard(6).Price = -1
        
        GroundInterCityPostalCard(7).WeightLimit = 5000
        GroundInterCityPostalCard(7).Weight = 1000
        GroundInterCityPostalCard(7).WeightCalcMethod = 1  'More than
        GroundInterCityPostalCard(7).Price = -1
        'International
        GroundInternationalPostalCard(1).WeightLimit = 2000
        GroundInternationalPostalCard(1).Weight = 20
        GroundInternationalPostalCard(1).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalPostalCard(1).Price = 900
        ''GroundInternationalPostalCard(1).Price = 1000
        
        GroundInternationalPostalCard(2).WeightLimit = 2000
        GroundInternationalPostalCard(2).Weight = 100
        GroundInternationalPostalCard(2).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalPostalCard(2).Price = -1
        
        GroundInternationalPostalCard(3).WeightLimit = 2000
        GroundInternationalPostalCard(3).Weight = 250
        GroundInternationalPostalCard(3).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalPostalCard(3).Price = -1
        
        GroundInternationalPostalCard(4).WeightLimit = 2000
        GroundInternationalPostalCard(4).Weight = 500
        GroundInternationalPostalCard(4).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalPostalCard(4).Price = -1
        
        GroundInternationalPostalCard(5).WeightLimit = 2000
        GroundInternationalPostalCard(5).Weight = 1000
        GroundInternationalPostalCard(5).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalPostalCard(5).Price = -1
        
        GroundInternationalPostalCard(6).WeightLimit = 2000
        GroundInternationalPostalCard(6).Weight = 2000
        GroundInternationalPostalCard(6).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalPostalCard(6).Price = -1
        
        
        '***** Ground Special Bag *****
        'City
        GroundCitySpecialBag.WeightLimit = 1000
        GroundCitySpecialBag.Weight = 1000
        GroundCitySpecialBag.WeightCalcMethod = 2  'For Each
        ''<>
        ''Change in price list
        ''GroundCitySpecialBag.Price = 150
        ''GroundCitySpecialBag.Price = 300
        GroundCitySpecialBag.Price = 320
        ''</>
        'Intercity
        GroundInterCitySpecialBag.WeightLimit = 1000
        GroundInterCitySpecialBag.Weight = 1000
        GroundInterCitySpecialBag.WeightCalcMethod = 2  'For Each
        ''<>
        ''Change in price list
        ''GroundInterCitySpecialBag.Price = 250
        ''GroundInterCitySpecialBag.Price = 500
        GroundInterCitySpecialBag.Price = 420
        ''</>
        'International
        GroundInternationalSpecialBag.WeightLimit = 1000
        GroundInternationalSpecialBag.Weight = 1000
        GroundInternationalSpecialBag.WeightCalcMethod = 2  'For Each
        ''GroundInternationalSpecialBag.Price = 7000
        GroundInternationalSpecialBag.Price = 7000


        '***** Airogram *****
        'International
        GroundInternationalAirogram(1).WeightLimit = 2000
        GroundInternationalAirogram(1).Weight = 20
        GroundInternationalAirogram(1).WeightCalcMethod = 0  'Up to the weight
        ''<>
        ''Change in price list
        ''GroundInternationalAirogram(1).Price = 2000
        GroundInternationalAirogram(1).Price = 3400
        ''GroundInternationalAirogram(1).Price = 2200
        ''</>
        
        GroundInternationalAirogram(2).WeightLimit = 2000
        GroundInternationalAirogram(2).Weight = 100
        GroundInternationalAirogram(2).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalAirogram(2).Price = -1
        
        GroundInternationalAirogram(3).WeightLimit = 2000
        GroundInternationalAirogram(3).Weight = 250
        GroundInternationalAirogram(3).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalAirogram(3).Price = -1
        
        GroundInternationalAirogram(4).WeightLimit = 2000
        GroundInternationalAirogram(4).Weight = 500
        GroundInternationalAirogram(4).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalAirogram(4).Price = -1
        
        GroundInternationalAirogram(5).WeightLimit = 2000
        GroundInternationalAirogram(5).Weight = 1000
        GroundInternationalAirogram(5).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalAirogram(5).Price = -1
        
        GroundInternationalAirogram(6).WeightLimit = 2000
        GroundInternationalAirogram(6).Weight = 2000
        GroundInternationalAirogram(6).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalAirogram(6).Price = -1

        '***** Kopon Reponse *****
        'International
        GroundInternationalKoponReponse(1).WeightLimit = 2000
        GroundInternationalKoponReponse(1).Weight = 20
        GroundInternationalKoponReponse(1).WeightCalcMethod = 0  'Up to the weight
        ''GroundInternationalKoponReponse(1).Price = 8000
        GroundInternationalKoponReponse(1).Price = 8800

        GroundInternationalKoponReponse(2).WeightLimit = 2000
        GroundInternationalKoponReponse(2).Weight = 100
        GroundInternationalKoponReponse(2).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalKoponReponse(2).Price = -1

        GroundInternationalKoponReponse(3).WeightLimit = 2000
        GroundInternationalKoponReponse(3).Weight = 250
        GroundInternationalKoponReponse(3).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalKoponReponse(3).Price = -1

        GroundInternationalKoponReponse(4).WeightLimit = 2000
        GroundInternationalKoponReponse(4).Weight = 500
        GroundInternationalKoponReponse(4).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalKoponReponse(4).Price = -1

        GroundInternationalKoponReponse(5).WeightLimit = 2000
        GroundInternationalKoponReponse(5).Weight = 1000
        GroundInternationalKoponReponse(5).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalKoponReponse(5).Price = -1

        GroundInternationalKoponReponse(6).WeightLimit = 2000
        GroundInternationalKoponReponse(6).Weight = 2000
        GroundInternationalKoponReponse(6).WeightCalcMethod = 0  'Up to the weight
        GroundInternationalKoponReponse(6).Price = -1
        
        '***** Air Local *****
        AirLocalMorasele(1).Weight = 50
        AirLocalMorasele(1).CalcMethod = 0
        AirLocalMorasele(1).CountryGroup = -1
        'AirLocalMorasele(1).Price = 100
        ''<>
        ''Change in price list
        ''AirLocalMorasele(1).Price = 130
        AirLocalMorasele(1).Price = 200
        ''AirLocalMorasele(1).Price = 140
        ''</>
        
        AirLocalMorasele(2).Weight = 10
        AirLocalMorasele(2).CalcMethod = 1
        AirLocalMorasele(2).CountryGroup = -1
        'AirLocalMorasele(2).Price = 20
        ''<>
        ''Change in price list
        ''AirLocalMorasele(2).Price = 50
        AirLocalMorasele(2).Price = 100
        ''AirLocalMorasele(2).Price = 60
        ''</>
        
        '***** Air International *****
        AirInternationalMorasele(1).Weight = 10
        AirInternationalMorasele(1).CalcMethod = 2
        AirInternationalMorasele(1).CountryGroup = 1
        'AirInternationalMorasele(1).Price = 65
        ''<>
        ''Change in price list
        ''AirInternationalMorasele(1).Price = 100
        AirInternationalMorasele(1).Price = 160
        ''AirInternationalMorasele(1).Price = 110
        ''</>
        
        AirInternationalMorasele(2).Weight = 10
        AirInternationalMorasele(2).CalcMethod = 2
        AirInternationalMorasele(2).CountryGroup = 2
        'AirInternationalMorasele(2).Price = 120
        ''<>
        ''Change in price list
        ''AirInternationalMorasele(2).Price = 200
        AirInternationalMorasele(2).Price = 340
        ''AirInternationalMorasele(2).Price = 220
        ''</>

        AirInternationalMorasele(3).Weight = 10
        AirInternationalMorasele(3).CalcMethod = 2
        AirInternationalMorasele(3).CountryGroup = 3
        'AirInternationalMorasele(3).Price = 160
        ''<>
        ''Change in price list
        ''AirInternationalMorasele(3).Price = 250
        AirInternationalMorasele(3).Price = 420
        ''AirInternationalMorasele(3).Price = 280
        ''</>
        
        
        
        
        
        '***** Amanat *****
        LocalAmanat.BankAndMoneyExtraPrice = 1250
        ''LocalAmanat.BankAndMoneyExtraPrice = 1320
        LocalAmanat.FromFreeZonePrice = 2100             '??????????????????  Min & Max??????????
        ''LocalAmanat.FromFreeZonePrice = 2200             '??????????????????  Min & Max??????????
        LocalAmanat.FromKishAndGheshmPrice = 2600
       ''LocalAmanat.FromKishAndGheshmPrice = 2750
        
        LocalAmanat.InterProvincePrice = 1100
        ''LocalAmanat.InterProvincePrice = 1100
        
       LocalAmanat.ExtraProvinceTejariPrice = 700
       LocalAmanat.ExtraProvinceTejariPriceRestant = 500
        
        LocalAmanat.IntraProvincePrice = 500
        ''LocalAmanat.IntraProvincePrice = 550
        
        LocalAmanat.MassAmanat10U20Percentage = 0.9
        LocalAmanat.MassAmanat21Percentage = 0.8
        LocalAmanat.MayeAndBreakPercentage = 0.25
        LocalAmanat.OutOfSizePercentage = 0.25
        ''<> OutOfStandardPackage
        LocalAmanat.OutOfStandardPackagePercentage = 0.25
        ''</> OutOfStandardPackage
        'LocalAmanat.ToIslandsExtraPrice = 550
        LocalAmanat.ToIslandsExtraPrice = 1000
        ''LocalAmanat.ToIslandsExtraPrice = 1100
        
        ''<> Iran Insurance
        KnownValueCashIranInsurance.CostPercentage = 0.001
        KnownValueCashIranInsurance.MaximumAcceptableCost = 500000000
        KnownValueCashIranInsurance.MinimumInsuranceEnvelope = 200
        KnownValueCashIranInsurance.MinimumInsurancePackage = 500
        
        KnownValueOthersIranInsurance.CostPercentage = 0.003
        KnownValueOthersIranInsurance.MaximumAcceptableCost = 50000000
        KnownValueOthersIranInsurance.MinimumInsuranceEnvelope = 200
        KnownValueOthersIranInsurance.MinimumInsurancePackage = 500
        
        ForeignInsurance.CostPercentage = 0.01
        ForeignInsurance.MaximumAcceptableCost = 6000000
        ForeignInsurance.MinimumInsurance = 2000
        
        
        LSpecialServices.EMSReturnReceiptPrice = 3100
        ''LSpecialServices.EMSReturnReceiptPrice = 2100
        
       ''LSpecialServices.EMSReturnReceiptPriceKharej = 9150
        LSpecialServices.EMSReturnReceiptPriceKharej = 12000
        
        LSpecialServices.ExpressU2Price = 2100
        ''LSpecialServices.ExpressU2Price = 1300
        
        LSpecialServices.ExtraExpressPrice = 300
        ''LSpecialServices.ExtraExpressPrice = 330
        
        LSpecialServices.MarsoleRegistrationPrice = 1700
        
        LSpecialServices.OutOfTimeAcceptanceDayPrice = 200
        ''LSpecialServices.OutOfTimeAcceptanceDayPrice = 220
        
        LSpecialServices.OutOfTimeAcceptanceNightPrice = 300
        ''LSpecialServices.OutOfTimeAcceptanceNightPrice = 330
        
        LSpecialServices.ReturnChangePrice = 1000
        ''LSpecialServices.ReturnChangePrice = 1200
        
        ''LSpecialServices.SpecialBagRegistrationPrice = 3000
        LSpecialServices.SpecialBagRegistrationPrice = 3200
        ''</>
        
''<> NewsAndM TODO:
'        LSpecialServices.NewsRegistrationPrice = 1500
'        LSpecialServices.NewsAndMExpressU2Price = 1300
'        LSpecialServices.NewsAndMExtraExpressPrice = 330
'        LSpecialServices.NewsAndMReturnChangePrice = 1200
''</> NewsAndM TODO:
        
        
'        LSpecialServices.EMSReturnReceiptPrice = 1750
'        LSpecialServices.EMSReturnReceiptPriceKharej = 3500
'        LSpecialServices.ExpressU2Price = 1100
'        LSpecialServices.ExtraExpressPrice = 300
'        LSpecialServices.MarsoleRegistrationPrice = 1200
'        LSpecialServices.OutOfTimeAcceptanceDayPrice = 200
'        LSpecialServices.OutOfTimeAcceptanceNightPrice = 300
'        LSpecialServices.ReturnChangePrice = 1000
'        LSpecialServices.SpecialBagRegistrationPrice = 2400
        
'        ISpecialServices.DispatchSmallPackagesOrAmanatPrice = 1000
'        ISpecialServices.GettingFromCustumesWithCN22 = 4400
'        ISpecialServices.MarsoleRegistrationPrice = 2750
'        ISpecialServices.SpecialBagRegistrationPrice = 2750
'        ISpecialServices.ExpressPrice = 3500
'        ISpecialServices.ReturnChangePrice = 1750 'ansari 3500--> 1750

        ''<>
        ''Change in price list
''        ISpecialServices.DispatchSmallPackagesOrAmanatPrice = 1100
''        ISpecialServices.GettingFromCustumesWithCN22 = 4800
''        ISpecialServices.MarsoleRegistrationPrice = 3500
''        ISpecialServices.SpecialBagRegistrationPrice = 3000
''        ISpecialServices.ExpressPrice = 3800
''        ISpecialServices.ReturnChangePrice = 3800

        ISpecialServices.DispatchSmallPackagesOrAmanatPrice = 1200
        ''ISpecialServices.DispatchSmallPackagesOrAmanatPrice = 1200
        
        ISpecialServices.GettingFromCustumesWithCN22 = 5250
        ''ISpecialServices.GettingFromCustumesWithCN22 = 5300
        
        ISpecialServices.MarsoleRegistrationPrice = 9000
        ''ISpecialServices.MarsoleRegistrationPrice = 3850
        
        ISpecialServices.SpecialBagRegistrationPrice = 8750
        ''ISpecialServices.SpecialBagRegistrationPrice = 3300
        
        ''<> DestinationDestpatchPrice
        ''ISpecialServices.DestinationDestpatchPrice = 5350
        ''</>
        
        ISpecialServices.ExpressPrice = 9600
        ''ISpecialServices.ExpressPrice = 4200
        
        ISpecialServices.ReturnChangePrice = 9600
        ''ISpecialServices.ReturnChangePrice = 4200
        ''</>



        ''<> News AND M TODO:
'        ISpecialServices.NewsRegistrationPrice = 9200
'        ISpecialServices.NewsAndMGettingFromCustumesWithCN22 = 5300
'        ISpecialServices.NewsAndMExpressPrice = 9550
'        ISpecialServices.NewsAndMReturnChangePrice = 9550
        ''</>
        
        '_CityName
        SourceCName = G_CityName
        SourceCCode = G_CityCode
        SourcePName = G_ProvinceName
        SourcePCode = G_ProvinceCode
        
        
End Sub

Private Function ParcelCost() As Long
    Dim intTemp As Long
    Dim sglTemp As Single
    Dim lngTemp As Long
    Dim lngInsuranceTemp As Long
    Dim tmpValue  As Long
    Dim tmpExteraValue As Long
        
        Cost = 0
        InitClass
        If MoraseleType = "”ﬂÊê—«„" And Weight <= 7000 And TransportType = "“„Ì‰Ì" Then
            Cost = 0
            Exit Function
        End If
                
        Select Case MoraseleType
            Case "”ﬂÊê—«„"
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        If Weight < 7000 Then
                            Cost = 0
                        End If
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 50
                                        Cost = Cost + AirLocalMorasele(1).Price
                                    Case Is > 50
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 50) / 10
                                        intTemp = Int((Weight - 50) / 10)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirLocalMorasele(1).Price + intTemp * AirLocalMorasele(2).Price
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case CountryGroup
                                    Case 1
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(1).Price * intTemp
                                    Case 2
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(2).Price * intTemp
                                    Case 3
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(3).Price * intTemp
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
            
            
            Case "‰«„Â"
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundCityLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundCityLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundCityLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundCityLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundCityLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundCityLetter(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInterCityLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInterCityLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInterCityLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInterCityLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInterCityLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInterCityLetter(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInternationalLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInternationalLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInternationalLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInternationalLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInternationalLetter(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInterCityLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInterCityLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInterCityLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInterCityLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInterCityLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInterCityLetter(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case Weight
                                    Case Is <= 50
                                        Cost = Cost + AirLocalMorasele(1).Price
                                    Case Is > 50
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 50) / 10
                                        intTemp = Int((Weight - 50) / 10)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirLocalMorasele(1).Price + intTemp * AirLocalMorasele(2).Price
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInternationalLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInternationalLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInternationalLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInternationalLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInternationalLetter(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case CountryGroup
                                    Case 1
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(1).Price * intTemp
                                    Case 2
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(2).Price * intTemp
                                    Case 3
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(3).Price * intTemp
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
            
            Case "„ÿ»Ê⁄"
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundCityNewsLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundCityNewsLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundCityNewsLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundCityNewsLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundCityNewsLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundCityNewsLetter(6).Price
                                    Case Is <= 5000
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 2000) / 1000
                                        intTemp = Int((Weight - 2000) / 1000)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + GroundCityNewsLetter(7).Price * intTemp + GroundCityNewsLetter(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInterCityNewsLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInterCityNewsLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInterCityNewsLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInterCityNewsLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInterCityNewsLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInterCityNewsLetter(6).Price
                                    Case Is <= 5000
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 2000) / 1000
                                        intTemp = Int((Weight - 2000) / 1000)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + GroundInterCityNewsLetter(7).Price * intTemp + GroundInterCityNewsLetter(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalNewsLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInternationalNewsLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInternationalNewsLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInternationalNewsLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInternationalNewsLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInternationalNewsLetter(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInterCityNewsLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInterCityNewsLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInterCityNewsLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInterCityNewsLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInterCityNewsLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInterCityNewsLetter(6).Price
                                    Case Is <= 5000
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 2000) / 1000
                                        intTemp = Int((Weight - 2000) / 1000)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + GroundInterCityNewsLetter(7).Price * intTemp + GroundInterCityNewsLetter(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case Weight
                                    Case Is <= 50
                                        Cost = Cost + AirLocalMorasele(1).Price
                                    Case Is > 50
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 50) / 10
                                        intTemp = Int((Weight - 50) / 10)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirLocalMorasele(1).Price + intTemp * AirLocalMorasele(2).Price
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalNewsLetter(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInternationalNewsLetter(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInternationalNewsLetter(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInternationalNewsLetter(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInternationalNewsLetter(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInternationalNewsLetter(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case CountryGroup
                                    Case 1
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(1).Price * intTemp
                                    Case 2
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(2).Price * intTemp
                                    Case 3
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(3).Price * intTemp
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
            
            Case "»” Â"
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundCitySmallPackage(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundCitySmallPackage(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundCitySmallPackage(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundCitySmallPackage(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundCitySmallPackage(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundCitySmallPackage(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInterCitySmallPackage(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInterCitySmallPackage(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInterCitySmallPackage(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInterCitySmallPackage(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInterCitySmallPackage(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInterCitySmallPackage(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalSmallPackage(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInternationalSmallPackage(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInternationalSmallPackage(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInternationalSmallPackage(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInternationalSmallPackage(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInternationalSmallPackage(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                        '' Registration Fee
                        '<H>
                        'Cost = Cost + LSpecialServices.MarsoleRegistrationPrice
                        ''</H>
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInterCitySmallPackage(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInterCitySmallPackage(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInterCitySmallPackage(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInterCitySmallPackage(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInterCitySmallPackage(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInterCitySmallPackage(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case Weight
                                    Case Is <= 50
                                        Cost = Cost + AirLocalMorasele(1).Price
                                    Case Is > 50
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 50) / 10
                                        intTemp = Int((Weight - 50) / 10)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirLocalMorasele(1).Price + intTemp * AirLocalMorasele(2).Price
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalSmallPackage(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInternationalSmallPackage(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInternationalSmallPackage(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInternationalSmallPackage(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInternationalSmallPackage(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInternationalSmallPackage(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case CountryGroup
                                    Case 1
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(1).Price * intTemp
                                    Case 2
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(2).Price * intTemp
                                    Case 3
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(3).Price * intTemp
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
            
            Case "ﬂ«—  Å” «·"
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundCityPostalCard(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundCityPostalCard(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundCityPostalCard(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundCityPostalCard(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundCityPostalCard(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundCityPostalCard(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInterCityPostalCard(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInterCityPostalCard(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInterCityPostalCard(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInterCityPostalCard(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInterCityPostalCard(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInterCityPostalCard(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalPostalCard(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInternationalPostalCard(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInternationalPostalCard(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInternationalPostalCard(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInternationalPostalCard(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInternationalPostalCard(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInterCityPostalCard(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInterCityPostalCard(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInterCityPostalCard(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInterCityPostalCard(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInterCityPostalCard(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInterCityPostalCard(6).Price
                                    Case Is <= 5000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case Weight
                                    Case Is <= 50
                                        Cost = Cost + AirLocalMorasele(1).Price
                                    Case Is > 50
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 50) / 10
                                        intTemp = Int((Weight - 50) / 10)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirLocalMorasele(1).Price + intTemp * AirLocalMorasele(2).Price
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalPostalCard(1).Price
                                    Case Is <= 100
                                        Cost = Cost + GroundInternationalPostalCard(2).Price
                                    Case Is <= 250
                                        Cost = Cost + GroundInternationalPostalCard(3).Price
                                    Case Is <= 500
                                        Cost = Cost + GroundInternationalPostalCard(4).Price
                                    Case Is <= 1000
                                        Cost = Cost + GroundInternationalPostalCard(5).Price
                                    Case Is <= 2000
                                        Cost = Cost + GroundInternationalPostalCard(6).Price
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case CountryGroup
                                    Case 1
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(1).Price * intTemp
                                    Case 2
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(2).Price * intTemp
                                    Case 3
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(3).Price * intTemp
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
            
            Case "ﬂÌ”Â „Œ’Ê’"
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                intTemp = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                Cost = Cost + GroundCitySpecialBag.Price * intTemp
                            Case "»Ì‰ ‘Â—Ì"
                                intTemp = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                Cost = Cost + GroundInterCitySpecialBag.Price * intTemp
                            Case "Œ«—ÃÂ"
                                intTemp = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                If intTemp < 5 Then intTemp = 5
                                
                                Cost = Cost + GroundInternationalSpecialBag.Price * intTemp
                        End Select
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                intTemp = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                Cost = Cost + GroundInterCitySpecialBag.Price * intTemp
                                Select Case Weight
                                    Case Is <= 50
                                        Cost = Cost + AirLocalMorasele(1).Price
                                    Case Is > 50
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 50) / 10
                                        intTemp = Int((Weight - 50) / 10)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirLocalMorasele(1).Price + intTemp * AirLocalMorasele(2).Price
                                End Select
                            Case "Œ«—ÃÂ"
                                intTemp = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                
                                If intTemp < 5 Then intTemp = 5
                                Cost = Cost + GroundInternationalSpecialBag.Price * intTemp
                                
                                Select Case CountryGroup
                                    Case 1
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(1).Price * intTemp
                                    Case 2
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(2).Price * intTemp
                                    Case 3
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(3).Price * intTemp
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
            
            Case "¬∆—Êê—«„"
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Cost = -1
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalAirogram(1).Price
                                    Case Is <= 100
                                        Cost = -1
                                    Case Is <= 250
                                        Cost = -1
                                    Case Is <= 500
                                        Cost = -1
                                    Case Is <= 1000
                                        Cost = -1
                                    Case Is <= 2000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 50
                                        Cost = Cost + AirLocalMorasele(1).Price
                                    Case Is > 50
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 50) / 10
                                        intTemp = Int((Weight - 50) / 10)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirLocalMorasele(1).Price + intTemp * AirLocalMorasele(2).Price
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalAirogram(1).Price
                                    Case Is <= 100
                                        Cost = -1
                                    Case Is <= 250
                                        Cost = -1
                                    Case Is <= 500
                                        Cost = -1
                                    Case Is <= 1000
                                        Cost = -1
                                    Case Is <= 2000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case CountryGroup
                                    Case 1
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(1).Price * intTemp
                                    Case 2
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(2).Price * intTemp
                                    Case 3
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(3).Price * intTemp
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
            
            Case "ﬂÊÅ‰ —Å‰”"
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Cost = -1
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalAirogram(1).Price
                                    Case Is <= 100
                                        Cost = -1
                                    Case Is <= 250
                                        Cost = -1
                                    Case Is <= 500
                                        Cost = -1
                                    Case Is <= 1000
                                        Cost = -1
                                    Case Is <= 2000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                Cost = -1
                            Case "»Ì‰ ‘Â—Ì"
                                Select Case Weight
                                    Case Is <= 50
                                        Cost = Cost + AirLocalMorasele(1).Price
                                    Case Is > 50
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight - 50) / 10
                                        intTemp = Int((Weight - 50) / 10)
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirLocalMorasele(1).Price + intTemp * AirLocalMorasele(2).Price
                                End Select
                            Case "Œ«—ÃÂ"
                                Select Case Weight
                                    Case Is <= 20
                                        Cost = Cost + GroundInternationalAirogram(1).Price
                                    Case Is <= 100
                                        Cost = -1
                                    Case Is <= 250
                                        Cost = -1
                                    Case Is <= 500
                                        Cost = -1
                                    Case Is <= 1000
                                        Cost = -1
                                    Case Is <= 2000
                                        Cost = -1
                                    Case Else
                                        Cost = -1
                                End Select
                                Select Case CountryGroup
                                    Case 1
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(1).Price * intTemp
                                    Case 2
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(2).Price * intTemp
                                    Case 3
                                        intTemp = 0
                                        sglTemp = 0
                                        sglTemp = (Weight) / 10
                                        intTemp = Int((Weight / 10))
                                        If sglTemp > intTemp Then
                                            intTemp = intTemp + 1
                                        End If
                                        Cost = Cost + AirInternationalMorasele(3).Price * intTemp
                                    Case Else
                                        Cost = -1
                                End Select
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
                
            Case "«„«‰ "
                Dim netCost As Long
                netCost = 0
                Select Case TransportType
                    Case "“„Ì‰Ì"
                        Select Case DestinationType
                            Case "‘Â—Ì"
                                intTemp = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                
                                If Trim(DestinationProvinceName) <> Trim(SourcePName) Then
                                    IntraProvince = False
                                Else
                                    IntraProvince = True
                                End If
                                
                                If SourceCName = "ﬂÌ‘" Or SourceCName = "ﬁ‘„" Then
                                    Cost = Cost + LocalAmanat.FromKishAndGheshmPrice * intTemp
                                Else
                                    If IntraProvince = False Then
                                        If Amanat_Tejari Then
                                            If IsRestant Then
                                                Cost = Cost + LocalAmanat.ExtraProvinceTejariPriceRestant * intTemp
                                            Else
                                                Cost = Cost + LocalAmanat.ExtraProvinceTejariPrice * intTemp
                                            End If
                                        Else
                                            Cost = Cost + LocalAmanat.InterProvincePrice * intTemp
                                        End If
                                    Else
                                        Cost = Cost + LocalAmanat.IntraProvincePrice * intTemp
                                    End If
                                    
                                    If IsIsland(DestinationCityName) Then ' Or Source is Island
                                        Cost = Cost + LocalAmanat.ToIslandsExtraPrice * intTemp
                                    End If
                                End If
                                
                                netCost = Cost
                                If IsBankAndMoney Then
                                    Cost = netCost + LocalAmanat.BankAndMoneyExtraPrice * intTemp
                                End If
                                
                                If IsMayeOrBreak Then
                                    Cost = Cost + netCost * LocalAmanat.MayeAndBreakPercentage
                                End If
                                                                                               
                                
                                If (Amanat_Anbooh) Then
                                    If ParcelCount > 10 And ParcelCount <= 20 Then
                                        Cost = Cost * LocalAmanat.MassAmanat10U20Percentage
                                    ElseIf ParcelCount > 20 Then
                                        Cost = Cost * LocalAmanat.MassAmanat21Percentage
                                    End If
                                End If
                                                                
                            Case "»Ì‰ ‘Â—Ì"
                                intTemp = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                
                                If Trim(DestinationProvinceName) <> Trim(SourcePName) Then
                                    IntraProvince = False
                                Else
                                    IntraProvince = True
                                End If
                                
                                If SourceCName = "ﬂÌ‘" Or SourceCName = "ﬁ‘„" Then
                                    Cost = Cost + LocalAmanat.FromKishAndGheshmPrice * intTemp
                                Else
                                    Set adoConn = New ADODB.Connection
                                    Set adoRst = New ADODB.Recordset
                                    'adoConn.Open "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" + G_DbPath + "\TTPOFFICE.mdb", "Admin", ""
                                    adoConn.Open G_ConnStr
                                    strSQL = "SELECT IsPort,IsFreeZone From CITY WHERE PNAME = '" & SourceCName & "'"
                                    adoRst.Open strSQL, adoConn, adOpenStatic, adLockOptimistic
                                    If adoRst.RecordCount > 0 Then
                                        If adoRst("IsPort") = True Or adoRst("IsFreeZone") = True Then
                                            Cost = Cost + LocalAmanat.FromFreeZonePrice * intTemp
                                        Else
                                            If IntraProvince = False Then
                                                If Amanat_Tejari Then
                                                    If IsRestant Then
                                                        Cost = Cost + LocalAmanat.ExtraProvinceTejariPriceRestant * intTemp
                                                    Else
                                                        Cost = Cost + LocalAmanat.ExtraProvinceTejariPrice * intTemp
                                                    End If
                                                Else
                                                    Cost = Cost + LocalAmanat.InterProvincePrice * intTemp
                                                End If
                                            Else
                                                Cost = Cost + LocalAmanat.IntraProvincePrice * intTemp
                                            End If
                                        End If
                                    Else 'Seems to be Error Case becasue City has not been found
                                        If IntraProvince Then
                                            Cost = Cost + LocalAmanat.IntraProvincePrice * intTemp
                                        Else
                                            Cost = Cost + LocalAmanat.InterProvincePrice * intTemp
                                        End If
                                    End If
                                End If
                                If IsIsland(DestinationCityName) Or IsIsland(SourceCName) Then ' Or Source is Island
                                    Cost = Cost + LocalAmanat.ToIslandsExtraPrice * intTemp
                                End If
                                 
                                netCost = Cost
                                If IsBankAndMoney Then
                                    Cost = netCost + LocalAmanat.BankAndMoneyExtraPrice * intTemp
                                End If
                                
                                   
                                If IsMayeOrBreak Then
                                    Cost = Cost + netCost * LocalAmanat.MayeAndBreakPercentage
                                End If
                                
                                '”Ê«· ‘Êœ ﬂÂ «„«‰  «‰»ÊÂ Â„  ”  ‘Êœ
'                                If ParcelCount > 10 And ParcelCount <= 20 Then
'                                    Cost = Cost * LocalAmanat.MassAmanat10U20Percentage
'                                ElseIf ParcelCount > 20 Then
'                                    Cost = Cost * LocalAmanat.MassAmanat21Percentage
'                                End If
                            Case "Œ«—ÃÂ"
                                intTemp = 0
                                tmpValue = 0
                                tmpExteraValue = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                
                                Set adoConn = New ADODB.Connection
                                Set adoRst = New ADODB.Recordset
                                
                                adoConn.Open G_ConnStr
                                strSQL = "SELECT * From Country WHERE countryname = '" & DestinationCountryName & "'"
                                adoRst.Open strSQL, adoConn, adOpenStatic, adLockOptimistic
                                
                                If adoRst.RecordCount > 0 Then
                                    adoRst.MoveFirst
                                    Select Case intTemp
                                        Case 1
'                                            tmpValue = adoRst("Landship1") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship1") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship1") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship1")
                                        Case 2
'                                            tmpValue = adoRst("Landship2") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship2") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship2") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship2")
                                        Case 3
'                                            tmpValue = adoRst("Landship3") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship3") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship3") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship3")
                                        Case 4
'                                            tmpValue = adoRst("Landship4") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship4") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship4") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship4")
                                        Case 5
'                                            tmpValue = adoRst("Landship5") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship5") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship5") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship5")
                                        Case 6
'                                            tmpValue = adoRst("Landship6") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship6") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship6") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship6")
                                        Case 7
'                                            tmpValue = adoRst("Landship7") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship7") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship7") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship7")
                                        Case 8
'                                            tmpValue = adoRst("Landship8") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship8") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship8") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship8")
                                        Case 9
'                                            tmpValue = adoRst("Landship9") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship9") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship9") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship9")
                                        Case 10
'                                            tmpValue = adoRst("Landship10") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship10") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship10") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Landship10")
                                        Case Is > 10
'                                            tmpValue = adoRst("Landship10") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Landship10") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Landship10") + tmpValue
'                                            End If
'
'                                            tmpValue = adoRst("Extera") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                tmpExteraValue = adoRst("Extera") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                tmpExteraValue = adoRst("Extera") + tmpValue
'                                            End If
'
'                                            Cost = Cost + (intTemp - 10) * tmpExteraValue

                                        tmpExteraValue = adoRst("Extera")
                                        Cost = Cost + adoRst("Landship10")
                                        Cost = Cost + (intTemp - 10) * tmpExteraValue

                                    End Select
                                End If
                                adoRst.Close
                                adoConn.Close
                                Set adoRst = Nothing
                                Set adoConn = Nothing
                                
                                netCost = Cost
                                If IsBankAndMoney Then
                                    Cost = netCost + LocalAmanat.BankAndMoneyExtraPrice * intTemp
                                End If
                                
                                  
                                If IsMayeOrBreak Then
                                    Cost = Cost + netCost * LocalAmanat.MayeAndBreakPercentage
                                End If
                                
                                'If ParcelCount > 10 And ParcelCount <= 20 Then
                                '    Cost = Cost * LocalAmanat.MassAmanat10U20Percentage
                                'ElseIf ParcelCount > 20 Then
                                '    Cost = Cost * LocalAmanat.MassAmanat21Percentage
                                'End If
                        
                        End Select
                    Case "ÂÊ«ÌÌ"
                        Select Case DestinationType
                            Case "»Ì‰ ‘Â—Ì"
                                intTemp = 0
                                sglTemp = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                
                                If DestinationProvinceName <> SourcePName Then
                                    IntraProvince = False
                                Else
                                    IntraProvince = True
                                End If
                                
                                If SourceCName = "ﬂÌ‘" Or SourceCName = "ﬁ‘„" Then
                                    Cost = Cost + LocalAmanat.FromKishAndGheshmPrice * intTemp
                                Else
                                    If IntraProvince = False Then
                                        If Amanat_Tejari Then
                                            If IsRestant Then
                                                Cost = Cost + LocalAmanat.ExtraProvinceTejariPriceRestant * intTemp
                                            Else
                                                Cost = Cost + LocalAmanat.ExtraProvinceTejariPrice * intTemp
                                            End If
                                        Else
                                            Cost = Cost + LocalAmanat.InterProvincePrice * intTemp
                                        End If
                                    Else
                                        Cost = Cost + LocalAmanat.IntraProvincePrice * intTemp
                                    End If
                                    
                                    If IsIsland(DestinationCityName) Then ' Or Source is Island
                                        Cost = Cost + LocalAmanat.ToIslandsExtraPrice * intTemp
                                    End If
                                End If
                                 
                                netCost = Cost
                                If IsBankAndMoney Then
                                    Cost = netCost + LocalAmanat.BankAndMoneyExtraPrice * intTemp
                                End If
                                
                                
                                  
                                If IsMayeOrBreak Then
                                    Cost = Cost + netCost * LocalAmanat.MayeAndBreakPercentage
                                End If
                                '”Ê«· ‘Êœ ﬂÂ «„«‰  «‰»ÊÂ Â„  ”  ‘Êœ
                                
                    
                                If (Amanat_Anbooh) Then
                                    If ParcelCount > 10 And ParcelCount <= 20 Then
                                        Cost = Cost * LocalAmanat.MassAmanat10U20Percentage
                                    ElseIf ParcelCount > 20 Then
                                        Cost = Cost * LocalAmanat.MassAmanat21Percentage
                                    End If
                                End If
        
                            
                            Case "Œ«—ÃÂ"
                                intTemp = 0
                                sglTemp = 0
                                tmpValue = 0
                                sglTemp = (Weight) / 1000
                                intTemp = Int((Weight / 1000))
                                If sglTemp > intTemp Then
                                    intTemp = intTemp + 1
                                End If
                                
                                Set adoConn = New ADODB.Connection
                                Set adoRst = New ADODB.Recordset
                                
                                adoConn.Open G_ConnStr
                                strSQL = "SELECT * From Country WHERE countryname = '" & DestinationCountryName & "'"
                                adoRst.Open strSQL, adoConn, adOpenStatic, adLockOptimistic
                                If adoRst.RecordCount > 0 Then
                                    adoRst.MoveFirst
                                    Select Case intTemp
                                        Case 1
                                        
'                                            tmpValue = adoRst("Airship1") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("Airship1") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("Airship1") + tmpValue
'                                            End If
                                             Cost = Cost + adoRst("Airship1")
                                        Case 2
'                                            tmpValue = adoRst("AirShip2") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip2") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip2") + tmpValue
'                                            End If
                                             Cost = Cost + adoRst("Airship2")
                                        Case 3
'                                            tmpValue = adoRst("AirShip3") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip3") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip3") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Airship3")
                                        Case 4
'                                            tmpValue = adoRst("AirShip4") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip4") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip4") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Airship4")
                                        Case 5
'                                            tmpValue = adoRst("AirShip5") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip5") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip5") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Airship5")
                                        Case 6
'                                            tmpValue = adoRst("AirShip6") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip6") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip6") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Airship6")
                                        Case 7
'                                            tmpValue = adoRst("AirShip7") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip7") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip7") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Airship7")
                                        Case 8
'                                            tmpValue = adoRst("AirShip8") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip8") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip8") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Airship8")
                                        Case 9
'                                            tmpValue = adoRst("AirShip9") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip9") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip9") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Airship9")
                                        Case 10
'                                            tmpValue = adoRst("AirShip10") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip10") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip10") + tmpValue
'                                            End If
                                            Cost = Cost + adoRst("Airship10")
                                        Case Is > 10
                                        ''<> AirExtra Adding
                                        '<HADI>
'                                            tmpValue = adoRst("AirShip10") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                Cost = Cost + adoRst("AirShip10") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                Cost = Cost + adoRst("AirShip10") + tmpValue
'                                            End If
'
'                                            tmpValue = adoRst("AirExtera") * 0.05
'                                            If Abs((tmpValue / 100) - Fix((tmpValue / 100))) > 0 Then
'                                                tmpExteraValue = adoRst("AirExtera") + tmpValue + (100 - 100 * ((tmpValue / 100) - Fix((tmpValue / 100))))
'                                            Else
'                                                tmpExteraValue = adoRst("AirExtera") + tmpValue
'                                            End If
'
'                                            Cost = Cost + (intTemp - 10) * tmpExteraValue
                                            
                                        ''</HADI>
                                        tmpExteraValue = adoRst("AirExtera")
                                        Cost = Cost + adoRst("AirShip10")
                                        Cost = Cost + (intTemp - 10) * tmpExteraValue
                                    End Select
                                End If
                                adoRst.Close
                                adoConn.Close
                                Set adoRst = Nothing
                                Set adoConn = Nothing
                                
                                netCost = Cost
                                If IsBankAndMoney Then
                                    Cost = netCost + LocalAmanat.BankAndMoneyExtraPrice * intTemp
                                End If
                                  
                                If IsMayeOrBreak Then
                                    Cost = Cost + netCost * LocalAmanat.MayeAndBreakPercentage
                                End If
                                '”Ê«· ‘Êœ ﬂÂ «„«‰  «‰»ÊÂ Â„  ”  ‘Êœ
'                                If ParcelCount > 10 And ParcelCount <= 20 Then
'                                    Cost = Cost * LocalAmanat.MassAmanat10U20Percentage
'                                ElseIf ParcelCount > 20 Then
'                                    Cost = Cost * LocalAmanat.MassAmanat21Percentage
'                                End If

                          If (Amanat_Anbooh) Then
                                    If ParcelCount > 10 And ParcelCount <= 20 Then
                                        Cost = Cost * LocalAmanat.MassAmanat10U20Percentage
                                    ElseIf ParcelCount > 20 Then
                                        Cost = Cost * LocalAmanat.MassAmanat21Percentage
                                    End If
                                End If
        
                        End Select
                    Case "œ—Ì«ÌÌ"
                        Cost = -1
                End Select
        End Select
        If Cost = -1 Then
            ParcelCost = -1
            Exit Function
        End If
        'Special Services
        Select Case DestinationType
            Case "‘Â—Ì"
                If IsRegistered And MoraseleType <> "«„«‰ " And (Not IsExpress) And MoraseleType <> "ﬂÌ”Â „Œ’Ê’" Then
                    Cost = Cost + LSpecialServices.MarsoleRegistrationPrice
                End If
                
                If (Not IsExpress) And MoraseleType = "ﬂÌ”Â „Œ’Ê’" Then
                    Cost = Cost + LSpecialServices.SpecialBagRegistrationPrice
                End If
                
                If IsExpress Then
                      intTemp = 0
                      sglTemp = 0
                      sglTemp = (Weight) / 1000
                      intTemp = Int((Weight / 1000))
                      If sglTemp > intTemp Then
                          intTemp = intTemp + 1
                      End If
                      If intTemp <= 2 Then
                        Cost = Cost + LSpecialServices.ExpressU2Price
                      Else
                        Cost = Cost + LSpecialServices.ExpressU2Price + (intTemp - 2) * LSpecialServices.ExtraExpressPrice
                      End If
                End If
                
                If Is2Receipt Then
                    Cost = Cost + LSpecialServices.ReturnChangePrice
                End If
                
                If IsDayOutOfTime Then
                    Cost = Cost + LSpecialServices.OutOfTimeAcceptanceDayPrice
                End If
                If IsNightOutOfTime Then
                    Cost = Cost + LSpecialServices.OutOfTimeAcceptanceNightPrice
                End If
                Cost = Cost + GetTimeExtraPrice
            Case "»Ì‰ ‘Â—Ì"
                If IsRegistered And MoraseleType <> "”ﬂÊê—«„" And MoraseleType <> "«„«‰ " And (Not IsExpress) And MoraseleType <> "ﬂÌ”Â „Œ’Ê’" Then
                    Cost = Cost + LSpecialServices.MarsoleRegistrationPrice
                End If
                If IsRegistered And MoraseleType = "”ﬂÊê—«„" And Weight > 7000 And (Not IsExpress) Then
                    Cost = Cost + LSpecialServices.MarsoleRegistrationPrice
                End If
                
                If (Not IsExpress) And MoraseleType = "ﬂÌ”Â „Œ’Ê’" Then
                    Cost = Cost + LSpecialServices.SpecialBagRegistrationPrice
                End If
                                
                If IsExpress Then
                      intTemp = 0
                      sglTemp = 0
                      sglTemp = (Weight) / 1000
                      intTemp = Int((Weight / 1000))
                      If sglTemp > intTemp Then
                          intTemp = intTemp + 1
                      End If
                      If intTemp <= 2 Then
                        Cost = Cost + LSpecialServices.ExpressU2Price
                      Else
                        Cost = Cost + LSpecialServices.ExpressU2Price + (intTemp - 2) * LSpecialServices.ExtraExpressPrice
                      End If
                End If
                
                If Is2Receipt Then
                    Cost = Cost + LSpecialServices.ReturnChangePrice
                End If
                
                If IsEMS2Receipt Then
                    Cost = Cost + LSpecialServices.EMSReturnReceiptPrice
                End If
                
                If IsDayOutOfTime Then
                        Cost = Cost + LSpecialServices.OutOfTimeAcceptanceDayPrice
                End If
                
                If IsNightOutOfTime Then
                    Cost = Cost + LSpecialServices.OutOfTimeAcceptanceNightPrice
                End If
                
                Cost = Cost + GetTimeExtraPrice
            
            Case "Œ«—ÃÂ"
                If IsRegistered And MoraseleType <> "«„«‰ " And MoraseleType <> "ﬂÌ”Â „Œ’Ê’" Then
                    Cost = Cost + ISpecialServices.MarsoleRegistrationPrice
                End If
                
                If (Not IsExpress) And MoraseleType = "ﬂÌ”Â „Œ’Ê’" Then
                    Cost = Cost + ISpecialServices.SpecialBagRegistrationPrice
                End If
                
                If IsExpress Then
                    intTemp = 0
                    sglTemp = 0
                    sglTemp = (Weight) / 1000
                    intTemp = Int((Weight / 1000))
                    If sglTemp > intTemp Then
                        intTemp = intTemp + 1
                    End If
                    Cost = Cost + ISpecialServices.ExpressPrice * intTemp
                End If
                
                If Is2Receipt Then
                    Cost = Cost + 12000
                End If
                
                If IsChangeAddress Then
                    Cost = Cost + ISpecialServices.ReturnChangePrice
                End If
                
                If IsCustoms And HasCN22 Then
                    Cost = Cost + ISpecialServices.GettingFromCustumesWithCN22
                End If
                
                If IsDispatched And (MoraseleType = "«„«‰ " Or MoraseleType = "»” Â") Then
                    Cost = Cost + ISpecialServices.DispatchSmallPackagesOrAmanatPrice
                End If
                'Œ«—ÃÂ Õﬁ ‘Ì›  ‰œ«—œ
                'Cost = Cost + GetTimeExtraPrice
        End Select
                
                                
                
    If ISOutOfSize Then
        'tmpCost = tmpCost + netCost * 0.25
        UnsizeCost = Cost * 0.25
    ''<> OutOfStandardPackage
    ElseIf ISOutOfStandardPackage Then
        UnstandardPackageCost = Cost * 0.25
    ''</> OutOfStandardPackage
    End If
                
        ParcelCost = Cost
End Function

Private Function EMSCost() As Long
    Dim intTemp As Long
    Dim sglTemp As Single
    Dim tmpCost As Long
    Dim netCost As Long
    Dim lngInsuranceTemp As Long
    Dim lngTemp As Long
    Dim tmpWeight
     
    netCost = 0
    InitClass
    tmpCost = 0
    tmpWeight = Weight
    
    If MoraseleType = "”ﬂÊê—«„" And Weight <= 7000 And TransportType = "“„Ì‰Ì" Then
        Cost = 0
        Exit Function
    End If
    
    Select Case DestinationType
        Case "‘Â—Ì", "»Ì‰ ‘Â—Ì"
            '‰—ŒÂ«Ì 81
            If tmpWeight <= 20 Then
                ''tmpCost = tmpCost + 3500
                tmpCost = tmpCost + 4200
                ''tmpCost = tmpCost + 3850
            ElseIf tmpWeight > 20 And tmpWeight <= 50 Then
                ''tmpCost = tmpCost + 4500
                tmpCost = tmpCost + 5300
            ElseIf tmpWeight > 50 And tmpWeight <= 100 Then
                ''tmpCost = tmpCost + 4500 + 1100
                ''tmpCost = tmpCost + 5000 + 1000
                tmpCost = tmpCost + 5300 + 1050
            ElseIf tmpWeight > 100 And tmpWeight <= 1000 Then
                intTemp = 0
                sglTemp = 0
                tmpWeight = tmpWeight - 100
                sglTemp = tmpWeight / 100
                intTemp = Int((tmpWeight / 100))
                If sglTemp > intTemp Then
                    intTemp = intTemp + 1
                End If
                ''tmpCost = tmpCost + 4500 + 1100 + intTemp * 1300
                ''tmpCost = tmpCost + 5000 + 1000 + intTemp * 1500
                tmpCost = tmpCost + 5300 + 1050 + intTemp * 1600
            ''ElseIf tmpWeight > 1000 Then 'And tmpWeight <= 10000 Then
            ElseIf tmpWeight > 1000 Then
                intTemp = 0
                sglTemp = 0
                tmpWeight = tmpWeight - 1000
                sglTemp = tmpWeight / 1000
                intTemp = Int((tmpWeight / 1000))
                If sglTemp > intTemp Then
                    intTemp = intTemp + 1
                End If
                ''tmpCost = tmpCost + 17300 + intTemp * 5200
                tmpCost = tmpCost + 20750 + intTemp * 6300
                ''tmpCost = tmpCost + 18800 + intTemp * 5700
            End If
            tmpCost = tmpCost + GetTimeExtraPrice
'        Case "»Ì‰ ‘Â—Ì"
'            If tmpWeight <= 50 Then
'                tmpCost = tmpCost + 3000
'            ElseIf tmpWeight > 50 And tmpWeight <= 100 Then
'                tmpCost = tmpCost + 3000 + 1000
'            ElseIf tmpWeight > 100 And tmpWeight <= 1000 Then
'                intTemp = 0
'                sglTemp = 0
'                tmpWeight = tmpWeight - 100
'                sglTemp = tmpWeight / 100
'                intTemp = Int((tmpWeight / 100))
'                If sglTemp > intTemp Then
'                    intTemp = intTemp + 1
'                End If
'                tmpCost = tmpCost + 3000 + 1000 + intTemp * 1200
'            ElseIf tmpWeight > 1000 Then 'And tmpWeight <= 10000 Then
'                intTemp = 0
'                sglTemp = 0
'                tmpWeight = tmpWeight - 1000
'                sglTemp = tmpWeight / 1000
'                intTemp = Int((tmpWeight / 1000))
'                If sglTemp > intTemp Then
'                    intTemp = intTemp + 1
'                End If
'                tmpCost = tmpCost + 14800 + intTemp * 4700
'            End If
'            tmpCost = tmpCost + GetTimeExtraPrice
        Case "Œ«—ÃÂ"
            '‰—ŒÂ«Ì 81
            If tmpWeight <= 500 Then
                Select Case EMSCountryGroup
                    Case 1
                        'tmpCost = 48700
                        'tmpCost = 80000
                        tmpCost = 134000
                        ''tmpCost = 88000
                    Case 2
                        'tmpCost = 75400
                        'tmpCost = 110000
                        tmpCost = 185000
                        ''tmpCost = 121000
                    Case 3
                        'tmpCost = 100200
                        'tmpCost = 140000
                        tmpCost = 235000
                        'tmpCost = 154000
                End Select
                ' add by sayyar at 1380/10/09
                tmpCost = tmpCost + GetTimeExtraPrice
            Else
                intTemp = 0
                sglTemp = 0
                sglTemp = (tmpWeight - 500) / 500
                intTemp = Int(((tmpWeight - 500) / 500))
                If sglTemp > intTemp Then
                    intTemp = intTemp + 1
                End If
                Select Case EMSCountryGroup
                    Case 1
                        'tmpCost = 48700 + 24800 * intTemp
                        'tmpCost = 80000 + 30000 * intTemp
                        tmpCost = 134000 + 50000 * intTemp
                        ''tmpCost = 88000 + 33000 * intTemp
                    Case 2
                        'tmpCost = 75400 + 38000 * intTemp
                        'tmpCost = 110000 + 40000 * intTemp
                        tmpCost = 185000 + 67000 * intTemp
                        'tmpCost = 121000 + 44000 * intTemp
                    Case 3
                        'tmpCost = 100200 + 43400 * intTemp
                        'tmpCost = 140000 + 50000 * intTemp
                        tmpCost = 235000 + 84000 * intTemp
                        'tmpCost = 154000 + 55000 * intTemp
                End Select
            End If
            
    End Select
    
    netCost = tmpCost
    If ISOutOfSize Then
        'tmpCost = tmpCost + netCost * 0.25
        UnsizeCost = netCost * 0.25
    ''<> OutOfStandardPackage
    ElseIf ISOutOfStandardPackage Then
        UnstandardPackageCost = netCost * 0.25
    ''</> OutOfStandardPackage
    End If
      
    If IsMayeOrBreak Then
        tmpCost = tmpCost + netCost * 0.25
    End If
    If Is2Receipt = True Then
        
        If DestinationType = "‘Â—Ì" Or DestinationType = "»Ì‰ ‘Â—Ì" Then
            tmpCost = tmpCost + LSpecialServices.EMSReturnReceiptPrice
        Else
            tmpCost = tmpCost + LSpecialServices.EMSReturnReceiptPriceKharej
        End If
    End If
    EMSCost = tmpCost
End Function

Private Function IsIsland(ByVal strDestName As String)
        Dim counter As Long
        
        For counter = 1 To 13
            If InStr(1, strDestName, HormozganIslandNames(counter)) > 0 Then
                IsIsland = True
                Exit Function
            End If
        Next counter
        
        For counter = 1 To 2
            If InStr(1, strDestName, BooshehrIslandNames(counter)) Then
                IsIsland = True
                Exit Function
            End If
        Next counter
        IsIsland = False
End Function

Public Function GetCost() As Long
        Cost = 0
        If IsEMSType Then
            Cost = EMSCost
        Else
            Cost = ParcelCost
        End If
        If Cost = -1 Then
            GetCost = -1
            Exit Function
        End If
        If IsSendPlace = True Then
            MySendPlaceCost = SendPlaceCost
            '<Hadi>
            '<Date 85/3/24 />
            '<Detail Remark 1 Line />
            'Cost = Cost + MySendPlaceCost
            '</Hadi>
        End If
        PostalCost = Cost
        InsuranceCost = GetInsuranceCost
        If InsuranceCost < 0 Then
            GetCost = -1
            Exit Function
        End If
        TotalCost = OtherPrice + PackingPrice + CustomerStampPrice + InsuranceCost + PostalCost + UnsizeCost
        GetCost = TotalCost
End Function

Public Function GetInsuranceCost() As Long
        Dim intTemp As Long
        Dim sglTemp As Single
        Dim tmpCost As Long
        Dim lngInsuranceTemp As Long
        Dim lngTemp As Long
        
        lngInsuranceTemp = 0
        If HasKnownValueCashIranInsurance Then
            lngTemp = ToldValue
            If lngTemp > KnownValueCashIranInsurance.MaximumAcceptableCost Then
                G_ShowMsg "„ﬁœ«— «ŸÂ«— ‘œÂ »«Ìœ Õœ«ﬂÀ— 500.000.000 —Ì«· »«‘œ", vbOKOnly
                GetInsuranceCost = -1
                Exit Function
            End If
            lngInsuranceTemp = KnownValueCashIranInsurance.CostPercentage * lngTemp
            If MoraseleType = "‰«„Â" Then
                If lngInsuranceTemp < KnownValueCashIranInsurance.MinimumInsuranceEnvelope And KnownValueCashIranInsurance.MinimumInsuranceEnvelope > 0 Then
                 lngInsuranceTemp = KnownValueCashIranInsurance.MinimumInsuranceEnvelope
                End If
            ElseIf MoraseleType = "»” Â" Then
                If lngInsuranceTemp < KnownValueCashIranInsurance.MinimumInsurancePackage And KnownValueCashIranInsurance.MinimumInsurancePackage > 0 Then
                 lngInsuranceTemp = KnownValueCashIranInsurance.MinimumInsurancePackage
                End If
            End If
        ElseIf HasKnownValueOthersIranInsurance Then
            lngTemp = ToldValue
            If lngTemp > KnownValueOthersIranInsurance.MaximumAcceptableCost Then
                G_ShowMsg "„ﬁœ«— «ŸÂ«— ‘œÂ »«Ìœ Õœ«ﬂÀ— 50.000.000 —Ì«· »«‘œ", vbOKOnly
                GetInsuranceCost = -1
                Exit Function
            End If
            lngInsuranceTemp = KnownValueOthersIranInsurance.CostPercentage * lngTemp
            If MoraseleType = "‰«„Â" Then
                If lngInsuranceTemp < KnownValueOthersIranInsurance.MinimumInsuranceEnvelope And KnownValueOthersIranInsurance.MinimumInsuranceEnvelope > 0 Then
                 lngInsuranceTemp = KnownValueOthersIranInsurance.MinimumInsuranceEnvelope
                End If
            ElseIf MoraseleType = "»” Â" Then
                If lngInsuranceTemp < KnownValueOthersIranInsurance.MinimumInsurancePackage And KnownValueOthersIranInsurance.MinimumInsurancePackage > 0 Then
                 lngInsuranceTemp = KnownValueOthersIranInsurance.MinimumInsurancePackage
                End If
            End If
        ElseIf HasUnknownValueEnvelopeIranInsurance Then
            lngTemp = ToldValue
            lngInsuranceTemp = 200
        ElseIf HasUnknownValuePackIranInsurance Then
            lngTemp = ToldValue
            lngInsuranceTemp = 500
        ElseIf HasForeignInsurance Then
            lngTemp = ToldValue
            If lngTemp > ForeignInsurance.MaximumAcceptableCost Then
                G_ShowMsg "„ﬁœ«— «ŸÂ«— ‘œÂ »«Ìœ Õœ«ﬂÀ— 6.000.000 —Ì«· »«‘œ", vbOKOnly
                GetInsuranceCost = -1
                Exit Function
            End If
            lngInsuranceTemp = ForeignInsurance.CostPercentage * lngTemp
            If lngInsuranceTemp < ForeignInsurance.MinimumInsurance And ForeignInsurance.MinimumInsurance > 0 Then
                lngInsuranceTemp = ForeignInsurance.MinimumInsurance
            End If
        End If
        ''</>  Iran Insurance
        GetInsuranceCost = lngInsuranceTemp
End Function

Private Function SendPlaceCost() As Long
        Dim lngTemp As Long
        Dim sglTemp As Single
        Dim tmpCost As Long
        
        Select Case DestinationType
            Case "‘Â—Ì", "»Ì‰ ‘Â—Ì"
                'If MoraseleType = "«„«‰ " Or MoraseleType = "»” Â" Then
                
                
                If MoraseleType = "«„«‰ " Then
                    'Select Case ParcelCount
                    Select Case ParcelIndex + 1
                        Case Is = 1
                            tmpCost = 2300
                            ''tmpCost = 2500 + (Weight \ 1000) * 550
                        Case Is <= 10
                            'tmpCost = 2300 + (ParcelCount - 1) * 1150
                            tmpCost = 1150
                            'tmpCost = 1300 + (Weight \ 1000) * 550
                        Case Is <= 30
                            'tmpCost = 2300 + 8 * 1150 + (ParcelCount - 9) * 550
                            tmpCost = 550
                            'tmpCost = 600 + (Weight \ 1000) * 550
                        Case Is > 30
                            'tmpCost = 2300 + 8 * 1100 + 20 * 550 + (ParcelCount - 29) * 220
                            tmpCost = 220
                            'tmpCost = 250 + (Weight \ 1000) * 550
                    End Select
                    
                    If Amanat_Tejari = False Then
                        tmpCost = tmpCost + (Weight \ 1000) * 500
                    End If
                Else
                    'Select Case ParcelCount
                   Select Case ParcelIndex + 1
                        Case Is = 1
                            'tmpCost = 1150
                            tmpCost = 1500
                            'tmpCost = 1650
                        Case Is <= 10
                            
                            'tmpCost = 1150 + (ParcelCount - 1) * 500
                            tmpCost = 500
                            'tmpCost = 550
                        Case Is <= 30
                            'tmpCost = 1150 + 8 * 500 + (ParcelCount - 9) * 200
                            tmpCost = 200
                            'tmpCost = 220
                        Case Is > 30
                            'tmpCost = 1150 + 8 * 500 + 20 * 200 + (ParcelCount - 29) * 170
                            tmpCost = 170
                            'tmpCost = 200
                    End Select
                End If
            Case "Œ«—ÃÂ"
                If MoraseleType <> "«„«‰ " Or MoraseleType <> "»” Â" Then
                    Select Case ParcelCount
                        Case Is = 1
                            'tmpCost = 1150
                            tmpCost = 1500
                            'tmpCost = 1650
                        Case Is <= 10
                            'tmpCost = 1150 + (ParcelCount - 1) * 500
                            tmpCost = 500
                            'tmpCost = 550
                        Case Is <= 30
                            'tmpCost = 1150 + 8 * 500 + (ParcelCount - 9) * 200
                            tmpCost = 200
                            'tmpCost = 220
                        Case Is > 30
                            'tmpCost = 1150 + 8 * 500 + 20 * 200 + (ParcelCount - 29) * 170
                            tmpCost = 170
                            'tmpCost = 200
                    End Select
                Else
                    tmpCost = -1
                End If
        End Select
        SendPlaceCost = tmpCost
        
End Function

Private Function GetTimeExtraPrice() As Integer
        Dim intHour As Byte
        Dim intMinute As Byte
        
        intHour = CInt(Mid(Format(Now, "HH:MM"), 1, 2))
        intMinute = CInt(Mid(Format(Now, "HH:MM"), 4, 2))
        If (intHour >= 20 And intHour <= 24) Or (intHour >= 0 And intHour < 7) Then
            GetTimeExtraPrice = 300
            Exit Function
        End If
        If (intHour >= 14 And intHour < 20) Then
            If (intHour > 14 And intHour < 20) Then
                GetTimeExtraPrice = 200
                Exit Function
            ElseIf (intHour = 14 And intMinute >= 30) Then
                GetTimeExtraPrice = 200
                Exit Function
            End If
        End If
        
        
End Function

