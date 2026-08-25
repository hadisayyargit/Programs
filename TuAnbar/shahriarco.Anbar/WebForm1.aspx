
<!DOCTYPE html>
<script runat="server">

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
</script>

<html>


<body>

    <form id="form1" runat="server">

        <a onclick="alert('hi')" style="cursor:pointer" >برو</a>

    <br />

        <label>زن</label>
        <input id="Radio1"  name="a" type="radio" style="" checked="checked" />
        
        <input id="Text1" type="text"  readonly="readonly" />

        <label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        مرد</label>
        <input id="Radio2"  name="a" type="radio" />
        
            </form>
    </body>
</html>
