namespace DiceWar;

public class WarDiceCup
{
    private List<WarDice> _warDice = new List<WarDice>();

    public WarDiceCup(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            WarDice newWarDice = new WarDice(1, 6);
            _warDice.Add(newWarDice);
        }
    }

    public void RollAll()
    {
        _warDice.ForEach(warDice => warDice.Roll());
    }

    public int Point()
    {
        return _warDice.Sum(warDice => warDice.Point());
    }

    public override string ToString()
    {
        string str = "";
        foreach (var die in _warDice)
        {
            str += "[" + die.Point() +"] ";
        }

        return str;
    }
}