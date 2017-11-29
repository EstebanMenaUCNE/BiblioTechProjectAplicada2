$(document).ready(function () {

    if ($("#H1Inicio").html() === "Inicio de sesión" || $("#H1Inicio").html() === "Inicio") {
        $("#SignOutButton").hide();
    }

    //Script para mostrar/ocultar filtros de fecha en las consultas
    function mostrarOcultarPanelFechas() {
        if ($("#ContentPlaceHolder1_FiltrarFechaCheckBox").is(':checked')) {
            $("#ContentPlaceHolder1_FechasPanel").show();
        } else {
            $("#ContentPlaceHolder1_FechasPanel").hide();
        }
    }
    mostrarOcultarPanelFechas();
    $("#ContentPlaceHolder1_FiltrarFechaCheckBox").click(mostrarOcultarPanelFechas);

    //Scripts para llenar TextBox del elemento que se modificara/eliminara en una consulta 
    $(".fila").hover(function () {
        var id = $(this).children("td").first().html();
        $("#ContentPlaceHolder1_FilaTextBox").val(id);
    });

    //Scripts para mostrar/ocultar la fecha libros devueltos en el registro de préstamos
    function mostrarOcultarFechaDevuelto() {
        //form_group_fecha_devuelto
        if ($("#ContentPlaceHolder1_EstadoDropDownList").val() === "Pendiente") {
            $("#form_group_fecha_devuelto").hide();
        }
        else {
            $("#form_group_fecha_devuelto").show();
        }
    }
    mostrarOcultarFechaDevuelto();
    $("#ContentPlaceHolder1_EstadoDropDownList").change(mostrarOcultarFechaDevuelto);

});