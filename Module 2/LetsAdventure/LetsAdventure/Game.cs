using LetsAdventure;

namespace LetsAdventures
{
    class Game
    {
        private static Jogador _jogador = new Jogador("");
        
        private static string? ClasseHeroi
        {
            get { return String.Format("{0,-9}", _jogador.GetType().Name);}
        }

        private static string[] _titulo =
        {
            "██╗     ███████╗████████╗███████╗     █████╗ ██████╗ ██╗   ██╗███████╗███╗   ██╗████████╗██╗   ██╗██████╗ ███████╗\n",
            "██║     ██╔════╝╚══██╔══╝██╔════╝    ██╔══██╗██╔══██╗██║   ██║██╔════╝████╗  ██║╚══██╔══╝██║   ██║██╔══██╗██╔════╝\n",
            "██║     █████╗     ██║   ███████╗    ███████║██║  ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝█████╗  \n",
            "██║     ██╔══╝     ██║   ╚════██║    ██╔══██║██║  ██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗██╔══╝  \n",
            "███████╗███████╗   ██║   ███████║    ██║  ██║██████╔╝ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║███████╗\n",
            "╚══════╝╚══════╝   ╚═╝   ╚══════╝    ╚═╝  ╚═╝╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝\n",
            "==================================================================================================================\n"
        };

        private static void DisplayAnimacaoTitulo()
        {
            foreach (var linha in _titulo)
            {
                Console.Write(linha);
                Thread.Sleep(450);
            }
        }

        private static void DisplayTitulo()
        {
            Console.Write(string.Join("", _titulo));
        }

        private static void AnimacaoLimpaTela(int linhas)
        {
            for (var i = 0; i < linhas; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                LimpaLinha();
                Thread.Sleep(250);
            }
        }

        private static void LimpaLinha()
        {
            var currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, currentLineCursor);
        }
        private static void TelaBemVindo()
        {
            DisplayAnimacaoTitulo();
            Thread.Sleep(450);
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                Bem-Vindo, Herói!                                               ║"); 
            Console.WriteLine("║                            //ˆ\\\\     {*}                           (/T\\)                                       ║");
            Console.WriteLine("║                           //. .\\\\     I                            (-,-)   (OOOO)                              ║");
            Console.WriteLine("║                           \\] - [/     I                             \\˜/      │3                                ║");
            Console.WriteLine("║                           /l\\ /j\\     I                         _ /=...'===//││                                ║");
            Console.WriteLine("║                          /. ~~  ,\\/==(]                      /OOO//│   │     └┘                                ║");
            Console.WriteLine("║                          \\\\    /      I                     O:@:O └└└└└                                        ║");
            Console.WriteLine("║                           |    |      I                      \\OOO/ ││ ││                                       ║");
            Console.WriteLine("║                          /j  L l\\     !                            [) (]                                       ║");
            Console.WriteLine("║                                                                                                                ║"); 
            Console.WriteLine("║ Pressione Enter para continuar...                                                                              ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Thread.Sleep(450);
            AnimacaoLimpaTela(14);
        }

        private static void SelecaoHeroi()
        {
            Console.Write("Bravo Herói, qual seu nome? ");
            var nomeHeroi = Console.ReadLine();
            Console.Beep();
            if (nomeHeroi.Length > 6)
            {
                nomeHeroi = nomeHeroi.Remove(6);
            }
            
            string input;
            int escolha;
            var linhas = 13;
            
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
            do
            {
                Console.Write("Classe: ");
                input = Console.ReadLine();
                linhas++;
            } while (!int.TryParse(input, out escolha) || escolha != 1 && escolha != 2);
            _jogador = escolha == 1 ? new Mago(nomeHeroi) : new Guerreiro(nomeHeroi);
            AnimacaoLimpaTela(linhas);
        }
        
        private static void MenuImg()
        {
            string input;
            int caminhoMenuImg;
            var linhas = 10 + _jogador.Img.Split('\n').Length;
            
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine($"║            {_jogador.Nome}                    ║");
            Console.WriteLine($"║            {ClasseHeroi}                 ║");
            Console.WriteLine($"║            Pontos: {_jogador.Pontos:D3}               ║");
            Console.WriteLine($"║            Nº de Vitórias: {_jogador.Vitoria:D2}        ║");
            Console.WriteLine("║                                      ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.Write(_jogador.Img);
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] BATALHAR                         ║");
            Console.WriteLine("║ [2] LOJA                             ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            var opcoes = new [] { "1", "2"};
            do
            {
                Console.Write("O que fazer? ");
                input = Console.ReadLine();
                linhas++;
            } while (!int.TryParse(input, out caminhoMenuImg) || !opcoes.Any(input.Contains));
            AnimacaoLimpaTela(linhas);
            EscolherCaminhoMenuImg(caminhoMenuImg);
        }

        private static Monstro GerarMonstro()
        {
            var nivel = new Random().Next(1,5);
            var monstro001 = new Monstro(nivel);
            return monstro001;
        }
        
        private static void EscolherCaminhoMenuImg(int caminhoMenuImg)
        {
            switch (caminhoMenuImg)
            {
                case 1:
                    EncontroInicialImg(GerarMonstro());
                    break;
                case 2:
                    LojaImg();
                    break;
            }
        }    

        private static void LojaImg()
        {
            string input;
            var linhas = 10;
            
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║               * LOJA *               ║");
            Console.WriteLine($"║ {_jogador.Nome}                               ║");
            Console.WriteLine($"║ {ClasseHeroi}                            ║");
            Console.WriteLine($"║ Pontos: {_jogador.Pontos:D3}                          ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] + Comprar Poção de Cura          ║");
            Console.WriteLine("║ [2] + Comprar Poção de Mana          ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [9] VOLTAR                           ╣");
            Console.WriteLine("╚══════════════════════════════════════╝");
            var opcoes = new [] { "1", "2", "9"};
            bool inputValido = false;
            int caminhoLoja = 0;

            while (!inputValido || caminhoLoja != 9)
            {
                Console.Write("O que fazer? ");
                input = Console.ReadLine();
                inputValido = int.TryParse(input, out caminhoLoja);
                if (inputValido && opcoes.Any(input.Contains))
                {
                    EscolherCaminhoLoja(caminhoLoja);
                    linhas++;
                }
                linhas++;
            }
            AnimacaoLimpaTela(linhas);
            MenuImg();
        }

        private static void EscolherCaminhoLoja(int caminhoLoja)
        {
            switch(caminhoLoja)
            {
                case 1: 
                    Console.WriteLine("Poção de Cura comprada!");
                    _jogador.AdicionarItem(new PocaoCura());
                    break;
                case 2:
                    Console.WriteLine("Poção de Mana comprada!");
                    _jogador.AdicionarItem(new PocaoMana());
                    break;
            }
        }
        private static void EncontroInicialImg(Monstro monstro)
        {
            string input;
            int caminhoEncontroInicial;
            var linhas = 6 + _jogador.Img.Split('\n').Length + monstro.Img.Split('\n').Length;
            
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine(monstro.Img);
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.Write(_jogador.Img);
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] LUTAR                            ║");
            Console.WriteLine("║ [2] INVENTÁRIO                       ║");
            Console.WriteLine("║ [3] FUGIR                            ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            var opcoes = new [] { "1", "2", "3"};
            do
            {
                Console.Write("O que fazer? ");
                input = Console.ReadLine();
                linhas++;
            } while (!int.TryParse(input, out caminhoEncontroInicial) || !opcoes.Any(input.Contains));
            AnimacaoLimpaTela(linhas);
            EscolherCaminhoEncontroInicial(caminhoEncontroInicial, monstro);
        }

        private static void EscolherCaminhoEncontroInicial(int caminhoEncontroInicial, Monstro monstro)
        {
            switch(caminhoEncontroInicial)
            {
                case 1:
                    BatalhaImg(monstro);
                    break;
                case 2:
                    InventarioImg(monstro);
                    break;
                case 3:
                    if (_jogador.Fugir(monstro))
                        MenuImg();
                    else
                        BatalhaImg(monstro);
                    break;                    
            }
        }

       private static void BatalhaImg(Monstro monstro)
        {
            string input;
            int caminhoBatalha;
            var opcoes = new [] { "1", "2"};
            bool validInput = false;

            while (!validInput || monstro.Vida > 0)
            {
                var linhas = 8 + _jogador.Img.Split('\n').Length + monstro.Img.Split('\n').Length;
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine(monstro.Img);
                Console.WriteLine("╠══════════════════╬═══════════════════╣");
                Console.Write(_jogador.Img);
                Console.WriteLine("╠══════════════════╬═══════════════════╣");
                Console.WriteLine("║ [1] ATAQUE BÁSICO                    ║");
                Console.WriteLine("║ [2] USAR HABILIDADE ESPECIAL         ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                
                Console.Write("O que fazer? ");
                input = Console.ReadLine();
                validInput = int.TryParse(input, out caminhoBatalha);
                if (validInput && opcoes.Any(input.Contains))
                {
                    linhas++;
                    EscolherCaminhoBatalha(caminhoBatalha, monstro);
                    Thread.Sleep(3000);
                }
                monstro.Ataque(_jogador);
                Console.WriteLine($"{monstro.Nome} diz: {monstro.Difamar()}");
                Console.WriteLine($"{monstro.Nome} atacou {_jogador.Nome}");
                Thread.Sleep(3000);
                AnimacaoLimpaTela(linhas);
            }
        }

        private static void EscolherCaminhoBatalha(int caminhoBatalha, Monstro monstro)
        {
            switch (caminhoBatalha)
            {
                case 1:
                    Console.WriteLine($"{_jogador.Nome} deu um ataque normal!");
                    _jogador.AtaqueNormal(monstro);
                    break;
                case 2:
                    Console.WriteLine($"{_jogador.Nome} usou sua habilidade {_jogador.Habilidade.Nome}!");
                    _jogador.UsarHabilidade(monstro);
                    break;
            }
        }

        private static void InventarioImg(Monstro monstro)
        {
            string input;
            int linhas = 11;
            
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║            * INVENTÁRIO *            ║");
            Console.WriteLine($"║ {_jogador.Nome}                               ║");
            Console.WriteLine($"║ {ClasseHeroi}                            ║");
            Console.WriteLine($"║ HP: {_jogador.Vida:D3}/{_jogador.VidaMaxima}                          ║");
            Console.WriteLine("║                                      ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [1] 4 un. Poção de Cura              ║");
            Console.WriteLine("║ [2] 0 un. Poção de Mana              ║");
            Console.WriteLine("╠══════════════════╬═══════════════════╣");
            Console.WriteLine("║ [9] VOLTAR                           ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            var opcoes = new [] { "1", "2", "9"};
            bool inputValido = false;
            int caminhoInventario = 0;

            while (!inputValido || caminhoInventario != 9)
            {
                Console.Write("O que fazer? ");
                input = Console.ReadLine();
                inputValido = int.TryParse(input, out caminhoInventario);
                if (inputValido && opcoes.Any(input.Contains))
                {
                    EscolherCaminhoInventario(caminhoInventario);
                    linhas++;
                }
                linhas++;
            }
            AnimacaoLimpaTela(linhas);
            EncontroInicialImg(monstro);
        }

        private static void EscolherCaminhoInventario(int caminhoInventario)
        {
            switch(caminhoInventario)
            {
                case 1:
                    Console.WriteLine($"{_jogador.Nome} usou Poção");
                    break;
                case 2:
                    Console.WriteLine($"{_jogador.Nome} usou Poção");
                    break;
            }
        }
        
        public static void Main(string[] args)
        {
            TelaBemVindo();
            SelecaoHeroi();
            MenuImg();

        }
    }
}
