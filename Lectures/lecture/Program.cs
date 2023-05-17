// // Chapter 3: Modules------------------------------------------------------------------------------------------------------
// // Mon, 01.31.2023

// // Start main here
// string userName = GetUser();
// SayHello(userName);
// int userAge = GetAge();
// if (CanDrive(userAge)){
//     System.Console.WriteLine("You can drive!");
// }

// string firstCharacter = "A";
// string secondCharacter = "b";
// System.Console.WriteLine("");
// System.Console.WriteLine(firstCharacter + " " + secondCharacter);
// // Swap without reference:
// System.Console.WriteLine("");
// Swap(firstCharacter,secondCharacter);
// System.Console.WriteLine("Out of swap: "+firstCharacter + " " + secondCharacter);
// // Swap with reference:
// System.Console.WriteLine("");
// SwapRef(ref firstCharacter, ref secondCharacter);
// System.Console.WriteLine("Out of swap ref: "+ firstCharacter + " " + secondCharacter);


// // End main here

// // Function to get user's name:
// static string GetUser() {
//     System.Console.WriteLine("Please enter your name: ");
//     return Console.ReadLine();
// }


// // Function to say hello:
// static void SayHello(string userName) {
//     System.Console.WriteLine("Hello "+ userName);
// }

// // Function to swap 2 characters:
// static void Swap( string x, string y) {
//     string temp = x;
//     x=y;
//     y=temp;
//     System.Console.WriteLine("in the swap: ");
//     System.Console.WriteLine(x + " " + y);
// }

// // Function to swap 2 characters with ref:
// static void SwapRef( ref string x, ref string y) {
//     string temp = x;
//     x=y;
//     y=temp;
//     System.Console.WriteLine("in the swap ref: ");
//     System.Console.WriteLine(x + " " + y);
// }

// // Function to get user's age:
// static int GetAge() {
//     System.Console.WriteLine("Please enter your age: ");
//     return int.Parse(Console.ReadLine());
// }

// // Function to test can drive:
// static bool CanDrive(int age) {
//     if (age >= 16) {
//         return true;
//     }else {
//         return false;
//     }
    
// }

// // Wed, 02/01/2023

// // start main
// string studentName = GetUser();
// int studentGrade = GetGrade();
// string letterGrade = ConvertGrade(studentGrade);
// System.Console.WriteLine($"Your letter grade is: {letterGrade}");
// DisplayMessage(letterGrade,studentName);

// // end main

// // start method GetGrade:
// static int GetGrade(){
//     System.Console.WriteLine("Enter your grade: ");
//     return int.Parse(Console.ReadLine());
// }
// // end method GetGrade

// // Function to get user's name:
// static string GetUser() {
//     System.Console.WriteLine("Please enter your name: ");
//     return Console.ReadLine();
// }
// // method ConvertGrade:
// static string ConvertGrade(int grade){
//     if (grade >= 90) return "A";
//     if (grade >= 80) return "B";
//     if (grade >= 70) return "C";
//     return "DNP";
// }
// // end method ConvertGrade

// // method DisplayMessage:
// static void DisplayMessage(string letterGrade, string name){
//     // Switch...case...break used for discrete choices
//     switch (letterGrade){
//         case "A":
//             System.Console.WriteLine($"Excellent job, {name}!");
//             break;
//         case "B":
//             System.Console.WriteLine($"Good job, {name}!");
//             break;
//         case "C":
//             System.Console.WriteLine($"Keep working hard, {name}!");
//             break;
//         default:
//             System.Console.WriteLine($"Better luck next time, {name}!");
//             break;
//     }
// }


// -----------ARRAY--------------------------------------------------------------------------------------------
// // Mon, 02/06/2023

// // start main
// int userChoice = GetUserChoice();
// // while is a PRE-TEST LOOP
// while(userChoice != 3){
//     RouteEm (userChoice);
//     userChoice = GetUserChoice();
// }

// // Use do{} while for POST-TEST LOOP
// // do{
// //     RouteEm (userChoice);
// //     userChoice = GetUserChoice();
// // } while(userChoice != 3);

// // end main

// // methods:
// static int GetUserChoice(){
//     DisplayMenu();
//     string userChoice = Console.ReadLine();
//     if (IsValidChoice(userChoice)){
//         return int.Parse(userChoice);
//     } else {
//         return 0;
//     } 
// }

// static void DisplayMenu(){
//     System.Console.WriteLine("Enter 1 to say hello\nEnter 2 to say howdy\nEnter 3 to exit");
// }

// static bool IsValidChoice(string userInput){
//     if (userInput == "1" || userInput == "2" || userInput == "3"){
//         return true;
//     } else{ 
//         return false;
//     }
// }

// static void SayHello(){
//     System.Console.WriteLine("Hello!");
//     PauseAction();
// }

// static void SayHowdy(){
//     System.Console.WriteLine("Howdy");
//     PauseAction();
// }

// static void SayInvalid(){
//     System.Console.WriteLine("Invalid input!");
//     PauseAction();
// }

// static void RouteEm(int menuChoice){
//     if (menuChoice == 1){
//         SayHello();
//     }else if(menuChoice == 2){
//         SayHowdy();
//     }else if (menuChoice != 3){
//         SayInvalid(); 
//     }
// }

// static void PauseAction(){
//     System.Console.WriteLine("Press any key to continue: ");
//     Console.ReadKey();
// }

// // Wed, 02/08/2023

// // start
// double sum = 0;
// int count = 0;
// double min = 200;
// double max = -2;
// double grade = EnterGrade(); // update read
// while(grade !=-1){ // condition check
//     if (grade < min){
//         min = grade;
//     } 
//     if (grade > max){
//         max = grade;
//     }
//     sum += grade;
//     count++;
//     grade= EnterGrade(); // update read

// }
// double avg = sum/count;
// double range = max -min;
// System.Console.WriteLine("Average: " + avg);
// System.Console.WriteLine("Range: "+ range);
// // EnterGrade():
// static double EnterGrade(){
//     System.Console.WriteLine("Please enter grade: ");
//     return double.Parse(Console.ReadLine());
// }

// // Mon, 02/13/2023

// //start main
// CountBackward(); // Count backwards from 10 to 1 then say blast off
// CountEven(); // Count only even number
// CountOdd(); // Count only odd number
// Timer(); // Time count from 00:00 to 10:59
// RandomTime();
// //end main

// // method

// static void CountBackward(){
//     // pre-ttest loop
//     for(int i=10; i>0; i--){
//         System.Console.WriteLine(i);
//     }
//     System.Console.WriteLine("Blast off!");
// }

// static void CountEven(){
//     // pre-ttest loop
//     for(int i=0; i<=10; i = i+2){
//         System.Console.WriteLine(i);
//     }
// }

// static void CountOdd(){
//     for (int i=0; i <=10; i++){
//         if (i%2 != 0){
//             System.Console.WriteLine(i);
//         }
//     }
// }

// static void Timer(){
//     // loop for minute:
//         for (int min = 0; min <= 10; min ++){
//             for (int sec = 0; sec <= 59; sec ++){
//                 if (sec > 9) System.Console.WriteLine($"{min}:{sec}");
//                 else System.Console.WriteLine($"{min}:0{sec}");
//             }
//         }
// }

// static void RandomTime(){
//     Random rand = new Random();
//     int hours = rand.Next(1,13);
//     int minutes = rand.Next(60);
//     if (minutes > 9) System.Console.WriteLine($"{hours}:{minutes}");
//     else System.Console.WriteLine($"{hours}:0{minutes}");
// }


// Wednesday, 02/15/2023
//-----------------------ARRAYS------------------------------------------

// start main

// arrays start at 0
// all items in an array must be the same data type
// string[] books = {"Mistborn", "Oatbringer", "Harry Potter: Goblet of Fire", "Kite Runner"};
// string [] books = new string[100]; // enter the most number of items that the array will possibly have
// string[] books = new string [100];
// string [] authors = new string [100];
// int count = GetBooks(books, authors);
// PrintBooks(books, authors, count);

// // end main

// // user enter book titles until user enters "STOP" = then print all book titles


// static int GetBooks (string[] myBooks, string[] myAuthors){
//     System.Console.WriteLine("Please enter book title: ");
//     string userInput = Console.ReadLine();
//     int count = 0;
//     while(userInput.ToLower() != "stop") {
//         System.Console.WriteLine("Who is the author?");
//         myAuthors[count] = Console.ReadLine();
//         myBooks[count] = userInput;
//         count++;

//         System.Console.WriteLine("Please enter book title: ");
//         userInput = Console.ReadLine();
//     }
//     return count;

// }

// static void PrintBooks (string[] myBooks, string[] myAuthors, int count){
//     for (int i = 0; i < 4; i++){
//     System.Console.WriteLine($"{myBooks[i]} \t{myAuthors[i]}");
//     }
// }

// Monday, 2.20.2023

// string myString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// string myString2 = new string("abcdefg"); // the same function as the prev line
// myString = ChangeVowels(myString);
// System.Console.WriteLine(myString);
// static string ChangeVowels(string myString){
//     char [] myArray = myString.ToCharArray();
//     for (int i = 0; i < myArray.Length; i++){
//         if (myArray[i] == 'A'){
//             myArray[i] = '*';
//         }
//     }
//     return new String(myArray); //create a brand new string and return it to the string
// }

// // start main
// const int MAX_BOOKS = 50;
// string [] books = new String [MAX_BOOKS];
// string [] authors = new String [MAX_BOOKS];
// int counts = GetAllBooks(books, authors);
// PrintBooks(books, authors, counts);
// System.Console.WriteLine("What book you wanna find?");
// string searchVal = Console.ReadLine();
// int foundIndex = FindBook (books, searchVal, counts);
// if (foundIndex != -1){
//     System.Console.WriteLine($"Your book was found at position: {foundIndex}");
//     System.Console.WriteLine("What should the title be?");
//     books[foundIndex] = Console.ReadLine();
//     System.Console.WriteLine();
//     System.Console.WriteLine("What should the author be?");
//     authors [foundIndex] = Console.ReadLine();
// } else {
//     System.Console.WriteLine("Yor book was not found.");
// }

// // end start

// static int GetAllBooks(string[] books, string[] authors) {
//     int counts = 0;
//     System.Console.WriteLine("Enter the book tittle. Enter STOP to stop.");
//     string userInput = Console.ReadLine(); // priming read
//     while (userInput.ToUpper() != "STOP"){
//         books [counts] = userInput;
//         System.Console.WriteLine("Please enter the author: ");
//         authors[counts] = Console.ReadLine();
//         counts ++;
//         System.Console.WriteLine("Enter the book tittle. Enter STOP to stop.");
//         userInput = Console.ReadLine(); // update read
//     }
    
//     return counts;
// }

// static void PrintBooks (string[] books, string[] authors, int count){
//     for (int i = 0; i < count; i++) {
//         System.Console.WriteLine(books[i] + "\t"+ authors[i]);
//     }
// }

// // sequential search:
// static int FindBook(string[] books, string searchVal, int count) {
//     for (int i = 0; i < count; i++){
//         if (books[i] == searchVal) return i;
//     }
//     return -1;
// }

// // Selection sort:
// static void Sort (string[] books, string[] authors, int[] pages,int count){
//     for (int i =0; i < count -1; i++){
//         int min = i;
//         for (int j = i + 1; j < count; j++) {
//             if (books[min].CompareTo(books[j]) > 0) {
//                 min = j;
//             }
//         }
//         if (min != i) {
//             Swap (books, min, i);
//             Swap (authors, min, i);
            
//         }
//     }
// }

// static void Swap(string [] myArray, int x, int y){
//     string temp = myArray [x];
//     myArray [x] = myArray [y];
//     myArray [y] = temp;
// }

// // method signature: combo of method type, name, and set parameters. If the name is the same but the signature is not, it's okay.

// // binary search:
// static int BinarySearch (string[] myBooks, int count, string searchVal){
//     int last = count;
//     int first = 0;
//     int foundIndex = -1;
//     bool found = false;
//     while(!found && last >= first){
//         int middle = (last + first)/2;
//         if (myBooks[middle].CompareTo(searchVal) == 0){
//             foundIndex = middle;
//              found = true;
//         }else if (myBooks[middle].CompareTo(searchVal) > 0){
//             first = middle + 1;
//         } else {
//             if (myBooks[middle].CompareTo(searchVal) < 0){
//                 last = middle -1;
//             }
//         }
//     }
// return foundIndex;
// }

// // Wed,03/01/2023
// class Program {

//     static void Main(){
//         // start main
//         const int MAX_BOOKS = 50;
//         string[] books = new String [MAX_BOOKS];
//         string[] authors = new String [MAX_BOOKS];
//         int[] pages = new int[MAX_BOOKS];

//         int count = GetAllBooks (books, authors, pages);
//         PrintAllBooks(books, authors, pages, count);
//         UpdateBooks(books, authors, pages, count);
//         SortByAuthors(books, authors, pages, count);
//         PagesByAuthors(authors, pages, count);
//     }

//         static int GetAllBooks(string[] books, string[] authors, int[] pages){
//             int count = 0;
//             //open file
//             StreamReader inFile = new StreamReader("input.txt");
            
//             //process file
//             string line = inFile.ReadLine(); //prime read
            
//             while (line != null){
//                 string[] temp = line.Split("#");
//                 books [count] = temp[0];
//                 authors[count] = temp[1];
//                 pages[count] = int.Parse(temp[2]);
//                 count++;
//                 line = inFile.ReadLine(); //update read
//             }

//             //close file
//             inFile.Close();
//             return count;
//         }

//         static void PrintAllBooks (string[] books, string[] authors, int[] pages, int count){
//             for (int i = 0; i < count; i++){
//                 System.Console.WriteLine($"{books[i]} written by {authors[i]} has {pages[i]}.");
//             }
//         }

//         static void UpdateBooks (string[] books, string[] authors, int[] pages, int count){
//             books[4] = "The Cast of Amontillado";
//             //open file
//             StreamWriter outFile = new StreamWriter("input.txt");
//             //process file
//             for(int i = 0; i<count; i++){
//                 outFile.WriteLine($"{books[i]}#{authors[i]}#{pages[i]}");
//             }
//             //close file
//             outFile.Close();
//         }

//         static void SortByAuthors(string[] books, string[] authors, int[] pages, int count){
//             string temp = authors[0];
//             for(int i = 0; i < count -1; i ++){
//                 int min = i;
//                 for (int j = i+1; j < count; j ++){
//                     if (authors[min].CompareTo(authors[j]) > 0) min = j;
//                 }
//                 if (min!= i){
//                     Swap(authors, min, i);
//                 }
                
//             }
//         }

//         static void Swap (string [] myArray, int x, int y){
//             string temp = myArray[x];
//             myArray[x] = myArray[y];
//             myArray[y] = temp;
//         }

//         static void Swap (int [] myArray, int x, int y){
//             int temp = myArray[x];
//             myArray[x] = myArray[y];
//             myArray[y] = temp;
//         }

//         static void PagesByAuthors (string[] authors, int[] pages, int count){
//             string curr = authors[0];
//             int pagesSum = pages[0];
//             for (int i = 1; i < count; i++){
//                 if (curr == authors[i]) {
//                     pagesSum += pages[i];
//                 } else ProcessBreak(ref curr, ref pagesSum, authors[i], pages[i]);
//             }
//             ProcessBreak(curr, pagesSum);
//         }

//         static void ProcessBreak(ref string curr, ref int pagesSum, string nextAuthor, int nextPages) {
//             System.Console.WriteLine($"{curr} \t {pagesSum}");
//             curr = nextAuthor;
//             pagesSum = nextPages;
//         }

//         static void ProcessBreak(string curr, int pagesSum) {
//             System.Console.WriteLine($"{curr} \t {pagesSum}");

//         }
// }
// // Mon, Mar 6, 2023

// string number = "111277744";
// System.Console.WriteLine(number);
// char current = number[0];
// int count = 1;

// for (int i = 1; i < number.Count(); i++){
//     if (current == number [i]){
//         count++;
//     }
//     else {
//         ProcessBreak(ref current, ref count, number[i]);
//     }

// ProcessBreak(ref current, ref count, '0');

// static void ProcessBreak(ref char current, ref int count, char newVal){
//     System.Console.Write($"{count}{current} ");
//     current = newVal;
//     count = 1;
// }

// Bubble sort

// int[] arr = {12,9,1,5,10,7,14};
// bool swapped = true;
// while (swapped){
//     swapped = false;
//     for (int i = 0; i < arr.Length-1; i++){
//         if (arr[i+1]<arr[i]){
//             Swap (arr,i+1,i);
//             swapped = true;
//         }
//     }
// }


// static void Swap (int[] arr, int x, int y){
//     int temp = arr[x];
//     arr[x] = arr[y];
//     arr[y] = temp;
// }

// for (int i = 0; i< arr.Length; i++){
//     System.Console.Write($"{arr[i]}\t");
// }

// Try - Catch

// System.Console.WriteLine("1-hello; 2-howdy; 3-exit");
// int menuChoice = 0;
// while(menuChoice!= 3){
//     try{
//         // Check if the input is an integer
//         menuChoice = int.Parse(Console.ReadLine());
        
//         // Check if the # input is out of the range 1-3:
//         if(menuChoice < 1 || menuChoice >3) {
//             throw new Exception("Please enter a valid choice number");
//         }
//     } catch (Exception e){
//         System.Console.WriteLine(e.Message);

//     // Always continue
//     } finally {
//         if (menuChoice == 1){
//             System.Console.WriteLine("Hello!");
//         } else {
//             if (menuChoice ==2) {
//                 System.Console.WriteLine("Howdy!");
//             }
//         }
//     }
// }
// Console.Clear();
// System.Console.WriteLine("Enter date: ");
// string input = Console.ReadLine();
// System.Console.WriteLine(DateValidation(input));

// static bool DateValidation(string input){
//     bool isValid = true;
//     // Check format (mm/dd/yyyy):
//     if (!(input.Length == 10 && input[2] == '/' && input[5] == '/')){
//         System.Console.WriteLine("Please input in format mm/dd/yyyy");
//         isValid = false;
//     } else{
//         // Check if a valid date:
//         DateTime date;
//         if (!DateTime.TryParse(input, out date)){
//             System.Console.WriteLine("Please input a valid date");
//             isValid = false;
//         } else{
//             // Restrict to only after today & within current year:
//             int currYear = DateTime.Today.Year;
//             if (DateTime.Compare(date,DateTime.Today)<=0 || date.Year != currYear){
//                 System.Console.WriteLine("Only enter a date after today & within the current year");
//                 isValid = false;
//             }
//         }
        
//     }
//     return isValid;
// }

using System;

       
// // Prompt user to enter a time with AM/PM
// Console.Write("Enter a time (e.g. 2:30 PM): ");
// string input = Console.ReadLine();

// // Parse the user input into a DateTime object
// DateTime time;
// if (DateTime.TryParse(input, out time))
// {
//     // Convert the time to 24-hour format if it's in AM/PM format
//     if (time.ToString("tt") == "PM" && time.Hour != 12)
//     {
//         time = time.AddHours(12);
//     }
//     else if (time.ToString("tt") == "AM" && time.Hour == 12)
//     {
//         time = time.AddHours(-12);
//     }

//     // Compare the user input time with the current time
//     if (time > DateTime.Now)
//     {
//         Console.WriteLine("The entered time is in the future.");
//     }
//     else if (time < DateTime.Now)
//     {
//         Console.WriteLine("The entered time has already passed.");
//     }
//     else
//     {
//         Console.WriteLine("The entered time is the current time.");
//     }
// }
// else
// {
//     Console.WriteLine("Invalid time format.");
// }


