aula//aula 52 AJAX

$.ajax({
    type: "GET",
    url: "https://api.openweathermap.org/data/2.5/weather?q=London,uk&appid=7edb01125b6d4084ec5f8c4bef2d937a",
    dataType: "json",
    success: function (data) {
        console.log(data.name);
    },
    error: function () {
        console.log("erro na execução");
    }
});

//outra maneira -- metodos em cadeia
$.ajax({
    type: "GET",
    url: "https://api.openweathermap.org/data/2.5/weather?q=bahia,br&appid=7edb01125b6d4084ec5f8c4bef2d937a",
    dataType: "json"
}).done(function (data) {
    console.log(data);
}).fail(function () {
    console.log("erro na execução");
});


// //colocando valores na tela
// $.ajax({
//     type: "GET",
//     url: "https://api.openweathermap.org/data/2.5/weather?q=bahia,br&appid=7edb01125b6d4084ec5f8c4bef2d937a",
//     dataType: "json"
// }).done(function (data) {
//     console.log(data);
//     $("#temp_atual").html(data.main.temp);
//     $("#temp_max").html(data.main.temp_max);
//     $("#temp_min").html(data.main.temp_min);
// }).fail(function () {
//     console.log("erro na execução");
// });


//colocando valores na tela com callback

function apresentar_dados(data){
    $("#temp_atual").html(data.main.temp);
    $("#temp_max").html(data.main.temp_max);
    $("#temp_min").html(data.main.temp_min);
};

function pegar_dados(callback) {
    $.ajax({
        type: "GET",
        url: "https://api.openweathermap.org/data/2.5/weather?q=bahia,br&appid=7edb01125b6d4084ec5f8c4bef2d937a",
        dataType: "json"
    }).done(function (data) {
        callback(data);
    }).fail(function () {
        console.log("erro na execução");
    });
};

pegar_dados(apresentar_dados);