//AULA 45 if ternario


var nome = "";

//IF BASICO
// if (nome) {
//     var mensagem = "Olá " + nome;
// } else {
//     var mensagem = "Nome não informado";
// }

//-----------------------------------------------------

// //IF TERNARIO
// var mensagem;

// nome ? mensagem = "Olá " + nome : mensagem = "Nome não informado";

// console.log(mensagem);

//-----------------------------------------------------


// //IF TERNARIO MAIS SIMPLES
// var mensagem;

// mensagem = nome ? "Olá " + nome : "Nome não informado";

// console.log(mensagem);

//-----------------------------------------------------

//IF TERNARIO COMPLEXO

nome = "";
idade = 40;

mensagem = (nome && idade) ? "Olá " + nome + " com idade de " + idade + " anos." 
: (!nome && !idade) ? "Nome e idade não informado"
: (!idade) ? "idade não informada"
: "nome não informado";

console.log(mensagem);
