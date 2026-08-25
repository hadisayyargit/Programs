<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bahar.aspx.cs" Inherits="drzeytoon.com.bahar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
			<div class="body-text">
				<div class="container-fluid demo">
					<div class="row-fluid">
						<h1 class="span12">&nbsp;&nbsp;&nbsp;&nbsp; تماس با ما</h1>
					</div>
                  
                      <span class="span8" dir="rtl" style="clear: right" >
                            طراحی: گروه پردازشگران خرداد
                              <a href="http://www.khordadnet.ir"><img src="Images/khordadlogoTransparent.png" width="10%" style="height: 51px" /></a>
                      </span>
        

                    &nbsp;<!-- 6/4 columns --><!--single map--><div class="row-fluid">
						<div id="single_map" style="width:100%; height:300px; background-color: #C0C0C0;" data-address="1253 Spadina Avn, Toronto ON" data-iconrel="img/pin/pin.png" data-zoom="12"> 
                            </div>
					</div>
					<div class="row-fluid">
						<div class="span3">
								<h4>We're Here're Here</h4>
								<p>
									Peach Realestate<br />
									Marketing Dept<br />
									12-123 1/2 Spadina St SE<br />
									Toronto ON M1B2P4<br />
									CANADA
								</p>

								<strong>تلفن تماس:</strong>+98 912 2105628 <br />  
								<strong>فکس:</strong> 416.556.4657 <br />
								<strong>پست الکترونیکی:</strong> <a href="mailto:companyName@email.com"> business@email.com</a>
								


						</div>
						<div class="span9"> 
							<div id="message"></div>
							<form class="form-horizontal contact-agent-form" method="post" action="php/contact.php" name="contactform" id="contactform" />
								<div class="row-fluid">
			                        <div class="field span6">
			                            <div class="span12">
			                                <label for="first_name" accesskey="U">نام*</label>
			                                <input type="text" class="span12" name="first_name" value="" id="first_name" placeholder="First Name" />
			                            </div>
			                           
			                        </div>
			                        <div class="field span6">
			                            <div class="span12">
			                                <label for="last_name" accesskey="O">نام خانوادگی*</label>
			                                <input type="text" class="span12" name="last_name" value="" id="last_name" placeholder="Last Name" />
			                            </div>
			                           
			                        </div>
		                        </div>
								<div class="row-fluid">
			                        <div class="field span6">
			                            <div class="span12">
			                                <label for="email" accesskey="E">پست الکترونیک*</label>
			                                <input type="email" class="span12" name="email" value="" id="email" placeholder="your_email@address.com" />
			                            </div>
			                           
			                        </div>
			                        <div class="field span6">
			                            <div class="span12">
			                                <label for="phone" accesskey="P">شماره تماس
			                                </label>
			                                <input type="tel" class="span12" name="phone" value="" id="phone" placeholder="( 000 ) 000 - 0000" />
			                            </div>
			                           
			                        </div>
		                        </div>
								<div class="row-fluid">
			                        <div class="field span12">
			                            <div class="span12">
			                                <label for="comments" accesskey="C">توضیحات*</label>
			                                <textarea class="span12" id="comments" rows="4" name="comments" placeholder="Please type your comments here.."></textarea>
			                            </div>
			                        </div>
		                        </div>
								<div class="row-fluid">
			                        <div class="field span12">
			                            <div class="span12">
			                            	<label for="verify" accesskey="V">Verify*</label>
			                            	<input name="verify" type="text" id="verify" size="6" value="" placeholder="verify code" />
			                                <label><img src="php/image.php" alt="Image verification" border="0" /></label>
			                            </div>
			                        </div>
		                        </div>
		                        <div class="divider"></div>
		                        <div class="button-align">
		                        	
		                        	<input type="submit" class="btn" id="submit" value="Submit" />
		                        </div>
								
							</form>
						</div>				
					</div>
					<!-- end 6/4 columns -->
				</div>
			</div>
    </form>
</body>
</html>
