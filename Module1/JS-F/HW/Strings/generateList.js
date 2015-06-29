//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.

function listGenerator (people, template){
    var list = '<ul>',
        listInner;

    people.forEach(function(human) {
        var prop,
            regex;

        listInner = template;
        for(prop in human) {
            regex = new RegExp('-\{' + prop + '\}-', 'g');

            listInner = listInner.replace(regex, human[prop]);
        }
        list = list + '<li>' + listInner + '<\/li>'
    });

    list = list + '<\/ul>';
    return list;
}

var people = [
    {name: 'Peter', age: 14},
    {name: 'Ivan', age: 20},
    {name: 'Gosho', age: 18},
    {name: 'Hristo', age: 26},
    {name: 'Mariyka', age: 13}],
    tmpl = '<strong>-{name}-<\/strong> <span>-{age}-<\/span>',
    laptops = [
        {brand: 'HP', cpu: 'E5-2650', hdd: '500 GB'},
        {brand: 'Lenovo', cpu: 'i7-4790k', hdd: '1000 GB'},
        {brand: 'Dell', cpu: 'G3258', hdd: '500 GB'},
        {brand: 'Sony', cpu: 'i3_4030U', hdd: '2000 GB'}

    ],
    ltmpl = '<strong>-{brand}-<\/strong><span>-{cpu}-<\/span>-{hdd}-';

console.log(listGenerator(people, tmpl));
console.log(listGenerator(laptops, ltmpl));