/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(start, end) {
    var i,
        j,
        len,
        result = [],
        isPrime = true;

    if(arguments.length < 2){
        throw new Error();
    }

    start = start * 1;
    end = end * 1;

    for (i = start; i <= end; i += 1) {
        isPrime = true;
        for (j = 2, len = Math.sqrt(i); j <= len; j += 1) {
            if(i % j === 0){
                isPrime = false;
                break;
            }
        }

        if(isPrime && i > 1){
            result.push(i);
        }
    }

    return result;
}

module.exports = findPrimes;


//console.log(findPrimes(0, 10));