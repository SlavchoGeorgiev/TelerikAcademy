//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

function clone(obj) {
    if (obj === null || typeof(obj) !== 'object' || 'isActiveClone' in obj)
        return obj;

    var temp = obj.constructor(); // changed

    for (var key in obj) {
        if (Object.prototype.hasOwnProperty.call(obj, key)) {
            obj['isActiveClone'] = null;
            temp[key] = clone(obj[key]);
            delete obj['isActiveClone'];
        }
    }

    return temp;
}

var person = {
        name: 'pesho',
        age: 20,
        grades: {
            math: 3,
            js: 6
        }
    },
    cloning,
    number = 5,
    newNumber;

cloning = clone(person);
newNumber = clone(number);

person = 'deleted';
number = 'deleted';

console.log('Cloned person: ' + cloning);
console.log('Person: ' + person);

console.log('Cloned number: ' + newNumber);
console.log('Number: ' + number);