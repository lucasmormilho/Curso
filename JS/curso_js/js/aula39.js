//AULA 39 eventos

$(document).ready(function () {

    ///colocar tudo de javascript aqui!!!
    ///garantia de execução depois de 100% carregada a pagina
    //ou $(function(){});

    $("#nome").keyup(function () {

        var qtd = $("#nome").val();
        console.log(qtd.length);
        if (qtd) {
            //$("#confirmar").show();
            $("#confirmar").css("display", "initial");
        } else {
            //$("#confirmar").hide();
            $("#confirmar").css("display", "none");
        }
    });
});