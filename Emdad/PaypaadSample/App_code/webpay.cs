using Pasargad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for webpay
/// </summary>
public class webpay
{
	public webpay()
	{

	}

    public webpay(String invoice_date, String invoice_number, int amount)
    {
        this.invoice_date = invoice_date;
        this.invoice_number = invoice_number;
        this.amount = amount;
    }

    public String invoice_date
    {
        get;
        set;
    }
    public String invoice_number
    {
        get;
        set;
    }
    public String merchant_code
    {
        get;
        set;
    }
    public String terminal_code
    {
        get;
        set;
    }
    public String redirect_address
    {
        get;
        set;
    }
    public String referrer_address
    {
        get;
        set;
    }

    private int amount
    {
        get;
        set;
    }

    public void PostCoupon()
    {
        PasargadCart myCart = new PasargadCart();

        //ساخت کلاس کارت خرید 
        myCart.invoice_date = this.invoice_date;
        myCart.invoice_number = this.invoice_number;
        myCart.time_stamp = DateTime.Now;
        //ساخت کلاس آیتم خرید برای نگهداری اطلاعات خرید
        PasargadItem item1 = new PasargadItem();
        item1.content = "کوپن";
        item1.amount = this.amount;
        item1.count = 1;
        item1.fee = this.amount;
        item1.description = "کوپن";        
        
        //اضافه کردن آیتم های خرید به کارت خرید
        myCart.addProductItem(item1);


        //ساخت ایکس ام ال از کارت خرید
        string content = PasargadUtil.createXML(myCart);
        //امضا و تصدیق اعتبار اطلاعات وارد شده
        string sign = Pasargad.PasargadUtil.sign(content);
        Pasargad.RemotePost myremotepost = new Pasargad.RemotePost(content, sign);
        myremotepost.Url = "https://paypaad.bankpasargad.com/PaymentController";

        //Session["cartObject"] = myCart;


        //ارسال اطلاعات به سامانه پرداخت امن
        myremotepost.Post();
    }
    /*
    public void GetCoupon()
    {
        PasargadCart cart = (PasargadCart)Session["cartObject"]; // restore cart object
        

        string tref =  Request["tref"];
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

     */

}