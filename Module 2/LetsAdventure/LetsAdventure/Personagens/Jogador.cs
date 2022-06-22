namespace LetsAdventure;

public class Jogador : Personagem
{
    public int Vitoria { get; protected set; }
    public Dictionary<Item , int> Itens { get; protected set; }

    public int Pontos { get; protected set; }

    public Jogador(string nome)
    {
        Nome = String.Format("{0,-6}", nome);
        Itens = new Dictionary<Item, int>();
        Vida = 100;
        Nivel = 1;
        Defesa = 10;
        Dano = 10;
        Agilidade = 10;
        VidaMaxima = Vida;
    }

    public void GanhaPontos(Monstro monstro)
    {
        Pontos += 500 * (monstro.Nivel - 1) / 10 + 500;
        Vitoria += 1;
        ProximoNivel();
    }

    protected virtual void ProximoNivel()
    {
        var proximoNivel =  500 * Math.Pow(Nivel, 2) - 500 * Nivel;
        Console.WriteLine("Proximo nivel" + proximoNivel);
        if (Pontos < proximoNivel) return;
        Pontos -= (int) proximoNivel;
        Dano += 10;
        Agilidade += 10;
        VidaMaxima += 20;
        Nivel += 1;
    }

    public bool Fugir(Monstro monstro)
    {
        var probabilidadeSucesso = 50 * Agilidade / monstro.Agilidade;
        var dado = new Random().Next(0, 100);
        return probabilidadeSucesso < dado;
    }

    public void UsarItem(int posicaoItem)
    {
        var item = Itens.ElementAt(posicaoItem);
        item.Key.Efeito(this);
        if (item.Value - 1 == 0)
        {
            Itens.Remove(item.Key);
            return;
        }
        Itens[item.Key] = item.Value - 1;
        
    }

    public void AdicionarItem(Item item)
    {
        if (Itens.ContainsKey(item))
        {
            Itens[item] += 1;
            return;
        }
        Itens.Add(item, 1);
    }
    
    public void AtaqueNormal(Personagem personagemAtacado)
    {
        Ataque(personagemAtacado);
    }

    public virtual void UsarHabilidade(Personagem personagemAtacado)
    {
        Ataque(personagemAtacado, true);
    }
}