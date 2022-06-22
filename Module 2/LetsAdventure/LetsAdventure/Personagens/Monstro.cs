using System.Text;
using LetsAdventure.Habilidades;

namespace LetsAdventure;

public sealed class Monstro : Personagem
{

    public Monstro(int nivel)
    {
        Nome = "Aranha Mutante";
        Vida = 150;
        VidaMaxima = Vida;
        Nivel = nivel;
        Defesa = 12 + 10*(nivel - 1);
        Dano = 5 + 10*(nivel - 1);
        Agilidade = 20 + 15*(nivel - 1);
        Habilidade = new GolpeDevastador();
        Img = CreateImg();
    }

    public void Ataque(Personagem personagemAtacado)
    {
        var chanceCritico = new Random().Next(1, 10);
        if (chanceCritico == 1)
        {
            Dano *= 2;
            base.Ataque(personagemAtacado, true);
            Dano /= 2;
            return;
        }
        base.Ataque(personagemAtacado);
    }
    
    protected override string CreateImg()
    {
        var img = new StringBuilder();
        img.Append("║                          /\\  |  /\\   ║\n");  
        img.Append($"║   {Nome}        //\\\\&&&//\\\\  ║\n");
        img.Append($"║   HP:{Vida:D3}/{VidaMaxima}            //\\((  ))/\\\\ ║\n");
        img.Append("║                        /  < ò ó >  \\ ║\n");
        img.Append("║                             └ ┘      ║");
        return img.ToString();
    }

    public string Difamar()
    {
        string[] difamacao =
        {
            "Você nunca conseguirá me derrotar", 
            "Quem te ensinou a lutar, fracote?", 
            "É só isso que você tem?",
            "Não fez nem cócegas"
        };
        var dado = new Random().Next(0, difamacao.Length - 1);
        return difamacao[dado];
    }
}