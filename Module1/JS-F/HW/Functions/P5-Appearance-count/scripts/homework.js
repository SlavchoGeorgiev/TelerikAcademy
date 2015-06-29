var input = document.getElementById('input'),
    numbers,
    searchNumber,
    testData = [
        {
            arr: [1, 2, 3, 4, 5, 3, 3],
            searchNum: 3,
            expResult: 3
        },
        {
            arr: [1, 2, 3, 4, 5, 3, 5],
            searchNum: 3,
            expResult: 2
        },
        {
            arr: [1, 2, 3, 5, 4, 5, 3, 3],
            searchNum: 5,
            expResult: 2
        },
        {
            arr: [1, 6.5, 3, 6.5, 5, 3, 3],
            searchNum: 6.5,
            expResult: 2
        }
    ];

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a function that counts how many times given number appears in given array.');
jsConsole.writeLine('Write a test function to check if the function is working correctly.');

jsConsole.writeLine('-=== Test Begin ===-');
testCountOccurs(testData);
jsConsole.writeLine('-=== Test End ===-');

jsConsole.writeLine('Please enter numbers separated by space: ');

function executeOnEvent() {
    if (numbers === undefined) {
        numbers = jsConsole.read('#input')
            .split(' ')
            .map(function (item){return item * 1});
        input.value = '';
        jsConsole.writeLine(numbers.join(', '));
        jsConsole.write('Please enter search number: ');
    }
    else if (searchNumber === undefined) {
        searchNumber = jsConsole.readFloat('#input');
        input.value = '';
        jsConsole.writeLine(searchNumber);
        jsConsole.writeLine('Number ' + searchNumber + ' occur: ' + countOccurs(numbers, searchNumber) + ' times');
        jsConsole.writeLine('Please enter numbers separated by space: ');
        numbers = undefined;
        searchNumber = undefined;
    }
}

function countOccurs(numbers, searchNumber) {
    var count = 0;
    numbers.forEach(function (item) {if (item === searchNumber) count += 1;});
    return count;
}

function testCountOccurs(data) {
    var i,
        len,
        printValue;
    for(i = 0, len = data.length; i < len; i += 1) {
        printValue = 'Test: ' + (i + 1) + ' Array ' + '<\/br>' +
            data[i].arr.join(', ') + '<\/br>' +
            ' Search number: ' +  data[i].searchNum + '<\/br>' +
            ' Expected result: ' + data[i].expResult + '<\/br>' +
            ' Result: ' + countOccurs(data[i].arr, data[i].searchNum) + '<\/br>';
        jsConsole.writeLine(printValue);
    }
}