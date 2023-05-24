using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    internal class RockPlayer : Player
    {
        public override RoshamboEnum GenerateRoshambo()
        {
            return RoshamboEnum.Rock;
        }
    }
}
