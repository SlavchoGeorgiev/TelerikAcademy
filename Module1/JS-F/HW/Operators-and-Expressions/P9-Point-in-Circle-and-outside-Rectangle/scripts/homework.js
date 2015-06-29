var input = document.getElementById('input'),
    x = undefined,
    y = undefined,
    h = 1,
    k = 1,
    r = 3,
    rectangleTop = 1,
    rectangleLeft = -1,
    rectangleWidth = 6,
    rectangleHeight = 2;

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).');
jsConsole.write('x = ');

function executeOnEvent() {

    if (x === undefined) {
        x = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(x);
        jsConsole.write('y = ');
    } else if (y === undefined) {
        y = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(y);
        if (((x - h) * (x - h) + (y - k) * (y - k) <= r * r) && (x < rectangleLeft || x > (rectangleLeft + rectangleWidth) || y > rectangleTop || y < (rectangleTop - rectangleHeight))) {
            jsConsole.writeLine('yes');
        }
        else {
            jsConsole.writeLine('no');
        }

        x = undefined;
        y = undefined;
        jsConsole.write('x = ');
    }
}