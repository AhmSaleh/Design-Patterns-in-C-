using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.DP.Strategy_Pattern
{
    public interface IStrategyInterface
    {
        public abstract void play(string teamName);
    }
}
