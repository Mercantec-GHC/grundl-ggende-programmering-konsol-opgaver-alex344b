// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Random dice = new Random();
// int roll = dice.Next();

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");


// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);


// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// if (total > 14)
// {
//     Console.WriteLine("You Win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, You Lose BASTARD!");
// }

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


// string message = "The quick brown fox jups over the lazy dog";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?!");
// }

// if (message.Contains("fox"))
// {
//     Console.WriteLine("DING DING DING DING DING DING!");
// }


//Game of doubles and triples
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("you rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("you rolled doubles! +2 bonus to total");
//         total += 2;
//     }
// }

// if (total >= 14)
// {
//     Console.WriteLine("You Win a Bugatti!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("you win a new laptop!");
// }
// else if(total == 7)
// {
//     Console.WriteLine("you win a trip for two!");
// }
// else
// {
//     Console.WriteLine("Sorry, You Lose BASTARD! YOU GET NOTING! HAHAHAHA!");
// }


//Challenge: Improve renewal rate of subscriptions

// Random random = new Random();
// int daysUntilExperiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExperiration <= 10)
// {

//     if (daysUntilExperiration <= 5 && daysUntilExperiration >= 1)
//     {
//         discountPercentage = 10;
//         Console.WriteLine($"Your subscription expires in {daysUntilExperiration} days. Renew now and save {discountPercentage}%");
//     }
//     else if (daysUntilExperiration == 1)
//     {
//         discountPercentage = 20;
//         Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
//     }
//     else if (daysUntilExperiration == 0)
//     {
//         Console.WriteLine("Your subscription has expired.");
//     }
//     else 
//     {
//         Console.WriteLine("Your subscription will expire soon. Renew now!");
//     }
// }

/*

//Declaring a new array
string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

*/
//Initialize an array
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassing First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


//Looping through an array using foreach

// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }


//Create a variable to hold the current bin number and display the running total
/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have a {sum} items in inventory");
*/

//nested iteration and selection statements

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}



