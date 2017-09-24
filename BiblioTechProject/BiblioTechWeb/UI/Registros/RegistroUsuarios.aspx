
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="BiblioTechWeb.UI.Registros.RegistroUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta lang="es-ES"/>
    <title>Registro de usuarios</title>
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
                    <a class="nav-link dropdown-toggle active" href="#" id="UsuariosNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Usuarios
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="RegistroUsuarios.aspx">Registro</a>
                        <a class="dropdown-item" href="../Consultas/ConsultaUsuarios.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="AutoresNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Autores
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="RegistroAutores.aspx">Registro</a>
                        <a class="dropdown-item" href="../Consultas/ConsultaAutores.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="EditorialesNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Editoriales
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="RegistroEditoriales.aspx">Registro</a>
                        <a class="dropdown-item" href="../Consultas/ConsultaEditoriales.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="LibrosNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Libros
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="RegistroLibros.aspx">Registro</a>
                        <a class="dropdown-item" href="../Consultas/ConsultaLibros.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="ClientesNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Clientes
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="RegistroClientes.aspx">Registro</a>
                        <a class="dropdown-item" href="../Consultas/ConsultaClientes.aspx">Consulta</a>
                    </div>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="PrestamosNavbarDropdownMenu" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Préstamos
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a class="dropdown-item" href="RegistroPrestamos.aspx">Registro</a>
                        <a class="dropdown-item" href="../Consultas/ConsultaPrestamos.aspx">Consulta</a>
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
    </div>

    <div class="container-fluid">
        
        <div class="row">
            <div class="col-xs-12 col-sm-8 col-md-6 col-lg-5">
                <!--header-->
                <div class="page-header text-center">
                    <h1>Registro de usuarios</h1>
                </div>
                <br />
                <!--Formulario de registro de usuarios-->
                <form id="Formulario" runat="server">
                    <div class="text-center">
                        <h4><asp:Label CssClass="text-center" ID="NuevoOModificandoLabel" runat="server" Text="Nuevo usuario"></asp:Label></h4>
                    </div>

                    <div class="float-right">
                        <asp:Button CssClass="btn btn-warning" ID="LimpiarButton" runat="server" Text="Nuevo" OnClick="LimpiarButton_Click" />
                    </div>
                    <br />

                    <div class="form-group d-none">
                        <label for="UsuarioIdTextBox">Usuario ID</label>
                        <asp:TextBox CssClass="form-control" ID="UsuarioIdTextBox" runat="server" autocomplete="off" OnTextChanged="UsuarioIdTextBox_TextChanged"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="NombreTextBox">Nombre</label>
                        <asp:TextBox CssClass="form-control" ID="NombreTextBox" runat="server" autocomplete="off" OnTextChanged="NombreTextBox_TextChanged"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="NombreUsuarioTextBox">Nombre de usuario</label>
                        <asp:TextBox CssClass="form-control" ID="NombreUsuarioTextBox" runat="server" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ContrasenaTextBox">Contraseña</label>
                        <asp:TextBox CssClass="form-control" ID="ContrasenaTextBox" runat="server" type="password" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ConfirmarContrasenaTextBox">Confirmar contraseña</label>
                        <asp:TextBox CssClass="form-control" ID="ConfirmarContrasenaTextBox" runat="server" type="password" autocomplete="off"></asp:TextBox>
                    </div>

                    <!--div class="form-group">
                        <label for="select_cargo">
                        Cargo</label>
                        <select id="select_cargo" class="form-control" name="D1">
                            <option>Bibliotecario</option>
                            <option>Administrador</option>
                        </select>
                    </!--div-->

                    <div class="form-group">
                        <label for="CargoDropDownList">Confirmar contraseña</label>
                        <asp:DropDownList CssClass="form-control" ID="CargoDropDownList" runat="server">
                            <asp:ListItem>Bibliotecario</asp:ListItem>
                            <asp:ListItem>Administrador</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="FechaCreacionTextBox">Fecha de creación</label>
                        <asp:TextBox type="date" CssClass="form-control" ID="FechaCreacionTextBox" runat="server" autocomplete="off"></asp:TextBox>
                    </div>
                
                    <!--div class="form-group">
                        <div class="input-group">
                            <span class="input-group-addon">Usuario</span>
                            <input type="text" class="form-control" id="usuario" autocomplete="off" name="usaurio" placeholder=".">
                        </div>
                    </div-->

                    <!--TexBoxes para controlar página-->
                    <!--TextBox para manipular alertas-->

                    <br />
                    <div class="text-center">
                        <asp:Button CssClass="btn btn-primary btn-lg" ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                        <br />
                    </div>
                
                </form>
            </div> <!--Fin col-->

            
            <!--Alertas-->
            <div class="col-xs-12 col-sm-4 col-md-6 col-lg-7">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Panel id="AlertaGuardadoExito" class="alert alert-success text-center" role="alert" runat="server">
                    <asp:Label ID="MensajeAlertaGuardadoExito" runat="server">¡Guardado con éxito!</asp:Label>
                </asp:Panel>
                <asp:Panel id="AlertaError" class="alert alert-danger text-center" role="alert" runat="server">
                    <asp:Label ID="MensajeAlertaError" runat="server">¡Algo salió mal!</asp:Label>
                </asp:Panel>
                <asp:Panel id="AlertaValidar" class="alert alert-info text-center" role="alert" runat="server">
                    <asp:Label ID="MensajeAlertaValidar" runat="server">Por favor llene todos los campos correctamente...</asp:Label>
                    <asp:Label ID="YaExisteAlertaValidar" runat="server">¡El nombre de usuario del usuario ya existe!</asp:Label>
                </asp:Panel>
            </div> 

        </div> <!--Fin row-->
    
    </div> <!--Fin fluid-container-->

    <br/>
    <br/>
    <br/>
    <br/>

    
    <footer>
        <div class="alert bg-dark color-blanco"><p class="text-center">BiblioTech Web Version. 2017.</p></div>
    </footer>


    <!--Modal de confirmación de contraseña-->
    <div class="modal" id="ModalConfirmacionContrasena">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Confirmar contraseña antigua</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>Modal body text goes here.</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary">Confirmar</button>
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                </div>
            </div>
        </div>
    </div>


</body>
</html>
