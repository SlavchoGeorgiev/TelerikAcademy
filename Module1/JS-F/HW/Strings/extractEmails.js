//Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.

function extractEmailsInArr (str) {
    var regexForEmails = /[\w\d]*@[\w\d.]+/gi;
    return str.match(regexForEmails);
}

var text = 'Aenean turpis elit, aliquam ivancho_1@abv.bg nec tincidunt vitae, dictum pesho_1@gmail.com eu justo. Fusce vulputate placerat imperdiet. Cras aliquet sapien vitae pharetra condimentum. Aliquam id lacus vel ante facilisis mattis.',
    emails;

emails = extractEmailsInArr(text);
console.log(emails);

