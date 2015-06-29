var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

window.onload = function () {
    executeOnEvent();
};

jsConsole.writeLine('Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.');
jsConsole.writeLine('Print the obtained array on the console.');

function executeOnEvent() {
    var array = [];
    array.length = 20;
    array = initializeArray(array);
    jsConsole.writeLine(array.join(', '));
}

function initializeArray(arrayForInit) {
    var i;
    for (i = 0; i < arrayForInit.length; i += 1) {
        arrayForInit[i] = i * 5;
    }

    return arrayForInit;
}

