var input = document.getElementById('input'),
    arr = undefined;

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.');
jsConsole.writeLine('Please enter sequence of numbers separated by space: ');

function executeOnEvent() {
    var element;

    if (arr === undefined) {
        arr = jsConsole.read('#input').split(' ').map(function (item) {
            return parseInt(item);
        });

        arr = arr.sort(function (a, b) {
            return a - b;
        });
        jsConsole.writeLine(arr.join(', '));
        input.value = '';
        jsConsole.write('Please enter element for search: ');
    }
    else {
        element = jsConsole.readInteger('#input');
        jsConsole.writeLine(element);
        input.value = '';

        jsConsole.writeLine('Index = ' + binSearch(arr, element, 0, arr.length));
        arr = undefined;
        jsConsole.writeLine('Please enter sequence of numbers separated by space: ');
    }
}

function binSearch(arr, element, indexMin, indexMax)
{
    var indexMid;
    if (indexMax < indexMin)
        return -1;
    else
    {
        indexMid = parseInt((indexMin + indexMax) / 2);
        if (arr[indexMid] > element)
            return binSearch(arr, element, indexMin, indexMid - 1);
        else if (arr[indexMid] < element)
            return binSearch(arr, element, indexMid + 1, indexMax);
        else
            return indexMid;
    }
}