var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time');
jsConsole.write('Please enter number: ');

function executeOnEvent() {
    var n, i, numbers = [];

    jsConsole.writeLine(input.value);
    n = jsConsole.readInteger('#input');
    input.value = '';

    for (i = 1; i <= n; i += 1) {
        if (i % 3 !== 0 && i % 7 !== 0) {
            numbers.push(i);
        }
    }

    jsConsole.writeLine(numbers.join(', '));
    console.log(numbers.join(', '));
    jsConsole.writeLine('Please enter number: ');
}
