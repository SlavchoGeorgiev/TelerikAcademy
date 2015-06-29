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

jsConsole.writeLine('Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.');
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

        if(a === 0 ||  b === 0 || c === 0) {
            jsConsole.writeLine('result: 0');
        }
        else if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0)) {
            jsConsole.writeLine('result: +')
        }
        else {
            jsConsole.writeLine('result: -')
        }

        a = undefined;
        b = undefined;
        c = undefined;
        jsConsole.write('a = ');
    }
}