namespace LetsAdventure;

public class Espada
{
    public string? Nome { get; }
    public int Poder { get; protected set; }

    public Espada()
    {
        Nome = "Excalibur";
        Poder = 5;
    }
}