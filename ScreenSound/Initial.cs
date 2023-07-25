//string mensagemDeBoasVindas = "Seja bem-vindo ao Screen Sound";
//Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>
//{
//    {
//        "Megadeth", new List<int> { 10, 9, 8 }
//    },
//    {
//        "Angra", new List<int>()
//    }
//};

//void ExibirLogo()
//{
//    Console.WriteLine(@"
//        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//    ");
//    Console.WriteLine(mensagemDeBoasVindas);
//}

//void ExibirOpcoesMenu()
//{
//    ExibirLogo();
//    Console.WriteLine("\n--------------Menu--------------");
//    Console.WriteLine("1 - Registrar uma banda");
//    Console.WriteLine("2 - Exibir todas as bandas");
//    Console.WriteLine("3 - Avaliar uma banda");
//    Console.WriteLine("4 - Exibir a média de uma banda");
//    Console.WriteLine("0 - Para sair");

//    Console.Write("\nSelecione uma opção: ");
//    string opcaoEscolhida = Console.ReadLine()!;
//    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

//    switch (opcaoEscolhidaNumerica)
//    {
//        case 1:
//            RegistrarBanda();
//            break;
//        case 2:
//            ExibirBandasRegistradas();
//            break;
//        case 3:
//            AvaliarBanda();
//            break;
//        case 4:
//            ExibirMediaBanda();
//            break;
//        case 0:
//            Console.WriteLine("Até a próxima! =)");
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }
//}

//void ExibirTituloOpcao(string titulo)
//{
//    int qtdCaracteres = titulo.Length;
//    string marcacao = string.Empty.PadLeft(qtdCaracteres, '*');
//    Console.WriteLine(marcacao);
//    Console.WriteLine(titulo);
//    Console.WriteLine(marcacao + "\n");
//}

//void RegistrarBanda()
//{
//    Console.Clear();
//    ExibirTituloOpcao("Registro de bandas");
//    Console.Write("Digite o nome da banda que deseja registrar: ");
//    string nomeBanda = Console.ReadLine()!;
//    bandasRegistradas.Add(nomeBanda, new List<int>());
//    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
//    Thread.Sleep(2000);
//    Console.Clear();
//    ExibirOpcoesMenu();
//}

//void ExibirBandasRegistradas()
//{
//    Console.Clear();
//    ExibirTituloOpcao("Exibindo a listagem de bandas");
//    foreach (string banda in bandasRegistradas.Keys)
//    {
//        Console.WriteLine($"Banda: {banda}");
//    }

//    Console.WriteLine("\nPressione uma tecla para retorno ao menu principal");
//    Console.ReadKey();
//    Console.Clear();
//    ExibirOpcoesMenu();
//}

//void AvaliarBanda()
//{
//    Console.Clear();
//    ExibirTituloOpcao("Avaliar uma banda");
//    Console.Write("Digite o nome da banda que deseja avaliar: ");
//    string nomeBanda = Console.ReadLine()!;

//    if (!bandasRegistradas.ContainsKey(nomeBanda))
//    {
//        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
//        Console.WriteLine("Pressione uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesMenu();
//    }

//    Console.Write($"\nQual nota a banda {nomeBanda} merece: ");
//    int nota = int.Parse(Console.ReadLine()!);
//    bandasRegistradas[nomeBanda].Add(nota);
//    Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeBanda}!");
//    Thread.Sleep(2000);
//    Console.Clear();
//    ExibirOpcoesMenu();
//}

//void ExibirMediaBanda()
//{
//    Console.Clear();
//    ExibirTituloOpcao("Exibir média da banda");
//    Console.Write("Digite o nome da banda que deseja exibir a média: ");
//    string nomeBanda = Console.ReadLine()!;

//    if (!bandasRegistradas.ContainsKey(nomeBanda))
//    {
//        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
//        Console.WriteLine("Pressione uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesMenu();
//    }

//    List<int> listaNotas = bandasRegistradas[nomeBanda];

//    double media = 0;

//    if (listaNotas.Any())
//    {
//        media = listaNotas.Average();

//    }

//    Console.WriteLine($"\nA média da banda {nomeBanda} é {media}");
//    Console.WriteLine("Pressione uma tecla para voltar ao menu principal");
//    Console.ReadKey();
//    Console.Clear();
//    ExibirOpcoesMenu();
//}

//ExibirOpcoesMenu();