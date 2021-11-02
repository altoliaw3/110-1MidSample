<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample1.aspx.cs" Inherits="_110_1MidSample.Sample1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>會員註冊</h2><br />
            <asp:Label runat="server" Text="手機電話(帳號)" Font-Size="X-Large"></asp:Label><asp:TextBox ID="tb_CellPhone" runat="server" Height="15px" Width="200px"></asp:TextBox><br />
            <asp:Label runat="server" Text="密碼" Font-Size="X-Large"></asp:Label><asp:TextBox ID="tb_Ps" runat="server" MaxLength="10" TextMode="Password" Height="15px" Width="200px"></asp:TextBox><asp:ImageButton ID="ib_Icon" runat="server" Height="30px" ImageUrl="eye-slash-solid.svg" Width="30px" /><br />
            <asp:Label runat="server" Text="生理性別" Font-Size="X-Large"></asp:Label>
            <asp:RadioButtonList ID="rb_Gender" runat="server" RepeatDirection="Horizontal" Font-Size="X-Large" RepeatLayout="Flow">
                <asp:ListItem Selected="True">男</asp:ListItem>
                <asp:ListItem>女</asp:ListItem>
                <asp:ListItem>其他</asp:ListItem>
            </asp:RadioButtonList> <br />
            <asp:Label runat="server" Text="影片說明" Font-Size="X-Large"></asp:Label>
            <asp:HyperLink runat="server" ImageUrl="youtube-brands.svg" ImageWidth="30px" NavigateUrl="https://www.youtube.com" ImageHeight="30px">HyperLink</asp:HyperLink>
            <br />
            <asp:Label runat="server" Text="驗證碼" Font-Size="X-Large"></asp:Label><asp:TextBox ID="tb_Num" runat="server" Height="15px" Width="50px"></asp:TextBox><asp:Image ID="ig_Num" runat="server" /><asp:HiddenField ID="hd_Num" runat="server" /><br />
            <asp:Button ID="btn_Submit" runat="server" Text="送出" PostBackUrl="Sample1Com.aspx" Height="30px" Width="80px" />
        </div>
    </form>
</body>
</html>
