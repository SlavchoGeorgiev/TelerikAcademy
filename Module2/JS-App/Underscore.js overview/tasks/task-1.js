/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName` and `lastName` properties
 *   **Finds** all students whose `firstName` is before their `lastName` alphabetically
 *   Then **sorts** them in descending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   Then **prints** the fullname of founded students to the console
 *   **Use underscore.js for all operations**
 */

//var _ = require('underscore');

function solve() {
    var result = function (students) {
        var result = _.chain(students)
            .filter(function (student) {
                return student.firstName < student.lastName;
            })
            .sortBy(function (student) {
                return student.firstName + ' ' + student.lastName;
            })
            .value()
            .reverse();

        _.each(result, function (student) {
            console.log(student.firstName + ' ' + student.lastName);
        });
    };

    return result;
}

//var students = [{
//    firstName: 'NAME #3',
//    lastName: 'NAME #2'
//}, {
//    firstName: 'NAME #4',
//    lastName: 'NAME #1'
//}, {
//    firstName: 'OAME #4',
//    lastName: 'NAME #7'
//}];
//
//
//var test = solve();
//test(students);

module.exports = solve;