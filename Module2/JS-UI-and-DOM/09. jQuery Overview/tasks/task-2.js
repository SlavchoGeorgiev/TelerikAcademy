/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string`

*/
function solve() {
   return function (selector) {
       var $selectedElement;

       if (typeof selector != 'string' && !(selector instanceof jQuery)) {
           throw new Error('The provided '+ selector + ' is not a **jQuery object** or a `string`');
       }

       if (typeof selector == 'string') {
           $selectedElement = $(selector);
       } else {
           $selectedElement = selector;
       }

       if($selectedElement.length < 1) {
           throw new Error(selector + ' do not select node.');
       }

       $('.button').text('hide');

       $selectedElement.on('click', '.button', function (button) {
           var $theButton = $(this);


           if($theButton.text() == 'hide') {
               $theButton
                   .text('show')
                   .nextAll('.content')
                   .first()
                   .css('display', 'none');
           } else {
               $theButton
                   .text('hide')
                   .nextAll('.content')
                   .first()
                   .css('display', '');
           }
       });
   };
}

module.exports = solve;