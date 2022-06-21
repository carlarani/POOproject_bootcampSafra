using LetsAdventure.Habilidades;

namespace LetsAdventure;

public class Personagem
{
    public string? Nome { get; set; }

    public int Vida { get; set; }

    public int Dano { get; protected set; }

    public int Defesa { get; protected set; }

    public int Agilidade { get; protected set; }

    public int Nivel { get; protected set; }

    public string Img { get; protected set; }

    public Habilidade Habilidade { get; protected set; }

    private void SofreDano(Personagem personagemAtacante, bool usaHabilidade)
    {
        if (usaHabilidade)
        {
            Vida -= (personagemAtacante.Dano + personagemAtacante.Habilidade.DanoExtra) * (100 / (100 + Defesa));
            return;
        }

        Vida -= personagemAtacante.Dano * (100 / (100 + Defesa));
    }

    public void Ataque(Personagem personagemAtacado, bool usaHabilidade = false)
    {
        personagemAtacado.SofreDano(this, usaHabilidade);
    }
}