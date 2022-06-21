namespace LetsAdventure;

public class PocaoMana : Item
{
    public PocaoMana()
    {
        Nome = "Poção de Mana (+40 de mana)";
    }
    public override void Efeito(Mago mago)
    {
        if (mago.Mana < mago.ManaMaximo)
        {
            mago.Mana += 40;
        }
        
    }
}