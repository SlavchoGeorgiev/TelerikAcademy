var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

window.onload = function (){executeOnEvent();};

jsConsole.writeLine('Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.');
jsConsole.writeLine('');

function executeOnEvent() {
    jsConsole.writeLine('Lexicographically smallest property in ' + document.toString() + ' is: ' + min(document));
    jsConsole.writeLine('Lexicographically largest property in ' + document.toString() + ' is: ' + max(document));
    jsConsole.writeLine('');
    jsConsole.writeLine('Lexicographically smallest property in ' + window.toString() + ' is: ' + min(window));
    jsConsole.writeLine('Lexicographically largest property in ' + window.toString() + ' is: ' + max(window));
    jsConsole.writeLine('');
    jsConsole.writeLine('Lexicographically smallest property in ' + navigator.toString() + ' is: ' + min(navigator));
    jsConsole.writeLine('Lexicographically largest property in ' + navigator.toString() + ' is: ' + max(navigator));
    jsConsole.writeLine('');
}

function min(obj) {
    var smallest = undefined,
        property;

    for (property in obj ) {
        if (smallest === undefined) {
            smallest = property.toString();
        }

        if (property.toString() < smallest) {
            smallest = property.toString();
        }
    }

    return smallest;
}

function max(obj) {
    var largest = undefined,
    property;

    for (property in obj ) {
        if (largest === undefined) {
            largest = property.toString();
        }

        if (property.toString() > largest) {
            largest = property.toString();
        }
    }

    return largest;
}