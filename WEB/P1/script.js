difficulty.addEventListener('change', function() {
    var sorteados = [""];
    sorteados[0] = "0";
    var difficulty = document.getElementById("difficulty");
    var row1 = document.getElementById("row1");
    var row2 = document.getElementById("row2");
    var row3 = document.getElementById("row3");
    var row4 = document.getElementById("row4");
    var imagens = [""];
    var imagesNumber = parseInt(difficulty.value);
    var imagem1;
    var imagem2;
    var passou = false;
    var contaSelecao = 1;
    var pares = 0;

    for (var i = 0; i < imagesNumber; i++) {
        imagens[i] = ("0".concat(i + 1)).toString().substr(-2) + ".png"
        console.log(imagens[i]);
    }
    
    for (var i = 0; i < imagesNumber; i++) {
        imagens.push(("0".concat(i + 1)).toString().substr(-2) + ".png")
        console.log(imagens[i]);
    }
    
    //embaralha o array
    function sorteio(array) {
        var indiceAtual = array.length, valorAux, randomIndex;
    
        // varre o array
        while (0 !== indiceAtual) {
    
            // faz o sorteio
            randomIndex = Math.floor(Math.random() * indiceAtual);
            indiceAtual -= 1;
    
            // troca a posicao do elemento
            valorAux = array[indiceAtual];
            array[indiceAtual] = array[randomIndex];
            array[randomIndex] = valorAux;
        }
        
        return array;
    }
    
    //Chama a funcao para embaralhar o array
    sorteio(imagens);
    
    var celulas = document.getElementsByTagName('td');
    //var celulas = sorteio(array)
    var contador = 0;
    
    for (let cel of celulas) {
        cel.addEventListener('click', mouse_click);
        cel.firstChild.src = imagens[contador];
        contador += 1;
    }
    
    contador = 0;
    setTimeout(function () {
        for (let cel of celulas) {
            cel.firstChild.style.visibility = "hidden";
            contador += 1;
        }
    }, 1000);
    
    function mouse_click(cel) {
        if ((contaSelecao <= 2) && (cel.target.firstChild.style.visibility == "hidden")) {
            if (passou == false) {
                passou = true;
                cel.target.firstChild.style.visibility = "visible";
                imagem1 = cel.target.firstChild;
                contaSelecao += 1;
            } else {
                passou = false;
                cel.target.firstChild.style.visibility = "visible";
                imagem2 = cel.target.firstChild;
                contaSelecao += 1;
                setTimeout(function () {
                    validaImagens();
                }, 1000);
            }
        }
    }
    
    function validaImagens() {
        if (imagem2.src != imagem1.src) {
            imagem1.style.visibility = "hidden";
            imagem2.style.visibility = "hidden";
        } else {
            pares++;
            console.log(pares);
            if (pares === imagesNumber) {
                alert('Parabens!');
                pares = 0;
                imagem1 = null;
                imagem2 = null;
                passou = false;
                contaSelecao = 1;
            }
        }
        imagem1 = null;
        imagem2 = null;
        contaSelecao = 1;
    }

    if (difficulty.value === "3") {
        if (row2.className === "show") {
            row2.classList.toggle("hide");
            row2.classList.toggle("show");
        }
        if (row3.className === "show") {
            row3.classList.toggle("hide");
            row3.classList.toggle("show");
        }
        if (row4.className === "show") {
            row4.classList.toggle("hide");
            row4.classList.toggle("show");
        }
    } else if (difficulty.value === "6") {
        if (row2.className === "hide") {
            row2.classList.toggle("hide");
            row2.classList.toggle("show");
        }
        if (row3.className === "show") {
            row3.classList.toggle("hide");
            row3.classList.toggle("show");
        }
        if (row4.className === "show") {
            row4.classList.toggle("hide");
            row4.classList.toggle("show");
        }
    } else if (difficulty.value === "9") {
        if (row2.className === "hide") {
            row2.classList.toggle("hide");
            row2.classList.toggle("show");
        }
        if (row3.className === "hide") {
            row3.classList.toggle("hide");
            row3.classList.toggle("show");
        }
        if (row4.className === "show") {
            row4.classList.toggle("hide");
            row4.classList.toggle("show");
        }
    } else if (difficulty.value === "12") {
        if (row2.className === "hide") {
            row2.classList.toggle("hide");
            row2.classList.toggle("show");
        }
        if (row3.className === "hide") {
            row3.classList.toggle("hide");
            row3.classList.toggle("show");
        }
        if (row4.className === "hide") {
            row4.classList.toggle("hide");
            row4.classList.toggle("show");
        }
    }

    console.log(imagesNumber);
});
     
function Teste(){
    window.location.reload();
}