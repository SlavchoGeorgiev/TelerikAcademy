var input = document.getElementById('input'),
    a = undefined,
    b = undefined;


input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.');
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
        if (a > b) {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        jsConsole.writeLine(a + ' ' + b);
        a = undefined;
        b = undefined;
        jsConsole.write('a = ');
    }
}