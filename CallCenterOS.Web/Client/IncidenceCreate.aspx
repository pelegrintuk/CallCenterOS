<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IncidenceCreate.aspx.cs" Inherits="CallCenterOS.Web.Client.IncidenceCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class "form-horizontal>
        <h4>Crear incidencia</h4>
        <hr />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger"/>
        <div class=" form-group">
            <asp:Label ID="Label1" runat="server" Text="Introduzca el nombre del equipo" CssClass="col-md-3" AssociatedControlID="txtEquipment"></asp:Label>
            <div class="col-md-9">
                <asp:TextBox ID="txtEquipment" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>
