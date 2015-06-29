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

jsConsole.writeLine('Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).');
jsConsole.writeLine('Calculates and prints its real roots.');
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
        jsConsole.writeLine(quadraticEquation(a, b, c));
        a = undefined;
        b = undefined;
        c = undefined;
        jsConsole.write('a = ');
    }
}

function quadraticEquation(coefficientA, coefficientB, coefficientC) {
    var d = coefficientB * coefficientB - 4 * coefficientA * coefficientC,
        result;
    if (d == 0)
    {
        result = 'There is exactly one real root <//br> X = ' + (-(b / (2 * a)));
    }
    else
    {
        if (d < 0)
        {
            result = 'There are no real roots.';
        }
        else
        {
            result =    'X1 = ' +  (-b + Math.sqrt(d)) / (2 * a) + '<br/>' +
                        'X2 = ' +  (-b - Math.sqrt(d)) / (2 * a);
        }
    }

    return result;
}