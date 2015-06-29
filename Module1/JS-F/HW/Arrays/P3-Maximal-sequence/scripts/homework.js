var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that finds the maximal sequence of equal elements in an array.');
jsConsole.writeLine('Please enter sequence of numbers separated by space: ');

function executeOnEvent() {
    var sequence;
    sequence = jsConsole.read('#input').split(' ').map(function (item) {
        return parseFloat(item);
    });
    jsConsole.writeLine(sequence.join(', '));
    input.value = '';
    jsConsole.writeLine(maxSequence(sequence).join(', '));
    jsConsole.writeLine('Please enter sequence of numbers separated by space: ');
}

function maxSequence(sequence) {
    var sequenceStart = 0,
        sequenceEnd = 0,
        maxSequenceStart = 0,
        maxSequenceEnd = 0,
        result = [],
        i = 0;

    for (sequenceStart in sequence) {
        for (i = sequenceStart | 0; i < sequence.length; i += 1) {
            if (sequence[i] === sequence[1 + i]) {
                sequenceEnd = 1 + i;
            }
            else {
                if (sequenceEnd - sequenceStart > maxSequenceEnd - maxSequenceStart) {
                    maxSequenceStart = sequenceStart | 0;
                    maxSequenceEnd = sequenceEnd | 0;
                }
                break;
            }
        }
    }

    for (i = maxSequenceStart; i <= maxSequenceEnd; i += 1) {
        result.push(sequence[i]);
    }
    return result;
}