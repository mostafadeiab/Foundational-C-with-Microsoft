using System;
class Intro {
  static void Main() {
    Console.WriteLine("Hello World!");

    Console.Write("Congratulations!");
    Console.Write(" ");
    Console.WriteLine("You wrote your first lines of code.");

    Console.WriteLine('b'); //char
    Console.WriteLine(123); //Int
    Console.WriteLine(0.25F); //Float f or F suffix
    Console.WriteLine(2.625); //Double
    Console.WriteLine(12.39816m); //Decimal M or m suffix
    Console.WriteLine(true); //bool
    Console.WriteLine(false); //bool

    string firstName;
    char userOption;
    int gameScore;
    decimal particlesPerMillion;
    bool processedCustomer;
    var message = "Hello world!"; //Input will determine var type

    Console.WriteLine("Hello\nWorld!");
    Console.WriteLine("Hello\tWorld!");

    Console.WriteLine("c:\\source\\repos");

    Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
    Console.WriteLine("Invoice: 1021\t\tComplete!");
    Console.WriteLine("Invoice: 1022\t\tComplete!");
    Console.WriteLine("\nOutput Directory:\t");

    Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

    Console.Write(@"c:\invoices");

    Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // Kon'nichiwa World

    string firstName = "Bob";
    string message = "Hello " + firstName;
    Console.WriteLine(message);
    string message = $"{greeting} {firstName}!";
    Console.WriteLine(message);

    string projectName = "ACME";
    string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
    Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

    string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
    string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
    Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

    int fahrenheit = 94;
    decimal celsius = (fahrenheit - 32m) * (5m / 9m);
    Console.WriteLine("The temperature is " + celsius + " Celsius.");

    
  }
}