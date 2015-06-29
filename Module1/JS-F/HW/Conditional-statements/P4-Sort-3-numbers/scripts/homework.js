var input = document.getElementById('input'),
    a = undefined,
    b = undefined,
    c = undefined;


input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Sort 3 real values in descending order.');
jsConsole.write('a = ');

function executeOnEvent() {

    if (a === undefined) {
        a = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(a);
        jsConsole.write('b = ');

    } else if (b === undefined) {
        b = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(b);
        jsConsole.write('c = ');
    }
    else if (c === undefined) {
        c = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(c);

        if (a > b) {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        if (c < a ) {
            jsConsole.writeLine(b + ' ' + a + ' ' + c);
        }
        else if (c > b) {
            jsConsole.writeLine(c + ' ' + b + ' ' + a);
        }
        else {
            jsConsole.writeLine(b + ' ' + c + ' ' + a);
        }

        a = undefined;
        b = undefined;
        c = undefined;
        jsConsole.write('a = ');
    }
}