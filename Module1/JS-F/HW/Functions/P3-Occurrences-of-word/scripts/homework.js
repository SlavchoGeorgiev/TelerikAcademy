var input = document.getElementById('input'),
    inputText = undefined,
    searchWord = undefined;

input.focus();

input.onkeydown = function (e) {
    if (e.keyCode === 13) {
        executeOnEvent();
    }
};

jsConsole.writeLine('Write a function that finds all the occurrences of word in a text.');
jsConsole.writeLine('The search can be case sensitive or case insensitive.');
jsConsole.writeLine('Use function overloading.');
jsConsole.writeLine('Please enter text: ');

function executeOnEvent() {
    if (inputText === undefined) {
        inputText = jsConsole.read('#input');
        input.value = '';
        jsConsole.writeLine(inputText);
        jsConsole.write('Please enter search word: ');
    }
    else if (searchWord === undefined) {
        searchWord = jsConsole.read('#input');
        input.value = '';
        jsConsole.writeLine(searchWord);
        jsConsole.writeLine('Case sensitive search occurrences : ' + searchWordOccurs(inputText, searchWord));
        jsConsole.writeLine('Case insensitive search occurrences : ' + searchWordOccurs(inputText, searchWord, true));
        jsConsole.writeLine('Please enter text: ');
        inputText = undefined;
        searchWord = undefined;
    }
}

function searchWordOccurs(inputText, searchWord, ci) {
    var count = 0,
        key;
    ci = ci || false;
    inputText = inputText.replace(/[,.:;!?]/g, '').split(' ');
    if (ci) {
        for (key in inputText) {
            if (inputText[key].toLowerCase() === searchWord.toLowerCase()) {
                count += 1;
            }
        }
    }
    else {
        for (key in inputText) {
            if (inputText[key] === searchWord) {
                count += 1;
            }
        }
    }

    return count;

}