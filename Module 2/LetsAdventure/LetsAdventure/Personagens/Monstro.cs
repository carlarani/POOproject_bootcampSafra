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
            "Você nunca conseguirá me derrotar!",
            "Quem te ensinou a lutar, fracote!",
            "É só isso que você tem?",
            "Não fez nem cócegas!",
            "É isso o que você chama de ataque?",
            "Treine mais, quem sabe um dia poderá me derrotar!",
            "AAAARRRRRGHHH! Você me paga!!!",
            "Como ousa invadir o meu covil?",
            "Vamos acabar logo com isso, está na hora do meu jantar!!!",
            "MUAHAHAHA, Pode vir!",
            "Cardápio do dia? Herói à milanesa! MUAHAHAHAHA",
            "Vou fazer você se arrepender de ter vindo até aqui!",
            "Plunct plact zum! Você não vai a lugar nenhum!!!",
            "Nem pense em fugir!",
            "Oque é, oque é? Tem cara de herói, mas está mortinho-da-silva ?",
            "Querida, avise as crianças, teremos herói no jantar! HAHAHAHAHA",
            "Aé?? Então tome isso!",
            "Quem você pensa que é para me enfrentar ?",
            "Coxinha de frango, asinha de galinha, se você quer desistir, dá uma risadinha!!! HAHAHAHAHA ops",
            "Já tomou sua dose de Whey Protein hoje?",
            "VEM MONSTRO!!! Digo, digo... ",
            "Quem me dera ser um peixe, ao invés de perder tempo com você!",
            "Olha o fusca azul... ENTÃO TOMA!!!",
            "Toc toc. Quem é? Um herói mortinho-da-silva! HAHAHA"
        };
        var dado = new Random().Next(0, difamacao.Length - 1);
        return difamacao[dado];
    }
}