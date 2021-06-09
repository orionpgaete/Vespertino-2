<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarCapWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">

            <div class="mensajes" >
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success" />
            </div>

            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Cliente</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox runat="server" ID="nombreTxt" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox runat="server" ID="rutTxt" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="bebidaDdl">Bebida Favorita</label>
                        <asp:DropDownList runat="server" ID="bebidaDb1" CssClass="form-control">
                            <asp:ListItem Text="Frapuchino" Value="FRA-01"/>
                            <asp:ListItem Text="Café" Value="CAF-01"/>
                            <asp:ListItem Text="Té" Value="TE-01"/>
                            <asp:ListItem Text="Té Chai" Value="TEC-01"/>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="nivelRb1">Nivel</label>
                        <asp:RadioButtonList runat="server" ID="nivelRb1" CssClass="form-control">
                            <asp:ListItem Selected="True" Text="Silver" Value="1"/>
                            <asp:ListItem Text="Gold" Value="2"/>
                            <asp:ListItem Text="Platinum" Value="3" />
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Button Text="Agregar" CssClass="btb btn-primary btn-lg" runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" />
                    </div>
               


                </div>
            </div>
        </div>
    </div>
</asp:Content>
