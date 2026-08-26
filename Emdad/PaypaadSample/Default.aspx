<%@ Page Language="C#" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ import Namespace="Pasargad" %>

<script runat="server">
    public PasargadCart sampleCart()
    {
        //ساخت کلاس کارت خرید 
        PasargadCart cart = new PasargadCart();
        cart.buyer_name = String.Format("{0}", Request.Form["cName"]);
        cart.buyer_tel = String.Format("{0}", Request.Form["cTel"]);
        cart.delivery_address = String.Format("{0}", Request.Form["cAddress"]);
        cart.delivery_days = "1";
        cart.invoice_date = "1392/03/01";
        cart.invoice_number = "12209000";
        cart.merchant_code = "5413371";
        cart.terminal_code = "756279744";
        cart.time_stamp = DateTime.Now;
        //ساخت کلاس آیتم خرید برای نگهداری اطلاعات خرید
        PasargadItem item1 = new PasargadItem();
        item1.content = "پیراهن";
        item1.amount = 1000;
        item1.count = 50;
        item1.fee = 20;
        item1.description = "descriptIon";        
        PasargadItem item2 = new PasargadItem();
        item2.content = "تخفیف";
        item2.amount = 20;
        item2.count = 1 ;
        item2.fee = 20;
        item2.description = "descriptIon";
        //اضافه کردن آیتم های خرید به کارت خرید
        cart.addProductItem(item1);
        cart.addProductItem(item2);
        return cart;
    }
    
	void PostMe(Object sender,EventArgs e){
        webpay myWebpay = new webpay("1392/03/01", "123456", 1100);
        myWebpay.PostCoupon();
        
          
        /*
        PasargadCart cart = sampleCart() ;
        //ساخت ایکس ام ال از کارت خرید
        string content = PasargadUtil.createXML(cart) ;
        //امضا و تصدیق اعتبار اطلاعات وارد شده
        string sign = PasargadUtil.sign(content) ;        
        RemotePost myremotepost =  new RemotePost(content , sign);
        myremotepost.Url = "https://paypaad.bankpasargad.com/PaymentController";
		Session["cartObject"] =  cart;
        //ارسال اطلاعات به سامانه پرداخت امن
		myremotepost.Post();
         */
	}

	
</script>
<html>
<head>
</head>
<body dir="rtl">
    <div align="center">
    <div dir="rtl">نکته : برای استفاده از این مثال باید فایل کلید خود را که بانک در اختیار شما 
        قرار می دهد با پسوند XML در در<br />
&nbsp;پوشه App_Data کپی کنید. می توانید مسیر فایل مورد نظر را از web.config نیز تغییر 
        دهید.</div>
    <form runat="Server">
		<div style="">
		<p>برای انجام خرید فرم را کامل کنید و روی دکمه کلیک کنید</p>
        <p>نام :&nbsp; <input id="cName" name="cName" /></p>
        <p>تلفن :&nbsp; <input id="cTel" name="cTel" /></p>
        <p>آدرس :&nbsp; <input id="cAddress" name="cAddress" /></p>
		<asp:button runat="Server" onclick="PostMe" Text="Proceed"/>

		</div>
	</form>
    </div>
</body>
</html>