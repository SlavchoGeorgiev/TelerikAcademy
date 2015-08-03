/* globals $ */

/*
 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
 Change the content of all .button elements with "hide"
 When a .button is clicked:
 Find the topmost .content element, that is before another .button and:
 If the .content is visible:
 Hide the .content
 Change the content of the .button to "show"
 If the .content is hidden:
 Show the .content
 Change the content of the .button to "hide"
 If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
 The provided DOM element is non-existant
 The id is either not a string or does not select any DOM element
 */

function solve() {
    var solve = function solve(selector) {
        var selectedElement,
            buttons;

        if (typeof(selector) === 'string') {
            selectedElement = document.getElementById(selector);
            if (selectedElement === null) {
                throw new Error(selector + 'do not select element.')
            }
        } else if (selector instanceof HTMLElement) {
            selectedElement = selector;
        } else {
            throw new Error();
        }

        buttons = document.getElementsByClassName('button');
        Array.prototype.forEach.call(buttons, function (btn) {
            btn.innerHTML = 'hide';
        });

        selectedElement.addEventListener('click', function (ev) {
            var theButton = ev.target,
                content = topMostContentBeforeButton(theButton);

            if (content != null && content.style.display === '' && ev.target.innerHTML === 'hide') {
                content.style.display = 'none';
                theButton.innerHTML = 'show';
            } else if (content != null && content.style.display === 'none' && ev.target.innerHTML === 'show') {
                content.style.display = '';
                theButton.innerHTML = 'hide';
            }

        }, false);

        function topMostContentBeforeButton(button) {
            var content = button.nextElementSibling;

            while (content) {
                if (content.className.indexOf('content') >= 0) {
                    return content;
                }

                content = content.nextElementSibling;
            }

            return null;
        }
    };

    return solve;
}

module.exports = solve;