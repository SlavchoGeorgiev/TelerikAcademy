var height,
    width,
    sides = [];
jsConsole.writeLine('Problem 3. Rectangle area');
jsConsole.writeLine('Write an expression that calculates rectangle’s area by given width and height.');
jsConsole.writeLine();
jsConsole.write('Please enter rectangle height: ');
document.getElementById('input').onkeydown = function(e){if(e.keyCode === 13) {onExecuteClick()}};

function onExecuteClick() {
    var input = document.getElementById('input');
    if (sides.length === 0) {
        sides.push(jsConsole.read('#input'));
        input.value = '';
        jsConsole.writeLine(sides[0]);
        jsConsole.write('Please enter rectangle width: ');
    } else if (sides.length === 1) {
        sides.push(jsConsole.read('#input'));
        input.value = '';
        jsConsole.writeLine(sides[1]);
        width = sides.pop();
        height = sides.pop();
        jsConsole.writeLine('Area = ' + width * height);
        jsConsole.writeLine('');
        jsConsole.write('Please enter rectangle height: ');
    } else {
        jsConsole.writeLine('Error :(');
    }
}