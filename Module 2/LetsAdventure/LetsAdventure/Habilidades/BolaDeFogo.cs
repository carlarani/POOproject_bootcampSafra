namespace LetsAdventure.Habilidades;

public class BolaDeFogo : Habilidade
{
    private int _consumoMana;

    public int ConsumoMana { get; }

    public BolaDeFogo()
    {
        Nome = "Bola de fogo";
        DanoExtra = 55;
        _consumoMana = 50;
    }

}