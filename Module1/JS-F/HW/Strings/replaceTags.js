//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]

function replaceAnchorTag(str) {
    inputStr = String(str);

    return inputStr.replace(/(<a\s+href=")([\w\/\.\/:]*)(">)([\w\s]*)(<\/a>)/g, function (match, anchorOpen, link, lessThen, content, anchorClose){
        return '[URL=' + link + ']' + content + '[\/URL]'
    })
}

var input = '<p>Please visit <a href="http:\/\/academy.telerik.com">our site<\/a> to choose a training course. Also visit <a href="www.devbg.org">our forum<\/a> to discuss the courses.<\/p>',
    output = replaceAnchorTag(input);

console.log(output);
