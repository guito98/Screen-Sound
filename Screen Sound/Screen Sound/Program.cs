// Screen Sound

string mensagemInicial = "\nBoas vindas ao Screen Sound";
string nomeBanda = "";
List<string> listaDasBandas = new List<string>();

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

void CapturarNome()
{
    Console.WriteLine(mensagemInicial);
    Console.Write("\nQual o seu nome? ");
    String nome = Console.ReadLine()!;
    Console.WriteLine("\nOlá, " + nome + "!");
    //Console.WriteLine($"Olá, {nome}!");
    //Console.WriteLine("Olá, {0}!", nome);
}

void ExibirMenuOpcoes()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

 switch (opcaoEscolhidaNum)
    {
        case 1: RegistrarBanda();
            break;
        case 2: BandasRegistradas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNum);
            break;
        case -1: Console.WriteLine("\nAté a próxima! Obrigado por usar nosso app!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("*******************");
    Console.Write("\nEscreva o nome da banda que deseja registrar: ");
    String nomeBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeBanda);
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirMenuOpcoes();
}

void BandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*****************");
    Console.WriteLine("Bandas favoritas");
    Console.WriteLine("*****************\n");
    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda {i + 1}: {listaDasBandas[i]}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirMenuOpcoes();
}

void AvaliarBanda()
{
    if(listaDasBandas.Count == 0){ //Se não tiver banda registrada
        Console.WriteLine("\n*****************\n");
        Console.WriteLine("Você ainda não registrou nenhuma banda. Deseja fazer isso agora?\n");
        Console.WriteLine("Digite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para voltar ao menu principal");
        Console.Write("\nDigite a sua opção: ");
        String opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNum){
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    Console.Clear();
                    ExibirMenuOpcoes();
                    break;
            }
        } 
    else if(listaDasBandas.Count == 1){ //Se tiver apenas uma banda registrada
        Console.Clear();
        Console.WriteLine("*****************");
        Console.WriteLine("Avaliar bandas");
        Console.WriteLine("*****************\n");
        Console.Write($"Qual nota de 0 a 10 deseja dar para a banda {nomeBanda}: ");

        String notaBanda = Console.ReadLine()!;
        int notaBandaNum = int.Parse(notaBanda);

        Console.WriteLine("Banda avaliada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenuOpcoes();
    } 
    else {
        Console.Clear();
        Console.WriteLine("*****************");
        Console.WriteLine("Avaliar bandas");
        Console.WriteLine("*****************\n");
        Console.WriteLine("Qual banda deseja avaliar?\n");
        for (int i = 0; i < listaDasBandas.Count; i++)
        {
            Console.WriteLine($"Banda {i + 1}: {listaDasBandas[i]}");
        }
        Console.Write("\nEscolha a banda que deseja avaliar: ");
        String bandaEscolhida = Console.ReadLine()!;
        int bandaEscolhidaNum = int.Parse(bandaEscolhida);
        Console.WriteLine($"\nQual nota você dá para a banda: {listaDasBandas[bandaEscolhidaNum]}");

    }
}

ExibirLogo();
CapturarNome();
ExibirMenuOpcoes();