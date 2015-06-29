var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that prints all the numbers from 1 to N.');
jsConsole.write('Please enter number: ');

function executeOnEvent() {
    var n, i, line = '';

    jsConsole.writeLine(input.value);
    n = jsConsole.readInteger('#input');
    input.value = '';

    for (i = 1; i <= n; i+=1) {
        console.log(i);
        if (i !== n) {
            line += i + ', ';
        }
        else {
            jsConsole.writeLine(line + i);
        }
    }

    jsConsole.writeLine('Please enter number: ');
}

