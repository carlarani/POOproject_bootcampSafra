using LetsAdventure.Habilidades;

namespace LetsAdventure;

public class Mago : Jogador
{
    protected int _mana;
    protected int _manaMaximo;

    public int Mana { get; set; }
    
    public int ManaMaximo { get; protected set; }
    
    public Mago(string nome) : base(nome)
    {
        _mana = 100;
        _manaMaximo = _mana;
        _habilidade = new BolaDeFogo();
    }

    protected override void ProximoNivel()
    {
        base.ProximoNivel();
        _manaMaximo += 30;
    }

    public override void UsarHabilidade(Personagem personagemAtacado)
    {
        var habilidade = (BolaDeFogo) _habilidade;
        if (_mana - habilidade.ConsumoMana < 0) { return; }

        _mana -= habilidade.ConsumoMana;
        Ataque(personagemAtacado, true);
    }
    
}