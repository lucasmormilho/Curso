//AULA 43 callback

function pegar_usuario(callback){

   window.setTimeout (function (){

    var u = {
        'nome': 'Lucas'
    };
    callback(u); //usar esse nomee para saber que é um callback

   }, 5000) 
};
               
pegar_usuario(function (user) {
    console.log('Olá ' + user.nome + ', como vai?');
});



//se a primeira demorar é um problema, simular com timeout porque
//javascript é assincrona
//Acontece muito com ajaz