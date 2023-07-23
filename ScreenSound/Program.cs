string mensagemDeBoasVindas = "Seja bem-vindo ao Screen Sound";
List<string> listaBandas = new List<string> { "Angra", "Megadeth", "Kryour" };

void ExibirLogo()
{
    Console.WriteLine(@"
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\n--------------Menu--------------");
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Exibir todas as bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Para sair");

    Console.Write("\nSelecione uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 0:
            Console.WriteLine("Até a próxima! =)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void ExibirTituloOpcao(string titulo)
{
    int qtdCaracteres = titulo.Length;
    string marcacao = string.Empty.PadLeft(qtdCaracteres, '*');
    Console.WriteLine(marcacao);
    Console.WriteLine(titulo);
    Console.WriteLine(marcacao + "\n");
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo a listagem de bandas");
    //for(int i = 0; i < listaBandas.Count; i++)
    //{
    //    Console.WriteLine($"{i+1}#: {listaBandas[i]}");
    //}
    foreach(string banda in listaBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione uma tecla para retorno ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();