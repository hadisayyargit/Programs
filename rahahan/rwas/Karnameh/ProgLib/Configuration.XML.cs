using System;
using System.Xml;

namespace ProgLib.Configuration.XML
{
	public enum TypeData
	{
		// Fields
		ServerName = 0,
		ClientName = 1,
		DataBase = 2,
		UserName = 3,
		PassWord = 4,
		Path1 = 5,
		Path2 = 6,
		Path3 = 7,
		Url1 = 8,
		Url2 = 9,
		Url3 = 10,
		Url4 = 11,
		Url5 = 12,
		ConnectionType = 13,
		Port = 14,
		Color_FrmRed=15,
		Color_FrmGreen=16,
		Color_FrmBlue=17,
		Color_FrmFromSpectrumRed=18,
		Color_FrmFromSpectrumGreen=19,
		Color_FrmFromSpectrumBlue=20,
		Color_FrmToSpectrumRed=21,
		Color_FrmToSpectrumGreen=22,
		Color_FrmToSpectrumBlue=23,
		Color_GrdBackColorRed=24,
		Color_GrdBackColorGreen=25,
		Color_GrdBackColorBlue=26,
		Color_GrdCaptionColorRed=27,
		Color_GrdCaptionColorGreen=28,
		Color_GrdCaptionColorBlue=29,
		Color_GrdAlternativeColorRed=30,
		Color_GrdAlternativeColorGreen=31,
		Color_GrdAlternativeColorBlue=32,
		Color_GrdHeaderColorRed=33,
		Color_GrdHeaderColorGreen=34,
		Color_GrdHeaderColorBlue=35,
		Color_FloatMenuColorRed=36,
		Color_FloatMenuColorGreen=37,
		Color_FloatMenuColorBlue=38,
		Color_FloatMenuItemBackColorRed=39,
		Color_FloatMenuItemBackColorGreen=40,
		Color_FloatMenuItemBackColorBlue=41,
		Color_FloatMenuItemForColorRed=42,
        Color_FloatMenuItemForColorGreen=43,
		Color_FloatMenuItemForColorBlue=44,
		Color_System=45,
		ReportPath=46,
		XMLVersion=47
	}

	public class CAfdiXML : CXMLDocument
	{
		// Fields
		private XmlTextReader ocXmlTextReader;
		private string strClient;
		private string strConnectionType;
		private string strDataBase;
		private string strElement;
		private string strPassWord;
		private string strPath1;
		private string strPath2;
		private string strPath3;
		private string strPort;
		private string strServer;
		private string strUrl1;
		private string strUrl2;
		private string strUrl3;
		private string strUrl4;
		private string strUrl5;
		private string strUserName;

		private string strColor_System;

		private string strReportPath;
		private string strXMLVersion;

		private string strColor_FrmRed;
		private string strColor_FrmGreen;
		private string strColor_FrmBlue;
		private string strColor_FrmFromSpectrumRed;
		private string strColor_FrmFromSpectrumGreen;
		private string strColor_FrmFromSpectrumBlue;
		private string strColor_FrmToSpectrumRed;
		private string strColor_FrmToSpectrumGreen;
		private string strColor_FrmToSpectrumBlue;
		private string strColor_GrdBackColorRed;
		private string strColor_GrdBackColorGreen;
		private string strColor_GrdBackColorBlue;
		private string strColor_GrdCaptionColorRed;
		private string strColor_GrdCaptionColorGreen;
		private string strColor_GrdCaptionColorBlue;
		private string strColor_GrdAlternativeColorRed;
		private string strColor_GrdAlternativeColorGreen;
		private string strColor_GrdAlternativeColorBlue;
		private string strColor_GrdHeaderColorRed;
		private string strColor_GrdHeaderColorGreen;
		private string strColor_GrdHeaderColorBlue;
		private string strColor_FloatMenuColorRed;
		private string strColor_FloatMenuColorGreen;
		private string strColor_FloatMenuColorBlue;
		private string strColor_FloatMenuItemBackColorRed;
		private string strColor_FloatMenuItemBackColorGreen;
		private string strColor_FloatMenuItemBackColorBlue;
		private string strColor_FloatMenuItemForColorRed;
		private string strColor_FloatMenuItemForColorGreen;
		private string strColor_FloatMenuItemForColorBlue;


		// Methods
		public CAfdiXML(string strXmlFile)
		{
			string text1;
			this.strPort = text1 = string.Empty;
			this.strConnectionType = text1 = text1;
			this.strUrl5 = text1 = text1;
			this.strUrl4 = text1 = text1;
			this.strUrl3 = text1 = text1;
			this.strUrl2 = text1 = text1;
			this.strUrl1 = text1 = text1;
			this.strPath3 = text1 = text1;
			this.strPath2 = text1 = text1;
			this.strPath1 = text1 = text1;
			this.strElement = text1 = text1;
			this.strPassWord = text1 = text1;
			this.strUserName = text1 = text1;
			this.strDataBase = text1 = text1;
			this.strClient = text1 = text1;
			this.strServer = text1;
			this.strXMLVersion = text1;
			try
			{
				if (strXmlFile == "")
				{
					throw new Exception("ProgLib Error - CAfdiXML : Input string not be null.");
				}
				this.ocXmlTextReader = new XmlTextReader(strXmlFile);
				if (!this.CkeckSyntax(this.ocXmlTextReader))
				{
					throw new Exception("ProgLib Error - CAfdiXML : Xml syntax check is failed.");
				}
			}
			catch (Exception exception1)
			{
				throw new Exception("ProgLib Error - CAfdiXML : " + exception1.Message);
			}
		}

		protected override bool CkeckSyntax(XmlTextReader reader)
		{
			int num2;
			int num3;
			int num4;
			int num1 = num2 = num3 = num4 = 0;
			while (reader.Read())
			{
				switch (reader.NodeType)
				{
					case XmlNodeType.Element:
					{
						num1++;
						this.strElement = reader.Name.ToLower();
						continue;
					}
					case XmlNodeType.Attribute:
					{
						continue;
					}
					case XmlNodeType.Text:
					{
						if (this.strElement != "srv-name")
						{
							goto Label_009E;
						}
						this.strServer = reader.Value;
						continue;
					}
					case XmlNodeType.Entity:
					{
						goto Label_0069;
					}
					case XmlNodeType.EndElement:
					{
						num2++;
						continue;
					}
					case XmlNodeType.EndEntity:
					{
						num4++;
						continue;
					}
					default:
					{
						continue;
					}
				}
			Label_0069:
				num3++;
				continue;
			Label_009E:
				if (this.strElement == "cli-name")
				{
					this.strClient = reader.Value;
					continue;
				}
				if (this.strElement == "database")
				{
					this.strDataBase = reader.Value;
					continue;
				}
				if (this.strElement == "username")
				{
					this.strUserName = reader.Value;
					continue;
				}
				if (this.strElement == "password")
				{
					this.strPassWord = reader.Value;
					continue;
				}
				if (this.strElement == "path1")
				{
					this.strPath1 = reader.Value;
					continue;
				}
				if (this.strElement == "path2")
				{
					this.strPath2 = reader.Value;
					continue;
				}
				if (this.strElement == "path3")
				{
					this.strPath3 = reader.Value;
					continue;
				}
				if (this.strElement == "url1")
				{
					this.strUrl1 = reader.Value;
					continue;
				}
				if (this.strElement == "url2")
				{
					this.strUrl2 = reader.Value;
					continue;
				}
				if (this.strElement == "url3")
				{
					this.strUrl3 = reader.Value;
					continue;
				}
				if (this.strElement == "url4")
				{
					this.strUrl4 = reader.Value;
					continue;
				}
				if (this.strElement == "url5")
				{
					this.strUrl5 = reader.Value;
					continue;
				}
				if (this.strElement == "connecttype")
				{
					this.strConnectionType = reader.Value;
					continue;
				}
				if (this.strElement == "port")
				{
					this.strPort = reader.Value;
				}

				if (this.strElement == "reportpath")
				{
					this.strReportPath= reader.Value;
				}

				if (this.strElement == "XMLVersion")
				{
					this.strXMLVersion= reader.Value;
				}

				if (this.strElement == "color_system")
				{
					this.strColor_System= reader.Value;
				}

				if (this.strElement == "color_frmred")
				{
					this.strColor_FrmRed = reader.Value;
				}
				if (this.strElement == "color_frmgreen")
				{
					this.strColor_FrmGreen = reader.Value;
				}
				if (this.strElement == "color_frmblue")
				{
					this.strColor_FrmBlue = reader.Value;
				}


				if (this.strElement == "color_frmfromspectrumred")
				{
					this.strColor_FrmFromSpectrumRed = reader.Value;
				}
				if (this.strElement == "color_frmfromspectrumgreen")
				{
					this.strColor_FrmFromSpectrumGreen = reader.Value;
				}
				if (this.strElement == "color_frmfromspectrumblue")
				{
					this.strColor_FrmFromSpectrumBlue = reader.Value;
				}


				if (this.strElement == "color_frmtospectrumred")
				{
					this.strColor_FrmToSpectrumRed = reader.Value;
				}
				if (this.strElement == "color_frmtospectrumgreen")
				{
					this.strColor_FrmToSpectrumGreen = reader.Value;
				}
				if (this.strElement == "color_frmtospectrumblue")
				{
					this.strColor_FrmToSpectrumBlue = reader.Value;
				}


				if (this.strElement == "color_grdbackcolorred")
				{
					this.strColor_GrdBackColorRed = reader.Value;
				}
				if (this.strElement == "color_grdbackcolorgreen")
				{
					this.strColor_GrdBackColorGreen = reader.Value;
				}
				if (this.strElement == "color_grdbackcolorblue")
				{
					this.strColor_GrdBackColorBlue = reader.Value;
				}


				if (this.strElement == "color_grdcaptioncolorred")
				{
					this.strColor_GrdCaptionColorRed = reader.Value;
				}
				if (this.strElement == "color_grdcaptioncolorgreen")
				{
					this.strColor_GrdCaptionColorGreen = reader.Value;
				}
				if (this.strElement == "color_grdcaptioncolorblue")
				{
					this.strColor_GrdCaptionColorBlue = reader.Value;
				}


				if (this.strElement == "color_grdalternativecolorred")
				{
					this.strColor_GrdAlternativeColorRed = reader.Value;
				}
				if (this.strElement == "color_grdalternativecolorgreen")
				{
					this.strColor_GrdAlternativeColorGreen = reader.Value;
				}
				if (this.strElement == "color_grdalternativecolorblue")
				{
					this.strColor_GrdAlternativeColorBlue = reader.Value;
				}

				if (this.strElement == "color_grdheadercolorred")
				{
					this.strColor_GrdHeaderColorRed = reader.Value;
				}
				if (this.strElement == "color_grdheadercolorgreen")
				{
					this.strColor_GrdHeaderColorGreen = reader.Value;
				}
				if (this.strElement == "color_grdheadercolorblue")
				{
					this.strColor_GrdHeaderColorBlue = reader.Value;
				}


				if (this.strElement == "color_floatmenucolorred")
				{
					this.strColor_FloatMenuColorRed = reader.Value;
				}
				if (this.strElement == "color_floatmenucolorgreen")
				{
					this.strColor_FloatMenuColorGreen = reader.Value;
				}
				if (this.strElement == "color_floatmenucolorblue")
				{
					this.strColor_FloatMenuColorBlue = reader.Value;
				}


				if (this.strElement == "color_floatmenuitembackcolorred")
				{
					this.strColor_FloatMenuItemBackColorRed = reader.Value;
				}
				if (this.strElement == "color_floatmenuitembackcolorgreen")
				{
					this.strColor_FloatMenuItemBackColorGreen = reader.Value;
				}
				if (this.strElement == "color_floatmenuitembackcolorblue")
				{
					this.strColor_FloatMenuItemBackColorBlue = reader.Value;
				}

				if (this.strElement == "color_floatmenuitemforcolorred")
				{
					this.strColor_FloatMenuItemForColorRed = reader.Value;
				}
				if (this.strElement == "color_floatmenuitemforcolorgreen")
				{
					this.strColor_FloatMenuItemForColorGreen = reader.Value;
				}
				if (this.strElement == "color_floatmenuitemforcolorblue")
				{
					this.strColor_FloatMenuItemForColorBlue = reader.Value;
				}
			}

			reader.Close();

			if (num1 != num2)
			{
				return false;
			}
			if (num3 != num4)
			{
				return false;
			}

			return true;
		}

//		public string ConnectionType{
//			get {
//				return strConnectionType;
//			}
//		}
		
		public string GetData(TypeData typeData)
		{
			switch (typeData)
			{
				case TypeData.ServerName:
				{
					return this.strServer;
				}
				case TypeData.ClientName:
				{
					return this.strClient;
				}
				case TypeData.DataBase:
				{
					return this.strDataBase;
				}
				case TypeData.UserName:
				{
					return this.strUserName;
				}
				case TypeData.PassWord:
				{
					return this.strPassWord;
				}
				case TypeData.Path1:
				{
					return this.strPath1;
				}
				case TypeData.Path2:
				{
					return this.strPath2;
				}
				case TypeData.Path3:
				{
					return this.strPath3;
				}
				case TypeData.Url1:
				{
					return this.strUrl1;
				}
				case TypeData.Url2:
				{
					return this.strUrl2;
				}
				case TypeData.Url3:
				{
					return this.strUrl3;
				}
				case TypeData.Url4:
				{
					return this.strUrl4;
				}
				case TypeData.Url5:
				{
					return this.strUrl5;
				}
				case TypeData.ConnectionType:
				{
					return this.strConnectionType;
				}
				case TypeData.Port:
				{
					return this.strPort;
				}

				case TypeData.ReportPath:
				{
					return this.strReportPath;
				}

				case TypeData.Color_System:
				{
					return this.strColor_System;
				}

				case TypeData.Color_FrmRed:
				{
					return this.strColor_FrmRed;
				}
				case TypeData.Color_FrmGreen:
				{
					return this.strColor_FrmGreen;
				}
				case TypeData.Color_FrmBlue:
				{
					return this.strColor_FrmBlue;
				}


				case TypeData.Color_FrmFromSpectrumRed:
				{
					return this.strColor_FrmFromSpectrumRed;
				}
				case TypeData.Color_FrmFromSpectrumGreen:
				{
					return this.strColor_FrmFromSpectrumGreen;
				}
				case TypeData.Color_FrmFromSpectrumBlue:
				{
					return this.strColor_FrmFromSpectrumBlue;
				}


				case TypeData.Color_FrmToSpectrumRed:
				{
					return this.strColor_FrmToSpectrumRed;
				}
				case TypeData.Color_FrmToSpectrumGreen:
				{
					return this.strColor_FrmToSpectrumGreen;
				}
				case TypeData.Color_FrmToSpectrumBlue:
				{
					return this.strColor_FrmToSpectrumBlue;
				}

				case TypeData.Color_GrdBackColorRed:
				{
					return this.strColor_GrdBackColorRed;
				}
				case TypeData.Color_GrdBackColorGreen:
				{
					return this.strColor_GrdBackColorGreen;
				}
				case TypeData.Color_GrdBackColorBlue:
				{
					return this.strColor_GrdBackColorBlue;
				}


				case TypeData.Color_GrdCaptionColorRed:
				{
					return this.strColor_GrdCaptionColorRed;
				}
				case TypeData.Color_GrdCaptionColorGreen:
				{
					return this.strColor_GrdCaptionColorGreen;
				}
				case TypeData.Color_GrdCaptionColorBlue:
				{
					return this.strColor_GrdCaptionColorBlue;
				}


				case TypeData.Color_GrdAlternativeColorRed:
				{
					return this.strColor_GrdAlternativeColorRed;
				}
				case TypeData.Color_GrdAlternativeColorGreen:
				{
					return this.strColor_GrdAlternativeColorGreen;
				}
				case TypeData.Color_GrdAlternativeColorBlue:
				{
					return this.strColor_GrdAlternativeColorBlue;
				}


				case TypeData.Color_GrdHeaderColorRed:
				{
					return this.strColor_GrdHeaderColorRed;
				}
				case TypeData.Color_GrdHeaderColorGreen:
				{
					return this.strColor_GrdHeaderColorGreen;
				}
				case TypeData.Color_GrdHeaderColorBlue:
				{
					return this.strColor_GrdHeaderColorBlue;
				}


				case TypeData.Color_FloatMenuColorRed:
				{
					return this.strColor_FloatMenuColorRed;
				}
				case TypeData.Color_FloatMenuColorGreen:
				{
					return this.strColor_FloatMenuColorGreen;
				}
				case TypeData.Color_FloatMenuColorBlue:
				{
					return this.strColor_FloatMenuColorBlue;
				}


				case TypeData.Color_FloatMenuItemBackColorRed:
				{
					return this.strColor_FloatMenuItemBackColorRed;
				}
				case TypeData.Color_FloatMenuItemBackColorGreen:
				{
					return this.strColor_FloatMenuItemBackColorGreen;
				}
				case TypeData.Color_FloatMenuItemBackColorBlue:
				{
					return this.strColor_FloatMenuItemBackColorBlue;
				}


				case TypeData.Color_FloatMenuItemForColorRed:
				{
					return this.strColor_FloatMenuItemForColorRed;
				}
				case TypeData.Color_FloatMenuItemForColorGreen:
				{
					return this.strColor_FloatMenuItemForColorGreen;
				}
				case TypeData.Color_FloatMenuItemForColorBlue:
				{
					return this.strColor_FloatMenuItemForColorBlue;
				}
			}

			ocXmlTextReader.Close();

			return string.Empty;
		}

		public string GetSyntaxSample()
		{
			return "<!--  This file contains connection info and other configuration info --> \n\r<ConnectionInfo>\n\r<Srv-Name>Afdi-Srv08</Srv-Name>\n\r<Cli-Name>Afdi-Cli01</Cli-Name>\n\r</ConnectionInfo>\n\r<Path1>c:</Path1>\n\r<Path2>d:</Path2>\n\r<Path3>e:</Path3>";
		}


		
	}


	public class CXMLDocument
	{
		// Methods
		public CXMLDocument()
		{
		}

		protected virtual bool CkeckSyntax(XmlTextReader reader)
		{
			return false;
		}

		public virtual void LoadDocument(string strXmlFile)
		{
		}
	}
}


