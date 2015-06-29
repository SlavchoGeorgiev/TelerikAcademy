var input = document.getElementById('input'),
    digit = undefined;

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).');
jsConsole.write('Digit = ');

function executeOnEvent() {

    digit = jsConsole.read('#input');
    input.value = '';
    jsConsole.writeLine(digit);
    jsConsole.writeLine(digitAsWord(digit));
    jsConsole.write('Digit = ');
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