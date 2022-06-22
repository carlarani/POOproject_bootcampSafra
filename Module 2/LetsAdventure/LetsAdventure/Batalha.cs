using LetsAdventure;

namespace LetsAdventures;

public class Batalha
{
    private Jogador Jogador { get; set; }
    private Monstro Monstro { get; set; }
    
    public Batalha(Jogador jogador, Monstro monstro)
    {
        Jogador = jogador;
        Monstro = monstro;
    }
    
}