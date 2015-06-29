function onExecuteClick() {
    jsConsole.writeLine(new Array(80).join('-'));
    jsConsole.writeLine(textCreate());
}

function textCreate() {
    var text = 'Lorem ipsum "dolor" sit amet, \'consectetur\' adipiscing elit. Maecenas vestibulum "ligula" aliquet \'\'ipsum\'\' feugiat convallis. Curabitur dictum elementum libero quis iaculis.';
    return text;
}

jsConsole.writeLine(textCreate());