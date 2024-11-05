namespace DiceWar;

public class GameManager
{
   private Player player1;
   private Player player2;

   private WarDiceCup diceCup1;
   private WarDiceCup diceCup2;
   
   Dictionary<Player, WarDiceCup> PlayersDice = new Dictionary<Player, WarDiceCup>();

   public GameManager(Player player1, Player player2)
   {
      this.player1 = player1;
      this.player2 = player2;
   }

   public void PlayRound()
   {
      PlayersDice.Select(pd => pd).ToList().ForEach(pd => RollDice(pd.Key));
   }

   public void RollDice(Player player)
   {
      Console.WriteLine(player.Name + " is rolling their dice");
      PlayersDice[player].RollAll();
      player.Points += PlayersDice[player].Point();
      Console.WriteLine(player.Name + " dice is:");
      Console.WriteLine(PlayersDice[player]);
      Console.WriteLine("Sum of points:\n" + player.Points);
   }

   public void StartGame(int numberOfDice, int rounds)
   {
      diceCup1 = new WarDiceCup(numberOfDice);
      diceCup2 = new WarDiceCup(numberOfDice);
      
      PlayersDice.Add(player1, diceCup1);
      PlayersDice.Add(player2, diceCup2);

      for (int i = 0; i < rounds; i++)
      {
         int RoundNumber = i + 1;
         Console.WriteLine("=====[Round: " + RoundNumber + "]=====");
         PlayRound();
         Console.WriteLine("==========================");
      }
      
      Console.WriteLine("\nGAME FINISHED!");
      Console.WriteLine(player1.Name + " finished with " + player1.Points + " points.");
      Console.WriteLine(player2.Name + " finished with " + player2.Points + " points.");
      
      if (player1.Points > player2.Points)
      {
         Console.WriteLine(player1.Name + " Wins!");
      } else if (player2.Points > player1.Points)
      {
         Console.WriteLine(player2.Name + " Wins!");
      }
      else
      {
         Console.WriteLine("Draw!");
      }
   }
}