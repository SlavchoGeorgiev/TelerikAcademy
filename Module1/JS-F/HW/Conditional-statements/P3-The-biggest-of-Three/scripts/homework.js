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

jsConsole.writeLine('Write a script that finds the biggest of three numbers.');
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

        if (a >= b && a >= c) {
            jsConsole.writeLine(a + ' is the biggest');
        }
        else if (b >= a && b >= c) {
            jsConsole.writeLine(b + ' is the biggest');
        }
        else {
            jsConsole.writeLine(c + ' is the biggest');
        }

        a = undefined;
        b = undefined;
        c = undefined;
        jsConsole.write('a = ');
    }
}