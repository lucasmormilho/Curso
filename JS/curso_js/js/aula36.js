
//AULA 36 EACH
var nomes = ["lucas","carlos"];

$.each(nomes,function (indice,valor) {
    console.log(valor);
  });


  var pessoa = {
    "nome": "Jão",
    "idade": 14,
    "CPF": 3004289820
  }

  $.each(pessoa, function (indice, valor) {
    console.log(indice, valor);
    });

  
    var teste = $("#interesses li");
    console.log(teste);

    $.each(teste, function (indice, valor) {
      console.log($(valor).text());
      });