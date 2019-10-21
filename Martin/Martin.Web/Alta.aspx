<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBase.Master" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="Martin.Web.Alta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="formPanel">
        <asp:Label runat="server" Text="Nombre Usuario:"></asp:Label>
        <asp:TextBox runat="server" ID="NombreUsuarioTB"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NombreUsuarioTB" ErrorMessage="Nombre de Usuario requerido" ValidationGroup="1">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" Text="Tipo Usuario:"></asp:Label>
        <%--<asp:TextBox runat="server" ID="TipoUsuarioTB"></asp:TextBox>--%>
        <asp:DropDownList runat="server" ID="usuarioDD"></asp:DropDownList>
       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TipoUsuarioTB" ErrorMessage="Tipo Usuario Requerido" ValidationGroup="1">*</asp:RequiredFieldValidator>--%>
        <br />  
        <asp:Label runat="server" Text="Ultimo Ingreso"></asp:Label>
        <asp:TextBox runat="server" ID="UltimoIngresoTB"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="UltimoIngresoTB" ErrorMessage="Ultimo Ingreso Requerido" ValidationGroup="1">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" Text="Email"></asp:Label>
        <asp:TextBox runat="server" ID="EmailTB"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="EmailTB" ErrorMessage="Email Requerido" ValidationGroup="1">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTB" ErrorMessage="Email invalido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="1">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label runat="server" Text="Clave"></asp:Label>
        <asp:TextBox ID="ClaveTB" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ClaveTB" ErrorMessage="Clave Requerida" ValidationGroup="1">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="1" />
    </asp:Panel>
    <asp:Panel runat="server" ID="actionFormPanel">
        <asp:LinkButton runat="server" Text="Aceptar" ID="aceptarBtn" OnClick="aceptarBtn_Click"></asp:LinkButton>
        <asp:LinkButton runat="server" Text="Cancelar" ID="cancelarBtn" OnClick="cancelarBtn_Click"></asp:LinkButton>
        <asp:Label runat="server" Text="Usuario Agregado" Visible="false" ID="agregado"></asp:Label>
    </asp:Panel>
</asp:Content>

