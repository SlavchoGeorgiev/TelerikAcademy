var input = document.getElementById('input');

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a function to count the number of div elements on the web page');
jsConsole.writeLine(countElements('div') + ' div elements in the current page.');
jsConsole.writeLine('Please enter tag name for search; ');

function executeOnEvent() {
    var tagName = jsConsole.read('#input');
    input.value = '';
    jsConsole.writeLine(countElements(tagName) + ' ' + tagName + ' elements in the current page.');
}

function countElements(tag) {
    return document.getElementsByTagName(tag).length;
}