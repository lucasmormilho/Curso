//aula 53 AJAX

//colocando valores na tela com callback

function apresentar_dados(data) {
    for (var x = 0; x < data.length; x++) {
        $("#paises").append('<option>' + data[x].Name + '</option>');
    }
};

function pegar_dados(callback) {
    $.ajax({
        type: "GET",
        url: "https://pkgstore.datahub.io/core/country-list/data_json/data/8c458f2d15d9f2119654b29ede6e45b8/data_json.json",
        dataType: "json"
    }).done(function (data) {
        callback(data);
    }).fail(function () {
        console.log("erro na execução");
    });
};

pegar_dados(apresentar_dados);


//--------------------------------------------------------

var cursos = [
    {
        "titulo": "PHP",
        "aval": []
    },
    {
        "titulo": "Javascript",
        "aval": [5, 5, 4.5, 4, 5, 5, 5, 4.5]
    },
    {
        "titulo": "Python",
        "aval": [5, 5, 4, 4, 5, 3, 5, 4, 4, 5]
    },
    {
        "titulo": "Machine Learning",
        "aval": [5, 5, 4.5]
    }
];

function media_avaliacao(dados) {
    for (var x = 0; x < dados.length; x++) {
        try {
            if (dados[x].aval.length == 0) {
                throw 'Curso ' + dados[x].titulo + ' não possui avaliação!'
            } else if (dados[x].aval.length < 5 && dados[x].aval.length > 0) {
                throw 'Curso ' + dados[x].titulo + ' possui menos de 5 avaliações!'
            }
            var soma = 0;
            for (var y = 0; y < dados[x].aval.length; y++) {
                soma += dados[x].aval[y];
            }
            var media = soma / dados[x].aval.length;
            console.log('Curso ' + dados[x].titulo + ' tem media de: ' + media.toFixed(2));
        }
        catch (err) {
            console.log(err);

        }
    };
};

media_avaliacao(cursos);



//--------------------------------------------------------

var acessosApp = {};

acessosApp.usuarios = {
    "33884h": "João Gomes",
    "43585f": "Maria Luisa",
    "93661h": "Pedro Henqrique",
    "23172g": "Paula Carvalho",
};

acessosApp.acessos = [
    {
        "usuario": "33884h",
        "data": "10/07/18"
    },
    {
        "usuario": "33884h",
        "data": "11/07/18"
    },
    {
        "usuario": "3585f",
        "data": "19/07/18"
    },
    {
        "usuario": "93661h",
        "data": "24/07/18"
    },
    {
        "usuario": "23172g",
        "data": "13/08/18"
    },
    {
        "usuario": "93661h",
        "data": "14/08/18"
    }
];

acessosApp.verAcessos = function (dados) {
    for (var a = 0; a < dados.length; a++) {
        mensagem = acessosApp.usuarios[dados[a].usuario] ? "Acesso de " + acessosApp.usuarios[dados[a].usuario] + " no dia " + dados[a].data : "Acesso de desconhecido no dia " + dados[a].data;
        $("#acessos").append("<li>" + mensagem + "</li>");
    }

};

acessosApp.verAcessos(acessosApp.acessos);


//--------------------------------------------------------

function shuffle(array) {
    let currentIndex = array.length, randomIndex;

    // While there remain elements to shuffle.
    while (currentIndex != 0) {

        // Pick a remaining element.
        randomIndex = Math.floor(Math.random() * currentIndex);
        currentIndex--;

        // And swap it with the current element.
        [array[currentIndex], array[randomIndex]] = [
            array[randomIndex], array[currentIndex]];
    }

    return array;
}

$("#gerar").click(function () {
    $("#opcoes").html("");
    $("#erro_acerto").html("");
    $("#pergunta").html("");
    $("#gerar").hide();

    pegar_questoes(apresentar_questoes);
});

function apresentar_questoes(data) {
    $("#pergunta").html(data.question);
    var respostas = data.incorrect_answers;
    var resposta_correta = data.correct_answer;
    respostas.push(resposta_correta);
    respostas = shuffle(respostas);

    for (var x = 0; x < respostas.length; x++) {
        $("#opcoes").append('<input type="radio" name="opcao" value="' + respostas[x] + '">' + respostas[x] + '<br>')
    }

    $("#opcoes input[name='opcao']").change(function () {
        $("#submit").show();

    })

    $("#submit").click(function () {

        var escolha = $("#opcoes input[name='opcao']:checked").val();
        $("#submit").hide();


        if (escolha == resposta_correta) {
            $("#erro_acerto").html("<span style='color:green'; font weight:bold'>Parabens, vocÊ acertou!!! A resposta é: " + resposta_correta + "</span>").show();
        } else {
            $("#erro_acerto").html("<span style='color:red'; font weight:bold'>Você errou!!! A resposta é: " + resposta_correta + "</span>").show();
        }

        $("#opcoes input[name='opcao']").attr('disabled', true);

        $("#gerar").show();

    });
};


function pegar_questoes(callback) {
    $.ajax({
        url: "https://opentdb.com/api.php?amount=1&category=11&difficulty=easy",
        type: "GET",
        dataType: "json"
    }).done(function (data) {
        callback(data.results[0]);
    }).fail(function () {
        console.log("Erro na requisição");
    });
};

pegar_questoes(apresentar_questoes);
