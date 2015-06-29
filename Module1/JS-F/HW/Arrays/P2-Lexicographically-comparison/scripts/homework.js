var input = document.getElementById('input'),
    firstString,
    secondString;

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that compares two char arrays lexicographically (letter by letter).');
jsConsole.write('Please enter first   string: ');

function executeOnEvent() {

    if (firstString === undefined) {
        firstString = jsConsole.read('#input');
        input.value = '';
        jsConsole.writeLine(firstString);
        jsConsole.write('Please enter second string: ');

    }
    else if (secondString === undefined) {
        secondString = jsConsole.read('#input');
        input.value = '';
        jsConsole.writeLine(secondString);
        compareTwoStrings(firstString.split(''), secondString.split(''));
        firstString = undefined;
        secondString = undefined;
        jsConsole.write('Please enter first  string: ');
    }
}


var compareTwoStrings = function (firstString, secondString) {
    var i,
        lenght;
    if (firstString.length > secondString.length) {
        lenght = secondString.length;
    }
    else {
        lenght = firstString.length;
    }

    for (i = 0; i < lenght; i += 1) {
        if (firstString[i].toString() > secondString[i].toString()) {
            jsConsole.writeLine(firstString[i] + ' > ' + secondString[i]);
        }
        else if (firstString[i].toString() < secondString[i].toString()) {
            jsConsole.writeLine(firstString[i] + ' < ' + secondString[i]);
        }
        else {
            jsConsole.writeLine(firstString[i] + ' = ' + secondString[i]);
        }
    }
};