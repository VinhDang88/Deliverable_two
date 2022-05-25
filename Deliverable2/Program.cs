Console.WriteLine("Hi. Welcome to Space Buffet. All you can eat for $9.99!");
Console.WriteLine("The only additional cost is coffee. How many people are in your group?");
Console.WriteLine("Please, parties of 6 or lower.");

int x = int.Parse(Console.ReadLine());
if (x > 6)
{
    Console.WriteLine("Sorry, we can only seat parties up to 6.");
    return;
} else
{
    Console.WriteLine("");
    Console.WriteLine("Alrighty! Table for " + x + "! Please follow me and take a seat.");
    Console.WriteLine("Does anyone want any drinks? We only have water or coffee.");
    Console.WriteLine("");
    
}
int waters = 0;
int coffees =0;
for (int i = 1; i <= x; i++)
{
    Console.WriteLine("Alright, person number " + i + " water or coffee?");
    string input = Console.ReadLine();
    Console.WriteLine("");
    if (input == "water")
    {
        waters++;
        Console.WriteLine("Water. Lovely.");
    }
    else if (input == "coffee")
    {
        coffees++;
        Console.WriteLine("Coffee. Splendid Choice!.");
    }
    else
    {
        Console.WriteLine("We currently don't have that option.");
    }
}

Console.WriteLine("");
Console.WriteLine("Okay, so that's " + coffees +" coffees and " + waters + " waters. I'll be right back with your drinks. You may now grab your food!");
Console.WriteLine("");

double costOfBuffett = x * 9.99;
double costOfCoffees = coffees * 1;
double totalCost = costOfBuffett + costOfCoffees;

Console.WriteLine(waters + " waters were free");
Console.WriteLine(coffees + " coffees were $" + costOfCoffees);
Console.WriteLine("The cost of the buffett is $" + costOfBuffett);
Console.WriteLine("-----------------------------");
Console.WriteLine("Total cost is $" + totalCost);
Console.WriteLine("Thank you for visiting! Come again.");
/*
Console.WriteLine("a table for " + x + "! Please follow me and take a seat.");
Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee."); */



/*for (int x = 1; x < 6; x++)
{
    Console.WriteLine("Alright, person number " + x + " water or coffee?");
}*/