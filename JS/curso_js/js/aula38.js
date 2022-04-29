//AULA 39 CSS


//$(".exemplo").css("display", "none");


  // Adicionar classe:
  $("#adicionar_classe").click(function(){
    $("#paragrafo-classes").addClass("styling");
});

// Remover classe:
$("#remover_classe").click(function(){
    $("#paragrafo-classes").removeClass("styling");
});

// Alternar classe:
$("#alternar_classe").click(function(){
    $("#paragrafo-classes").toggleClass("styling");
});