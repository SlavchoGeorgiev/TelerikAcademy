/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {
        var domElement = {};
        // init: function (type) {},
        // appendChild: function (child) {},
        // addAttribute: function (name, value) {},
        // get innerHTML() {
        //
        // }

        Object.defineProperty(domElement, 'init', {
            value: function (type) {
                this.type = type;
                this.attributes = [];
                this.children = [];
                return this;
            }
        });

        Object.defineProperties(domElement, {
            type: {
                get: function () {
                    return this._type;
                },
                set: function (value) {
                    if (typeof(value) === 'undefined') {
                        throw new Error('Type is undefined');
                    }

                    if (!(typeof(value) === 'string')) {
                        throw new Error('Type must be string.');
                    }

                    if (!/^[A-z]+[A-z, 0-9]*$/.test(value)) {
                        throw new Error('Type must be any non-empty string that contains only Latin letters and digits.');
                    }

                    this._type = value;
                }
            },
            appendChild: {
                value: function (child) {
                    child.parent = this;
                    this.children.push(child);
                    return this;
                }
            },
            addAttribute: {
                value: function (name, value) {
                    var searchedAttribute = searchByAttributeName.call(this, name);

                    if (!/^[A-z]+[A-z,-]+$/.test(name)) {
                        throw new Error('Invalid attribute name.');
                    }

                    if (searchedAttribute.isExist) {
                        this.attributes[searchedAttribute.index].value = value;
                    } else {
                        this.attributes.push({name: name, value: value});
                    }

                    return this;
                }
            },
            removeAttribute: {
                value: function (attribute) {
                    //remove attribute
                    var searchedAttribute = searchByAttributeName.call(this, attribute);

                    if (!searchedAttribute.isExist) {
                        throw new Error('Attribute' + attribute + 'dosn\'t exist.');
                    }

                    this.attributes.splice(searchedAttribute.index, 1);
                    return this;
                }
            },
            innerHTML: {
                get: function () {
                    return getInnerHTML.call(this);
                }
            },
            content: {
                get: function () {
                    if (this.children.length !== 0) {
                        return '';
                    }
                    else {
                        return this._content || '';
                    }
                },
                set: function (value) {
                    if (this.children.length > 0){
                        //throw new Error('Element has a children(s) content can\'t be set.');
                    } else {
                        this._content = value;
                    }
                }
            }
        });

        function getInnerHTML() {
            var inHTML = '',
                att = this.attributes.sort(function (a, b) {
                    if (a.name > b.name) {
                        return 1;
                    }
                    else if (a.name < b.name) {
                        return -1;
                    } else {
                        return 0;
                    }
                }),
                key;

            inHTML = '<' + this.type;

            for (key in att) {
                inHTML += ' ' + att[key].name + '="' + att[key].value + '"';
            }

            inHTML += '>';

            if (this.children.length === 0){
                inHTML += this.content;
            } else {
                this.children.forEach(function (child) {
                    if (typeof(child) === 'string'){
                        inHTML += child;
                        return;
                    }

                    inHTML += child.innerHTML;
                });
            }

            inHTML += '</' + this.type + '>';
            return inHTML;
        }

        function searchByAttributeName(name) {
            var searchedAttribute = {index: 0, isExist: false};
            this.attributes.forEach(function (att, index) {
                if (att.name == name) {
                    searchedAttribute.index = index;
                    searchedAttribute.isExist = true;
                }
            });

            return searchedAttribute;
        }

        return domElement;
    }());

    return domElement;
}

module.exports = solve;

var domElement = solve();

var meta = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
    .init('head')
    .appendChild(meta);

var div = Object.create(domElement)
    .init('div')
    .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
    .init('body')
    .appendChild(div)
    .addAttribute('id', 'myid')
    .addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
    .init('html')
    .appendChild(head)
    .appendChild(body);

console.log(root.innerHTML);