namespace LetsAdventure;

public class Personagem
{
    protected string? _nome;
    protected int _vida;
    protected int _dano;
    protected int _defesa;
    protected int _agilidade;
    protected int _nivel;
    protected string _img;
    protected Habilidade habilidade;

    public string? Nome { get; set; }

    public int Vida { get; protected set; }

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
            _vida -= (personagemAtacante._dano + personagemAtacante.Habilidade.DanoExtra) * (100 / (100 + _defesa));
            return;
        }
        _vida -= personagemAtacante._dano * (100 / (100 + _defesa));
    }

    public virtual void Ataque(Personagem personagemAtacado, bool usaHabilidade = false)
    {
        personagemAtacado.SofreDano(this, usaHabilidade);
    }
}