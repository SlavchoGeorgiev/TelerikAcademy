var input = document.getElementById('input'),
    arrOfInts,
    inPosition;

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).');
jsConsole.writeLine('Please enter integer numbers separated by space: ');

function executeOnEvent() {
    if (arrOfInts === undefined) {
        arrOfInts = jsConsole.read('#input')
            .split(' ')
            .map(function (item) {
                return item | 0
            });
        input.value = '';
        jsConsole.writeLine(arrOfInts.join(', '));
        jsConsole.write('Please enter number\'s position: ');
    }
    else if (inPosition === undefined) {
        inPosition = jsConsole.readInteger('#input');
        input.value = '';
        jsConsole.writeLine(inPosition);
        jsConsole.writeLine(arrOfInts.isElementBiggerThanNeighbours(inPosition));
        jsConsole.writeLine('Please enter integer numbers separated by space: ');
        arrOfInts = undefined;
        inPosition = undefined;
    }
}

Array.prototype.isElementBiggerThanNeighbours = function (index) {
    if (this[index - 1] < this[index] && this[index + 1] < this[index]) {
        return this[index] + ' is bigger than its two neighbours';
    }
    return this[index] + ' isn\'t bigger than its two neighbours';
};