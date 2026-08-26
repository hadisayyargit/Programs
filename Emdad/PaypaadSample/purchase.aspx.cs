using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pasargad;
using System.Xml;

public partial class purchase : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PasargadCart cart = (PasargadCart)Session["cartObject"]; // restore cart object


        string tref = Request["tref"];
        string i_date = Request["iD"];
        string i_number = Request["iN"];


        

        XmlDocument xml_result = new XmlDocument();

        if (!String.IsNullOrEmpty(tref))
        {
            xml_result = PasargadUtil.getResponse(tref);
        }

        else if (cart != null)
        {
            xml_result = PasargadUtil.getResponse(cart);
        }
        else
        {
            //something is wrong
        }
        if (xml_result.GetElementsByTagName("result").Item(0).InnerText == "true")
        {
            if ((int)float.Parse(xml_result.GetElementsByTagName("amount").Item(0).InnerText) != cart.get_total_amount())
            {
                //
            }
            else
            {
                //complete the shopping
                Response.Write("FINISHED");
            }
        }
        else
        {
            //something is wrong
        }
    }
}