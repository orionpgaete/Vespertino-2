<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarAsistente.aspx.cs" Inherits="EventosWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="row">
                  <div class="row mt-5">
                        <div class="col-lg-6 mx-auto">
                            <asp:DropDownList ID="estadoDDl" Enable="false" runat="server" AutoPostBack="true" OnSelectedIndexChanged="estadoDDL_SelectedIndexChanged">
                                <asp:ListItem Text="Pagada" Selected="True" Value="Pagada"></asp:ListItem>
                                <asp:ListItem Text="Con Deuda" Value="Con Deuda"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:CheckBox runat="server" ID="todosChx" Text="Todos" Checked="true"
                                AutoPostBack="true" OnCheckedChanged="todosChx_CheckedChanged" />
                        </div>
                    </div>
                    <div class="row mt-5">
                        <asp:GridView ID="grillaAsistente" 
                            CssClass="table table-hover table-bordered"
                            AutoGenerateColums="false"
                            ShowHeaderWhenEmpty="true"
                            EmptyDataText="No hay registros"
                            OnRowCommand="grillaAsistente_RowCommand"
                            runat="server">
                            <Columns>
                                <asp:BoundField HeaderText="Nombre"  DataField="Nombre" />
                                <asp:BoundField HeaderText="Apelido"  DataField="Apellido" />
                                <asp:BoundField HeaderText="Edad"  DataField="Edad" />
                                <asp:BoundField HeaderText="Empresa"  DataField="Empresa" />
                                <asp:BoundField HeaderText="Region"  DataField="Region.Nombre" />
                                <asp:BoundField HeaderText="Estado"  DataField="Estado" />
                                <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                        <asp:Button CssClass="btn btn-danger" runat="server"
                                             CommandName="eliminar" Text="Eliminar"
                                             CommandArgument='<%# Eval("Id")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </ContentTemplate>
       </asp:UpdatePanel>
</asp:Content>
