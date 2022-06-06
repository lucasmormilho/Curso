//aula 50 AJAX



var xhttp = new XMLHttpRequest();

var xhttp = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject("Microsoft.XMLHTTP");

xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        console.log(JSON.parse(this.responseText));
    }
};


xhttp.open("GET", "https://api.openweathermap.org/data/2.5/weather?q=London,uk&appid=7edb01125b6d4084ec5f8c4bef2d937a");
xhttp.send();

