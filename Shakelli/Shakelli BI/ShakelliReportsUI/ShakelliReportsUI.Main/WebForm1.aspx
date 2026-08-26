<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ShakelliReportsUI.Main.WebForm1" %>




<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Select1 {
            width: 196px;
        }
        .auto-style2 {
            width: 35px;
        }
        </style>
</head>
<body>
    <form id="reportForm" runat="server">


        <input type="checkbox" checked="checked" />
        <div disabled="disabled">

        <input id="txt1" value="1234"   type="text" style="color:seagreen; font-family: 'B Yekan'; " dir="rtl" />
            
            <select  id="Select1" name="D1" font-family= 'B Yekan' > 
                <option>1</option>
                <option>2</option>
            </select></div>


                               <table class="table table-striped table-bordered table-advance table-hover" id="sample_2">
                                    <p>
                                        <button type="button" class="btn btn-primary" onclick="location.href='/Prime/organization_create?organizationid=0'">جدید</button>
                                    </p>
                                    <thead>
                                        <tr style="background-color: #208496; color:white">
                                            <th class="auto-style2">شناسه</th>
                                            <th class="">عنوان</th>
                                            <th class="">نوع سازمان</th>
                                            <th class="">کد محل</th>
                                            <th class="">کد دسترسی</th>
                                            <th class="">نام سازمان بالاتر</th>
                                            <th class="hidden">شناسه نوع سازمان</th>
                                            <th class="hidden">شناسه سازمان پدر</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                                <tr class="odd gradeX">
                                                
                                                <td class="auto-style2">1</td>
                                                <td class="hidden-phone"><a href="/Prime/Organization_edit?organizationid=1">هولدینگ شکلی</a></td>
                                                <td class="hidden-phone"></td>
                                                <td class="hidden-phone"></td>
                                                <td class="hidden-phone">A</td>
                                                <td class="hidden-phone"></td>
                                                <td class="hidden"></td>
                                                <td class="hidden"></td>
    </tr>
                                        
                                                <tr class="odd gradeX">
                                                
                                                <td class="auto-style2">2</td>
                                                <td class="hidden-phone"><a href="/Prime/Organization_edit?organizationid=2">صفاپخش</a></td>
                                                <td class="hidden-phone"></td>
                                                <td class="hidden-phone">1</td>
                                                <td class="hidden-phone">A</td>
                                                <td class="hidden-phone">هولدینگ شکلی</td>
                                                <td class="hidden"></td>
                                                <td class="hidden">1</td>
    
                                            </tr>

                                    </tbody>
                                </table>    
        

        <asp:Label ID="Label1" runat="server" ForeColor="#1E8496" Text="Label" BackColor="#1EAA91"></asp:Label>
        

    </form>

</body>
</html>