using LetsAdventure.Habilidades;

namespace LetsAdventure;

public class Guerreiro : Jogador
{
    public Espada Espada { get; }
    public Guerreiro(string nome) : base(nome)
    {
        Espada = new Espada();
        Habilidade = new GolpeDevastador();
    }
    
    public override void UsarHabilidade(Personagem personagemAtacado)
    {
        var habilidade = (GolpeDevastador) Habilidade;
        var dano = habilidade.DanoExtra + Espada.Poder;
        Dano += dano;
        Ataque(personagemAtacado, true);
        Dano -= dano;
        Ataque(personagemAtacado, true);
    }
}