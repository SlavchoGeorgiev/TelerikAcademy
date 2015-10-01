/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **groups** the animals by `species`
    *   the groups are sorted by `species` descending
*   **sorts** them ascending by `legsCount`
	*	if two animals have the same number of legs sort them by name
*   **prints** them to the console in the format:

```
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    GROUP_1_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in group 1
    NAME has LEGS_COUNT legs //for the second animal in group 1
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    GROUP_2_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in the group 2
    NAME has LEGS_COUNT legs //for the second animal in the group 2
    NAME has LEGS_COUNT legs //for the third animal in the group 2
    NAME has LEGS_COUNT legs //for the fourth animal in the group 2
```
*   **Use underscore.js for all operations**
*/

//var _ = require('underscore');

function solve(){
  return function (animals) {
        var grouped = _.chain(animals)
            .groupBy(function (animal) {
                return animal.species;
            })
            .sortBy(function(group, key) {
                return key;
            })
            .reverse()
            .map(function (group) {
                return _.chain(group)
                    .sortBy(function (animal) {
                        return animal.name;
                    })
                    .sortBy(function (animal) {
                        return animal.legsCount * 1;
                    })
                    .value();
            })
            .each(function (groupe) {
                var separator = [];
                separator.length = groupe[0].species.length + 2;
                //separator[groupe[0].species.length] = undefined;
                separator = separator.join('-');

                console.log(separator);
                console.log(groupe[0].species + ':');
                console.log(separator);

                _.each(groupe, function (animal) {
                    console.log(animal.name + ' has ' + animal.legsCount + ' legs');
                })
            })
            .value();
  };
}

//var animals = [{
//    name: 'Minkov',
//    species: 'Mosquito',
//    legsCount: 2
//}, {
//    name: 'Doncho',
//    species: 'Mosquito',
//    legsCount: 2
//}, {
//    name: 'Komara',
//    species: 'Mosquito',
//    legsCount: 4
//}];
//
//var test = solve();
//test(animals);

module.exports = solve;
