namespace DiceWar;

public class Player
{
    private string name;
    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Points { get; set; }


    public Player(string name)
    {
        this.name = name;
    }
}