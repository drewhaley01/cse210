using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
while (loop == true)
{ Console.WriteLine ("Please choose one of the following choices: ");
    Console.WriteLine  ("1. Write");
    Console.WriteLine ("2. Display");
    Console.WriteLine ("3. Load");
    Console.WriteLine ("4. Save");
    Console.WriteLine ("5. Quit");
    Console.WriteLine ("What would you like to do? ");

    string userinput = Console.ReadLine() ?? "";

    if (userinput == "1"){
        Console.WriteLine("You have selected number 1");
    }
    else if (userinput == "2"){
        Console.WriteLine("You have selected number 2");
    }
    else if (userinput == "3"){
        Console.WriteLine("You have selected number 3");
    }
    else if (userinput == "4"){
        Console.WriteLine("You have selected number 4");
    }
    else{
        loop = false;
    }


}
    }
}