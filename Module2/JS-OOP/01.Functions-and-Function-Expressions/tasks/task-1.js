/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(arr) {

    var result = (function () {
        var sum;

        if(Array.isArray(arr) && arr.length === 0) {
            return null;
        }

        arr = arr.map(function(element) {
            element = element * 1;
            if (isNaN(element)){
                throw new Error();
            }
            return element;
        });

        sum = arr.reduce(function(a, b) {
            return a + b;
        });

        return sum;
    }());

    return result;
}

module.exports = sum;