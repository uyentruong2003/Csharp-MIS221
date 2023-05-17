namespace OOP_lecture
{
    public class BookReport
    {
        Book[] books;

        public BookReport(Book[] books){
            this.books = books;
        }

        public void PrintAllBooks(){
            for (int i = 0; i < Book.GetCount(); i++){
                System.Console.WriteLine(books[i].ToString());
            }
        }

        public void PagesByGenre(){
            string curr = books[0].GetGenre(); //prime read
            int count = books[0].GetPages(); //prime read

            for(int i =1; i < Book.GetCount(); i++){
                if(books[i].GetGenre() == curr){
                    count+=books[i].GetPages();
                } else{
                    ProcessBreak(ref curr, ref count, books[i]);
                }
            }
            ProcessBreak(ref curr, ref count);

        }

        private void ProcessBreak(ref string curr, ref int count, Book newBook){
            // Print the current group name (in this example, genre), and the count:
            System.Console.WriteLine($"{curr}\t{count}");

            // reset the curr and count (update read)
            curr = newBook.GetGenre();
            count = newBook.GetPages();
        }

        private void ProcessBreak(ref string curr, ref int count){
            System.Console.WriteLine($"{curr}\t{count}");
        }

    }   
}