var input = document.getElementById('input');
input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.');
jsConsole.writeLine('The bits are counted from right to left, starting from bit #0.');
jsConsole.writeLine('The result of the expression should be either 1 or 0.');
jsConsole.write('Please enter a digit: ');

function executeOnEvent() {
    var inputDigit = jsConsole.readInteger('#input'),
    mask = 1 << 3,
        thirdBit = (inputDigit & mask) >> 3;

    jsConsole.writeLine(inputDigit + ' = ' +inputDigit.toString(2));
    jsConsole.writeLine('Bit #3 = ' + thirdBit);
    jsConsole.write('Please enter a digit: ');
}