// Objeto para pegar os preços e as fotos das camisetas

var camisetas = {
    'branca': {

        'gola_v': {
            'sem_estampa': {
                'preco_unit': 5.12,
                'foto': 'v-white.jpg'
            },
            'com_estampa': {
                'preco_unit': 8.95,
                'foto': 'v-white-personalized.jpg'
            }
        },

        'gola_normal': {
            'sem_estampa': {
                'preco_unit': 4.99,
                'foto': 'normal-white.jpg'
            },
            'com_estampa': {
                'preco_unit': 8.77,
                'foto': 'normal-white-personalized.jpg'
            }
        }
    },

    'colorida': {
        'gola_v': {
            'sem_estampa': {
                'preco_unit': 6.04,
                'foto': 'v-color.jpg'
            },
            'com_estampa': {
                'preco_unit': 9.47,
                'foto': 'v-color-personalized.png'
            }
        },

        'gola_normal': {
            'sem_estampa': {
                'preco_unit': 5.35,
                'foto': 'normal-color.jpg'
            },
            'com_estampa': {
                'preco_unit': 9.28,
                'foto': 'normal-color-personalized.jpg'
            }
        }
    }
}


// parâmetros da pesquisa

var parametros_pesquisa = {
    "quantidade": 1,
    "cor": "colorida",
    "gola": "gola_v",
    "qualidade": "q150",
    "estampa": "sem_estampa",
    "embalagem": "unitaria"
}

//aqui fica o load da pag
$(function () {
    // 1. Crie uma função para calcular o preço baseado nos parâmetros da variável "parametros_pesquisa" e solte o
    // valor no console para testar se está certo.
    function calc_preco(parametros) {
        // Regras adicionais para o orçamento:

        // 1. Verificar se há em localStorage os parâmetros do último orçamento e se houver, carregar a página com eles.

        $(".refresh-loader").show();
        var quantidade = parametros.quantidade;
        var preco_unitario = camisetas[parametros.cor][parametros.gola][parametros.estampa].preco_unit;
        var foto = "img/" + camisetas[parametros.cor][parametros.gola][parametros.estampa].foto;
        var preco_total = quantidade * preco_unitario;
        
        // 2. A camisa de qualidade alta (190g/m2) deve acrescer o preço unitário em 12%.
        if (parametros.qualidade == "q190") {
            preco_total *= 1.12;
        }

        // 3. A embalagem unitária tem um custo de 0.15 por unidade
        if (parametros.embalagem == "unitaria") {
            preco_total += parametros.quantidade * 0.15;
        }

        // 4. Após cálculo do preço, há que se aplicar um desconto por quantidade, sendo: 
        // faixa 1: acima de 1.000 - Desconto de 15%
        // faixa 2: acima de 500 - Desconto de 10%
        // faixa 3: acima de 100 - Desconto de 5%
        if (quantidade >= 1000) {
            preco_total *= 0.85;
        } else if (quantidade >= 500) {
            preco_total *= 0.90;
        } else if (quantidade >= 100) {
            preco_total *= 0.95;
        }

        // 3. Altere a função do cálculo do preço. Em vez de soltar os valores no console, atualize as informações
        // nos elementos "result_", atualize o preço no elemento "valor-total" e mude o atributo "src" do elemento
        // "foto-produto" para alterar a imagem mostrada (todas as imagens estão na pasta img).

        window.setTimeout(function () {

            var id_gola = "#" + parametros.gola;
            $("#result_gola").html($(id_gola).html()); //usar assim para pegar o html que não contem o underline

            var id_cor = "#" + parametros.cor;
            $("#result_cor").html($(id_cor).html()); //usar assim para pegar o html que não contem o underline

            var id_estampa = "option[value='" + parametros.estampa + "']";
            $("#result_estampa").html($(id_estampa).html());

            var id_qualidade = "#" + parametros.qualidade;
            $("#result_qualidade").html($(id_qualidade).html()); //usar assim para pegar o html que não contem o underline

            var id_embalagem = "option[value='" + parametros.embalagem + "']";
            $("#result_embalagem").html($(id_embalagem).html());

            $("#result_quantidade").html(parametros.quantidade); //usar assim para pegar o html que não contem o underline

            $("#valor-total").html(preco_total.toLocaleString('pt-BR', { minimumFractionDigits: 2, maximunFractionDigits: 2 }));

            $("#foto-produto").attr("src", foto);

            $(".refresh-loader").hide();
        }, 1000);


        window.localStorage.setItem("gola", parametros.gola);
        window.localStorage.setItem("cor", parametros.cor);
        window.localStorage.setItem("estampa", parametros.estampa);
        window.localStorage.setItem("qualidade", parametros.qualidade);
        window.localStorage.setItem("embalagem", parametros.embalagem);
        window.localStorage.setItem("quantidade", parametros.quantidade);


    };

    function atualizar_campos(parametros) {
        //cor
        $("#cor").children().removeClass("selected");
        var id_cor = "#" + parametros.cor;
        $(id_cor).addClass("selected");

        //gola
        $("#gola").children().removeClass("selected");
        var id_gola = "#" + parametros.gola;
        $(id_gola).addClass("selected");

        //qualidade
        $("#qualidade").children().removeClass("selected");
        var id_qualidade = "#" + parametros.qualidade;
        $(id_qualidade).addClass("selected");

        //estampa
        $("#estampa").val(parametros.estampa);

        //embalagem
        $("#embalagem").val(parametros.embalagem);

        //quantidade
        $("#quantidade").val(parametros.quantidade);

    };


    // 2. Faça os eventos click e change para os filtros.

    // c. Sempre que um dos eventos acima ocorrer, atualize a variável "parametros_pesquisa" e rode a função para
    // calcular o preço

    // a. Faça o evento click para os filtros do tipo botão (.option-filter). Sempre que houver um click,
    // remova a classe "selected" dos botões do grupo e depois aplique-a apenas ao que foi clicado para
    // que ele fique azul.

    // b. Faça o evento change para os filtros do tipo <select> e para o <input> de quantidade.
    $("#quantidade").change(function () {
        parametros_pesquisa[$(this).attr("id")] = $(this).val(); //top pegar valor pelo this
        calc_preco(parametros_pesquisa);
    });

    $(".option-filter div").click(function () {
        $(this).parent().children("div").removeClass("selected");
        $(this).addClass("selected");

        parametros_pesquisa[$(this).parent().attr("id")] = $(this).attr("id"); //top pegar valor pelo this
        calc_preco(parametros_pesquisa);
    });

    // b. Faça o evento change para os filtros do tipo <select> e para o <input> de quantidade.
    $("select").change(function () {
        var parametro_select = $(this).attr("id");
        parametros_pesquisa[parametro_select] = $(this).val(); //top pegar valor pelo this
        calc_preco(parametros_pesquisa);
    });

    //ao carregar obter valores do local storage

    if (window.localStorage["quantidade"]) {
        parametros_pesquisa.quantidade = parseInt(window.localStorage["quantidade"]);
    };
    if (window.localStorage["cor"]) {
        parametros_pesquisa.cor = window.localStorage["cor"];
    };
    if (window.localStorage["gola"]) {
        parametros_pesquisa.gola = window.localStorage["gola"];
    };
    if (window.localStorage["qualidade"]) {
        parametros_pesquisa.qualidade = window.localStorage["qualidade"];
    };
    if (window.localStorage["estampa"]) {
        parametros_pesquisa.estampa = window.localStorage["estampa"];
    };
    if (window.localStorage["embalagem"]) {
        parametros_pesquisa.embalagem = window.localStorage["embalagem"];
    };



    calc_preco(parametros_pesquisa);
    atualizar_campos(parametros_pesquisa);
});



// Sugestão de etapas da resolução

// 4. Adicione a funcionalidade de hide e show do spinner (elemento "refresh-loader") à função de cálculo de preço.
// Como não estamos consultando dados externos, o cálculo acaba sendo rápido demais, portanto use um setTimeout
// para deixar ele aparecer por pelo menos 2 segundos.

// 5. Crie a funcionalidade do localStorage e ao carregar a página, consulte o localStorage,
// atualize a variável "parametros_pesquisa" e rode a função de cálculo de preço

