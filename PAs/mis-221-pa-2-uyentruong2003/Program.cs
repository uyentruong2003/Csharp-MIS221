// START MAIN-----------------------------------------------------------------------------------------------------------
string option = GetOption(); // prime read
while (option != "3"){
    if (option =="1"){
        ConvertCurrency();
    } else if (option == "2"){
        RestaurantPOS();
    }else{
        System.Console.WriteLine("Your input is invalid.");
    }
    option = GetOption(); // update read
}

// END MAIN------------------------------------------------------------------------------------------------------------

// GetOption()
static string GetOption(){
    System.Console.WriteLine("Please enter 1 for Convert Currency, 2 for Restaurant POS, 3 for Exit: ");
    return (Console.ReadLine());
}
//-----------------------------------------METHODS FOR CURRENCY CONVERSION-----------------------------------------------------------
// Method to get the currency letter from the user:
static string GetCurrencyLetter(){
    string letter = Console.ReadLine().ToUpper(); // priming read
    // prompt user until they re-enter a valid currency
    while ((letter != "C") && (letter != "E")&& (letter != "I") && (letter != "J") && (letter != "M") && (letter != "B") && (letter != "U")){
        System.Console.Write("Please re-enter a valid letter for the currency (U, C, E, I, J, M, or B): ");
        letter = Console.ReadLine().ToUpper(); // update read
    }
    return letter;
}


// Method to get currency names:
static string GetCurrencyName(string letter){
    switch(letter.ToUpper()){
        case "C": return "Canadian Dollar";
        break;
        case "E": return "Euro";
        break;
        case "I": return "Indian Ruppee";
        break;
        case "J": return "Japanese Yen";
        break;
        case "M": return "Mexican Peso";
        break;
        case "B": return "British Pound";
        break;
        default: return "US Dollar";
        break;
    }
}

//Method to get the exchange rate (to USD) of the currency:
static double Get_Exchange_Rate(string letter){
    switch(letter.ToUpper()){
        case "C": return 1.34;
        break;
        case "E": return 0.93;
        break;
        case "I": return 82.24;
        break;
        case "J": return 131.20;
        break;
        case "M": return 18.98;
        break;
        case "B": return 0.83;
        break;
        default: return 1;
        break;
    }
}

// Method to do the conversion:
static void ConversionCalc(string curr1, string curr2, double amount){
    // curr1_rate: the exchange rate to USD of the initial currency
    double curr1_rate = Get_Exchange_Rate(curr1);

    // curr2_rate: the exchange rate to USD of the ending currency
    double curr2_rate = Get_Exchange_Rate(curr2);

    double converted;
    // Convert from a non-USD currency to USD or other currency
    if (curr1 != "U"){
        converted = (amount*curr2_rate)/curr1_rate;
    // Convert from USD to any currency
    } else{
        converted = amount*curr2_rate;
    }
    System.Console.WriteLine($"\n{amount} {GetCurrencyName(curr1)}(s) = {Math.Round(converted,2)} {GetCurrencyName(curr2)}(s) \n");
}

//Method to Convert any currency in the list (including USD) to one another
static void ConvertCurrency(){
    System.Console.WriteLine($"Enter the capitalized letters corresponding to the currencies you would like to exchange from and to: \nU: {GetCurrencyName("U")} \nC: {GetCurrencyName("C")} \nE: {GetCurrencyName("E")} \nI: {GetCurrencyName("I")} \nJ: {GetCurrencyName("J")} \nM: {GetCurrencyName("M")} \nB: {GetCurrencyName("B")}");

    // Prompt user to input the letter for the currency they want to exchange FROM
    System.Console.Write("\nI would like to exchange currency \nFROM: ");
    string curr1 = GetCurrencyLetter();
    System.Console.WriteLine($"({GetCurrencyName(curr1)})");
    
    // Prompt user to input the letter for the currency they want to exchange TO
    System.Console.Write("TO: ");
    string curr2 = GetCurrencyLetter(); // prime read
    System.Console.WriteLine($"({GetCurrencyName(curr2)})");

    // If the ending currency (curr2) is the same as the initial currency (curr1), prompt user to re-enter until not anymore
    while (curr2 == curr1){
        System.Console.WriteLine($"Please re-enter. You need a second currency different than {GetCurrencyName(curr1)} for the conversion to proceed");
        curr2 = GetCurrencyLetter(); // update read
        System.Console.WriteLine($"({GetCurrencyName(curr2)})");
    }

    System.Console.WriteLine("\nPlease input the amount of money you would like to exchange currency: ");
    double amount = double.Parse(Console.ReadLine());

    // Call the method to do calculation:
    ConversionCalc(curr1,curr2,amount);
}

//---------------------------------------------METHODS FOR RESTAURANT POS-----------------------------------------------------

//Method to calculate the total bill:
static double BillCalc(double food, double alcohol){
    double tax = 0.09 * (food+alcohol);
    double tips = 0.18 * food;
    System.Console.WriteLine($"\nFood: ${Math.Round(food,2)} \nAlcohol: ${Math.Round(alcohol,2)} \nTax: ${Math.Round(tax,2)} \nTips: ${Math.Round(tips,2)}");
    return (food+alcohol+tips+tax);
}
//Method to prompt user input their payment
static double GetPayment(){
    System.Console.Write("Please enter your payment: $");
    return double.Parse(Console.ReadLine());
}
//Method to check the difference between the amount paid and the total bill.
static void CheckDifference(double paid, double grandTotal){

    // If the amount paid is less than the total bill, 
    // prompt user to make more payment until full payment is reached
    while (paid < grandTotal){
        double owed = grandTotal - paid;
        System.Console.WriteLine($"\nYou still owe the restaurant ${Math.Round(owed,2)}");
        paid = paid + GetPayment();
    }
    System.Console.WriteLine($"\nTotal payment made: ${Math.Round(paid,2)}");

    // If the amount paid is more than the total bill, 
    // display the change needs to give back
    if (paid>grandTotal){
        double change = paid - grandTotal;
        System.Console.WriteLine($"Here's your change: ${Math.Round(change,2)}");
    }
}
//RestaurantPOS()
static void RestaurantPOS(){
    System.Console.Write("Enter the total for food: $");
    double food = double.Parse(Console.ReadLine());
    System.Console.Write("Enter the total for alcohol: $");
    double alcohol = double.Parse(Console.ReadLine());
    double grandTotal = BillCalc(food, alcohol);
    System.Console.WriteLine($"GRAND TOTAL: ${Math.Round(grandTotal,2)} \n");
    double paid = GetPayment();
    CheckDifference(paid, grandTotal);
}

