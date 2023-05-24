using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    internal class RandomPlayer : Player
    {
        public override RoshamboEnum GenerateRoshambo()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            return (RoshamboEnum)randomNumber;

        }
    }
}
