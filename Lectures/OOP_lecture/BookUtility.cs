namespace OOP_lecture
{
    public class BookUtility
    {
       private Book[] books; // an array of object Book 

    // with-arg constructor:
       public BookUtility(Book[] books){
            this.books = books;
       }

        // Method to get user input for books:
        public void GetAllBooks(){
            //prime read
            Book.SetCount(0); // instead of int count = 0
            System.Console.WriteLine("Please enter the book title or STOP to stop: ");
            string userInput = Console.ReadLine();

            while (userInput.ToUpper()!= "STOP"){
                books[Book.GetCount()] = new Book(); // instead of books[count]
                books[Book.GetCount()].SetTitle(userInput);
                System.Console.WriteLine("Please enter the author: ");
                books[Book.GetCount()].SetAuthor(Console.ReadLine());
                System.Console.WriteLine("Please enter the # of pages: ");
                books[Book.GetCount()].SetPages(int.Parse(Console.ReadLine()));
                // update read
                Book.IncCount(); // instead of count++
                System.Console.WriteLine("Please enter the book title or STOP to stop: ");
                userInput = Console.ReadLine();
            }
        }

        public void GetAllBooksFromFile(){
            //open file
            StreamReader inFile = new StreamReader("input.txt");
            
            //process file
            
            // prime read
            Book.SetCount(0);
            string line = inFile.ReadLine();

            while(line != null){
                // Separate by delimiter '#' to an array of title, author, and pages
                string[] temp = line.Split('#');
                // Pass the title, author, and pages into the constructor
                books[Book.GetCount()] = new Book(temp[0], temp[1], int.Parse(temp[2]),temp[3]);
                // update read
                Book.IncCount();
                line = inFile.ReadLine();
            }


            //close file
            inFile.Close();
        }

        public void AddBook(){
            System.Console.WriteLine("Please enter the title: ");
            Book myBook = new Book ();
            myBook.SetTitle(Console.ReadLine());
            System.Console.WriteLine("Please enter the author: ");
            myBook.SetAuthor(Console.ReadLine());
            System.Console.WriteLine("Please enter the # of pages: ");
            myBook.SetPages(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the genre: ");
            myBook.SetGenre(Console.ReadLine());

            // Add to the book list:
            books[Book.GetCount()] = myBook;
            Book.IncCount();

            // Save newly added book to file:
            Save();
        }

        private void Save(){
            //open file
            StreamWriter outFile = new StreamWriter ("input.txt");

            // process file
            // add all the books in the array to the file:
            for (int i = 0; i< Book.GetCount(); i++){
                outFile.WriteLine(books[i].ToFile());

            }
            // close file
            outFile.Close();
        }

        public void UpdateBook(){
            System.Console.WriteLine("What is the title of the book you want to update?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);
            if(foundIndex != -1){
                // Update the book's info:
                System.Console.WriteLine("Please enter the title: ");
                books[foundIndex].SetTitle(Console.ReadLine());
                System.Console.WriteLine("Please enter the author: ");
                books[foundIndex].SetAuthor(Console.ReadLine());
                System.Console.WriteLine("Please enter the # of pages: ");
                books[foundIndex].SetPages(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the genre: ");
                books[foundIndex].SetGenre(Console.ReadLine());

                Save();

            } else{
                System.Console.WriteLine($"There's no book named {searchVal}");
            }
        }
        private int Find(string searchVal) {
            for(int i = 0; i < Book.GetCount(); i++){
                if (books[i].GetTitle().ToUpper() == searchVal.ToUpper()){
                    return i;
                }
            }

            return -1;
        }

            // Selection sort --> needed for control break
            public void Sort(){
                for (int i = 0; i < Book.GetCount()-1; i ++){
                    int min = i;
                    for(int j = i+1; i< Book.GetCount(); j++){
                        // Sort by Genre, then Sort by Pages:
                        if (books[j].GetGenre().CompareTo(books[min].GetGenre()) < 0 || (books[j].GetGenre()==books[min].GetGenre() && books[j].GetPages()<books[min].GetPages())){
                            min = j;
                        }
                    }
                    if (min != i){
                        Swap(min,i);
                    }
                }
        }

        private void Swap (int x, int y){
            Book temp = books[x];
            books[x] = books[y];
            books[y] = temp;
        }
    }

}