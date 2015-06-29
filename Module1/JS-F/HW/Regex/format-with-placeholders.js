String.prototype.format = function(options) {
    var formattedStr = this
        ,option;
    for (option in options ) {
        var placeHolder = new RegExp('#{' + option + '}');
        formattedStr = formattedStr.replace(placeHolder, options[option]);
    }
    return formattedStr;
};

console.log('Hello, there! Are you #{name}?'.format({name: 'John'}));
console.log('My name is #{name} and I am #{age}-years-old'.format({name: 'John', age: 13}));