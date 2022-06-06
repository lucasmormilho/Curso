//AULA 44 error



function pegar_usuario() {

    window.setTimeout(function () {
        var u = {
            'nome': 'João'
        };
        return u;
    }, 1000);

}

function saudar_usuario(user) {
    console.log('Olá ' + user.nome + ', como vai?');
}

// //try/catch
// try {
//     var user = pegar_usuario();
//     saudar_usuario(user);
// } catch {
//     console.log('erro');
// } 
// console.log('Novo comando para executar ao final');

// console.log('-----------------------------------------------------');

// //finally
// try {
//     var user = pegar_usuario();
//     saudar_usuario(user);
// } catch {
//     console.log('erro');
// } 
// finally {
//     console.log('esse comando finally sempre serea executado');
// }
// console.log('Novo comando para executar ao final');

// console.log('-----------------------------------------------------');

//Throw
var user = {"nome": ''};
try {

    if(user.nome == ''){
        throw 'Nome em branco';
    }

    saudar_usuario(user);

} catch(err) { //err é o erro do throw

    console.log(err);
} 

console.log('-----------------------------------------------------');