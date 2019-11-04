<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Martin.Web.Listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
            <Columns>
                </Columns>
        </asp:GridView>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Recuperar</asp:LinkButton>
    </form>
</body>
</html>
