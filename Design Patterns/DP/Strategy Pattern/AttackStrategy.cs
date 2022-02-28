using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.DP.Strategy_Pattern
{
    public class AttackStrategy : IStrategyInterface
    {
        public void play(string teamName)
        {
            Console.WriteLine($"{teamName} is playing with Attack Strategy!");
        }
    }
}
