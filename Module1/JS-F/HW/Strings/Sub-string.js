//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

var text = 'The text is as follows: We are livIng in an yellow submarine. ' +
    'We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. ' +
    'We will move out of it in 5 days.';

String.prototype.subStringCounter = function (searchString) {
    var position = 0,
        counter = 0;

    searchString = searchString.toLowerCase();

    while (this.indexOf(searchString, position) >= 0) {
        counter += 1;
        position = this.toLowerCase().indexOf(searchString, position) + 1;
    }

    return counter;
};

console.log(text.subStringCounter('in'));
console.log(text.subStringCounter('we'));