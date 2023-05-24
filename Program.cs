
using Roshambo;


HumanPlayer player = new HumanPlayer();

string input = "";
while (input == "") 
{
    Console.WriteLine("Welcome to ROSHAMBO!");
    Console.WriteLine("What is your name?");
    input = Console.ReadLine().Trim();
        if(input == "")
        {
        Console.WriteLine("That is not a valid name! Please enter at least one character.");
        input = Console.ReadLine().Trim();
        }   
}
player.Name = input;

Console.WriteLine(player.Name);
