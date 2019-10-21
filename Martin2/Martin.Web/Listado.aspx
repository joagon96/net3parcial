<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Listado.aspx.cs" Inherits="Martin.Web.Listado" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false"
        ShowHeaderWhenEmpty="true"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID" 
        Caption='<table border="1" width="100%" cellpadding="0" cellspacing="0" bgcolor="yellow"><tr><td>Alumnos</td></tr></table>'
        >
        <Columns>
            <asp:BoundField HeaderText="Alumno" DataField="Id" />
            <asp:BoundField HeaderText="Apellido y Nombre" DataField="ApellidoNombre" />
            <asp:BoundField HeaderText="Dni" DataField="Dni" />
            <%--<asp:BoundField HeaderText="Edad" DataField="Edad" />--%>
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:BoundField HeaderText="Fecha Nacimiento" DataField="FechaNacimiento" />
            <asp:BoundField HeaderText="Nota Promedio" DataField="NotaPromedio" />
        </Columns>
    </asp:GridView>
</asp:Content>
