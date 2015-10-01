/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName`, `lastName` and `age` properties
 *   **finds** the students whose age is between 18 and 24
 *   **prints**  the fullname of found students, sorted lexicographically ascending
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

//var _ = require('underscore');

function solve() {
    return function (students) {
        var result = _.chain(students)
            .filter(function (student) {
                return 18 <= student.age && student.age <= 24;
            })
            .sortBy(function (student) {
                return student.firstName + ' ' + student.lastName
            })
            .each(function (student) {
                console.log(student.firstName + ' ' + student.lastName)
            })
            .value();

        return result;
    };
}
//
//var students = [{
//    firstName: 'NAME #3',
//    lastName: 'NAME #2',
//    age: 35
//}, {
//    firstName: 'NAME #4',
//    lastName: 'NAME #1',
//    age: 11
//}, {
//    firstName: 'OAME #4',
//    lastName: 'NAME #7',
//    age: -5
//}];
//
//var test = solve();
//test(students);

module.exports = solve;
