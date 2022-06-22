namespace LetsAdventure;

public class Item
{
    public decimal Preco { get; protected set; }
    public string? Nome { get; protected set; }

    public virtual void Efeito(Jogador jogador) { }
    
    public virtual void Efeito(Mago mago) { }
}