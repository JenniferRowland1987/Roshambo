using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    abstract class Player
    {
        public string Name { get; set; }
        public RoshamboEnum Roshambo { get; set; }

        public abstract RoshamboEnum GenerateRoshambo();

    }
}
