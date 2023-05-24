
using Roshambo;

HumanPlayer player = new HumanPlayer();
RoshamboEnum computerThrow;
RoshamboEnum playerThrow;
string userThrowSelection;
string userOpponentSelection;
int playerScore = 0;
int computerScore = 0;

static void DisplayOpponents()
{
    Console.WriteLine("Please choose your opponent!");
    Console.WriteLine("R - Rock Player, C - Computer Player");
}

static void DisplayMenu(Type enumType)
{
    Console.WriteLine("Please choose your throw from the following:");
    foreach (int i in Enum.GetValues(enumType))
    {
        Console.WriteLine($"{Enum.GetName(enumType, i)}");
    }
    
}

static RoshamboEnum GetComputerThrow(string opponentSelection)
{
    RockPlayer rockPlayer = new RockPlayer();
    RandomPlayer randomPlayer = new RandomPlayer();
    RoshamboEnum compThrow = RoshamboEnum.Paper;

    
    while (!Validators.ValidateOpponentSelection(opponentSelection))
    {
        Console.WriteLine("Sorry, that is an invalid opponent selection, please try again.");
        DisplayOpponents();
        opponentSelection = Console.ReadLine().ToLower().Trim();
    }
    switch (opponentSelection)
    {
        case "r":
            compThrow = rockPlayer.GenerateRoshambo();
            break;
        case "rock":
            compThrow = rockPlayer.GenerateRoshambo();
            break;
        case "c":
            compThrow = randomPlayer.GenerateRoshambo();
            break;
        case "computer":
            compThrow = randomPlayer.GenerateRoshambo();
            break;
    }
    return compThrow;
}

static ResultsEnum GetResults(RoshamboEnum playThrow, RoshamboEnum compThrow)
{
    if (playThrow == RoshamboEnum.Rock && compThrow == RoshamboEnum.Paper)
    {
        return ResultsEnum.lose;
    }
    else if (playThrow == RoshamboEnum.Rock && compThrow == RoshamboEnum.Scissors)
    {
        return ResultsEnum.win;
    }
    else if (playThrow == RoshamboEnum.Paper && compThrow == RoshamboEnum.Rock)
    {
        return ResultsEnum.win;
    }
    else if (playThrow == RoshamboEnum.Paper && compThrow == RoshamboEnum.Scissors)
    {
        return ResultsEnum.lose;
    }
    else if (playThrow == RoshamboEnum.Scissors && compThrow == RoshamboEnum.Rock)
    {
        return ResultsEnum.lose;
    }
    else if (playThrow == RoshamboEnum.Scissors && compThrow == RoshamboEnum.Paper)
    {
        return ResultsEnum.win;
    }
    else
    {
        return ResultsEnum.draw;
    }
}


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

Console.WriteLine($"Welcome, {player.Name}!");
bool playAgain = true;
while (playAgain)
{
    DisplayOpponents();
    userOpponentSelection = Console.ReadLine().ToLower().Trim();

    DisplayMenu(typeof(RoshamboEnum));
    

    playerThrow = player.GenerateRoshambo();
    computerThrow = GetComputerThrow(userOpponentSelection);

    Console.WriteLine($"{player.Name}, you chose: {playerThrow}!");
    Console.WriteLine("....");
    Console.WriteLine($"your opponent chose: {computerThrow}");

    if(GetResults(playerThrow, computerThrow) == ResultsEnum.win)
    {
        Console.WriteLine($"{playerThrow} beats {computerThrow}!  {player.Name} wins this round!");
        playerScore++;           
    }
    else if(GetResults(playerThrow, computerThrow) == ResultsEnum.lose)
    {
        Console.WriteLine($"{computerThrow} beats {playerThrow}, better luck next time, {player.Name}!");
        computerScore++;
    }
    else
    {
        Console.WriteLine("it's a draw!");
    }
    Console.WriteLine($"{player.Name}, you have {playerScore} points! Your opponent has {computerScore}!");
    Console.WriteLine($"Would you like to play another round, {player.Name}? (Y/N)");
    string response = Console.ReadLine().ToLower().Trim();
    while(response != "y" && response != "yes" && response != "n" && response != "no")
    {
        Console.WriteLine("it's a yes or no question... would you like to play again? (Y/N)");
        response = Console.ReadLine().ToLower().Trim();
    }
    if(response == "n" || response == "no")
    {
        Console.WriteLine("Thank you for playing!");
        playAgain = false;
    }
    else
    {
        playAgain = true;
        continue;
    }

}


