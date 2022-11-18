
var someVar = 42;

let button = document.createElement("button");
button.innerHTML = "Ge mig svaret på allt ";
button.onclick = function () {
    alert(someVar);
}
document.querySelector("body").appendChild(button);

/* let button2 = document.createElement("button");
button2.innerHTML = "Ge mig svaret på allt (someLet)";
button2.onclick = function () {
    alert(someLet);
}
document.querySelector("body").appendChild(button2); */