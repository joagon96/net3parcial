<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="Basso.Web.Alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Alumno</div>
        <p>
            Id<asp:TextBox ID="IDtb" runat="server"></asp:TextBox>
        </p>
        <p>
            Dni<asp:TextBox ID="dnitb" runat="server"></asp:TextBox>
        </p>
        Apellido y nombre<asp:TextBox ID="antb" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <p>
            Email<asp:TextBox ID="emailtb" runat="server"></asp:TextBox>
        </p>
        <p>
            Fecha de nacimiento<asp:TextBox ID="fechnactb" runat="server"></asp:TextBox>
        </p>
        <p>
            Nota Promedio<asp:TextBox ID="notatb" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Aceptar" runat="server" ClientIDMode="AutoID" OnClick="Button1_Click" Text="Aceptar" />
        <asp:Button ID="Cancelar" runat="server" OnClick="Cancelar_Click" Text="Cancelar" />
    </form>
</body>
</html>
