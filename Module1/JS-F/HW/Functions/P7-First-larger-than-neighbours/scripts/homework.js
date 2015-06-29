var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.');
jsConsole.writeLine('Please enter numbers separated by space: ');

function executeOnEvent() {
    var arrOfNums;
    arrOfNums = jsConsole.read('#input')
        .split(' ')
        .map(function (item) {
            return item * 1});
    input.value = '';
    jsConsole.writeLine(arrOfNums.join(', '));
    jsConsole.writeLine('The index of the first element in array that is larger than its neighbours is: ' + arrOfNums.firstBiggerThanNeighbours());
}

Array.prototype.isElementBiggerThanNeighbours = function (index) {
    if (this[index - 1] < this[index] && this[index + 1] < this[index]) {
        return true;
    }
    return false;
};

Array.prototype.firstBiggerThanNeighbours = function () {
    var len,
        i;
    for(i = 0, len = this.length; i < len; i +=1) {
        if (this.isElementBiggerThanNeighbours(i)){
            return i;
        }
    }

    return -1;
};