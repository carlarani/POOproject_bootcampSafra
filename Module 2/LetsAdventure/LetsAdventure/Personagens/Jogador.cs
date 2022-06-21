namespace LetsAdventure;

public class Jogador : Personagem
{
    protected Dictionary<Item, int> itens;
    protected int _vidaMaxima;
    protected int _pontos = 0;

    public Dictionary<Item, int> Itens { get; private set; }

    public new int Nivel { get; }

    public int Pontos { get; protected set; }

    public int VidaMaxima { get; protected set; }

    public Jogador(string nome)
    {
        Nome = nome;
        itens = new Dictionary<Item, int>();
        Vida = 100;
        Nivel = 1;
        Defesa = 10;
        Dano = 10;
        Agilidade = 10;
        _vidaMaxima = Vida;
    }

    public void GanhaPontos(Monstro monstro)
    {
        _pontos += 500 * (monstro.Nivel - 1) / 10 + 500;
        ProximoNivel();
    }

    protected virtual void ProximoNivel()
    {
        var proximoNivel = 500 * (Nivel ^ 2) - 500 * Nivel;
        if (_pontos < proximoNivel) return;
        _pontos -= proximoNivel;
        Defesa += 10;
        Dano += 10;
        Agilidade += 10;
        _vidaMaxima += 20;
        _nivel += 1;
    }

    public bool Fugir(Monstro monstro)
    {
        var probabilidadeSucesso = 50 * Agilidade / monstro.Agilidade;
        var dado = new Random().Next(0, 100);
        return probabilidadeSucesso < dado;
    }

    public void UsarItem(int posicaoItem)
    {
        var item = itens.ElementAt(posicaoItem);
        item.Key.Efeito(this);
        if (item.Value - 1 == 0)
        {
            itens.Remove(item.Key);
            return;
        }
        itens[item.Key] = item.Value - 1;
    }

    public virtual void UsarHabilidade(Personagem personagemAtacado)
    {
        Ataque(personagemAtacado, true);
    }
}