// Start main

// Prompt user to enter the day of the week
string dayOfWeek = GetDayOfWeek();
// Check if the day has a birthday & return the corresponding TA's name:
string nameTA = BirthdayDecision(dayOfWeek);
// Display HPBD message for the correct TA:
SayHappyBirthday(nameTA);

// End main

// method to get day of the week input:
static string GetDayOfWeek(){
    System.Console.WriteLine("What day is today (Monday, Tuesday, etc.)? ");
    return Console.ReadLine();
}


// method to test whose bd it is:
static string BirthdayDecision(string day){
    switch(day){
        case "Tuesday":
            return "Makayla";
            break;
        case "Friday":
            return "Alex";
            break;
        default:
            return "N/A";
            break;

    }
}


// method to display HPBD message:
static void SayHappyBirthday(string name){
    if (name == "N/A"){
        System.Console.WriteLine("No birthdays today :(");
    } else{
        System.Console.WriteLine($"Happy Birthday, {name}!");
    }
}