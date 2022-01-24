// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.



// Deciding to go back or fourth
var bkwdOrFwd = 1;
var backwardOrder = document.getElementById("bkwdOrderButton");
var forwardOrder = document.getElementById("fwdOrderButton");

backwardOrder.addEventListener("click", function () {
    backwardOrder.style.backgroundColor = '#181717';
    backwardOrder.style.color = 'white';
    forwardOrder.style.backgroundColor = '#efefef';
    forwardOrder.style.color = 'black';

    bkwdOrFwd = -1;

}, false);

forwardOrder.addEventListener("click", function () {
    forwardOrder.style.backgroundColor = '#181717';
    forwardOrder.style.color = 'white';
    backwardOrder.style.backgroundColor = '#efefef';
    backwardOrder.style.color = 'black';

    bkwdOrFwd = 1;

}, false);

// Changing the text of the buttons and showing/hiding the relevant buttons
function changeBtnTxt(buttonIDa, buttonIDb, buttonIDc) {
    var text = document.getElementById(buttonIDa);

    if (buttonIDa == "startButton") {
        text.value = text.value == "Start" ? "Stop" : "Start";
    }
    if (buttonIDa == "orderButton") {
        if (text.value == "Sequential") {
            text.value = "Random";
            document.getElementById(buttonIDb).style.visibility = "hidden";
            document.getElementById(buttonIDb).style.display = "none";
            document.getElementById(buttonIDc).style.visibility = "hidden";
            document.getElementById(buttonIDc).style.display = "none";
        } else if (text.value == "Random") {
            text.value = "Sequential";
            document.getElementById(buttonIDb).style.visibility = "visible";
            document.getElementById(buttonIDb).style.display = "inline-block";
            document.getElementById(buttonIDc).style.visibility = "visible";
            document.getElementById(buttonIDc).style.display = "inline-block";
        }
    }
}
