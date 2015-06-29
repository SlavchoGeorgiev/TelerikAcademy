var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a function that returns the last digit of given integer as an English word.');
jsConsole.writeLine('Please enter integer number: ');

function executeOnEvent() {
    var input = jsConsole.readInteger('#input');
    jsConsole.writeLine('The last digit is: ' + digitAsWord(input % 10));
    jsConsole.writeLine('Please enter integer number: ');
}

function digitAsWord(digit) {
    switch (parseInt(digit)) {
        case 0: return "Zero";
        case 1: return "One";
        case 2: return "Two";
        case 3: return "Three";
        case 4: return "Four";
        case 5: return "Five";
        case 6: return "Six";
        case 7: return "Seven";
        case 8: return "Eight";
        case 9: return "Nine";
        default: return "not a digit";
    }
}