﻿window.onload = function () {
    console.log("start")

    let hova = document.getElementById("ide");
    for (var s = 0; s < 10; s++) {
        let sor = document.createElement("div");
        sor.classList.add("sor")
        hova.appendChild(sor);


        for (var o = 0; o < 10; o++) {
            let szám = document.createElement("div");
            szám.classList.add("elem")
            sor.appendChild(szám);
            szám.innerText = (s + 1) * (o + 1);



        } 

    }
}