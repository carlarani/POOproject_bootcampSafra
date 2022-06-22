using LetsAdventure.Habilidades;

namespace LetsAdventure;

public class Personagem
{
    public string? Nome { get; set; }

    public int Vida { get; set; }
    
    public int VidaMaxima { get; protected set; }

    public int Dano { get; protected set; }

    public int Defesa { get; protected set; }

    public int Agilidade { get; protected set; }

    public int Nivel { get; protected set; }

    public string Img { get; protected set; }

    public Habilidade Habilidade { get; protected set; }

    protected virtual string CreateImg()
    {
        return " @ _ @";
    }

    private void SofreDano(Personagem personagemAtacante, bool usaHabilidade)
    {
        // double dano = personagemAtacante.Dano * (100 / (100 + Defesa));
        int dano = 10;
        if (usaHabilidade)
        {
             // dano = (personagemAtacante.Dano + personagemAtacante.Habilidade.DanoExtra) * (100 / (100 + Defesa));
             dano = 20;
        }
        
        Vida -= dano;
    }

    protected void Ataque(Personagem personagemAtacado, bool usaHabilidade = false)
    {
        personagemAtacado.SofreDano(this, usaHabilidade);
    }
}