var input = document.getElementById('input');

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write an expression that checks for given integer if its third digit (right-to-left) is 7.');
jsConsole.write('Please enter a digit: ');

function executeOnEvent() {
    var inputDigit = jsConsole.readInteger('#input'),
        thirdDigit;
    thirdDigit = parseInt(inputDigit / 100) % 10;
    jsConsole.writeLine(inputDigit);


    if (thirdDigit === 7) {
        jsConsole.writeLine('Third digit (right-to-left) is: 7.');
    } else {
        jsConsole.writeLine('Third digit (right-to-left) isn\'t 7 it is: ' + thirdDigit);
    }

    jsConsole.write('Please enter a digit: ');
}