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
        funct = function () { var a = 2; return a;},
        nullValue = null,
        nan = NaN,
        undef = undefined;

    jsConsole.writeLine('Boolean value: ' + boolean);
    jsConsole.writeLine('Integer number value: ' + intNum);
    jsConsole.writeLine('Floating point number value: ' + floatNum);
    jsConsole.writeLine('String value: ' + string);
    jsConsole.writeLine('Array value: ' + array.join(', '));
    jsConsole.writeLine('Object value: ' + object);
    jsConsole.writeLine('Function value: ' + funct);
    jsConsole.writeLine('Null value: ' + nullValue);
    jsConsole.writeLine('Not a number value: ' + nan);
    jsConsole.writeLine('Udefined value: ' + undef);
}

declarateJSLiterals();