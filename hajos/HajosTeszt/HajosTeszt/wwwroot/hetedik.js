var kérdések;
var kerdes_szam = 1;
window.onload = function letöltés() {

    fetch('/questions.json')
        .then(response => response.json())
        .then(data => letöltésBefejeződött(data)
        );
}

function letöltésBefejeződött(data) {

    console.log(data)
    kérdések = data;
    let ide = document.getElementById("kérdés_szöveg");
    let elem = document.createElement("div");
    kérdésMegjelenítés(data);
}

function kérdésMegjelenítés(data) {
    //kérdés
    ide = document.getElementById("kérdés_szöveg");
    elem = document.createElement("div");
    elem.innerHTML = data[kerdes_szam].questionText
    ide.appendChild(elem);

    //1.válasz
    ide = document.getElementById("válasz1");
    elem = document.createElement("div");
    elem.innerHTML = data[kerdes_szam].answer1
    ide.appendChild(elem);

    //2. válasz
    ide = document.getElementById("válasz2");
    elem = document.createElement("div");
    elem.innerHTML = data[kerdes_szam].answer2
    ide.appendChild(elem);

    //3.válasz
    ide = document.getElementById("válasz3");
    elem = document.createElement("div");
    elem.innerHTML = data[kerdes_szam].answer3
    ide.appendChild(elem);
}
function kovetkezo() {
    if (kerdes_szam == 1) {
        kerdes_szam = 2;
    }
    else {
        if (kerdes_szam == 2) {
            kerdes_szam = 3
        }
        else {
            kerdes_szam = 1;
        }
    }


    kérdésMegjelenítés();
}

document.getElementById("elore").onclick = kovetkezo();
