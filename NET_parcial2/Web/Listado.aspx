<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBase.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Web.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView runat="server" ID="dgvUsuarios" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
            <asp:BoundField HeaderText="Clave" DataField="Clave" />
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:BoundField HeaderText="Tipo de Usuario" DataField="TipoUsuario" />
            <asp:BoundField HeaderText="Ultimo ingreso" DataField="UltimoIngreso" DataFormatString="{0:d}" />
        </Columns>
    </asp:GridView>
</asp:Content>
