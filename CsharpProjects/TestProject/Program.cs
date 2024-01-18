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
/*
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
*/


/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/

/*
//whitespace to make your code easier to read
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
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
*/

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);

// int letterCount = 0;

// foreach (char letter in message)
// {
//     if (letter == 'o')
//     {
//         letterCount++;
//     }
// }

// string newMessage = new String(message);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

//Hjemme pc test
//Console.WriteLine("Hello World!")


/*
// initialize variables - graded assignments, plus ekstra students
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
       studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
    studentScores = beckyScores;
    else if (currentStudent == "Chris")
    studentScores = chrisScores;
    else if (currentStudent == "Eric")
    studentScores = ericScores;
    else if (currentStudent == "Gregor")
    studentScores = gregorScores;
    else
        continue;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

*/


/*
// Use the inequality operator
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/


//code to display the result of a coin flip
// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

/*
//Boolean expressions challenge
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/


//Create a variable inside of a code block
/*
bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: " + value);
}

Console.WriteLine($"Outside of code block: {value}");
*/

//Remove code blocks from if statements
/*
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");    
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
*/

//update problematic code in the code editor
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
    {
       found = true;
    }
}
if (found) 
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine($"Total: {total}");
*/

//Create and test a switch statement
/*
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
*/

/*
//rewrite if-elseif-else using a switch statement
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat Shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size fits all!";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

/*
//Write a basic for statement
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
*/

//Changed the iteration conditions
// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

//Experiment with the iterator's pattern
// for (int i = 10; i >= 0; i -= 6)
// {
//     Console.WriteLine(i);
// }

//Using the break keyword to break the iteration statement

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

//Overcoming the limitation of the foreach statement using the for statement
/*
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
*/

//activity using for and if statements
/*
for (int i = 1; i <101; i++)
{
    if((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}
*/

//a do-while statement to break when a certain random number is generated
/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

//Use the continue statement to step directly to the Boolean expression

/*
Random random = new Random();
int current = random.Next(0, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

//using do and while iteration statements
/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero Wins" : "Monster Wins!");
*/

//MinValue and MaxValue properties for each signed integral type
/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
*/

/*
//MinValue and MaxValue properties for each signed float type
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

//Define a reference type variable
//int[] data = new int[3];
/*
string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);
*/

//Write code that attempts to add an int and a string and save the result in an int
/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
*/

//Perform a cast
/*
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
*/

/*
//widening conversion or narrowing conversion
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");
*/

/*
//Performing Data Conversions
//int to string
int first = 6;
int second = 9;

string message = first.ToString() + second.ToString();
Console.WriteLine(message);

//normal string
string first1 = "6";
string second1 = "9";

string message1 = first1 + second1;
Console.WriteLine(message1);

//normal int
int first3 = 60;
int second3 = 9;

int message2 = first3 + second3;
Console.WriteLine(message2);

//string to int
string first2 = "60";
string second2 = "9";

int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);

//Convert a string to a int using the Convert class
string value1 = "6";
string value2 = "9";

int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

//Compare casting and converting a decimal into an int
int value = (int)1.5m; //casting truncates / rounds down
Console.WriteLine(value);

int value3 = Convert.ToInt32(1.5m); //converting rounds up
Console.WriteLine(value3);
*/ 

/*
//TryParse() a string into an int
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unabale to report measurement.");
}
if (result > 0)
Console.WriteLine($"Mearsurement (w/ offser): {50 + result}");
*/

//combine string array values as strings and as integers
/*
string[] values = {"12.3", "45", "ABC", "11", "DEF"};
decimal sum = 0m; 
string message = "";

foreach (var value in values)
{
    decimal number; //uses and stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        sum += number;
    }
    else
    {
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {sum}");
*/
/*
//output math operations as specific number types
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;


int result1 = value1 / (int)value2;

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3; 

Console.WriteLine($"Divide value2 by value3, display the result as an decimal: {result2}");

float result3 = value3 / (float)value1;

Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/

//Create an array of pallets, then sort them and reversed
/*
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

//Use array methods to clear and resize an array
/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

//Resize the array to remove elements
/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/*
//Use the ToCharArray() to reverse a string
string value = "abc123";
char[] valueArray = value.ToCharArray();

//Reverse, then combine the char array into a new string
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

//Split() the comma-separated-value string into an array of strings
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

//Write code to reverse each word in a message
//one way to do it i guess
/*
string pangram = "The quick brown fox jumps over the lazy dog";
char[] newPangram = pangram.ToCharArray();
Array.Reverse(newPangram);

Console.WriteLine(newPangram);

// another way to do it.
string pangram = "The quick brown fox jumps over the lazy dog";
string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];
for (int i = 0; i < message.Length; i++)
{
    char[] newPangram = message[i].ToCharArray();
    Array.Reverse(newPangram);
    newMessage[i] = new string(newPangram);
}

string result = string.Join(" ", newMessage);
Console.WriteLine(result);
*/

//challenge to parse a string of orders, sort the orders and tag possible errors
/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);

foreach (var order in orders)
{
    if (order.Length == 4)
    {
        Console.WriteLine(order);
    }
    else
    {
        Console.WriteLine(order + "\t- Error");
    }
}
*/


//Investigate string formatting basics
//####################################################
/*
//What is Composite Formatting?
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

//update
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

//string interpolation
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

//Formatting currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

//update
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

//Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

//Combining formatting approaches
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);

// update
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);


//Display the invoice number using string interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");

//Finalize the receipt with the total amount due formatted as currency
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
*/

/*
//Discover padding and alignment
//#######################################
string first = "hello";
string second = "world";

string result = string.Format($"{0} {1}!", first, second);
Console.WriteLine(result);

//Add a line of numbers above the output to more easily confirm the result
string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);
 */
/*
 //apply string interpolation to a form letter
 
 string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a custumer of our {currentProduct} offering we are excitedd to tell you about new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += string.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += string.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += string.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += string.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
*/

/*
//Write code to find parenthesis pairs embedded in a string
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

//update
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

//Modify the starting position of the sub string
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;
//modification
//openingPosition += 6;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

//Avoid magic values (Hardcoded strings like "<span>" in the previous code listing are known as "magic strings" and hardcoded numeric values like 6 are known as "magic numbers". These "Magic" values are undesirable for many reasons and you should try to avoid them if possible.)

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

/*
///////////////////////////////////////////////////////////////////////////////////////
//if there is different symbols but every open symbol needs a matching closing symbol
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/
///////////////////////////////////////////////////////////////////////////////////////
/*
//removing characters in spefific locations from a string
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

// replace method, to replace one or more characters
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/

/*
//Extract, replace, and remove data from an input string
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
//get the quantity
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end if <span> tag
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

//we set the output to the input, where we replace the trademark symbol with registered trademark symbol
const string tradeSymbol = "&trade";
const string regSymbol = "&reg";
output = input.Replace(tradeSymbol, regSymbol);

//here we are gonna remove the opening div tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

//We will remove the closing div and add "Output:" in the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);
*/

