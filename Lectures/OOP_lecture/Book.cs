namespace OOP_lecture
{
    public class Book
    {  
        // INSTANCE Variable: the variable for each object Book
        private string title;
        private string author;
        private int pages;
        private string genre;

        // CLASS Variable (static): 1 Variable for the ENTIRE class
        static private int count;
        
        // no-arg constructor
        public Book() {

        }
        // arg constructor
        public Book(string title, string author, int pages, string genre){
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.genre = genre;
        }

        // Settors & Gettors:
        public void SetTitle(string title){
            this.title = title;
        }

        public string GetTitle(){
            return title;
        }

        public void SetAuthor(string author){
            this.author = author;
        }

        public string GetAuthor(){
            return author;
        }

        public void SetPages(int pages){
            this.pages = pages;
        }

        public int GetPages(){
            return pages;
        }

        public void SetGenre(string genre){
            this.genre = genre;
        }

        public string GetGenre(){
            return genre;
        }

        static public void SetCount(int count){
            Book.count = count; // refer to the count var for the Book class
        }

        // increase count by 1
        static public void IncCount(){
            Book.count++;
        }

        static public int GetCount(){
            return Book.count;
        }

        // represent the object with a string
        public override string ToString(){
            return $"{this.title} written by {this.author} has {this.pages} and is listed as genre {this.genre}.";
        }

        // what to print in file
        public string ToFile(){
            return $"{this.title}#{this.author}#{this.pages}#{this.genre}";
        }
    }

}