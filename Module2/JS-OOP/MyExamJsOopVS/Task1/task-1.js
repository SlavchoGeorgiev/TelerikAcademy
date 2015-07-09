function solve() {
    var module = (function () {
        var item,
            book,
            media,
            catalog,
            bookCatalog,
            mediaCatalog,
            validator = {
                validateIfDefined: function(value, name) {
                    name = name || 'Value';
                    if (typeof value == 'undefined') {
                        throw new Error(name + ' is undefined');
                    }
                },
                validateIfString: function (value, name) {
                    name = name || 'Value';
                    if (!(typeof value == 'string')) {
                        throw new Error(name + ' is not a string');
                    }
                },
                validateNonEmptyString: function (str, name) {
                    name = name || 'Value';
                    this.validateIfDefined(str, name);
                    this.validateIfString(str, name);

                    if (str.length <= 0) {
                        throw new Error(name + ' is empty string');
                    }
                },
                validateTextLength: function(str, minLength, maxLength, name) {
                    name = name || 'Value';
                    this.validateIfDefined(str);
                    this.validateIfString(str);

                    if (str.length < minLength || str.length > maxLength) {
                        throw new Error(name + ' is out of range');
                    }
                },
                validateIsbn: function(str, name) {
                    name = name || 'Isbn';

                    if (str.length !== 10 && str.length !== 13) {
                        throw new Error(name + ' with invalid length');
                    }

                    if(!/^[0-9]+$/g.test(str)) {
                        throw new Error(name + ' can contain only digits');
                    }
                },
                validateIfNumber: function(value, name) {
                    name = name || 'Value';

                    if(typeof value != 'number') {
                        throw new Error(name + ' is not a number');
                    }
                },
                validateNumberInRange: function (num, minValue, maxValue, name) {
                    name = name || 'Number';
                    this.validateIfNumber(num, name);

                    if (num < minValue || num > maxValue) {
                        throw new Error(name + 'is out of range');
                    }
                }
            };

        item = (function () {
            var item,
                lastId = 0;

            item = Object.create({});

            Object.defineProperty(item, 'init', {
                value: function (description, name) {
                    this.description = description;
                    this.name = name;
                    lastId += 1;
                    this._id = lastId;
                    this.isItem = true;

                    return this;
                }
            });

            Object.defineProperty(item, 'description', {
                get: function () {
                    return this._description;
                },
                set: function (value) {
                    validator.validateNonEmptyString(value, 'Item description');
                    this._description = value;
                }
            });

            Object.defineProperty(item, 'name', {
                get: function () {
                    return this._name;
                    },
                set: function (value) {
                    validator.validateTextLength(value, 2, 40, 'Item name');
                    this._name = value;
                }
            });

            Object.defineProperty(item, 'id', {
                get: function () {
                    return this._id;
                }
            });

            return item;
        }());

        book = (function (parent) {
            var book;

            book = Object.create(parent);

            Object.defineProperty(book, 'init', {
                value: function (name, isbn, genre, description) {
                    parent.init.call(this, description, name);
                    this.isbn = isbn;
                    this.genre = genre;
                    this.isBook = true;

                    return this;
                }
            });

            Object.defineProperty(book, 'isbn', {
                get: function () {
                    return this._isbn;
                },
                set: function (value) {
                    validator.validateIfDefined(value, 'Book isbn');
                    validator.validateIfString(value, 'Book isbn');
                    validator.validateIsbn(value);

                    this._isbn = value;
                }
            });

            Object.defineProperty(book, 'genre', {
                get: function () {
                    return this._genre;
                },
                set: function(value) {
                    validator.validateTextLength(value, 2, 20, 'Book genre');

                    this._genre = value;
                }
            });

            return book;
        }(item));

        media = (function (parent) {
            var media;

            media = Object.create(parent);

            Object.defineProperty(media, 'init', {
                value: function (name, rating, duration, description) {
                    parent.init.call(this, description, name);
                    this.rating = rating;
                    this.duration = duration;
                    this.isMedia = true;

                    return this;
                }
            });

            Object.defineProperty(media, 'duration', {
                get: function() {
                    return this._duration;
                },
                set: function (value) {
                    validator.validateIfNumber(value, 'Duration');

                    if (value <= 0) {
                        throw new Error('Duration must be greater than zero');
                    }

                    this._duration = value;
                }
            });

            Object.defineProperty(media, 'rating', {
                get: function () {
                    return this._rating;
                },
                set: function (value) {
                    validator.validateNumberInRange(value, 1, 5, 'Media rating');

                    this._rating = value;
                }
            });

            return media;
        }(item));

        catalog = (function () {
            var catalog,
                lastId = 0;

            catalog = Object.create({});

            Object.defineProperty(catalog, 'init', {
                value: function (name) {
                    validator.validateTextLength(name, 2, 40, 'Catalog name');
                    this.name = name;
                    this.items = [];
                    lastId += 1;
                    this._id = lastId;

                    return this;
                }
            });

            Object.defineProperty(catalog, 'add', {
                value: function(item) {
                    var input,
                        self = this;

                    if (arguments.length == 0) {
                        throw new Error('No items are passed');
                    }

                    if(item instanceof Array) {
                        input = item;
                    } else {
                        input = Array.prototype.slice.call(arguments);
                    }

                    if (input.length == 0) {
                        throw  new Error('Invalid argument(s)');
                    }

                    input.forEach(function (item) {
                        if (!item.isItem) {
                            throw new Error('Invalid item');
                        }
                    });

                    input.forEach(function (item) {
                        self.items.push(item);
                    });

                    return this;
                }
            });

            Object.defineProperty(catalog, 'find', {
                value: function(input) {
                    var id,
                        index;

                    if (arguments.length == 0) {
                        throw new Error('No items are passed in method find');
                    }

                    if (input.id && input.name) {
                        return this.items
                            .slice()
                            .filter(function(item) {
                                if (item.id == input.id && item.name == input.name) {
                                    return true;
                                }

                                return false;
                            });

                    } else if (input.id) {
                        return this.items
                            .slice()
                            .filter(function(item) {
                                if (item.id == input.id) {
                                    return true;
                                }
                                return false;
                            });

                    } else if (input.name) {
                        return this.items
                            .slice()
                            .filter(function(item) {
                                if (item.name == input.name) {
                                    return true;
                                }
                                return false;
                            });
                    } else if(typeof input == 'number') {
                        id = input;
                        index = indexOfItemInItemsById(this.items, id);

                        if (index < 0) {
                            return null;
                        }

                        return this.items[index];
                    }
                    else {
                        throw  new Error('Id is not a number');
                    }
                }
            });

            Object.defineProperty(catalog, 'search', {
                value: function(pattern) {
                    validator.validateNonEmptyString(pattern, 'Pattern');

                    return this.items
                        .slice()
                        .filter(function (item) {
                            if (item.name.toLowerCase().indexOf(pattern.toLowerCase()) >= 0 ||
                                item.description.toLowerCase().indexOf(pattern.toLowerCase()) >= 0) {
                                return true;
                            }

                            return false;
                        });
                }
            });

            function indexOfItemInItemsById(items, id) {
                var i, len;
                for (i = 0, len = items.length; i < len; i += 1) {
                    if(items[i].id == id){
                        return i;
                    }
                }

                return -1;
            }

            return catalog;
        }());

        bookCatalog = (function (parent) {
            var bookCatalog;

            bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog, 'init', {
                value: function(name) {
                    parent.init.call(this, name);

                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'add', {
                value: function (input) {
                    if (input instanceof Array) {
                        input.forEach(function (item) {
                            if (!item.isBook) {
                                throw new Error(item + ' is not a book')
                            }
                        });

                        parent.add.call(this, input);
                    }
                    else {
                        Array.prototype.slice.call(arguments)
                            .forEach(function (item) {
                                if (!item.isBook) {
                                    throw new Error(item + ' is not a book')
                                }
                            });

                        parent.add.call(this, Array.prototype.slice.call(arguments));
                    }

                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'getGenres', {
                value: function() {
                    var result = [];
                    this.items
                        .slice()
                        .forEach(function (book) {
                            if (result.indexOf(book.genre.toLowerCase() < 0)) {
                                result.push(book.genre.toLowerCase());
                            }
                        });

                    return result;
                }
            });

            Object.defineProperty(bookCatalog, 'find', {
                value: function(options) {
                    if (options.id && options.name && options.genre) {
                        return this.items
                            .slice()
                            .filter(function(item) {
                                if (item.id == options.id &&
                                    item.name == options.name &&
                                    item.genre == options.genre) {

                                    return true;
                                }
                                return false;
                            });

                    } else {
                        return parent.find.call(this, options);
                    }
                }
            });

            return bookCatalog;
        }(catalog));

        mediaCatalog = (function (parent) {
            var mediaCatalog;

            mediaCatalog = Object.create(parent);

            Object.defineProperty(mediaCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name);

                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'add', {
                value: function (input) {
                    if (input instanceof Array) {
                        input.forEach(function (item) {
                            if (!item.isMedia) {
                                throw new Error(item + ' is not a media')
                            }
                        });

                        parent.add.call(this, input);
                    }
                    else {
                        Array.prototype.slice.call(arguments)
                            .forEach(function (item) {
                                if (!item.isMedia) {
                                    throw new Error(item + ' is not a media')
                                }
                            });

                        parent.add.call(this, Array.prototype.slice.call(arguments));
                    }

                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'getTop', {
                value: function (count) {
                    validator.validateIfNumber(count, 'Count');

                    if (count < 1) {
                        throw new Error('Count must be greater than one');
                    }

                    return this.items
                        .slice()
                        .sort(function (first, second) {
                            if (first.duration < second.duration) {
                                return -1
                            } else if (first.duration > second.duration) {
                                return 1
                            }
                            return 0;
                        })
                        .splice(0, count)
                        .map(function (media) {
                            return {id: media.id, name: media.name};
                        });
                }
            });

            Object.defineProperty(mediaCatalog, 'getSortedByDuration', {
                value: function () {
                    return this.items.slice()
                        .sort(function (first, second) {
                            if (first.duration < second.duration) {
                                return 1;
                            }
                            if (first.duration > second.duration) {
                                return -1;
                            }
                            if (first.id < second.id) {
                                return -1;
                            }
                            if (first.id > second.id) {
                                return 1;
                            }

                            return 0;
                        });
                }
            });

            return mediaCatalog;
        }(catalog));

        return {
            getBook: function (name, isbn, genre, description) {
                //return a book instance
                return Object.create(book).init(name, isbn, genre, description)
            },
            getMedia: function (name, rating, duration, description) {
                //return a media instance
                return Object.create(media).init(name, rating, duration, description);
            },
            getBookCatalog: function (name) {
                //return a book catalog instance
                return Object.create(bookCatalog).init(name);
            },
            getMediaCatalog: function (name) {
                //return a media catalog instance
                return Object.create(mediaCatalog).init(name);
            }
        };
    }());

    return module;
}
//some tests
var module = solve();



var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');
//console.log(catalog);
var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);
//console.log(catalog);
//console.log(catalog.find(book1.id));
//returns book1

//console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

//console.log(catalog.search('js'));
// returns book2

//console.log(catalog.search('javascript'));
//returns book1 and book2

//console.log(catalog.search('Te sa zeleni'));
//returns []
