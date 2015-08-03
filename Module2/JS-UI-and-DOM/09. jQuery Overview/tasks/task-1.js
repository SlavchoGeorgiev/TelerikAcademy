/* globals $ */

/* 

 Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
 */

function solve() {
    var solve = function solve(selector, count) {
        var i,
            $root = $(selector),
            $ul = $('<ul />')
                .addClass('items-list'),
            $li = $('<li />')
                .addClass('list-item')
                .text('List item #');

        if(typeof selector != 'string') {
            throw new Error(selector, 'is not valid selector');
        }

        if ($root.length < 0) {
            return;
        }

        if (isNaN(count)) {
            throw new Error(count + ' is not a number.');
        } else if (count < 1) {
            throw new Error(count + ' must be greater than 1.');
        }

        for (i = 0; i < count; i += 1) {
            $li.clone().text($li.text() + i).appendTo($ul);
        }

        $root.append($ul);
    };

    return solve;
}

module.exports = solve;