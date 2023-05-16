// // Problem 1:
// // Start main
// System.Console.WriteLine("Please enter a series of digits: ");
// string digits = Console.ReadLine();
// System.Console.WriteLine("New sequence: "+ Counter(digits));
// // End main

// // Method Counter():
// static string Counter(string digits){
//     int count = 1;
//     string newSequence =  "";
//     for (int i = 0; i< digits.Length-1; i++) {
        
//         if (digits[i] == digits[i+1]){
//             count = count + 1;
//         } else {
//             newSequence = newSequence + count.ToString() + digits[i];
//             count = 1;
//         }
        
//     }
//     newSequence = newSequence + count.ToString() + digits[digits.Length-1];
//     return newSequence;
// }

// // Problem 2:
// bool stopCount = false;
// int fruit = 0;
// int meat = 0;
// int pastry = 0;
// int soup = 0;
// while (stopCount == false){
//     System.Console.WriteLine("Please enter the type of container (fruit, meat, pastry, or soup): ");
//     string type = Console.ReadLine();
//     // If the worker enter a word not "fruit","meat","pastry",or "soup", loop until get the desired input:
//     while ((type != "fruit")&&(type !="meat")&&(type != "pastry")&&(type != "soup")){
//             System.Console.WriteLine("Please re-enter a valid type (fruit, meat, pastry, or soup): ");
//             type = Console.ReadLine();
//         }
//     if (type == "fruit"){fruit = fruit + 1;} 
//     if (type == "meat"){meat = meat + 1;}
//     if (type == "pastry"){pastry = pastry + 1;}
//     if (type == "soup"){soup = soup + 1;}
    
//     System.Console.WriteLine("Is this the last container to wrap yet (yes/no)?");
//     string last = Console.ReadLine();
//     // If the worker enter an answer not either "yes" or "no", loop until get the desired input:
//     while ((last != "yes")&&(last !="no")){
//             System.Console.WriteLine("Please re-enter the answer (yes or no): ");
//             last = Console.ReadLine();
//     }
//     if (last == "yes"){stopCount = true; System.Console.WriteLine("You're done with wrapping. The total will be output now: ");}
//     if (last == "no"){stopCount = false;System.Console.WriteLine("Move on to the next container.");}
// }

// int totalUsed = fruit + meat + pastry + soup;
// double orderAmount = (fruit + meat)*1.2 + pastry + soup;
// System.Console.WriteLine("Containers used by type: ");
// System.Console.WriteLine($"Fruit: {fruit}; Meat: {meat}; Pastry: {pastry}; Soup: {soup}.");
// System.Console.WriteLine($"Total containers used: {totalUsed}");
// System.Console.WriteLine($"We need to order: {(int)Math.Round(orderAmount)}");

// // Problem 3:
// double weight;
// int carets;
// int imperfections;
// string display;
// string decision;
// string again = "yes";
// while (again == "yes"){
//     System.Console.WriteLine("Please input the weight (in grams) of the watch: ");
//     weight = double.Parse(Console.ReadLine());
//     System.Console.WriteLine("Please input the number of carets of the watch: ");
//     carets = int.Parse(Console.ReadLine());
//     System.Console.WriteLine(" Please input the number of imperfections on the watch: ");
//     imperfections = int.Parse(Console.ReadLine());
//     System.Console.WriteLine("Please input the type of display: ");
//     display = Console.ReadLine();
//     if (((display=="digital") || (display== "touchscreen")) && (weight >=0.6)&& (carets ==14) && (imperfections < 2)){
//         decision = "The watch should be bought.";
//     } else {
//         decision = "The watch should not be bought";
//     }
//     System.Console.WriteLine(decision);
//     System.Console.WriteLine("Do you want to test another watch (yes/no)? ");
//     again = Console.ReadLine();
// }


// Problem 4:
// start main
string again = "yes";
while (again == "yes"){
    string workerName = GetName();
    int pastries = GetPastriesNum();
    string rating = GetRating(pastries);
    int currentPoint = GetCurrentPoint();
    int updatedPoint = PointCalc(currentPoint, rating);
    System.Console.WriteLine($"Hey {workerName}, you get {rating} rating today, and your point now is to {updatedPoint}. Keep it up!");
    System.Console.WriteLine("Do you want to calculate the point of another worker (yes/no)? ");
    again = Console.ReadLine();
}

// end main

// method GetName():
static string GetName(){
    System.Console.WriteLine("Please enter the worker's name: ");
    return Console.ReadLine();
}

// method GetPastriesNum():
static int GetPastriesNum(){
    System.Console.WriteLine("Please enter the number of bread this worker made today: ");
    return int.Parse(Console.ReadLine());
}

// method GetRating(int pastries):
static string GetRating (int pastries){
    if (pastries >=600){return "A";}
    else if (pastries >=400){return "B";}
    else if (pastries >=250){return "C";}
    else if (pastries >=150){return "D";}
    else {return "E";}
}

// method GetCurrentPoint:
static int GetCurrentPoint(){
    System.Console.WriteLine("Please enter the worker's current point: ");
    return int.Parse(Console.ReadLine());
}

// method PointCalc(int currentPoint, string rating):
static int PointCalc(int currentPoint, string rating){
    if (rating == "A"){return (currentPoint + 3);}
    else if (rating == "B"){return(currentPoint + 2);}
    else if (rating =="C"){return (currentPoint + 1);}
    else if (rating == "E"){return(currentPoint-1);}
    else{return currentPoint;}
    
}

