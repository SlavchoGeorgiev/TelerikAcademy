function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = this,
                regex,
                key,
                i,
                len = data.length,
                $container = $('[data-template]'),
                template = $('[id="' + $container.attr('data-template') + '"]').html(),
                buffer = '';


            if (template.indexOf('{{/each}}') > -1) {
                var indexOfEachBegin = template.indexOf('{{#each ');
                var indexOfEachEnd = template.indexOf('{{/each}}') + 9;
                var beforeEach = template.substring(0, indexOfEachBegin);
                var afterEach = template.substring(indexOfEachEnd, template.length);
                var colectionName = template.substring(indexOfEachBegin + 8, template.indexOf('}}', indexOfEachBegin));
                var inEachContent = template.substring(template.indexOf('}}', indexOfEachBegin) + 2, indexOfEachEnd - 9);
            }

            for (i = 0; i < len; i += 1) {
                var currentElement = template;

                regex = new RegExp('{{this}}', 'g');

                if (colectionName) {
                    var colectionFragment = '';

                    for(key in data[i][colectionName]) {
                        colectionFragment += inEachContent.replace(regex, data[i][colectionName][key])
                    }

                    currentElement = beforeEach + colectionFragment + afterEach;
                }

                currentElement = currentElement.replace(regex, i);

                for (key in data[i]) {
                    regex = new RegExp('{{' + key + '}}', 'g');
                    currentElement = currentElement.replace(regex, data[i][key]);
                }

                buffer += currentElement;
            }

            $container.html(buffer);
            $('[id="' + $container.attr('data-template') + '"]').remove();
        };
    };
}

module.exports = solve;