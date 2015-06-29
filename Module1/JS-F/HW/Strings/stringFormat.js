//Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.


function stringFormat() {
    var args = Array.prototype.slice.call(arguments),
        regex,
        i,
        len;

    for (i = 1, len = args.length; i < len; i += 1) {
        regex = new RegExp('\\{' + (i - 1) + '\\}', 'g');
        args[0] = args[0].replace(regex, args[i]);
    }

    return args[0];
}

console.log(stringFormat('Hello {0}!', 'Peter'));

var frmt = '{0}, {1}, {0} text {2}',
    str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log(str);