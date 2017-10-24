$(document).ready(function () {
    if ($("#H1InicioSesion").html() === "Inicio de sesión") {
        $("#SignOutButton").hide();
    }

    //Script para mostrar/ocultar filtros de fecha en las consultas
    if ($("#FiltrarFechaCheckBox").is(':checked')) {
        $("#FechasPanel").show();
    } else {
        $("#FechasPanel").hide();
    }

    $("#FiltrarFechaCheckBox").click(function () {
        if ($("#FiltrarFechaCheckBox").is(':checked')) {
            $("#FechasPanel").show();
        } else {
            $("#FechasPanel").hide();
        }
    });

    //Scripts para llenar TextBox del elemento que se modificara/eliminara en una consulta 
    $(".fila").hover(function () {
        var id = $(this).children("td").first().html();
        $("#FilaTextBox").val(id);
    });
    
});