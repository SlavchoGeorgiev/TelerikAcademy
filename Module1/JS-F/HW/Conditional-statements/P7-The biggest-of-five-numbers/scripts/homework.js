var input = document.getElementById('input'),
    num = [];


input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that finds the greatest of given 5 variables.');
jsConsole.writeLine('Use nested if statements.');
jsConsole.write('Num' + (num.length + 1) + ' = ');

function executeOnEvent() {
    if (num.length < 4) {
        num.push(jsConsole.readFloat('#input'));
        jsConsole.writeLine(input.value);
        input.value = '';
        jsConsole.write('Num' + (num.length + 1) + ' = ');
    }
    else {
        num.push(jsConsole.readFloat('#input'));
        jsConsole.writeLine(input.value);
        input.value = '';
        jsConsole.writeLine('Greatest: ' +  findBiggest(num.pop(), num.pop(), num.pop(), num.pop(), num.pop()));
        jsConsole.write('Num' + (num.length + 1) + ' = ');
    }
}

function findBiggest(num1, num2, num3, num4, num5) {
    if (num1 >= num2 && num1 >= num3 && num1 >= num4 && num1 >= num5)
    {
        return num1;
    }
    else if (num2 >= num3 && num2 >= num4 && num2 >= num5)
    {
        return num2;
    }
    else if (num3 >= num4 && num3 >= num5)
    {
        return num3;
    }
    else if (num4 >= num5)
    {
        return num4;
    }
    else
    {
        return num5;
    }
}