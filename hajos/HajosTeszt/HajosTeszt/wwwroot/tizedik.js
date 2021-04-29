var kérdések;
var kerdes_szam = 1;
window.onload = function letöltés() {

    fetch('/questions/4')
        .then(response => response.json())
        .then(data => console.log(data)
        );
}

function letöltésBefejeződött(data) {

    console.log(data)
    kérdések = data;
    let ide = document.getElementById("kérdés_szöveg");
    let elem = document.createElement("div");
    kérdésMegjelenítés(data);
}

function kérdésMegjelenítés(kérdés) {
    console.log(kérdés);
    document.getElementById("kérdés_szöveg").innerText = kérdés.questionText
    document.getElementById("válasz1").innerText = kérdés.answer1
    document.getElementById("válasz2").innerText = kérdés.answer2
    document.getElementById("válasz3").innerText = kérdés.answer3
    document.getElementById("kép").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
}

function kérdésBetöltés(id) {
    fetch(`/questions/${id}`)
        .then(response => {
            if (!response.ok) {
                console.error(`Hibás válasz: ${response.status}`)
            }
            else {
                return response.json()
            }
        })
        .then(data => kérdésMegjelenítés(data));
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
