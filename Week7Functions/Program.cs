Console.WriteLine("Are you coming or leaving? (in/out");
string userchoice = Console.ReadLine();

if (userchoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}





static void PrintHello() //function / method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, alligator.");
}
