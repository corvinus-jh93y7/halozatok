var kérdések;
var kerdes_szam = 1;

var hotList = [];      
var questionsInHotList = 3;
var displayedQuestion;   
var numberOfQuestions;      
var nextQuestion = 1; 
var timeoutHandler;
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
    let kérdés = hotList[displayedQuestion].question;
    console.log(kérdés);
    document.getElementById("kérdés_szöveg").innerText = kérdés.questionText
    document.getElementById("válasz1").innerText = kérdés.answer1
    document.getElementById("válasz2").innerText = kérdés.answer2
    document.getElementById("válasz3").innerText = kérdés.answer3
    document.getElementById("kép").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
}

function kérdésBetöltés(id) {
    fetch(`/questions/${questionNumber}`)
        .then(
            result => {
                if (!result.ok) {
                    console.error(`Hibás letöltés: ${response.status}`)
                }
                else {
                    return result.json()
                }
            }
        )
        .then(
            q => {
                hotList[destination].question = q;
                hotList[destination].goodAnswers = 0;
                console.log(`A ${questionNumber}. kérdés letöltve a hot list ${destination}. helyére`)
                if (displayedQuestion == undefined && destination == 0) { //!!!!!!!!!!!!!
                    displayedQuestion = 0;
                    kérdésMegjelenítés();
                }
        );
} 


function init() {
    for (var i = 0; i < questionsInHotList; i++) {
        let q = {
            question: {},
            goodAnswers: 0
        }
        hotList[i] = q;
    }

    //Első kérdések letöltése
    for (var i = 0; i < questionsInHotList; i++) {
        kérdésBetöltés(nextQuestion, i);
        nextQuestion++;
    }
}


document.getElementById(`válasz1`).style.pointerEvents = "none"

function előre() {
    displayedQuestion++;
    if (displayedQuestion == questionsInHotList) displayedQuestion = 0;
    kérdésMegjelenítés()
}

document.getElementById("elore").onclick = előre();


timeoutHandler = setTimeout(előre, 3000);