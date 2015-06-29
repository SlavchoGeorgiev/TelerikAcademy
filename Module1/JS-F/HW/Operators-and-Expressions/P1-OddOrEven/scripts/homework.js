document.getElementById('input').onkeydown = function(e){if(e.keyCode === 13) {onExecuteClick()}};

function onExecuteClick() {
    var number = jsConsole.readInteger('#input');
    jsConsole.writeLine(number % 2 === 0 ? number +  ' is Even' : number + ' is Odd');
}

jsConsole.writeLine('Please enter integer number:');