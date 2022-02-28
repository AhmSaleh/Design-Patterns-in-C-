using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.DP.Strategy_Pattern
{
    public class TeamClinet
    {
        public IStrategyInterface TeamStrategy { get; set; }
        public string TeamName { get; set; }

        public TeamClinet(string temaName)
        {
            TeamName = temaName;
        }

        public void SetStrategy(IStrategyInterface teamStrategy)
        {
            TeamStrategy = teamStrategy;
        }

        // Delegation
        public void PlayGame() => TeamStrategy.play(TeamName);
    }
}
