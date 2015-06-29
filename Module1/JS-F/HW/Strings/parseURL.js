/*
 Write a script that parses an URL address given in the format:
 [protocol]://[server]/[resource] and extracts from 
 it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.*/

String.prototype.parseURL = function () {
    var string = String(this),
        url = {
            protocol: undefined,
            server: undefined,
            resource: undefined
        },
        regExUrlParse = /(\w{3,10}):\/\/([A-z.]+)\/(.+)/g,
        parsedArr = regExUrlParse.exec(string);

    url.protocol = parsedArr[1];
    url.server = parsedArr[2];
    url.resource = parsedArr[3];

    return url;
};

var urlAsStr = 'http:\/\/telerikacademy.com\/Courses\/Courses\/Details\/239';

console.log(urlAsStr.parseURL());