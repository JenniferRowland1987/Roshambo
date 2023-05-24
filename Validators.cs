using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    internal class Validators
    {
        public static bool ValidateOpponentSelection(string userOpponentSelection)
        {
            if (userOpponentSelection != "rock" && userOpponentSelection != "r" && userOpponentSelection != "computer" && userOpponentSelection != "c")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidateRPSSelection(string userThrowSelection)
        {
            if (userThrowSelection != "r" && userThrowSelection != "p" && userThrowSelection != "s" && userThrowSelection != "rock" && userThrowSelection != "paper" && userThrowSelection != "scissors")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
