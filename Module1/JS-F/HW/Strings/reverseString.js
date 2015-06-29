//Write a JavaScript function that reverses a string and returns it.

var str = 'Lorem ipsum dolor sit amet.';

String.prototype.reverseStr = function () {
    var string = String(this),
        tempStr = string.split('');
    tempStr = tempStr.reverse();
    return tempStr.join('');
};

console.log(str.reverseStr());