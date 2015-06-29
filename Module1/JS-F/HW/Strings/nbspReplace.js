//Write a function that replaces non breaking white-spaces in a text with &nbsp;

var text = 'Write a&nbspfunction&nbspthat&nbspreplaces non breaking&nbsp&nbspwhite-spaces in a&nbsptext with&nbsp.';

String.prototype.replaceNbsp = function () {
    return this.replace(/&nbsp/g, ' ');
}

console.log(text.replaceNbsp());