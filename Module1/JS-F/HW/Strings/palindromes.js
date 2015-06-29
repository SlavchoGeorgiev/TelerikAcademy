//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

function findPalindromes(str) {
    var arrOfWords = str.split(/[\W"]/g),
        palindromes = [];

    arrOfWords.filter(function (item) {
        return item === ' ' || item.length > 1;
    })
        .forEach(function (chechedWord) {
            if(isWordPalindrome(chechedWord)){
                palindromes.push(chechedWord);
            }
        });

    function isWordPalindrome(word) {
        var i, len, realLength = word.length;
        for (i = 0, len = (word.length / 2) | 0; i < len; i += 1) {
            if(word[i] !== word[realLength - 1 - i]){
                return false;
            }
        }

        return true;
    }

    return palindromes;
}

var text = 'Write a program that extracts from a given text all palindromes, e.g. "ABBA", lamal, exe.';

console.log(findPalindromes(text));