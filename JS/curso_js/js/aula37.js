//AULA 37 FORM


var conteudo_input = $("#campo_nome").val();
console.log(conteudo_input);

$("#campo_nome").val("jose carlos");

//pegando apenas o valor
var select_options = $("#options").val();
console.log(select_options);


//pegar o texto
var select_options_text = $("#options").find(":selected").text();
console.log(select_options_text);

//monitorar mudanças com change
$("#options").change(function () {
  var monitora = $("#options").find(":selected").text();
  console.log(monitora);
});

//value radio button
var radio_button_value = $("input[name='genero']:checked").val();
console.log(radio_button_value);

//texto radio button
var radio_button_text = $("input[name='genero']:checked").parent('span').text();
console.log(radio_button_text);

//radio button change
$("input[name='genero").change(function () {
  var radio_button_text = $("input[name='genero']:checked").parent('span').text();
  console.log(radio_button_text);
});

//checkbox
$("input[name='interesse']").change(function () {  
  
  var checkbox_selecionado = $("input[name='interesse']:checked");
  var array_texto = [];

  $.each(checkbox_selecionado, function (indice,valor) {  
      array_texto.push($(valor).parent("span").text());
  });
  console.log(array_texto);

});