// See https://aka.ms/new-console-template for more information

//Module 1
//Showing Console.WriteLine();
using System.Security;

//Console.WriteLine("Hello, World!");

//showing Console.Write();/ This cmd writes everything on the same line.
//Console.Write("Congratulations!");
//Console.Write(" ");
//Console.Write("You wrote your first line of code.");

//combination of Console.Write(); and Console.WriteLine();
//Console.WriteLine("This is the first line.");
//Console.Write("This is the first line.");


//Module 2
//Console.WriteLine('b');
//Demonstrating difference between double quotation and single quotation and shows char literal and string literal.
//Console.WriteLine("Hello world!"); 
//This code Console.WriteLine('Hello World!'); with single quotations should produce the error - error CS1012: Too many characters in character literal.


//Here i will use the int literal and show what it does
//Console.WriteLine(123);

//Here i make a int literal Float, i use F to make sure it knows its float im working with. its called af literal suffix
//Console.WriteLine(0.25F);
//Next i will make a int literal decimal, the compiler deafaults sets it automatically to a decimal, so that means i dont need a literal suffix
//Console.WriteLine(2.625);
//Here i use letter m upper or lowercase it doesnt realyy matter, but here i use it as the literal suffix to makes sure its a decimal literal
//Console.WriteLine(12.39816m);


//Here i will use Boolean literals
//these lines of code is used to represent the idea of truth and false, also called bool, which is used for decision logic.
//Console.WriteLine(true);
//Console.WriteLine(false);


//Here i will show a declared declare a variable
//string firstName;
//Variable name examples
//char userOption;
//int gameScore;
//decimal particlesPerMillion;
//bool processedCustomer;


//Creating the first variable
//Retriving the value stored in the variable, and reassigning the value of a variable
//string firstName;
//firstName = "Bob";
//Console.WriteLine(firstName);
//firstName = "Liem";
//Console.WriteLine(firstName);
//firstName = "Isabella";
//Console.WriteLine(firstName);
//firstName = "Yasmin";
//Console.WriteLine(firstName);

//Here is the wrong way to assign a value to a variable
//string firstName;
//"Bob" = firstName;
//This way of writing the code will give you yhis error - error CS0131: The left-hand side of an assignment must be a variable, property or indexer

//Initialize the variable
// if you dont set a value before you retrive a value from a variable you will get an error - (2,19): error CS0165: Use of unassigned local variable 'firstName'
//string firstName;
//Console.WriteLine(firstName);

//Challenge: Display literal and variable values
//string firstName;
//firstName = "Bob";
//Console.Write("Hello, ");
//Console.Write(firstName);
//Console.Write("! you have ");
//Console.Write(3);
//Console.Write(" messages in your inbox. ");
//Console.Write("The temperature is ");
//Console.Write(34.4m);
//Console.Write(" celsius.");


//Exercise - Combine strings using character escape sequences
//Character escape sequences

//Console.WriteLine("Hello\nWorld!");
//Console.WriteLine("Hello\tWorld!");

////Console.WriteLine("Hello "World"!");

//Console.WriteLine("Hello \"world\"!");

////Conosole.WriteLine("C:\Source\repos");

//Console.WriteLine("c:\\source\\repos");

//Console.WriteLine("Generating invoices for customer \"Contoso corp\" ...\n");

//Console.WriteLine("Invoice: 1021\t\tComplete!");
//Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine("\nOutput Directory:\t");

//Console.WriteLine(@"    c:\source\repos    
//        (this is where your code goes)");

//Console.Write(@"c:\invoices");

//// Kon'nichiwa World
//Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

//// To generate Japanese invoices:
//// Nihon no seikyū-sho o seisei suru ni wa:
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
//// User command to run an application
//Console.WriteLine(@"c:\invoices\app.exe -j");

//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
//Console.WriteLine("Invoice: 1021\t\tComplete!");
//Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine("\nOutput Directory:\t");
//Console.Write(@"c:\invoices");

//// To generate Japanese invoices:
//// Nihon no seikyū-sho o seisei suru ni wa:
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
//// User command to run an application
//Console.WriteLine(@"c:\invoices\app.exe -j");

//Exercise - Combine strings using string concatenation

//Concatenate a literal string and a variable
//string firstName = "Bob";
//string message = "Hello " + firstName;
//Console.WriteLine(message);

//Concatenate multiple variables and literal strings
//string firstName = "Bob";
//string greeting = "Hello";
//string message = greeting + " " + firstName + "!";
//Console.WriteLine(message);

//int version = 11;
//string updateText = "Update to Windows";
//string message = $"{updateText} {version}";
//Console.WriteLine(message);

////combined verbatim literals and string inerpolation
//string projectName = "First-Project";
//Console.WriteLine($@"c:\Output\{projectName}\Data");

//chalange: Format and display instructions
//string projectName = "ACME";
//string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
//Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
//string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
//Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

//Numbers and adding stuff
//int firstNumber = 12;
//int secondNumber = 9;
//Console.WriteLine(firstNumber + secondNumber);
//string firstName = "Bob";
//int widgetsSold = 7;
//Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

//Exercise - Perform math operations

//int sum = 7 + 5;
//int difference = 7 - 5;
//int product = 7 * 5;
//int quotient = 7 / 5;

//Console.WriteLine("sum: " + sum);
//Console.WriteLine("Difference: " + difference);
//Console.WriteLine("Product: " + product);
//Console.WriteLine("Quotient: " + quotient);

//Add code to perform division using literal decimal data
//decimal decimalQuotient = 7 / 5.0m;
//decimal decimalQuotient = 7.0m / 5.0m;

//int decimalQuotient = 7 / 5.0m;
//int decimalQuotient = 7.0m / 5;
//int decimalQuotient = 7.0m / 5.0m;
//decimal decimalQuotient = 7 / 5;

//Add code to perform division using literal decimal data

//int first = 7;
//int second = 5;
//decimal quotient = (decimal)first / (decimal)second;
//Console.WriteLine(quotient);

//Write code to determine the remainder after integer division

//Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
//Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//Write code to exercise C#'s order of operations

//int value1 = 3 + 4 * 5;
//int value2 = (3 + 4) * 5;
//Console.WriteLine(value1);
//Console.WriteLine(value2);

//Write code to increment and decrement a value
//int value = 1;

//value = value + 1;
//Console.WriteLine("First increment: " + value);

//value += 1;
//Console.WriteLine("Second increment: " + value);

//value++;
//Console.WriteLine("Third increment: " + value); 

//value = value - 1;
//Console.WriteLine("First decrement: " + value);

//value -= 1;
//Console.WriteLine("Second decrement: " + value);

//value--;
//Console.WriteLine("Third decrement: " + value);



//Use the increment operator before and after the value

//int value = 1;
//value++;
//Console.WriteLine("First: " + value);
//Console.WriteLine($"Second: {value++}");
//Console.WriteLine("Third: " + value);
//Console.WriteLine("Fourth: " + (++value));


////Challenge: Calculate Celsius given the current temperature in Fahrenheit
//decimal value = (94 - 32) * (5m / 9);
//Console.WriteLine($"The temperature is {value} Celsius.");

////"Real" solution
//int fahrenheit = 94;
//decimal celsius = (fahrenheit - 32m) * (5m / 9m);
//Console.WriteLine("The temperature is" + celsius + " Celsius.");


//Setup: Use the following steps to prepare for the Guided project exercises:
// initialize variables - graded assignments 
//int currentAssignments = 5;

//int sophia1 = 93;
//int sophia2 = 87;
//int sophia3 = 98;
//int sophia4 = 95;
//int sophia5 = 100;

//int nicolas1 = 80;
//int nicolas2 = 83;
//int nicolas3 = 82;
//int nicolas4 = 88;
//int nicolas5 = 85;

//int zahirah1 = 84;
//int zahirah2 = 96;
//int zahirah3 = 73;
//int zahirah4 = 85;
//int zahirah5 = 79;

//int jeong1 = 90;
//int jeong2 = 92;
//int jeong3 = 98;
//int jeong4 = 100;
//int jeong5 = 97;


////Create variables to store the sum
//int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
//int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
//int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
//int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

////Create variables to store the average
//decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
//decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
//decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
//decimal jeongScore = (decimal) jeongSum / currentAssignments;

//Console.WriteLine("Student\t\tGrade\n");
//Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
//Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
//Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
//Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

//Project overview: developing a Student GPA Calculator that will help calculate students' overall Grade Point Average

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

//Calculate the final GPA
int gradeA = 4;
int gradeB = 3;

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

// Format the console output
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");










string userName = Console.ReadLine();