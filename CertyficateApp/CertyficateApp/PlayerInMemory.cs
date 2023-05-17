using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertyficateApp
{
    internal class PlayerInMemory : PlayerBase
    {
        public PlayerInMemory(string firstname, string lastname, int age) 
            : base(firstname, lastname, age)
        {
        }
    }
}
