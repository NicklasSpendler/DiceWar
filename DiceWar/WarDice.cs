namespace DiceWar;

public class WarDice : Dice
{
    public WarDice(int minValue, int maxValue) : base(minValue, maxValue)
    {
        
    }

    public override int Point()
    {
        if (DiceValue % 2 != 0)
        {
            return DiceValue * 2;
        }
        return DiceValue;
    }
}