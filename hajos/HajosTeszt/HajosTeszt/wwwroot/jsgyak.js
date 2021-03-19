window.onload = function () {
    console.log("betölt")

   

    var faktoriális = function (n) {
        let er = 1;
        for (let i = 2; i <= n; i++) {
            er = er * i;
        }
        return er;
    }

    let hova = document.getElementById("pascal");
    for (var s = 0; s < 10; s++) {
        let sor = document.createElement("div");
        sor.classList.add("sor")
        hova.appendChild(sor);
        


        for (var o = 0; o < s + 1; o++) {
            let elem = document.createElement("div");
            elem.classList.add("elem")
            sor.appendChild(elem);

            elem.innerText = faktoriális(s) / (faktoriális(o) * faktoriális(s - o));
           
        }






    }






}
