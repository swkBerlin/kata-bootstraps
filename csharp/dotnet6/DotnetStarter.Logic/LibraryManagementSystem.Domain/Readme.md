https://workat.tech/machine-coding/practice/design-library-management-system-jgjrv8q8b136

**rules**
 - library composed of racks
 - rack composed of books. one rack can have at most one copy of a book
 
 
**state**
 - book has title, author, rack number, publisher
 - each copy has unique id
 - each rach has unique no. from 1 to n
 - user has id and name
 - can borrow max of 5 books at a time

**behaviour**
 - Create a library.
 - Add a book to the library. The book should be added to the first available rack.
 - Remove a book copy from the library.
 - Allow a user to borrow a book copy given the book id, user id, and due date. The first available copy based on the rack number should be provided.
 - Allow a user to borrow a book copy given the book copy id, user id, and due date.
 - Allow a user to return a book copy given the book copy id. The book should be added to the first available rack.
 - Allow a user to print the book copy ids of all the books borrowed by them.
 - Allow a user to search for books using few book properties (Book ID, Title, Author, Publisher). Searching should return details about all the book copies that match the search query.

**design**

entities
 - Book
  - static Dictionary<int, Book> Books
  - static GetBook(int bookId)
  - id
  - title
  - List<author>
  - List<publisher>
  - Book(title, author, publisher)
  - List<Book> SearchBooks(attribute, value)

 - BookCopy
  - static Dictionary<string, BookCopy> BookCopies
  - static GetBookCopy(string id)
  - string id
  - int bookId
  - string borrowedBy
  - Date dueDate
  - BookCopy(id, bookId)
  - bool IsCopyOfBook(Book)

 - Rack
  - number
  - Dictionary<string, BookCopy>
  - Rack()
  - List<BookCopy> GetCopiesOfBook(Book)
  - bool TryAddBookCopy(BookCopy)
  - bool TryRemoveBookCopy(BookCopy)
  - bool HasACopyOfBook(Book)
  - bool HasBookCopy(BookCopy)

 - Library
  - List<Rack>
  - Library()
  - AddBook(title, author, publisher, List<BookCopy>)
  - RemoveBookCopy(BookCopy)
  - BorrowBook(Book, User, dueDate)
  - BorrowBookCopy(BookCopy, User, dueDate)
  - ReturnBookCopy(BookCopy, User)
  - List<(BookCopy, Date)> GetBorrowedBooks(User)
  - List<BookCopy> SearchBooks(attribute, value)

 - User
  - static Dictionary<int, User> Users
  - static GetUser(int userId)
  - id
  - name
  - MaxBorrowBookCount
  - List<(BookCopy, Date)>
  - User(id, name, maxBorrowBookCount = 5)
  - bool CanBorrow()
  - void BorrowBook(BookCopy, Date)
  - void ReturnBookCopy(BookCopy)

 
API
 - createLibrary(rack count)
 - addBook(title, author, publisher, List<BookCopy>)
 - removeBookCopy(bookCopyId)
 - borrowBook(bookId, userId, dueDate)
 - borrowBookCopy(bookCopyId, userId, dueDate)
 - returnBookCopy(bookCopyId)
 - printBorrowedBooks(userId)
 - searchBooks(attribute, value)
