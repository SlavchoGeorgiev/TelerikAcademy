/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    "use strict"
    var Course = {
            init: function (title, presentations) {
                this.title = title;
                this.presentations = presentations;
                this.listOfStudents = [];
                this.lastStudentId = 0;
                this.listOfSubmitedHomeworks = {};

                return this;
            },
            addStudent: function (name) {
                var student = Object.create(Student)
                    .init(name, this.getNextStudentId());

                this.lastStudentId = this.getNextStudentId();
                this.listOfStudents.push(student);

                return this.lastStudentId;
            },
            getAllStudents: function () {
                return this.listOfStudents.slice();
            },
            submitHomework: function (studentID, homeworkID) {
                if (homeworkID > this.presentations.length || homeworkID < 1) {
                    throw new Error('Invalid homework ID');
                }

                if (this.findStudentById(studentID) < 0) {
                    throw new Error('Invalid student ID');
                }

                if (!this.listOfSubmitedHomeworks[studentID]) {
                    this.listOfSubmitedHomeworks[studentID] = [];
                }

                if (this.listOfSubmitedHomeworks[studentID].indexOf(homeworkID) < 0) {
                    this.listOfSubmitedHomeworks[studentID].push(homeworkID);
                }

                return this;
            },
            pushExamResults: function (results) {
                var self = this;
                results.forEach(function (result) {
                    var i, len, occurrenceCount = 0;

                    if (self.findStudentById(result.StudentID) < 0) {
                        throw new Error('Student with ID: ' + result.StudentID + ' don\'t exist.');
                    }

                    for (i = 0, len = results.length; i < len; i += 1) {
                        if (results[i].StudentID == result.StudentID) {
                            occurrenceCount += 1;
                        }
                    }

                    if (occurrenceCount > 1) {
                        throw new Error('StudentID: ' + result.StudentID + ' is given more than once');
                    }

                    if (typeof(result.score) !== 'number') {
                        throw new Error('score is not a number');
                    }
                });

                this.examResults = results;

                return this;
            },
            getTopStudents: function () {
                var i,
                    len,
                    key,
                    result = [],
                    currentStudent,
                    currentStudentIndex,
                    currentStudentId,
                    examWeight = 0.75,
                    homeworkWeight = 0.25,
                    copyOfListOfStudent = this.listOfStudents.slice();

                for (key in copyOfListOfStudent) {
                    copyOfListOfStudent[key].finalSore = 0;
                }

                // Add exam score to final score;
                for (key in this.examResults) {
                    currentStudentId = this.examResults[key].StudentID;
                    currentStudentIndex = this.findStudentById(currentStudentId);
                    currentStudent = copyOfListOfStudent[currentStudentIndex];
                    currentStudent.finalSore += examWeight * this.examResults[key].score;
                }

                // Add homework score to final score;
                for (currentStudentId in this.listOfSubmitedHomeworks) {
                    currentStudentIndex = this.findStudentById(currentStudentId);
                    currentStudent = copyOfListOfStudent[currentStudentIndex];
                    currentStudent.finalSore += homeworkWeight * (this.listOfSubmitedHomeworks[currentStudentId].length / this.presentations.length) * 100;
                }

                //Sort student by final score
                copyOfListOfStudent = copyOfListOfStudent.sort(function (a, b) {
                    return b.finalSore - a.finalSore;
                });

                if (copyOfListOfStudent.length < 10) {
                    len = copyOfListOfStudent.length;
                }
                else {
                    len = 10;
                }

                for (i = 0; i < len; i += 1) {
                    result.push(copyOfListOfStudent[i]);
                }

                return result;
            },
            getNextStudentId: function () {
                return this.lastStudentId + 1;
            },
            findStudentById: function (id) {
                var index;
                for (index in this.listOfStudents) {
                    if (this.listOfStudents[index].id == id) {
                        return index | 0;
                    }
                }

                return -1;
            }
        },
        Student = {
            init: function (name, id) {
                var splicedName;

                splicedName = validateStudentName(name);
                this.firstname = splicedName[0];
                this.lastname = splicedName[1];
                this.id = id;

                return this;
            }
        };

    Object.defineProperties(Course, {
        title: {
            get: function () {
                return this._title;
            },
            set: function (value) {
                validateCourseTitle(value);
                this._title = value;
            }
        },
        presentations: {
            get: function () {
                return this._presentations;
            },
            set: function (value) {
                validatePresentations(value);

                this._presentations = value;
            }
        }
    });

    function validateCourseTitle(title) {
        if (typeof(title) !== 'string') {
            throw new Error('Title must be string');
        }

        if (/^\s.*|.*\s$/.test(title)) {
            throw new Error('Title start or end with spaces.');
        }

        if (/.*\s{2,}.*/.test(title)) {
            throw new Error('Title have consecutive spaces');
        }

        if (title.length === 0) {
            throw new Error('Title must have at least one character');
        }
    }

    function validatePresentations(presentations) {
        if (!(presentations instanceof Array)) {
            throw new Error('Presentations must be array');
        }

        if (presentations.length === 0) {
            throw new Error('Course must have at least one presentation.');
        }

        presentations.forEach(function (title) {
            validateCourseTitle(title);
        });
    }

    function validateStudentName(name) {
        var splicedName;
        if (typeof(name) !== 'string') {
            throw new Error('Student name must be string');
        }

        splicedName = name.split(' ');

        if (splicedName.length !== 2) {
            throw new Error('Student name must contain first ana last name separated by single space.');
        }

        splicedName.forEach(function (name) {
            if (!/^[A-Z][a-z]*$/.test(name)) {
                throw new Error('Names must start with an upper case letter and all other symbols in the name (if any) are lowercase letters');
            }
        });

        return splicedName;
    }

    return Course;
}


module.exports = solve;

//Test Data
var Course = solve();

var myCourse = Object.create(Course)
    .init('OOP', ['First', 'Second']);

myCourse.addStudent('Ivaylo Ivanov');
myCourse.addStudent('Hrist Ivanov');
myCourse.addStudent('Hohn John');
myCourse.addStudent('Jhon Don');
myCourse.addStudent('Hrisi Beova');
myCourse.addStudent('Iv Zarkova');
myCourse.addStudent('Mariq Ob');
myCourse.addStudent('Bon Don');
myCourse.addStudent('Baj Van');
//myCourse.addStudent('Baj Van');
//myCourse.addStudent('Baj Van');
//myCourse.addStudent('Baj Van');
//myCourse.addStudent('Baj Van');
//myCourse.addStudent('Baj Van');

//console.log(myCourse.getAllStudents());

myCourse.submitHomework(1, 1)
    .submitHomework(1, 2)
    .submitHomework(1, 2)
    .submitHomework(2, 1)
    .submitHomework(3, 2)
    .submitHomework(6, 1)
    .submitHomework(6, 2);

//console.log(myCourse.listOfSubmitedHomeworks);

myCourse.pushExamResults([
    {StudentID: 1, score: 80},
    {StudentID: 2, score: 50},
    {StudentID: 3, score: 10},
    {StudentID: 5, score: 70},
    {StudentID: 6, score: 100},
    {StudentID: 7, score: 36}
]);

//console.log(myCourse.examResults);

console.log(myCourse.getTopStudents());

