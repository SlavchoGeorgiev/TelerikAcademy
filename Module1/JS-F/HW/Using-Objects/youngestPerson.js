//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.


function youngesPerson(hora) {
    var index,
        length,
        humanWithMinAge = hora[0];

    for (index = 1, length = hora.length; index < length; index += 1) {
        if (hora[index].age < humanWithMinAge.age) {
            humanWithMinAge = hora[index];
        }
    }

    console.log(humanWithMinAge.firstname + ' ' + humanWithMinAge.lastname + ' is ' + humanWithMinAge.age + ' old he is the youngest person in this group.');
};

var people = [
    {firstname: 'Gosho', lastname: 'Petrov', age: 32},
    {firstname: 'Bay', lastname: 'Ivan', age: 81},
    {firstname: 'Ivan', lastname: 'Hristov', age: 18},
    {firstname: 'Slavcho', lastname: 'Petrov', age: 41}];

youngesPerson(people);
