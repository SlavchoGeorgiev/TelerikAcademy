/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];

		function listBooks(filter) {
            var bookList = [];

            if (arguments.length === 0) {
                return books.slice();
            }

            if(filter.category && filter.author) {
                books.forEach(function (currBook) {
                    if(currBook.category === filter.category && currBook.author === filter.author) {
                        bookList.push(currBook);
                    }
                });

                return bookList;
            }
            else {
                if(filter.category) {
                    books.forEach(function (currBook) {
                        if(currBook.category === filter.category) {
                            bookList.push(currBook);
                        }
                    });

                    return bookList;
                }

                if(filter.author) {
                    books.forEach(function(currBook) {
                        if(currBook.author === filter.author) {
                            bookList.push((currBook));
                        }
                    });

                    return bookList;
                }
            }
		}

		function addBook(book) {

            validateBook(book);

			book.ID = books.length + 1;
			books.push(book);
            if (categories.indexOf(book.category) < 0){
                addNewCategory(book.category);
            }
			return book;
		}

		function listCategories() {
			return categories;
		}

        function addNewCategory(category) {
            categories.push(category);
        }

        function validateBook(book) {

            if(book.title.length > 100 || book.title.length < 2) {
                throw new Error('Book title must be between 2 and 100 characters, including letters, digits and special characters!');
            }

            if(book.category.length > 100 || book.category.length < 2 ) {
                throw new Error('Category name must be between 2 and 100 characters, including letters, digits and special characters!');
            }

            if (book.author === '' || typeof(book.author) !== "string") {
                throw new Error('Author must be non-empty string');
            }

            if (!isValidISBN(book.isbn)) {
                throw new Error('Book ISBN is  code that contains either 10 or 13 digits');
            }

            if (!isUniqueBook(book)) {
                throw new Error('Book title and Book ISBN must be unique!');
            }
        }

        function isValidISBN(isbn) {
            if(isNaN(isbn * 1)) {
                return false;
            }

            if(isbn.toString().length !== 10 &&  isbn.toString().length !== 13){
                return false;
            }

            return true;
        }

        function isUniqueBook(book) {
            var isUnique = true;

            books.forEach(function(currBook) {
                if(currBook.title === book.title || currBook.isbn == book.isbn) {
                    isUnique = false;
                }
            });

            return isUnique;
        }

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());

	return library;
}
module.exports = solve;
