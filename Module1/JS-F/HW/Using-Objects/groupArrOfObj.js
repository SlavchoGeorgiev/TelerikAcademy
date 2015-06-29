var people = [
    {firstname: 'Gosho', lastname: 'Petrov', age: 32},
    {firstname: 'Bay', lastname: 'Ivan', age: 81},
    {firstname: 'Ivan', lastname: 'Hristov', age: 18},
    {firstname: 'Gosho', lastname: 'Hristov', age: 32},
    {firstname: 'Bay', lastname: 'Petrov', age: 81},
    {firstname: 'Ivan', lastname: 'Ivan', age: 18},
    {firstname: 'Slavcho', lastname: 'Petrov', age: 41}];


function groupArrayOfObjects(obj, prop) {
    var result = [],
        key;
    for (key in obj) {
        if (!result.hasOwnProperty(obj[key][prop])){
            result[obj[key][prop]] = [];
            result[obj[key][prop]].push(obj[key]);
        }
        else {
            result[obj[key][prop]].push(obj[key]);
        }
    }

    return result;
}

function printGroupedArray(array) {
    var key,
        index,
        prop;
    for (key in array) {
        console.log('===== Group by value: ' + key + ' =====');
        for (index in array[key]){
            for (prop in array[key][index]) {
                console.log(prop + ': ' + array[key][index][prop]);
            }
        }
    }
}

printGroupedArray(groupArrayOfObjects(people, 'firstname'));
printGroupedArray(groupArrayOfObjects(people, 'age'));