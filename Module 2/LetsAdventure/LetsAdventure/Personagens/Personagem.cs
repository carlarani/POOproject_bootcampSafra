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
    
    public virtual void CreateImg()
    {
        Img = " @ _ @";
    }

    private void SofreDano(Personagem personagemAtacante, bool usaHabilidade)
    {
        // TODO: ARRUMAR FÓRMULA
        // int dano = personagemAtacante.Dano * (Defesa + 100/ 100);
        int dano = 10;
        if (usaHabilidade)
        {
            dano = 20;
            // dano = (personagemAtacante.Dano + personagemAtacante.Habilidade.DanoExtra) * (Defesa + 100/ 100);
        }
        Vida -= dano;
        CreateImg();
    }

    protected void Ataque(Personagem personagemAtacado, bool usaHabilidade = false)
    {
        personagemAtacado.SofreDano(this, usaHabilidade);
    }
}