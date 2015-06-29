String.prototype.bind = function (str, objectToBind) {
    var prop,
        index,
        len,
        thisString = this,
        bindAttributes = thisString.match(/data-bind-\w+="\w+"/g),
        classesAndAttributes = [];

    for (index in bindAttributes) {
        var attributeToBind,
            valueBind;
        attributeToBind = bindAttributes[index].match(/-\w+=/g)
            .join('');
        attributeToBind = attributeToBind.substring(1, attributeToBind.length - 1);
        valueBind = bindAttributes[index].match(/("\w*")/g)
            .join('')
            .replace(/"/g, '');
        classesAndAttributes.push({attribute: attributeToBind, value: valueBind});
    }

    for (prop in objectToBind) {
        for (index = 0, len = classesAndAttributes.length; index < len; index += 1) {
            if (prop === classesAndAttributes[index].value){
                classesAndAttributes[index].value = objectToBind[prop];
            }
        }
    }

    for (index = 0, len = classesAndAttributes.length; index < len; index += 1) {
        if (classesAndAttributes[index].attribute === 'content') {
            thisString = thisString.insertAtPosition(classesAndAttributes[index].value , thisString.indexOf('>') + 1)
        }
        else {
            thisString = thisString.insertAtPosition(' ' + classesAndAttributes[index].attribute + '="' + classesAndAttributes[index].value + '"' , thisString.indexOf('>'));
        }
    }

    return thisString;
};

String.prototype.insertAtPosition = function (stringToInsert, position) {
  return this.substring(0, position) + stringToInsert + this.substring(position);
};

console.log('Input: str = \'<div data-bind-content="name"></div>\';');
console.log('str.bind(str, {name: \'Steven\'});');
console.log('output: ' + '<div data-bind-content="name"></div>'.bind('', {name: 'Steven'}));
console.log();
console.log('Input: str = \'<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>\';');
console.log('str.bind(str, {name: \'Elena\', link: \'http://telerikacademy.com\'});');
console.log('output: ' + '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>'.bind('', {name: 'Elena', link: 'http://telerikacademy.com'}));
