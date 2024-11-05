namespace DiceWar;
using Pcg;

public class Dice
{
    protected int DiceValue;

    public Dice()
    {
        MinValue = 0;
        MaxValue = 6;
    }

    public Dice(int minValue, int maxValue)
    {
        MinValue = minValue;
        MaxValue = maxValue;
    }

    private int maxValue;
    public int MaxValue
    {
        get => maxValue;
        set
        {
            if (value > 0)
            {
                maxValue = value;
            }
            else
            {
                throw new ArgumentException("MaxValue must be greater than 0");
            }
        }
    }

    private int minValue;
    public int MinValue
    {
        get => minValue;
        set
        {
            if (value > 0)
            {
                minValue = value;
            }
            else
            {
                throw new ArgumentException("MinValue must be greater than 0");
            }
        }
    }

    public void Roll()
    {
        Random random = new PcgRandom();
        DiceValue = random.Next(MinValue, MaxValue);
    }

    public virtual int Point()
    {
        return DiceValue;
    }
    
    public override string ToString()
    {
        return "Dice: " + DiceValue + " / " + MaxValue;
    }
}