using LetsAdventure.Habilidades;
using System.Text;

namespace LetsAdventure;

public sealed class Mago : Jogador
{
    public int Mana { get; set; }
    
    public int ManaMaximo { get; private set; }

    public Mago(string nome) : base(nome)
    {
        Mana = 100;
        ManaMaximo = Mana;
        Habilidade = new BolaDeFogo();
        Defesa = 2;
        CreateImg();
    }

    protected override void ProximoNivel()
    {
        base.ProximoNivel();
        Dano += 2;
        ManaMaximo += 30;
        Defesa += 5;
    }

    public override void CreateImg()
    {
        var img = new StringBuilder();
        img.Append("║  //ˆ\\\\     {*}                       ║\n");
        img.Append($"║ //. .\\\\     I     {Nome}: Nível {Nivel}    ║\n");
        img.Append($"║ \\] - [/     I     HP:{Vida:D3}/{VidaMaxima}         ║\n");
        img.Append("║ /l\\ /j\\     I                        ║\n");
        img.Append("║/. ~~  ,\\/==(]                        ║\n");
        Img = img.ToString();
    }

    public override void UsarHabilidade(Personagem personagemAtacado)
    {
        var habilidade = (BolaDeFogo) Habilidade;
        if (Mana - habilidade.ConsumoMana < 0) { return; }
        Mana -= habilidade.ConsumoMana;
        Dano += habilidade.DanoExtra;
        Ataque(personagemAtacado, true);
        Dano -= habilidade.DanoExtra;
    }
    
}