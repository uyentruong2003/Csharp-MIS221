
using OOP_lecture;
// // Book.cs is a model class
// // BookUtility.cs modify the Book object
// // BookReport.cs publish final version of the object Book object

// // INITIATE THE CLASS with a w-arg/ no-arg constructor:
// // use the no-arg constructor- create the object requires Settors
// Book myBook = new Book ();
// myBook.SetTitle("Mistborn");
// myBook.SetAuthor("Brandon Sanderson");
// myBook.SetPages(800);
// System.Console.WriteLine(myBook.ToString());

// // use the with-arg constructor- NOT require Settors
// Book yourBook = new Book ("Financial Feminists", "Tori Dunlap", 300);
// System.Console.WriteLine(yourBook.ToString());

Console.Clear();
// create an array of Book objects
Book[] books = new Book[50];

// initiate the class BookUtility:
BookUtility utility = new BookUtility(books);

// initiate the class BookReport:
BookReport report = new BookReport(books);

// Get existed books from file:
utility.GetAllBooksFromFile();
 
// Print books on screen:
System.Console.WriteLine();
report.PrintAllBooks();

// System.Console.WriteLine("Let's add a book!");
// utility.AddBook();
// report.PrintAllBooks();

// utility.UpdateBook();

utility.Sort();

report.PrintAllBooks();