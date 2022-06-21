namespace LetsAdventure;

public class PocaoCura : Item
{
    public PocaoCura()
    {
        Nome = "Poção de Cura (+40 de vida)";
    }
    public override void Efeito(Jogador jogador)
    {
        if (jogador.Vida < jogador.VidaMaxima)
        {
            jogador.Vida += 40;
        }
        
    }
}