//Write a function for creating persons.
//    Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders

var persons = [];

persons.push(new Person('Ivaylo', 'Ivanchev', 18, false));
persons.push(new Person('Nikolay', 'Petrov', 21, false));
persons.push(new Person('Georgi', 'Ivanov', 25, false));
persons.push(new Person('Avgust', 'Jliev', 30, false));


function Person(firstname, lastname, age, gender) {
    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
    this.gender = gender;
}

Person.prototype.toString = function () {
    return this.firstname + ' ' + this.lastname + ' is ' + this.age + ' years old, and ' + (this.gender ? ' she is female.' : ' he is male.');
};


//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)

function isAllAtLegalAge(humans) {
    return humans.every(function (human) {
        return human.age >= 18
    });
}

console.log('Is all persons adult: ' + isAllAtLegalAge(persons));
persons.push(new Person('Hristina', 'Petrova', 17, true));
console.log('Is all persons adult: ' + isAllAtLegalAge(persons));

//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)

function printUnderage(peoples) {
    peoples.filter(
        function (human) {
            return human.age < 18;
        })
        .forEach(function (human) {
            console.log(human.toString());
        })
}

printUnderage(persons);
persons.push(new Person('Bobi', 'Iliev', 16, false));
console.log('Add new person!');
printUnderage(persons);

//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

function averageAgeOfFemales(peoples) {
    var count = 0,
        sumOfAge = 0;

    peoples.filter(function (human) {
        return human.gender;
    })
        .forEach(function (girl) {
            count += 1;
            sumOfAge += girl.age;
        });

    return sumOfAge / count;
}

console.log('Average age of all females is: ' + averageAgeOfFemales(persons));
persons.push(new Person('Emiliq', 'Vasileva', 24, true));
console.log('Add new girl 24 years old!');
console.log('Average age of all females is: ' + averageAgeOfFemales(persons));

//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)


function youngestMale(peoples) {
    return peoples.filter(function (person) {
        return !person.gender;
    })
        .sort(function (p1, p2) {return p2 - p1;})[0]
        .toString();
}

console.log('The youngest male person: ' + youngestMale(persons).match(/(.+)\,/)[1] + '.');

//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)

persons.push(new Person('Nadq', 'Petrova', 21, true));
persons.push(new Person('Nataliq', 'Petrova', 25, true));
persons.push(new Person('Angel', 'Iliev', 30, false));

function groupByFirstNameLetter (peoples) {
    return peoples.reduce(function(grouped, person, index){
        var firstLetter,
            temp;

        if (index === 1) {
            firstLetter = grouped.firstname[0].toLowerCase();
            temp = {
                firstname: grouped.firstname,
                lastname: grouped.lastname,
                age: grouped.age,
                gender: grouped.gender
            };
            grouped = {};
            grouped[firstLetter] = [];
            grouped[firstLetter].push(temp);
        }

        firstLetter = person.firstname[0].toLowerCase();

        if(grouped[firstLetter]){
            grouped[firstLetter].push(person);
        }
        else {
            grouped[firstLetter] = [];
            grouped[firstLetter].push(person);
        }

        return grouped;
    });
}

console.log(groupByFirstNameLetter(persons));