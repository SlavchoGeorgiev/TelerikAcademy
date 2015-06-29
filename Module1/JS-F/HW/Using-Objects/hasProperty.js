//Write a function that checks if a given object contains a given property.

function hasProperty(object, propertyName) {
    return Object.prototype.hasOwnProperty.call(object, propertyName);
}

var person = {
    name: 'Pesho',
    age: 25
};

console.log('hasProperty(person, \'name\') : ' + hasProperty(person, 'name'));
console.log('hasProperty(person, \'hair\') : ' + hasProperty(person, 'hair'));