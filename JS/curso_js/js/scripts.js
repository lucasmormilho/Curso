
//aula callback
alert("Teste");

function pegar_usuario(){
    var u = {
        'nome': 'João'
    };
    return u;
}
        
function saudar_usuario(user) {
    console.log('Olá ' + user.nome + ', como vai?');
}
        
var user = pegar_usuario();
saudar_usuario(user);