//AULA 40 efeitos

$(function () {

    $("#botao-esconder").click(function () {
        $(this).hide(2000, function () {
            $("#texto-escondido").show();
            alert("uhuuu");
        });
    });

    //original
    $("#toggle-tab").click(function () {

        $("#tab-content").toggle();
        $("#toggle-tab").toggleClass("flip");

    });

    //mais lento
/*     $("#toggle-tab").click(function() {

        $("#tab-content").slideToggle(500);
        $("#toggle-tab").toggleClass("flip");
        
    }); */

    //fade
/*     $("#toggle-tab").click(function() {

        $("#tab-content").fadeToggle();
        $("#toggle-tab").toggleClass("flip");

    }); */

});