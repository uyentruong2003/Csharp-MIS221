// main start
// prompt the user to enter choice
int choice = GetChoice();
//check if their choice different than 1,2,3
choice = CheckChoice(choice); // prime read
// Routing based on choice (1: full triangle, 2: partial triangle, 3: exit)
RoutEm(choice);

// main end

// method: GetChoice()
static int GetChoice(){
    System.Console.WriteLine("Enter 1 to draw full triangle, 2 to draw partial triangle, 3 to exit:");
    return int.Parse(Console.ReadLine());
}

// method: CheckChoice()
static int CheckChoice (int choice){
    while ((choice != 1) && (choice != 2) && (choice != 3) ){
        System.Console.WriteLine("Your choice is invalid. Please re-enter as instructed below.");
        choice = GetChoice();
    }
    return choice;
}

//method RoutEm():
static void RoutEm(int choice){
    while (choice != 3){
        // if user enters 1 --> call method DrawFull()
        if (choice == 1){
            DrawFull();
        // if user enters 2 --> call method DrawPartial()
        } else if (choice == 2){
            DrawPartial();
        
        }
        // update read
        choice = CheckChoice(GetChoice());

    }
}

// method to draw full triangle- DrawFull():
static void DrawFull(){
    int ran = new Random().Next(3,9);
    for(int i = 1; i<ran; i++){
        System.Console.WriteLine("O");
        for (int inLine = 0; inLine <= i-1; inLine++){
            System.Console.Write("O");
        }
    }
    System.Console.Write("O");
    System.Console.WriteLine('\n');
}


// method random number generator- IsPrint():
static bool IsPrint(){
    // output randomly either 0 or 1
    Random rnd = new Random();
    int number = rnd.Next(2);
    // if number =1 --> true
    if (number == 1){
        return true;
    // if number =0 --> false
    } else{
        return false;
    }
}

// method draw partial triangle- DrawPartial():
static void DrawPartial(){
    int ran = new Random().Next(3,9);
    for(int i = 1; i<ran; i++){
        // if IsPrint = True --> writeline "O", else print " "
        if (IsPrint()){
            System.Console.WriteLine("O");
        } else {
            System.Console.WriteLine(" ");
        }
        
        for(int inLine = 0; inLine <= i-1; inLine++){
            // if IsPrint = True --> write "O", else print " "
            if (IsPrint()){
                System.Console.Write("O");
            } else {
                System.Console.Write(" ");
            }
        }
    }
    // if IsPrint = True --> write "O", else print " "
    if (IsPrint()){
            System.Console.Write("O");
    } else {
            System.Console.Write(" ");
    }
    System.Console.WriteLine('\n');
}
