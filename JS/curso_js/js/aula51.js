//aula 51 AJAX


//pegar apenas temparatura
function temperatura(dados) {
    var dados_obj = JSON.parse(dados);
    console.log("A temperatura em londres é de : " + dados_obj.main.temp + " graus !!!");
};


//mostrar dados completos
function mostrar_dados(dados) {
    var dados_obj = JSON.parse(dados);
    console.log(dados_obj);
}

//função callback
function tempo(callback) {
    var xhttp = new XMLHttpRequest();
    var xhttp = window.XMLHttpRequest ? new XMLHttpRequest()
        : new ActiveXObject("Microsoft.XMLHTTP");
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            callback(this.responseText);
        }
    };
    xhttp.open("GET", "https://api.openweathermap.org/data/2.5/weather?q=London,uk&appid=7edb01125b6d4084ec5f8c4bef2d937a");
    xhttp.send();
};

tempo(temperatura);
tempo(mostrar_dados);
