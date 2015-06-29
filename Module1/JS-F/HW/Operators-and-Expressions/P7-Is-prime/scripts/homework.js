var input = document.getElementById('input');
input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write an expression that checks if given positive integer number n (n ≤ 100) is prime.');
jsConsole.write('Please enter a n: ');

function executeOnEvent() {
    var n = jsConsole.readInteger('#input'),
        check = true,
        i;

    jsConsole.writeLine(n);

    if (n < 0) {
        check = false;
    } else if (n == 0 || n == 1) {
        check = false;
    }

    for (i = 2; i <= Math.sqrt(n); i += 1) {
        if (parseInt(n % i) === 0) {
            check = false;
        }
    }

    if (check) {
        jsConsole.writeLine(n + ' is prime');
    }
    else {
        jsConsole.writeLine(n + ' isn\'t prime');
    }

    jsConsole.write('Please enter a n: ');
}