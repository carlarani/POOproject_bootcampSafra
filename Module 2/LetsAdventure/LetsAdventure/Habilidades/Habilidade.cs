namespace LetsAdventure.Habilidades;

public class Habilidade
{
    protected string _nome;
    protected int _danoExtra;

    public string Nome { get; set; }

    public int DanoExtra { get; protected set; }
}