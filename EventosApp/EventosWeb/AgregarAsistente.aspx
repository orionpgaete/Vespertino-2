<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarAsistente.aspx.cs" Inherits="EventosWeb.AgregarAsistente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Asistente</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="rutTxt" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un rut Valido"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="nombreTxt" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe Ingresar nombre"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="apellidoTxt">Apellido</label>
                        <asp:TextBox ID="apellidoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="apellidoTxt" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe ingresar un apellido"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                         <label for="edadTxt">Edad</label>
                        <asp:TextBox ID="edadTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="edadTxt" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe ingresar la edad"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ControlToValidate="edadTxt" ID="RangeValidator1" runat="server" Type="Integer" ErrorMessage="Debe ingresar un rango Valido" MaximumValue="99" MinimumValue="18"></asp:RangeValidator>
                        </div>
                    <div class="form-group">
                         <label for="empresaTxt">Empresa</label>
                        <asp:TextBox ID="empresaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="empresaTxt" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Debe ingresar nombre empresa"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                         <label for="estadoRb1">Estado</label>
                            <asp:RadioButtonList ID="estadoRb1" runat="server">
                                 <asp:ListItem Text="Pagada" Selected="True" Value="Pagada"></asp:ListItem>
                                 <asp:ListItem Text="Con Deuda" Value="Con Deuda"></asp:ListItem>
                            </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <label for="regionDDL">Region</label>
                        <asp:DropDownList ID="regionDDL" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Button OnClick="ingresarBtn_Click" runat="server" CssClass="btn btn-secondary float-right" ID="ingresarBtn" Text="Ingresar" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
