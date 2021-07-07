<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarAsistente.aspx.cs" Inherits="EventosWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="row mt-5">
            <div class="col-lg-6 mx-auto">
                <asp:DropDownList ID="estadoDDl" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="row mt-5">
            <asp:GridView ID="grillaAsistente" 
                CssClass="table table-hover table-bordered"
                AutoGenerateColums="false"
                ShowHeaderWhenEmpty="true"
                EmptyDataText="No hay registros"
                runat="server">
                <Columns>
                    <asp:BoundField HeaderText="Nombre"  DataField="Nombre" />
                    <asp:BoundField HeaderText="Apelido"  DataField="Apellido" />
                    <asp:BoundField HeaderText="Edad"  DataField="Edad" />
                    <asp:BoundField HeaderText="Empresa"  DataField="Emporesa" />
                    <asp:BoundField HeaderText="Region"  DataField="Region.Nombre" />
                    <asp:BoundField HeaderText="Estado"  DataField="Estado" />
                    
                    
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>
