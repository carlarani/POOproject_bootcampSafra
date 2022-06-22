using LetsAdventure;

namespace LetsAdventures
{
    class Game
    {

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
            string nomeHeroi = Console.ReadLine();
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
            Console.ReadKey();
            Console.Beep();
        }
        
        private static void MenuImg(Jogador jogador)
        {
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
        }
        private static void LojaImg(Jogador jogador)
        {
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
        }
        private static void BatalhaImg(Jogador jogador, Monstro monstro)
        {
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
            var classeJogador = jogador.GetType().ToString().Remove(0, 14);
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║            * INVENTÁRIO *            ║");
            Console.WriteLine($"║ {jogador.Nome}                               ║");
            Console.WriteLine($"║ {String.Format("{0,-9}", classeJogador)}                                 ║");
            Console.WriteLine($"║ HP: {jogador.Vida:D3}/{jogador.VidaMaxima}                          ║");
            Console.WriteLine("║                                      ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
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
            var mago = new Guerreiro("Boen");
            var monstro = new Monstro(2);
            
            // BatalhaImg(mago, monstro);
            MenuImg(mago);
            
        }
    }
}