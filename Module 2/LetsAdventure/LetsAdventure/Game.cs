using LetsAdventure;

namespace LetsAdventures
{
    class Game
    {
        public static int tipoHeroi;
        private static string nomeHeroi;
        public static string NomeHeroi
        {
            get { return nomeHeroi; }
            set { NomeHeroi = value; }
        }

        private static void DisplayTitulo()
        {
            Console.WriteLine("██╗     ███████╗████████╗███████╗     █████╗ ██████╗ ██╗   ██╗███████╗███╗   ██╗████████╗██╗   ██╗██████╗ ███████╗");
            Console.WriteLine("██║     ██╔════╝╚══██╔══╝██╔════╝    ██╔══██╗██╔══██╗██║   ██║██╔════╝████╗  ██║╚══██╔══╝██║   ██║██╔══██╗██╔════╝");
            Console.WriteLine("██║     █████╗     ██║   ███████╗    ███████║██║  ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝█████╗  ");
            Console.WriteLine("██║     ██╔══╝     ██║   ╚════██║    ██╔══██║██║  ██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗██╔══╝  ");
            Console.WriteLine("███████╗███████╗   ██║   ███████║    ██║  ██║██████╔╝ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║███████╗");
            Console.WriteLine("╚══════╝╚══════╝   ╚═╝   ╚══════╝    ╚═╝  ╚═╝╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝");
        }
        private static void MenuPrincipal()
        {
            DisplayTitulo();
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
            nomeHeroi = Console.ReadLine();
            if(nomeHeroi.Length>6)
                nomeHeroi=nomeHeroi.Remove(6);

            string input = "";
            do
            {
                Console.Clear();
                Console.Beep();
                DisplayTitulo();
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
                input =Console.ReadLine();
            }while (!int.TryParse(input, out tipoHeroi) || tipoHeroi!=1 && tipoHeroi!=2);
            Console.Beep();
        }
        
        private static int MenuImg(Jogador jogador)
        {
            string input="";
            int caminhoMenuImg;
            do
            {
                Console.Clear();
                var classeJogador = jogador.GetType().ToString().Remove(0, 14);
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine($"║            {jogador.Nome}                    ║");
                Console.WriteLine($"║            {String.Format("{0,-9}", classeJogador)}                 ║");
                Console.WriteLine($"║            Pontos: {jogador.Pontos:D3}               ║");
                Console.WriteLine($"║            Nº de Vitórias: {jogador.Vitoria:D2}        ║");
                Console.WriteLine("║                                      ║");
                Console.WriteLine("╠══════════════════╬═══════════════════╣");
                Console.Write(jogador.Img);
                Console.WriteLine("╠══════════════════╬═══════════════════╣");
                Console.WriteLine("║ [1] BATALHAR                         ║");
                Console.WriteLine("║ [2] LOJA                             ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                input = Console.ReadLine();
            }while (!int.TryParse(input, out caminhoMenuImg) || caminhoMenuImg != 1 && caminhoMenuImg != 2);
            return caminhoMenuImg;
        }
        private static int LojaImg(Jogador jogador)
        {
            string input = "";
            int caminhoLoja = 0;
            do
            {
                Console.Clear();
                var classeJogador = jogador.GetType().ToString().Remove(0, 14);
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║               * LOJA *               ║");
                Console.WriteLine($"║ {jogador.Nome}                               ║");
                Console.WriteLine($"║ {String.Format("{0,-9}", classeJogador)}                                 ║");
                Console.WriteLine($"║ Pontos: {jogador.Pontos:D3}                          ║");
                Console.WriteLine("╠══════════════════╬═══════════════════╣");
                Console.WriteLine("║ [1] ↑ Aumentar Agilidade             ║");
                Console.WriteLine("║ [2] + Comprar Poção de Cura          ║");
                Console.WriteLine("║ [3] + Comprar Poção de Mana          ║");
                Console.WriteLine("╠══════════════════╬═══════════════════╣");
                Console.WriteLine("║ [9] VOLTAR                           ╣");
                Console.WriteLine("╚══════════════════════════════════════╝");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out caminhoLoja) || caminhoLoja != 1 && caminhoLoja != 2 && caminhoLoja != 3 && caminhoLoja != 9);
            return caminhoLoja;
        }
        private static void BatalhaImg(Jogador jogador, Monstro monstro)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine(monstro.Img);
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.Write(jogador.Img);
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] LUTAR                            ║");
            Console.WriteLine("║ [2] INVENTÁRIO                       ║");
            Console.WriteLine("║ [3] FUGIR                            ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
        }

        private static void InventarioImg(Jogador jogador)
        {
            Console.Clear();
            var classeJogador = jogador.GetType().ToString().Remove(0, 14);
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║            * INVENTÁRIO *            ║");
            Console.WriteLine($"║ {jogador.Nome}                               ║");
            Console.WriteLine($"║ {String.Format("{0,-9}", classeJogador)}                                 ║");
            Console.WriteLine($"║ HP: {jogador.Vida:D3}/{jogador.VidaMaxima}                          ║");
            Console.WriteLine("║                                      ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] 4 un. Poção de Cura              ║");
            Console.WriteLine("║ [2] 0 un. Poção de Mana              ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [9] VOLTAR                           ║");
            Console.WriteLine("║ O que o herói irá fazer?             ║");
            Console.WriteLine("║ ...                                  ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
        }
        public static void Main(string[] args)
        {
            
            MenuPrincipal();
            Jogador player001= new Jogador(NomeHeroi);
            if (tipoHeroi==1)
            {
                player001 = new Mago(NomeHeroi);
                
            } else if(tipoHeroi==2)
            {
                player001 = new Guerreiro(NomeHeroi);
            }
            if(MenuImg(player001)==1)
            {
                Monstro monstro001 = new Monstro(2);
                BatalhaImg(player001, monstro001);

            } else if (MenuImg(player001)==2)
            {
                if (LojaImg(player001)==9)
                    MenuImg(player001);
            }




            // MenuGuerreiro();             
            // MenuMago();             
            // Loja();             
            // Inventario();
            //var mago = new Guerreiro("Boen");
            //var monstro = new Monstro(2);

            //// BatalhaImg(mago, monstro);
            //MenuImg(mago);

        }
    }
}