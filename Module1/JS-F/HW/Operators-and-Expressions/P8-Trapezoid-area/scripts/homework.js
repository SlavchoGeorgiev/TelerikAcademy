var input = document.getElementById('input'),
    a = undefined,
    b = undefined,
    h = undefined;

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write an expression that calculates trapezoid\'s area by given sides a and b and height h.');
jsConsole.write('a = ');

function executeOnEvent() {

    if (a === undefined) {
        a = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(a);
        jsConsole.write('b = ');
    }
    else if (b === undefined) {
        b = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(b);
        jsConsole.write('h = ');
    }
    else if (h === undefined) {
        h = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(h);
        jsConsole.writeLine('Area = ' + (a + b) / 2 * h);

        a = undefined;
        b = undefined;
        h = undefined;
        jsConsole.write('a = ');
    }
}