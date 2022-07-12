<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IncidenceEdit.aspx.cs" Inherits="CallCenterOS.Web.Client.IncidenceEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h4>Editar incidencia</h4>
        <asp:HiddenField ID="txtId" runat="server" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger"/>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nombre del equipo:" CssClass="col-md-3" AssociatedControlID="txtEquipment"></asp:Label>
            <div class="col-md-9">
                <asp:Label ID="txtEquipment" runat="server" Text="" CssClass="form-control"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Tipo de incidencia:" CssClass="col-md-3" AssociatedControlID="ddlType"></asp:Label>
            <div class="col-md-9">
                <asp:Label ID="ddlType" runat="server" Text="" CssClass="form-control"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
