$(document).ready(function () {

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

    $(".fila").hover(function () {
        var id = $(this).children("td").first().html();
        $("#FilaTextBox").val(id);
    });
});