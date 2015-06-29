//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

var expression1 = '((a+b)/5-d)',
    expression2 = ')(a+b))';

function isCorrectBrackets(exp) {
    var count = 0,
        i,
        len;

    for (i = 0, len = exp.length; i < len; i += 1) {
        if (exp[i] === '(') {
            count += 1;
        }
        else if (exp[i] === ')') {
            count -= 1;
        }

    }

    return !count;
}
console.log(isCorrectBrackets(expression1));
console.log(isCorrectBrackets(expression2));