using LetsAdventure.Habilidades;

namespace LetsAdventure;

public class Mago : Jogador
{
    public int Mana { get; set; }
    
    public int ManaMaximo { get; protected set; }
    
    public Mago(string nome) : base(nome)
    {
        Mana = 100;
        ManaMaximo = Mana;
        Habilidade = new BolaDeFogo();
        Defesa = 2;
    }

    protected override void ProximoNivel()
    {
        base.ProximoNivel();
        Dano += 2;
        ManaMaximo += 30;
        Defesa += 5;
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