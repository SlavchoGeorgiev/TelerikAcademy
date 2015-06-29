//Write a function that extracts the content of a html page given as text.
//The function should return anything that is in a tag, without the tags.

var exampleText = '<html>' +
    '<head>' +
    '<title>Sample site<\/title>' +
    '<\/head>' +
    '<body>' +
    '<div>text' +
    '<div>more text<\/div>' +
    'and more...' +
    '<\/div>' +
    'in body' +
    '<\/body>' +
    '<\/html>';
String.prototype.htmlExtractText = function () {
    return this.replace(/<\/?\w+>/g, '');
};
console.log(exampleText);
console.log(exampleText.htmlExtractText());