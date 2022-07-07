<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IncidenceCreate.aspx.cs" Inherits="CallCenterOS.Web.Client.IncidenceCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h4>Crear incidencia</h4>
        <hr />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger"/>
        <div class=" form-group">
            <asp:Label ID="Label1" runat="server" Text="Introduzca el nombre del equipo" CssClass="col-md-3" AssociatedControlID="txtEquipment"></asp:Label>
            <div class="col-md-9">
                <asp:TextBox ID="txtEquipment" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El nombre del equipo es obligatorio" ControlToValidate="txtEquipment" Text="*"></asp:RequiredFieldValidator>
            </div>
        </div>
                <div class=" form-group">
            <asp:Label ID="Label2" runat="server" Text="Introduzca el texto de la incidencia" CssClass="col-md-3" AssociatedControlID="txtEquipment"></asp:Label>
            <div class="col-md-9">
                <asp:TextBox ID="TxtIncidence" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="10"></asp:TextBox>
            </div>
        </div>
        <div class=" form-group">
            <asp:Label ID="Label3" runat="server" Text="Seleccione tipo de incidencia" CssClass="col-md-3" AssociatedControlID="txtEquipment"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="El texto de la incidencia es obligatorio" ControlToValidate="txtEquipment" Text="*"></asp:RequiredFieldValidator>
            <div class="col-md-9">
            <asp:DropDownList ID="ddltype" runat="server" CssClass="form-control"></asp:DropDownList>    
            </div>
        </div>
        <div class=" form-group">
            <div class="col-md-1 col-md-offset-3">
                <asp:Button ID="btnSubmit" runat="server" Text="Crear" CssClass="btn btn-default"/>  
            </div>
        </div>        
    </div>
</asp:Content>
