var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Sorting an array means to arrange its elements in increasing order.');
jsConsole.writeLine('Write a script to sort an array.');
jsConsole.writeLine('Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.');
jsConsole.writeLine('Please enter sequence of numbers separated by space: ');

function executeOnEvent() {
    var arr;
    arr = jsConsole.read('#input').split(' ').map(function (item) {
        return parseFloat(item);
    });
    jsConsole.writeLine(arr.join(', '));
    input.value = '';
    jsConsole.writeLine(sort(arr).join(', '));
    jsConsole.writeLine('Please enter sequence of numbers separated by space: ');
}

function sort(arr) {
    var i, j, minInTheRest, indexOfMin;

    for (i = 0; i < arr.length - 1; i++)
    {
        minInTheRest = arr[i];
        indexOfMin = -1;
        for (j = i + 1; j < arr.length; j++)
        {
            if (arr[j] <= minInTheRest)
            {
                minInTheRest = arr[j];
                indexOfMin = j;
            }
        }
        if (indexOfMin != -1)
        {
            arr[i] ^= arr[indexOfMin];
            arr[indexOfMin] ^= arr[i];
            arr[i] ^= arr[indexOfMin];
        }
    }

    return arr;
}