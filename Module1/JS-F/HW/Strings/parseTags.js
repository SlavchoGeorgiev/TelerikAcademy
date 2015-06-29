//You are given a text. Write a function that changes the text in all regions:
//
//  <upcase>text</upcase> to uppercase.
//  <lowcase>text</lowcase> to lowercase
//  <mixcase>text</mixcase> to mix casing(random)


var textExample1 = 'We are <mixcase>living<\/mixcase> in a <upcase>yellow submarine<\/upcase>. We <mixcase>don\'t<\/mixcase> have <lowcase>anything<\/lowcase> else.',
    textExample2 = 'We are <mixcase>living<\/mixcase> in a <lowcase><upcase>yellow<\/upcase> submarine<\/lowcase>. We <mixcase>don\'t<\/mixcase> have <lowcase>anything<\/lowcase> else.';

String.prototype.parseTags = function () {
    var text = String(this);

    text = text.replace(/<upcase>([^<>]+)<\/upcase>/gi, function (match, p1) {
        return p1.toUpperCase();
    });

    text = text.replace(/<lowcase>([^<>]+)<\/lowcase>/gi, function (match, p1) {
        return p1.toLowerCase();
    });

    text = text.replace(/<mixcase>([^<>]+)<\/mixcase>/gi, function (match, p1) {
        var i,
            len,
            result = [];

        for (i = 0, len = p1.length; i < len; i += 1) {
            if (Math.random() > 0.5) {
                result.push(p1[i].toUpperCase());
            }
            else {
                result.push(p1[i].toLowerCase());
            }
        }

        return result.join('');
    });

    if (text.search(/[<>]/gi) !== -1){
        text = text.parseTags();
    }

    return text;
};

console.log(textExample1.parseTags());
console.log(textExample2.parseTags());