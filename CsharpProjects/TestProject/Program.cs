﻿// Random dice = new Random();
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

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("you rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("you rolled doubles! +2 bonus to total");
        total += 2;
    }
}

if (total >= 14)
{
    Console.WriteLine("You Win a Bugatti!");
}
else if (total >= 10)
{
    Console.WriteLine("you win a new laptop!");
}
else if(total == 7)
{
    Console.WriteLine("you win a trip for two!");
}
else
{
    Console.WriteLine("Sorry, You Lose BASTARD! YOU GET NOTING! HAHAHAHA!");
}















