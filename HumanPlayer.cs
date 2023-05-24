using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    internal class HumanPlayer : Player
    {
        public string Name { get; set; }
        public string UserThrowSelection { get; set; }
        public RoshamboEnum PlayerThrow { get; set; }

   
        public override RoshamboEnum GenerateRoshambo()
        {
            while (!Validators.ValidateRPSSelection(UserThrowSelection))
            {
                Console.WriteLine($"Sorry, that is an invalid throw, please try again.");
                Console.WriteLine("Choose: R - Rock, P - Paper, S - Scissors."); ;
                string input = Console.ReadLine();
                UserThrowSelection = input.ToLower().Trim();
            }
            switch (UserThrowSelection)
            {
                case "r":
                    PlayerThrow = RoshamboEnum.Rock;
                    break;
                case "rock":
                    PlayerThrow = RoshamboEnum.Rock;
                    break;
                case "p":
                    PlayerThrow = RoshamboEnum.Paper;
                    break;
                case "paper":
                    PlayerThrow = RoshamboEnum.Paper;
                    break;
                case "s":
                    PlayerThrow = RoshamboEnum.Scissors;
                    break;
                case "scissors":
                    PlayerThrow = RoshamboEnum.Scissors;
                    break;
            }
            return PlayerThrow;
        }
    }
}
