//aula 47 - namespace

//UTILIZAR NAMESPACE AJUDA A MITIGAR O RISCO DE TER DUAS VARIAVEIS COM O MESMO NOME

var ObjetoDessaPag = {};

ObjetoDessaPag.nome = "lucas";

ObjetoDessaPag.ver_nome = function () {
    console.log(ObjetoDessaPag.nome);
}

ObjetoDessaPag.ver_nome();

//dessa forma pode criar uma variavel nome em outro parte da pagina

//-----------------------------------------------


//namespace usando função

var meuWebApp = (function () {
    // console.log("star");
    var nome = "maria";
    return {
        'ver_nome': function () {
            return nome;
        },
        'mudar_nome': function (novo_nome) {
            nome = novo_nome;
        },
        'apagar_nome': function () {
            nome = null;
        }
    }
})(); ///quando criar essa variavel sera executada essa function


console.log(meuWebApp.ver_nome());

meuWebApp.mudar_nome("bola");
console.log(meuWebApp.ver_nome());

meuWebApp.apagar_nome();
console.log(meuWebApp.ver_nome());

 //-----------------------------------------------