
$(function () {

    var accuweatherAPIKey = "HBc8T40JATO5F32lVHQAIqS79FbKQmhR";

    var weatherObject = { //objetos globais
        cidade: "",
        estado: "",
        pais: "",
        temperatura: "",
        texto_clima: "",
        icone_clima: ""
    };

    $("#search-button").click(function () {
        $('.refresh-loader').show();
        var pesquisa = $("input#local").val()
        pesquisa = encodeURI(pesquisa);
        if (pesquisa) {
            pesquisarlocal(pesquisa);
        } else {
            alert("Local Inválido.")
        }
    });

    $("input#local").on('keypress', function (tecla) {
        if (tecla.which == 13) { //tecla enter
            $('.refresh-loader').show();
            var pesquisa = $("input#local").val()
            pesquisa = encodeURI(pesquisa);
            if (pesquisa) {
                pesquisarlocal(pesquisa);
            } else {
                alert("Local Inválido.")
            }
        };
    });

    function pesquisarlocal(input) {
        var tokenmapbox = "pk.eyJ1IjoibHVjYXNzdGFyIiwiYSI6ImNsNG1nemFyNTA3YXUzaXE4c2xnY3ZsdjQifQ.oo4s_aELGUyuCWDHNaVOgw";

        $.ajax({
            type: "GET",
            url: "https://api.mapbox.com/geocoding/v5/mapbox.places/" + input + ".json?proximity=ip&types=place%2Cpostcode%2Caddress&access_token=" + tokenmapbox,
            dataType: "json",
            success: function (data) {
                try{
                //console.log(data.features[0].center[1] + "," + data.features[0].center[0]);
                pegarLocalCode(data.features[0].center[1], data.features[0].center[0]) 
                }
                catch{
                 gerarErro("Erro na pesquisa de local");
                }
            },
            error: function () {
                console.log("Erro");
                gerarErro("Erro na pesquisa de local");
            }
        });
    };

    function preencherClimaAgora(cidade, estado, pais, temperatura, texto_clima, icone_clima) {

        var texto_local = cidade + "," + estado + "." + pais;
        $("#texto_local").text(texto_local);
        $("#texto_clima").text(texto_clima);
        $("#texto_temperatura").html(String(temperatura) + "&deg;");
        $("#icone_clima").css("background-image", "url('" + weatherObject.icone_clima + "')");

    };

    function pegarTempoAtual(localCode) {
        $.ajax({
            type: "GET",
            url: "http://dataservice.accuweather.com/currentconditions/v1/" + localCode + "?apikey=" + accuweatherAPIKey + "&language=pt-br",
            dataType: "json",
            success: function (data) {
                //console.log(data);

                weatherObject.temperatura = data[0].Temperature.Metric.Value;
                weatherObject.texto_clima = data[0].WeatherText;

                var iconNumber = data[0].WeatherIcon <= 9 ? "0" + String(data[0].WeatherIcon) : String(data[0].WeatherIcon); //problema de usar 01 02 03

                weatherObject.icone_clima = "https://developer.accuweather.com/sites/default/files/" + iconNumber + "-s.png"

                preencherClimaAgora(weatherObject.cidade, weatherObject.estado, weatherObject.pais, weatherObject.temperatura, weatherObject.texto_clima, weatherObject.icone_clima);
            },
            error: function () {
                console.log("Erro");
                gerarErro("Erro ao obter clima atual");
            }
        });
    };

    function PreencherPrevisaoTempoDias(previsoes) {

        //console.log(previsoes);

        $("#info_5dias").html("");

        var array_diassemana = ["Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"]; //tratamento nome dias

        for (var x = 0; x < previsoes.length; x++) {

            var dataHoje = new Date(previsoes[x].Date) //tratamento nome dias
            var diassemana = array_diassemana[dataHoje.getDay()]; //tratamento nome dias

            var iconNumber = previsoes[x].Day.Icon <= 9 ? "0" + String(previsoes[x].Day.Icon) : String(previsoes[x].Day.Icon); //problema de usar 01 02 03

            icone_clima = "https://developer.accuweather.com/sites/default/files/" + iconNumber + "-s.png"

            maximum = previsoes[x].Temperature.Maximum.Value;

            minimum = previsoes[x].Temperature.Minimum.Value;

            if (previsoes[x].Temperature.Maximum.Unit == 'F') {
                maximum = (maximum - 32) * 5 / 9; //converter fahrenheit
            }

            if (previsoes[x].Temperature.Minimum.Unit == 'F') {
                minimum = (minimum - 32) * 5 / 9; //converter fahrenheit
            }


            elementoHtmldias = '<div class="day col">';
            elementoHtmldias += '<div class="day_inner">';
            elementoHtmldias += '<div class="dayname">';
            elementoHtmldias += diassemana;
            elementoHtmldias += '</div>';
            elementoHtmldias += '<div style="background-image: url(\'' + icone_clima + '\')" class="daily_weather_icon">';
            elementoHtmldias += '</div>';
            elementoHtmldias += '<div class="max_min_temp">';
            elementoHtmldias += minimum.toFixed(1) + '&deg; /' + maximum.toFixed(1) + '&deg;';
            elementoHtmldias += '</div>';
            elementoHtmldias += '</div>';
            elementoHtmldias += '</div>';

            $("#info_5dias").append(elementoHtmldias);

            elementoHtmldias = "";
        }
    };

    function gerarGrafico(hora, temperatura) {
        Highcharts.chart('hourly_chart', {
            chart: {
                type: 'line'
            },
            title: {
                text: 'Temperatura Hora a Hora'
            },
            xAxis: {
                categories: hora
            },
            yAxis: {
                title: {
                    text: 'Temperatura (°C)'
                }
            },
            plotOptions: {
                line: {
                    dataLabels: {
                        enabled: false
                    },
                    enableMouseTracking: false
                }
            },
            series: [{
                showInLegende: false,
                data: temperatura
            }]
        });
    };

    function pegarPrevisaoHoraaHora(localCode) {
        $.ajax({
            type: "GET",
            url: "http://dataservice.accuweather.com/forecasts/v1/hourly/12hour/" + localCode + "?apikey=" + accuweatherAPIKey + "&language=pt-br",
            dataType: "json",
            success: function (data) {
                //console.log(data);

                var array_horas = [];
                var array_temp = [];

                for (var x = 0; x < data.length; x++) {
                    var hora = new Date(data[x].DateTime).getHours();
                    array_horas.push(String(hora) + "h");

                    var temp = data[x].Temperature.Value;

                    if (data[x].Temperature.Unit == 'F') {
                        temp = (temp - 32) * 5 / 9; //converter fahrenheit
                    }

                    array_temp.push(temp);
                    gerarGrafico(array_horas, array_temp);
                    $('.refresh-loader').fadeOut();

                }
                //console.log(array_horas);
                //console.log(array_temp);
            },
            error: function () {
                console.log("Erro");
                gerarErro("Erro da previsão hora a hora");
            }
        });
    };

    function pegarTempoDias(localCode) {
        $.ajax({
            type: "GET",
            url: "http://dataservice.accuweather.com/forecasts/v1/daily/5day/" + localCode + "?apikey=" + accuweatherAPIKey + "&language=pt-br",
            dataType: "json",
            success: function (data) {
                //console.log(data);

                minimum = String(data.DailyForecasts[0].Temperature.Minimum.Value);
                maximum = String(data.DailyForecasts[0].Temperature.Maximum.Value);

                if (data.DailyForecasts[0].Temperature.Minimum.Unit == 'F') {
                    minimum = (minimum - 32) * 5 / 9; //converter fahrenheit
                }

                if (data.DailyForecasts[0].Temperature.Maximum.Unit == 'F') {
                    maximum = (maximum - 32) * 5 / 9; //converter fahrenheit
                }

                $("#texto_max_min").html(minimum.toFixed(1) + "&deg; / " + maximum.toFixed(1) + "&deg;");
                PreencherPrevisaoTempoDias(data.DailyForecasts);
            },
            error: function () {
                console.log("Erro");
                gerarErro("Erro na previsão de 5 dias");
            }
        });
    };

    function pegarLocalCode(lat, long) {
        $.ajax({
            type: "GET",
            url: "http://dataservice.accuweather.com/locations/v1/cities/geoposition/search?apikey=" + accuweatherAPIKey + "&q=" + lat + "%2C" + long + "&language=pt-br",
            dataType: "json",
            success: function (data) {
                //console.log(data);
                try {
                    weatherObject.cidade = data.ParentCity.LocalizedName;
                }
                catch {
                    weatherObject.cidade = data.LocalizedName;
                }
                weatherObject.estado = data.AdministrativeArea.LocalizedName;
                weatherObject.pais = data.Country.LocalizedName;

                var localCode = data.Key;
                pegarTempoAtual(localCode);
                pegarTempoDias(localCode);
                pegarPrevisaoHoraaHora(localCode);
            },
            error: function () {
                console.log("Erro");
                gerarErro("Erro no código do local");
            }
        });
    };

    function obterGeolocalizacao() {

        var latpadrao = -23.6821604;
        var longpadrao = -46.8754915;

        $.ajax({
            type: "GET",
            url: "http://www.geoplugin.net/json.gp",
            dataType: "json",
            success: function (data) {

                if (data.geoplugin_latitude && data.geoplugin_longitude) {
                    //console.log(data);
                    pegarLocalCode(data.geoplugin_latitude, data.geoplugin_longitude)
                }
                else {
                    pegarLocalCode(data.latpadrao, data.longpadrao)
                }
            },
            error: function () {
                console.log("Erro");
                pegarLocalCode(data.latpadrao, data.longpadrao)
            }
        });
    };

    function gerarErro(mensagem) {
        if (!mensagem) {
            mensagem = "Erro na solicitação";
        }

        $('.refresh-loader').hide();
        $("#aviso-erro").text(mensagem);
        $("#aviso-erro").slideDown();
        window.setTimeout(function () { 
            $("#aviso-erro").slideUp(); 
        }, 3000)
    };

    obterGeolocalizacao();
    gerarGrafico();

    // *** APIs ***
    // clima, previsão 12 horas e previsão 5 dias: https://developer.accuweather.com/apis
    // pegar coordenadas geográficas pelo nome da cidade: https://docs.mapbox.com/api/
    // pegar coordenadas do IP: http://www.geoplugin.net
    // gerar gráficos em JS: https://www.highcharts.com/demo



});

