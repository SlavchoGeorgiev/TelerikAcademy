var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that finds the most frequent number in an array.');
jsConsole.writeLine('Please enter sequence of numbers separated by space: ');

function executeOnEvent() {
    var arr;
    arr = jsConsole.read('#input').split(' ').map(function (item) {
        return parseFloat(item);
    });
    jsConsole.writeLine(arr.join(', '));
    input.value = '';
    jsConsole.writeLine(findMostFrequent(arr));
    jsConsole.writeLine('Please enter sequence of numbers separated by space: ');
}

function findMostFrequent(arr) {
    var mostFreq,
        mostFreqOccurrence = 0,
        current,
        currentOccurrence,
        i, j;

    for (i in arr){
        current = arr[i];
        currentOccurrence = 0;
        for(j in arr) {
            if (current === arr[j]) {
                currentOccurrence += 1;
            }
        }

        if (currentOccurrence >= mostFreqOccurrence) {
            mostFreqOccurrence = currentOccurrence;
            mostFreq = current;
        }
    }

    return mostFreq + ' (' + mostFreqOccurrence + ' times)';
}