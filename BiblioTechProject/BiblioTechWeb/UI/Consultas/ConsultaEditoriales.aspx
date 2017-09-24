<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaEditoriales.aspx.cs" Inherits="BiblioTechWeb.UI.Consultas.ConsultaEditoriales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta lang="es-ES"/>
    <title>Consulta de editoriales</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>

    <!--Inclusión de Bootstrap 4.0.0 CDN-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" integrity="sha384-/Y6pD6FV/Vv2HJnA6t+vslU6fwYXjCFtcEpHbNJ0lyAFsXTsjBbfaDjzALeQsN6M" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" integrity="sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1" crossorigin="anonymous"></script>

    <!--Inclusión de scripts personales-->
    <script src="../../Scripts/Scripts.js"></script>

    <!--Inclusión de hoja de estilos personal-->
    <link rel="stylesheet" href="../../Estilos/Estilos.css" />

</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">BiblioTech</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarText">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item">
                    <a class="nav-link" href="#">Inicio</a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="UsuariosNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Usuarios
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="../Registros/RegistroUsuarios.aspx">Registro</a>
                        <a class="dropdown-item" href="ConsultaUsuarios.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="AutoresNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Autores
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="../Registros/RegistroAutores.aspx">Registro</a>
                        <a class="dropdown-item" href="ConsultaAutores.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle active" href="#" id="EditorialesNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Editoriales
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="../Registros/RegistroEditoriales.aspx">Registro</a>
                        <a class="dropdown-item" href="ConsultaEditoriales.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="LibrosNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Libros
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="../Registros/RegistroLibros.aspx">Registro</a>
                        <a class="dropdown-item" href="ConsultaLibros.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="ClientesNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Clientes
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="../Registros/RegistroClientes.aspx">Registro</a>
                        <a class="dropdown-item" href="ConsultaClientes.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="PrestamosNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Préstamos
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="../Registros/RegistroPrestamos.aspx">Registro</a>
                        <a class="dropdown-item" href="ConsultaPrestamos.aspx">Consulta</a>
                    </div>
                </li>
            </ul>
            <span class="navbar-text">
                <a class="" href="#">Salir de sesión</a>
            </span>
        </div>
    </nav>

    <div class="container-fluid">
        <header class="text-center">
            <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
            <h1 class="display-4 d-sm-none">BiblioTech</h1>
        </header>
        <!--header-->
        <div class="page-header text-center">
            <h1>Consulta de editoriales</h1>
        </div>
    </div>
    <br />

    <div class="container">               
        <!--Formulario de consulta de usuarios-->
        <form runat="server">
            <div class="col-xs-12 col-sm-4 d-inline-block">
                    <asp:DropDownList CssClass="form-control" ID="FiltrarDropDownList" runat="server">
                        <asp:ListItem>Sin filtro</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>Nombre</asp:ListItem>
                    </asp:DropDownList>
            </div>

            <div class="col-xs-12 col-sm-7 d-inline-block">
                <div class="form-group">
                    <asp:TextBox CssClass="form-control" ID="FiltrarTextBox" runat="server" autocomplete="off" ></asp:TextBox>
                </div>
            </div>

            <div class="col">
            </div>
                
            <div class="float-left">
                <asp:Button CssClass="btn btn-primary" ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
            </div>
            <div class="float-right">
                <asp:Button CssClass="btn btn-success" ID="ImprimirButton" runat="server" Text="Imprimir" />
            </div>
            <br />
            <br />

            <!--Inputs de manipulación-->
            <asp:TextBox CssClass="d-none" ID="FilaTextBox" runat="server" ></asp:TextBox>


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
                            <p>¿Seguro que desea eliminar esta editorial?</p>
                            <p>También se borrarán todos los libros pertenecientes a ésta.</p>
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
                            <p>¿Seguro que desea ir al registro de editoriales para modificar esta editorial?</p>
                        </div>
                        <div class="modal-footer">
                            <asp:Button CssClass="btn btn-warning" ID="ModificarButton" runat="server" Text="Continuar" OnClick="ModificarButton_Click" />
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                        </div>
                    </div>
                </div>
            </div>

        </form>

        <div class="row">
            <div class="col-12">
                <!--Tabla de consultas-->
                <table class="table table-hover table-responsive">
                    <!--Encabezados de la tabla-->
                    <tr>
                        <th class="bg-info">Usuario ID</th>
                        <th class="bg-info">Nombre</th>
                        <th class="bg-info"></th>
                        <th class="bg-info"></th>
                    </tr>

                    <!--Resultado de la consulta-->
                    <tbody id="listaF">
                        <% foreach (var editorial in Lista) %>
                        <% { Response.Write("<tr class='fila'> <td>" + editorial.EditorialId + "</td> <td>" + editorial.Nombre + "</td> <td> <button class='btn-modificar btn btn-sm btn-warning' data-toggle='modal' data-target='#ModalConfirmacionModificar'>Modificar</button> </td> <td>  <button class='btn-eliminar btn btn-sm btn-danger' data-toggle='modal' data-target='#ModalConfirmacionEliminar'>Eliminar</button> </td> </tr>"); } %>
                    </tbody>
                       
                    <tr>
                        <th class="bg-dark"></th>
                        <th class="bg-dark"></th>
                        <th class="bg-dark"></th>
                        <th class="bg-dark"></th>
                    </tr>
                </table>
            </div>
        </div>

    </div> <!--Fin fluid-container-->

    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>

    
    <footer>
        <div class="alert bg-dark color-blanco"><p class="text-center">BiblioTech Web Version. 2017.</p></div>
    </footer>


</body>
</html>
