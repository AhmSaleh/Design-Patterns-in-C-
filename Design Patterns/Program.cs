using Design_Patterns.DP.Strategy_Pattern;

#region Pattern Strategy Run
TeamClinet team1 = new("Team 1");
team1.SetStrategy(new AttackStrategy());
team1.PlayGame();
team1.SetStrategy(new DefendStrategy());
team1.PlayGame();

Console.WriteLine("\n\n");

TeamClinet team2 = new("Team 2");
team2.SetStrategy(new DefendStrategy());
team2.PlayGame();
team2.SetStrategy(new AttackStrategy());
team2.PlayGame();
#endregion
