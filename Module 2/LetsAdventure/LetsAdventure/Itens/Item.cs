namespace LetsAdventure;

public class Item
{
    private string? _nome;

    public string? Nome { get; protected set; }

    public virtual void Efeito(Jogador jogador) { }
    
    public virtual void Efeito(Mago mago) { }
}