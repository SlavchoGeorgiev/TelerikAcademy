//Write a function that removes all elements with a given value.
//Attach it to the array type.

Array.prototype.remove = function (element) {
    var result = [],
        index,
        len;
    for(index = 0, len = this.length; index < len; index += 1) {
        if (this[index] !== element) {
            result.push(this[index]);
        }
    }
    return result;
};

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

console.log(arr.remove(1));
