/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */


var result = function () {
    var solve = function solve(element, contents) {
        var clonedDiv,
            domElement,
            isCorrectContent = false;
            dFrag = document.createDocumentFragment(),
            div = document.createElement('div');

        if (typeof(element) === 'string') {
            domElement = document.getElementById(element);
        } else if (/*!!element.tagName*/ element instanceof HTMLElement) {
            domElement = element;
        } else {
            throw new Error(element + 'is not DOM element or valid ID name!');
        }

        isCorrectContent = Array.prototype.every.call(contents, function(content) {
            return typeof(content) === 'string' || typeof(content) === 'number';
        });

        if (!isCorrectContent) {
            throw new Error('Contents contains not valid element/s');
        }


        for (i = 0, len = contents.length; i < len; i += 1) {
            clonedDiv = div.cloneNode(true);
            clonedDiv.innerHTML = contents[i];
            dFrag.appendChild(clonedDiv);
        }

        domElement.innerHTML = '';
        domElement.appendChild(dFrag);
    };

    return solve;
};

module.exports = result;