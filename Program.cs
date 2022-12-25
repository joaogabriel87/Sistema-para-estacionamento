using estacionamento;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoinicial = 0;
decimal precoPorHora= 0;

Console.WriteLine("Sejam bem vindos ao sistema de estacionamento! \n" +
 "Digite o preço inicial");
 precoinicial = Convert.ToDecimal(Console.ReadLine());

 Console.WriteLine("Agora digite o preço por hora");
 precoPorHora = Convert.ToDecimal(Console.ReadLine());
 Sistema es = new Sistema(precoinicial, precoPorHora);
 string opcao = string.Empty;
 bool exibirMenu = true;

 while(exibirMenu)
 {
    Console.Clear();
    Console.WriteLine("Digite a sua opcão");
    Console.WriteLine("1 - Cadastrar veiculo");
    Console.WriteLine("2 - Remover veiculo");
    Console.WriteLine("3 - Listar veiculo");
    Console.WriteLine("4 - Encerrar ");

    switch (Console.ReadLine())
    {
        case "1":
        es.AdicionarVeiculo();
        break;
        
        case "2":
        es.RemoverVeiculo();
        break;

        case "3":
        es.Listarveiculos();
        break;

        case "4":
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("Opção invalida");
        break;
    }

    {
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }

    Console.WriteLine("O programa se encerrou");
 }

