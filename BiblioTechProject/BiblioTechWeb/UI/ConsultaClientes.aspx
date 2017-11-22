<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="ConsultaClientes.aspx.cs" Inherits="BiblioTechWeb.UI.ConsultaClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Consulta de clientes - BiblioTech</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
        <h1 class="display-4 d-sm-none">BiblioTech</h1>
    </header>
    <!--header-->
    <div class="page-header text-center">
        <h1>Consulta de clientes</h1>
    </div>

    <div class="col-xs-12 col-sm-4 d-inline-block">
        <asp:DropDownList CssClass="form-control" ID="FiltrarDropDownList" runat="server">
            <asp:ListItem>Sin filtro</asp:ListItem>
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Nombre</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="col-xs-12 col-sm-7 d-inline-block">
        <div class="form-group">
            <asp:TextBox CssClass="form-control" ID="FiltrarTextBox" runat="server" autocomplete="off"></asp:TextBox>
        </div>
    </div>

    <div class="col">
    </div>

    <div class="float-left">
        <asp:Button CssClass="btn btn-primary" ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
    </div>
    <div class="float-right">
        <asp:Button CssClass="btn btn-success" ID="ImprimirButton" runat="server" Text="Imprimir" OnClick="ImprimirButton_Click" />
    </div>
    <br />
    <br />

    <!--Inputs de manipulación-->
    <asp:TextBox CssClass="d-none" ID="FilaTextBox" runat="server"></asp:TextBox>


    <!--Modal de confirmación eliminar-->
    <div class="modal" id="ModalConfirmacionEliminar">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header bg-danger">
                    <h5 class="modal-title">¡Advertencia!</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>¿Seguro que desea eliminar este cliente?</p>
                </div>
                <div class="modal-footer">
                    <asp:Button CssClass="btn btn-danger" ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                </div>
            </div>
        </div>
    </div>

    <!--Modal de confirmación modificar-->
    <div class="modal" id="ModalConfirmacionModificar">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header bg-warning">
                    <h5 class="modal-title">¡Advertencia!</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>¿Seguro que desea ir al registro de clientes para modificar esta cliente?</p>
                </div>
                <div class="modal-footer">
                    <asp:Button CssClass="btn btn-warning" ID="ModificarButton" runat="server" Text="Continuar" OnClick="ModificarButton_Click" />
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-12">
            <!--Tabla de consultas-->
            <table class="table table-hover table-responsive">
                <!--Encabezados de la tabla-->
                <tr>
                    <th class="bg-info">Cliente ID</th>
                    <th class="bg-info">Nombre</th>
                    <th class="bg-info">Cédula</th>
                    <th class="bg-info">Sexo</th>
                    <th class="bg-info">Teléfono</th>
                    <th class="bg-info">Dirección</th>
                    <th class="bg-info">Fecha nacimiento</th>
                    <th class="bg-info">Email</th>
                    <th class="bg-info"></th>
                    <th class="bg-info"></th>
                </tr>

                <!--Resultado de la consulta-->
                <tbody id="listaF">
                    <% foreach (var cliente in Lista) %>
                    <% { Response.Write("<tr class='fila'> <td>" + cliente.ClienteId + "</td> <td>" + cliente.Nombre + "</td><td>" + cliente.Cedula + "</td><td>" + cliente.Sexo + "</td><td>" + cliente.Telefono + "</td><td>" + cliente.Direccion + "</td><td>" + cliente.FechaNacimiento.ToString().Substring(0, 10) + "</td><td>" + cliente.Email + "</td> <td> <a class='btn-modificar btn btn-sm btn-warning' data-toggle='modal' data-target='#ModalConfirmacionModificar'>Modificar</a> </td> <td>  <a class='btn-eliminar btn btn-sm btn-danger' data-toggle='modal' data-target='#ModalConfirmacionEliminar'>Eliminar</a> </td> </tr>"); } %>
                </tbody>

                <tr>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
