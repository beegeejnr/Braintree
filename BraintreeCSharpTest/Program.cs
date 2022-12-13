using Microsoft.Extensions.Configuration;
using BraintreeCSharpTest;


string selection = "";

while (selection.ToUpper() != "0")
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Test 1: Read Config");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Test 2: Draw Pyramid");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Test 3: Regex");

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Select test to run (0 to exit): ");
    selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            Test01 test01 = new Test01();
            test01.Run();
            break;
        case "2":
            Test02.Run();
            break;
        case "3":
            Test03.Run();
            break;
        default:
            break;
    }
}

