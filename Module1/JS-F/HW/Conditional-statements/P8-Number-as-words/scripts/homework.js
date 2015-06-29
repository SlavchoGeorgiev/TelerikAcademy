var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation');
jsConsole.write('Please enter number: ');

function executeOnEvent() {
    jsConsole.writeLine(input.value);
    jsConsole.writeLine(NumbersAsWordsBuilder(parseInt(input.value)));
    input.value = '';
    jsConsole.write('Please enter number: ');
}

function NumbersAsWordsBuilder(inputDig)
{
    if (inputDig === 0) {
        return 'Zero';
    }
    else if (CheckDigitNumbers(inputDig) <= 2 && inputDig < 20) {
        return DigitToText0to19(inputDig);
    }
    else if (CheckDigitNumbers(inputDig) === 2) {
        return DigitToText20to90(parseInt(inputDig / 10) * 10) + ' ' + DigitToText0to19(parseInt(inputDig % 10)).toLowerCase();
    }
    else if (parseInt(inputDig % 100) === 0) {
        return DigitToText0to19(parseInt(inputDig / 100)) + ' hundred ';
    }
    
    else if (CheckDigitNumbers(parseInt(inputDig % 100)) <= 2 && parseInt(inputDig % 100) < 20) {
        return DigitToText0to19(parseInt(inputDig / 100)) + ' hundred and ' + DigitToText0to19(parseInt(inputDig % 100)).toLowerCase();
    }
    else if (CheckDigitNumbers(parseInt(inputDig % 100)) === 2) {
        return DigitToText0to19(parseInt(inputDig / 100)) + ' hundred and ' + DigitToText20to90(parseInt(parseInt(inputDig % 100) / 10) * 10).toLowerCase() + ' ' + DigitToText0to19(parseInt(inputDig % 10)).toLowerCase();
    }
    return 'Invalid input!';
}
function DigitToText0to19(digit) {
    switch (digit) {
        case 0: return '';
        case 1: return 'One';
        case 2: return 'Two';
        case 3: return 'Three';
        case 4: return 'Four';
        case 5: return 'Five';
        case 6: return 'Six';
        case 7: return 'Seven';
        case 8: return 'Eight';
        case 9: return 'Nine';
        case 10: return 'Ten';
        case 11: return 'Eleven';
        case 12: return 'Twelve';
        case 13: return 'Тhirteen';
        case 14: return 'Fourteen';
        case 15: return 'Fifteen';
        case 16: return 'Sixteen';
        case 17: return 'Seventeen';
        case 18: return 'Eighteen';
        case 19: return 'Nineteen';
        default: return 'Error';
    }
}
function DigitToText20to90(digit) {
    switch (digit) {
        case 0: return '';
        case 20: return 'Twenty';
        case 30: return 'Thirty';
        case 40: return 'Forty';
        case 50: return 'Fifty';
        case 60: return 'Sixty';
        case 70: return 'Seventy';
        case 80: return 'Eighty';
        case 90: return 'Ninety';
        default: return 'Error';
    }
}
function CheckDigitNumbers(digit) {
    if (digit === 0) {
        return 1;
    }
    else {
        if (digit / 10.0 > 0 && digit / 10.0 < 1) {
            return 1;
        }
        else {
            if ((digit / 100.0 > 0) && (digit / 100.0 < 1)) {
                return 2;
            }
            else {
                if ((digit / 1000.0 > 0) && (digit / 1000.0 < 1)) {
                    return 3;
                }
                else {
                    return 0;
                }
            }
        }
    }
}
