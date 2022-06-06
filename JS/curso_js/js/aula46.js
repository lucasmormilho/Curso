//Aula 46 Escopa

//define a acessibilidade de uma variavel

// //escopo local == dentro de uma function
// function criar_nome() {
//     var nome = 'Maria';
//     console.log(nome); // O console mostrará 'Maria'
// }

// criar_nome();

// console.log(nome); //erro pois ela esta no escopo local

//----------------------------------------------------------------------

// //escopo global

// var nome;

// function criar_nome() {
//     nome = 'Maria';
//     console.log(nome); // O console mostrará 'Maria'
// }

// criar_nome();

// console.log(nome); //erro pois ela esta no escopo local

//----------------------------------------------------------------------

// //escopo global dentro de uma function

// function criar_nome() {
//     teste_nome = 'Maria'; //global pois não usei o var
//     console.log(teste_nome); // O console mostrará 'Maria'
// }

// criar_nome();

// console.log(window.teste_nome); //erro pois ela esta no escopo local

//----------------------------------------------------------------------

// //escopo global dentro de uma condição usando var

// var x = 0;
// if(x==0){
//     var nome = "carlos"; //variaveis dentro de condição são globais
// }
// console.log(nome);

//----------------------------------------------------------------------

// //escopo local dentro de uma condição usando let

// var x = 0;
// if(x==0){
//     let nome = "carlos"; //variaveis dentro de condição são globais
// }
// console.log(nome);


//----------------------------------------------------------------------

// //escopo local dentro de um for usando let

for (let x = 0; x < 5; x++) { //sempre usar let em for
    console.log(x);
}


//----------------------------------------------------------------------

// //key word nova cons --- ñão pode trocar o valor

const PI = "3.14153"

PI = "10"