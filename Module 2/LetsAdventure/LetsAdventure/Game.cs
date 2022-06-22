using LetsAdventure;

namespace LetsAdventures
{
    class Game
    {
        static void MenuPrincipal()
        {
            Console.WriteLine("██╗     ███████╗████████╗███████╗     █████╗ ██████╗ ██╗   ██╗███████╗███╗   ██╗████████╗██╗   ██╗██████╗ ███████╗");
            Console.WriteLine("██║     ██╔════╝╚══██╔══╝██╔════╝    ██╔══██╗██╔══██╗██║   ██║██╔════╝████╗  ██║╚══██╔══╝██║   ██║██╔══██╗██╔════╝");
            Console.WriteLine("██║     █████╗     ██║   ███████╗    ███████║██║  ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝█████╗  ");
            Console.WriteLine("██║     ██╔══╝     ██║   ╚════██║    ██╔══██║██║  ██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗██╔══╝  ");
            Console.WriteLine("███████╗███████╗   ██║   ███████║    ██║  ██║██████╔╝ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║███████╗");
            Console.WriteLine("╚══════╝╚══════╝   ╚═╝   ╚══════╝    ╚═╝  ╚═╝╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝");
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                  Bem Vindo(a)!                                                 ║"); 
            Console.WriteLine("║                            //ˆ\\\\     {*}                           (/T\\)                                       ║");
            Console.WriteLine("║                           //. .\\\\     I                            (-,-)   (OOOO)                              ║");
            Console.WriteLine("║                           \\] - [/     I                             \\˜/      │3                                ║");
            Console.WriteLine("║                           /l\\ /j\\     I                         _ /=...'===//││                                ║");
            Console.WriteLine("║                          /. ~~  ,\\/==(]                      /OOO//│   │     └┘                                ║");
            Console.WriteLine("║                          \\\\    /      I                     O:@:O └└└└└                                        ║");
            Console.WriteLine("║                           |    |      I                      \\OOO/ ││ ││                                       ║");
            Console.WriteLine("║                          /j  L l\\     !                            [) (]                                       ║");
            Console.WriteLine("║                                                                                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.Write("Bravo Herói, qual seu Nome? ");
            string nomeHeroi = Console.ReadLine();
            Console.Clear();
            Console.Beep();
            Console.WriteLine("██╗     ███████╗████████╗███████╗     █████╗ ██████╗ ██╗   ██╗███████╗███╗   ██╗████████╗██╗   ██╗██████╗ ███████╗");
            Console.WriteLine("██║     ██╔════╝╚══██╔══╝██╔════╝    ██╔══██╗██╔══██╗██║   ██║██╔════╝████╗  ██║╚══██╔══╝██║   ██║██╔══██╗██╔════╝");
            Console.WriteLine("██║     █████╗     ██║   ███████╗    ███████║██║  ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝█████╗  ");
            Console.WriteLine("██║     ██╔══╝     ██║   ╚════██║    ██╔══██║██║  ██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗██╔══╝  ");
            Console.WriteLine("███████╗███████╗   ██║   ███████║    ██║  ██║██████╔╝ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║███████╗");
            Console.WriteLine("╚══════╝╚══════╝   ╚═╝   ╚══════╝    ╚═╝  ╚═╝╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝");
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                                ║"); 
            Console.WriteLine("║                            //ˆ\\\\     {*}         Selecione         (/T\\)                                       ║");
            Console.WriteLine("║     [1] MAGO              //. .\\\\     I         sua classe!        (-,-)   (OOOO)            [2] GUERREIRO     ║");
            Console.WriteLine("║                           \\] - [/     I                             \\˜/      │3                                ║");
            Console.WriteLine("║                           /l\\ /j\\     I                         _ /=...'===//││                                ║");
            Console.WriteLine("║                          /. ~~  ,\\/==(]                      /OOO//│   │     └┘                                ║");
            Console.WriteLine("║                          \\\\    /      I                     O:@:O └└└└└                                        ║");
            Console.WriteLine("║                           |    |      I                      \\OOO/ ││ ││                                       ║");
            Console.WriteLine("║                          /j  L l\\     !                            [) (]                                       ║");
            Console.WriteLine("║                                                                                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
            Console.Beep();
        }
        static void MenuMago()
        {
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║       CALEBE        ║");
            Console.WriteLine("║       classe:       ║");
            Console.WriteLine("║        MAGO         ║");
            Console.WriteLine("╠═════════════════════╣");
            Console.WriteLine("║     //ˆ\\\\     {*}   ║");
            Console.WriteLine("║    //. .\\\\     I    ║");
            Console.WriteLine("║    \\] - [/     I    ║");
            Console.WriteLine("║    /l\\ /j\\     I    ║");
            Console.WriteLine("║   /. ~~  ,\\/==(]    ║");
            Console.WriteLine("║   \\\\    /      I    ║");
            Console.WriteLine("║    |    |      I    ║");
            Console.WriteLine("║   /j  L l\\     !    ║");
            Console.WriteLine("╠═════════════════════╣");
            Console.WriteLine("║ [1] BATALHAR        ║");
            Console.WriteLine("║ [2] LOJA            ║");
            Console.WriteLine("╚═════════════════════╝");
        }
        static void MenuGuerreiro()
        {
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║       CALEBE        ║");
            Console.WriteLine("║       classe:       ║");
            Console.WriteLine("║      GUERREIRO      ║");
            Console.WriteLine("╠═════════════════════╣");
            Console.WriteLine("║       (/T\\)         ║");
            Console.WriteLine("║       (-,-)   (OOOO)║");
            Console.WriteLine("║        \\˜/      │3  ║");
            Console.WriteLine("║      /=...'===//││  ║");
            Console.WriteLine("║ /OOO//│   │     └┘  ║");
            Console.WriteLine("║ O:@:O └└└└└         ║");
            Console.WriteLine("║ \\OOO/ ││ ││         ║");
            Console.WriteLine("║       [) (]         ║");
            Console.WriteLine("╠═════════════════════╣");
            Console.WriteLine("║ [1] BATALHAR        ║");
            Console.WriteLine("║ [2] LOJA            ║");
            Console.WriteLine("╚═════════════════════╝");
        }
        static void Loja()
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║               * LOJA *               ║");
            Console.WriteLine("║ CALEBE                               ║");
            Console.WriteLine("║ MAGO                                 ║");
            Console.WriteLine("║ Pontos:000                           ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] ↑ Aumentar HP                    ║");
            Console.WriteLine("║ [2] ↑ Aumentar Mana                  ║");
            Console.WriteLine("║ [3] ↑ Aumentar Dano                  ║");
            Console.WriteLine("║ [4] ↑ Aumentar Agilidade             ║");
            Console.WriteLine("║ [5] + Comprar Poção de Cura          ║");
            Console.WriteLine("║ [6] + Comprar Poção de Mana          ║");
            Console.WriteLine("║ [8] + Comprar Poção Anti-veneno      ║");
            Console.WriteLine("║ [9] + Comprar Poção Anti-paralisia   ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [9] VOLTAR                           ╣");
            Console.WriteLine("╚══════════════════════════════════════╝");
        }
        static void BatalhaImg(Jogador jogador)
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║                          /\\  |  /\\   ║");                 
            Console.WriteLine("║   Aranha Mutante        //\\\\&&&//\\\\  ║");
            Console.WriteLine("║   HP:75/100            //\\((  ))/\\\\  ║");
            Console.WriteLine("║                        /  < ò ó >  \\ ║");
            Console.WriteLine("║                             └ ┘      ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.Write(jogador.Img);
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] LUTAR                            ║");
            Console.WriteLine("║ [2] INVENTÁRIO                       ║");
            Console.WriteLine("║ [3] FUGIR                            ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
        }

        static void Inventario()
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║            * INVENTÁRIO *            ║");
            Console.WriteLine("║ CALEBE                               ║");
            Console.WriteLine("║ MAGO                                 ║");
            Console.WriteLine("║ HP:075/100                           ║");
            Console.WriteLine("║ Saúde:Normal                         ║");
            Console.WriteLine("║                                      ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] 2 un. Poção Anti-paralisia       ║");
            Console.WriteLine("║ [2] 1 un. Poção Anti-veneno          ║");
            Console.WriteLine("║ [3] 4 un. Poção de Cura              ║");
            Console.WriteLine("║ [4] 0 un. Poção de Mana              ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [5] VOLTAR                           ║");
            Console.WriteLine("║ O que o herói irá fazer?             ║");
            Console.WriteLine("║ ...                                  ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
        }
        public static void Main(string[] args)
        {
            // MenuPrincipal();             
            // MenuGuerreiro();             
            // MenuMago();             
            // Loja();             
            // Inventario();
            var mago = new Mago("Boen  ");
            BatalhaImg(mago);
            
        }
    }
}