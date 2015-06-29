function onExecuteClick() {
    jsConsole.writeLine(new Array(80).join('-'));
    declarateJSLiterals();
}

function declarateJSLiterals() {
    var boolean = true,
        intNum = 1,
        floatNum = 1.5,
        string = '"string"',
        array = [1, 2, 3, 4, 5, 6],
        object = { name: 'Pesho', grade: 2 },
        funct = function () { var a = 2; return a; },
        nullValue = null,
        nan = NaN,
        undef = undefined;

    jsConsole.writeLine('Type of Boolean: ' + typeof boolean);
    jsConsole.writeLine('Type of Integer number: ' + typeof intNum);
    jsConsole.writeLine('Type of Floating point number: ' + typeof floatNum);
    jsConsole.writeLine('Type of String: ' + typeof string);
    jsConsole.writeLine('Type of Array: ' + typeof array);
    jsConsole.writeLine('Type of Object: ' + typeof object);
    jsConsole.writeLine('Type of Function: ' + typeof funct);
    jsConsole.writeLine('Type of Null: ' + typeof nullValue);
    jsConsole.writeLine('Type of Not a number: ' + typeof nan);
    jsConsole.writeLine('Type of Udefined: ' + typeof undef);
}

declarateJSLiterals();