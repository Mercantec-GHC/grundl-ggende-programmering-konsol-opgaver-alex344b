// See https://aka.ms/new-console-template for more information

//Module 1
//Showing Console.WriteLine();
Console.WriteLine("Hello, World!");

//showing Console.Write();/ This cmd writes everything on the same line.
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first line of code.");

//combination of Console.Write(); and Console.WriteLine();
Console.WriteLine("This is the first line.");
Console.Write("This is the first line.");


//Module 2
Console.WriteLine('b');
//Demonstrating difference between double quotation and single quotation and shows char literal and string literal.
Console.WriteLine("Hello world!"); 
//This code Console.WriteLine('Hello World!'); with single quotations should produce the error - error CS1012: Too many characters in character literal.


//Here i will use the int literal and show what it does
Console.WriteLine(123);

//Here i make a int literal Float, i use F to make sure it knows its float im working with. its called af literal suffix
Console.WriteLine(0.25F);
//Next i will make a int literal decimal, the compiler deafaults sets it automatically to a decimal, so that means i dont need a literal suffix
Console.WriteLine(2.625);
//Here i use letter m upper or lowercase it doesnt realyy matter, but here i use it as the literal suffix to makes sure its a decimal literal
Console.WriteLine(12.39816m);


//Here i will use Boolean literals
//these lines of code is used to represent the idea of truth and false, also called bool, which is used for decision logic.
Console.WriteLine(true);
Console.WriteLine(false);


string userName = Console.ReadLine();