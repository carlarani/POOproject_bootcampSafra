namespace LetsAdventure;

public class Personagem
{
    protected string _nome;
    private int _vida;
    private int _dano;
    private int _defesa;

    public Personagem(string nome, int vida, int dano, int defesa)
    {
        _nome = nome;
        _vida = vida;
        _dano = dano;
        _defesa = defesa;
    }

    public string Nome { get; set; }

    public int Vida { get; set; }

    public int Dano { get; set; }
    
    public int Defesa { get; set; }

    public void sofreDano(int danoRecebido)
    {
        // inserir tratamento se quiser
        _vida -= danoRecebido;
    }

    public void fugir()
    {
        // implementar
    }

    public void ataque()
    {
        // recebe personagem que vai sofrer o dano e utiliza o sofreDano()
    }
}