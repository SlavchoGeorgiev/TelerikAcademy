var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that finds the max and min number from a sequence of numbers.');
jsConsole.writeLine('Please enter sequence of numbers separated by space: ');

function executeOnEvent() {
    var sequence;
    sequence = jsConsole.read('#input').split(' ');
    jsConsole.writeLine(jsConsole.read('#input'));
    input.value = '';
    jsConsole.write('Min = ' + min(sequence) + ' ');
    jsConsole.writeLine('Max = ' + max(sequence));
    jsConsole.writeLine('Please enter sequence of numbers separated by space: ');
}

function min(sequence) {
    var minNum,
        i;

    for (i in sequence) {
        if (!isNaN(parseFloat(sequence[i]))) {
            minNum = parseFloat(sequence[i]);
            break;
        }
    }

    for (i in sequence) {
        if (parseFloat(sequence[i]) < minNum && !isNaN(parseFloat(sequence[i]))) {
            minNum = parseFloat(sequence[i]);
        }
    }
    return minNum;
}

function max(sequence) {
    var maxNum,
        i;

    for (i in sequence) {
        if (!isNaN(parseFloat(sequence[i]))) {
            maxNum = parseFloat(sequence[i]);
            break;
        }
    }

    for (i in sequence) {
        if (parseFloat(sequence[i]) > maxNum && !isNaN(parseFloat(sequence[i]))) {
            maxNum = parseFloat(sequence[i]);
        }
    }
    return maxNum;
}