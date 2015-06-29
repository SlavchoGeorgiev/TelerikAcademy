var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a function that reverses the digits of given decimal number.');
jsConsole.write('Please enter decimal number: ');

function executeOnEvent() {
    var userInput = jsConsole.readFloat('#input');
    jsConsole.writeLine(userInput);
    input.value = "";
    jsConsole.writeLine('Reversed: ' + reverseNumber(userInput));
    jsConsole.write('Please enter decimal number: ');
}

function reverseNumber(inputNumber) {
    var result,
        isNegative = false;
    if (inputNumber < 0) {
        isNegative = true;
        result = (-1 * inputNumber).toString();
    }
    else {
        result = inputNumber.toString();
    }
    result = result.split('');
    result = result.reverse();
    result = result.join('');
    if (isNegative){
        return result * -1;
    }
    return result * 1;
}