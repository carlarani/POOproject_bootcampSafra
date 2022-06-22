using LetsAdventure.Habilidades;
using System.Text;

namespace LetsAdventure;

public sealed class Guerreiro : Jogador
{
    private Espada _espada;
    public Guerreiro(string nome) : base(nome)
    {
        _espada = new Espada();
        Habilidade = new GolpeDevastador();
        Img = CreateImg();
    }

    protected override string CreateImg()
    {
        var img = new StringBuilder();
        img.Append("║ (/T\\)                                ║\n");
        img.Append($"║ (-,-)   (OOOO)      {Nome}           ║\n");
        img.Append($"║  \\˜/      │3        HP:{Vida:D3}/{VidaMaxima}       ║\n");
        img.Append("║/=...'===//││                         ║\n");
        img.Append("║ │   │     └┘                         ║\n");
        return img.ToString();
    }
    
    public override void UsarHabilidade(Personagem personagemAtacado)
    {
        var habilidade = (GolpeDevastador) Habilidade;
        var dano = habilidade.DanoExtra + _espada.Poder;
        Dano += dano;
        Ataque(personagemAtacado, true);
        Dano -= dano;
        Ataque(personagemAtacado, true);
    }
}