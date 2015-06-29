document.getElementById('input').onkeydown = function(e){if(e.keyCode === 13) {onExecuteClick()}};
jsConsole.writeLine('Please enter integer number:');

function onExecuteClick() {

    var input = jsConsole.read('#input');
    input = parseInt(input);
    jsConsole.writeLine(input % 5 === 0 && input % 7 === 0 ? input + ' can be divided (without remainder) by 7 and 5 in the same time.'
                                                : input + ' can\'t be divided (without remainder) by 7 and 5 in the same time.');
    jsConsole.writeLine('Please enter integer number:');
}