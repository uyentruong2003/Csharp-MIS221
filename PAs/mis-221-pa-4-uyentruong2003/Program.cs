using System.IO;
// MENU
Console.Clear();
string choice = GetChoice();
RouteEm(ref choice);


// RouteEm(): input validation:
static void RouteEm(ref string choice){
    while (choice !="4"){
        if (choice == "1") {
            Console.Clear();
            EncodeFile();
            choice = GetChoice();
        }   
        else if (choice == "2") {
            Console.Clear();
            DecodeFile();
            choice = GetChoice();
        }   
        else if (choice == "3") {
            Console.Clear();
            WordCount();
            choice = GetChoice();
        }   
        else{
            System.Console.Write("Invalid choice.");
            choice = GetChoice(); //update
        }
    }
}

static string GetChoice(){
    System.Console.WriteLine("MAIN MENU:\t1. ENCODE A FILE\t2. DECODE A FILE\t3. WORD COUNT\t4. EXIT");
    System.Console.Write("Please enter your choice (1, 2, 3, or 4): ");
    return Console.ReadLine();  
}

static void WordCount(){
    string fileName = GetFileName("text","word count");
    string text = ReadFile(fileName);  
    string[] wordArr = text.Split(" ");
    int count = wordArr.Count();
    Console.WriteLine($"Word Count for file {fileName}: {count}\n");
}

static void EncodeFile(){
    System.Console.WriteLine("***ENCODE FILE***");
    // Get the name of the file that is going to be encoded: 
    string file1 = GetFileName("input", "encoding");
    // Get the name of the file that will store the encoded text: 
    string file2 = GetFileName("output","encoding");
    // Run the ROT13 translator: 
    ROT13Translator(file1, file2, "Encoding");
    
}

static void DecodeFile(){
    System.Console.WriteLine("***DECODE FILE***");
    // Get the name of the file that is going to be decoded:
    string file1 = GetFileName("input", "decoding");
    // Get the name of the file that will store the decoded text: 
    string file2 = GetFileName("output","decoding");
    // Run the ROT13 translator: 
    ROT13Translator(file1, file2, "Decoding");
}

static string GetFileName(string fileType, string action){
    // Prompt user to enter the input file name:
    System.Console.Write($"Enter the name of the {fileType} file for {action}: ");
    string fileName = Console.ReadLine();
    // Check if the file exists in folder:
    while(!File.Exists(fileName)){
        System.Console.Write($"File '{fileName}' does not exist in folder. Please re-enter a correct name or add a new file to folder to proceed: ");
        fileName = Console.ReadLine();
    }
    return fileName;
}


static void ROT13Translator(string file1, string file2, string action){
    // GET CONTENT FROM FILE1:
    string input = ReadFile(file1);

    //TRANSLATE CONTENT:
    string output = ApplyROT13(input.ToLower());  
    System.Console.WriteLine($"{action} file..."); 

    // STORE TRANSLATED CONTENT IN FILE2:
    WriteFile(file2, output);
}

static string ReadFile(string file){
    //open file:
    StreamReader inFile = new StreamReader(file);
    //process file:
    Console.Clear();
    System.Console.WriteLine($"Get the content of {file}...\n");
    string content = File.ReadAllText(file); //read the content of file1
    System.Console.WriteLine($"Content of '{file}':\n{content}"); //display on screen
    //close file:
    inFile.Close();
    return content;
}

static void WriteFile(string file, string content){
    //open file:
    StreamWriter outFile = new StreamWriter(file);
    //process file:
    System.Console.WriteLine($"\nOutput:\n{content}"); //display on screen
    outFile.WriteLine(content); //add the code in file2
    System.Console.WriteLine($"\nStore the output in {file}...\n");
    //close file:
    outFile.Close();
}

static string ApplyROT13(string input){
    char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    char[] inputCharArr = input.ToCharArray();
    char[] outputCharArr = new char[inputCharArr.Length];
    string output ="";
    for (int i = 0; i < inputCharArr.Length; i++){
        if (alphabet.Contains(inputCharArr[i])) { // if the char is A-Z
            //find the index of the current input char in the alphabet
            int x = Array.IndexOf(alphabet, inputCharArr[i]);
            // find the index of the corresponding output char in the alphabet
            int y = x + 13;
            // if the index of the output char exceeds 25, starts from the beginning of the alphabet
            if (y>25) y = y-26;
            outputCharArr[i]=alphabet[y];
        } else{
            outputCharArr[i]=inputCharArr[i]; // for non-letter characters such as numbers & symbols
        }
        output += outputCharArr[i].ToString();
    }
    return output;
    
}


