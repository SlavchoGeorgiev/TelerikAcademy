var input = document.getElementById('input'),
    x = undefined,
    y = undefined,
    h = 0,
    k = 0,
    r = 5;
input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius');
/*(x-h)^2+(y-k)^2=r^2*/
jsConsole.write('x = ');

function executeOnEvent() {

    if (x === undefined) {
        x = jsConsole.readFloat('#input');
        jsConsole.writeLine(x);
        jsConsole.write('y = ');
    } else if (y === undefined) {
        y = jsConsole.readFloat('#input');
        jsConsole.writeLine(y);
        if ((x - h) * (x - h) + (y - k) * (y - k) <= r * r) {
            jsConsole.writeLine('P(' + x + ', ' + y + ') is inside K({' + h + ', ' + k + '}, ' + r + ')');
        }
        else {
            jsConsole.writeLine('P(' + x + ', ' + y + ') is outside K({' + h + ', ' + k + '}, ' + r + ')');
        }
        x = undefined;
        y = undefined;
        jsConsole.write('x = ');
    }
}