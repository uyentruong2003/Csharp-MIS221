// Inputs: ordersFilled, milesDriven, ordersMade
int ordersFilled;
int ordersMade;
double milesDriven;
// Outputs: fulfillmentRate, costPerOrder
double fulfillmentRate;
double costPerOrder;
// Processing items: DRIVERS_WAGE (constant), milesPerOrder
const double DRIVERS_WAGE = 1.27;
double milesPerOrder;

// ****** MAIN *******
// Prompt user for the orders filled
Console.WriteLine("Input the number of orders filled: ");
ordersFilled = int.Parse(Console.ReadLine());

// Prompt users for orders made
Console.WriteLine("Input the number of orders made: ");
ordersMade = int.Parse(Console.ReadLine());

// Prompt users for the miles driven
Console.WriteLine("Input the number of miles driven: ");
milesDriven = double.Parse(Console.ReadLine());

// Calculate the fulfillment rate:
fulfillmentRate = ordersFilled / ordersMade;

// Calculate the miles-per-order rate:
milesPerOrder = ordersFilled / milesDriven;
    // Hi, I think the formula given in the IPO chart is wrong. 
    // To calculate the milesPerOrder, I think should use this instead:
    // milesPerOrder = milesDriven/ordersFilled
    // I'm still following the formula in the IPO chart FYI.

// Calculate the cost-per-order rate:
costPerOrder = milesPerOrder * DRIVERS_WAGE;

// Print out fulfillmentRate and costPerOrder:
Console.WriteLine("Fulfillment Rate: " + fulfillmentRate);
Console.WriteLine("Cost per Order: $" + costPerOrder);

