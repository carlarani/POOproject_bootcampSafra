namespace LetsAdventure;

public class Monstro : Personagem
{
    private int taxaCritico;//10 ou 20

    public void causarDanoCritico(int _dano)
    {
        int dado = 0;
        switch (taxaCritico)
        {
            case 10: dado = new Random().Next(1, 10); break;
            case 20: dado = new Random().Next(1, 5); break;
        }
        if (dado == 1)
            _dano *= 2;
    }

    public string difamar()
    {
        string[] difamacao = new string[] { "A", "B", "C" };
        var dado = new Random().Next(0, difamacao.Length - 1);
        return difamacao[dado];
    }
}