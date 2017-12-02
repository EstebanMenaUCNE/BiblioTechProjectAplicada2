<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="ConsultaPrestamos.aspx.cs" Inherits="BiblioTechWeb.UI.ConsultaPrestamos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Consulta de préstamos - BiblioTech</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
        <h1 class="display-4 d-sm-none">BiblioTech</h1>
    </header>
    <!--header-->
    <div class="page-header text-center">
        <h1>Consulta de préstamos</h1>
    </div>

    <div class="col-xs-12 col-sm-4 d-inline-block">
        <asp:DropDownList CssClass="form-control" ID="FiltrarDropDownList" runat="server">
            <asp:ListItem>Sin filtro</asp:ListItem>
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Cliente (ID)</asp:ListItem>
            <asp:ListItem>Cliente (Nombre)</asp:ListItem>
            <asp:ListItem>Pendientes</asp:ListItem>
            <asp:ListItem>Devueltos</asp:ListItem>
            <asp:ListItem>Retrasados devueltos</asp:ListItem>
            <asp:ListItem>Retrasados pendientes</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="col-xs-12 col-sm-7 d-inline-block">
        <div class="form-group">
            <asp:TextBox CssClass="form-control" ID="FiltrarTextBox" runat="server" autocomplete="off"></asp:TextBox>
        </div>
    </div>

    <div class="col">
        <div class="form-group">
            <asp:CheckBox ID="FiltrarFechaCheckBox" runat="server" />
            <label for="ContentPlaceHolder1_FiltrarFechaCheckBox">Fitrar por fecha</label>
        </div>
    </div>

    <asp:Panel ID="FechasPanel" runat="server">
        <div class="col-xs-12 col-sm-5 d-inline-block">
            <div class="form-group">
                <label for="ContentPlaceHolder1_FechaDesdeTextBox">Desde</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaDesdeTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
        </div>

        <div class="col-xs-12 col-sm-5 d-inline-block">
            <div class="form-group">
                <label for="ContentPlaceHolder1_FechaHastaTextBox">Hasta</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaHastaTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
        </div>
    </asp:Panel>

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
                    <p>¿Seguro que desea eliminar este préstamo?</p>
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
                    <p>¿Seguro que desea ir al registro de préstamos para modificar este préstamo?</p>
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
                    <th class="bg-info">Préstamo ID</th>
                    <th class="bg-info">Fecha préstamo</th>
                    <th class="bg-info">Fecha entregar antes</th>
                    <th class="bg-info">Fecha libros entregados</th>
                    <th class="bg-info">Estado</th>
                    <th class="bg-info">ID cliente</th>
                    <th class="bg-info">Cliente</th>
                    <th class="bg-info"></th>
                    <th class="bg-info"></th>
                </tr>

                <!--Resultado de la consulta-->
                <tbody id="listaF">
                    <% foreach (var prestamo in Lista) %>
                    <% { Response.Write("<tr class='fila'> <td>" + prestamo.PrestamoId + "</td> <td>" + prestamo.FechaPrestamo.ToString().Substring(0, 10) + "</td> <td>" + prestamo.FechaEntregarAntes.ToString().Substring(0, 10) + "</td> <td>" + prestamo.FechaLibrosEntregados.ToString().Substring(0, 10) + "</td> <td>" + prestamo.Estado + "</td> <td>" + prestamo.ClienteId + "</td> <td>" + prestamo.NombreCliente + "</td> <td> <a class='btn-modificar btn btn-sm btn-warning' data-toggle='modal' data-target='#ModalConfirmacionModificar'>Modificar</a> </td> <td>  <a class='btn-eliminar btn btn-sm btn-danger' data-toggle='modal' data-target='#ModalConfirmacionEliminar'>Eliminar</a> </td> </tr>"); } %>
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
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
