using banko.Class;

bool MostrarTela = true;
List<Conta> listaDeContas = new List<Conta>();

while (MostrarTela)
{
    Conta minhaConta = PossuiConta(listaDeContas);
    Console.WriteLine("1 - Mostrar saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Transfeir");
    Console.WriteLine("5 - Fechar programa");
    string opicao = Console.ReadLine();
    switch (opicao)
    {
        case "1":
            minhaConta.MostrarSaldo();
            break;
        case "2":
            minhaConta.Depositar();
            break;
        case "3":
            Console.WriteLine("Digite o valor que será sacado");
            minhaConta.Sacar();
            break;
        case "4":
            minhaConta.Transferir();
            break;
        case "5":
            MostrarTela = false;
            break;
        default:
            Console.WriteLine("Opcao invalida!");
            break;
    }
}

static void CriarConta(List<Conta> listaDeContas)
{
    Console.WriteLine("Digite o seu nome");
    string nome = Console.ReadLine();

    Console.WriteLine("Deposite um valor");
    double saldo = double.Parse(Console.ReadLine());

    Conta minhaConta = new Conta(nome: nome, saldo: saldo, credito: 5000, TipoDeConta.PessoaFisica);
    listaDeContas.Add(minhaConta);
}

static void PegarConta(List<Conta> listaDeContas)
{
    Console.WriteLine("Digite o seu nome");
    string client = Console.ReadLine();
    for (int i = 0; i < listaDeContas.Count(); i++)
    {
        Conta Cliente = listaDeContas[i];
        if (Cliente.ConferirNome(client))
        {
            Conta minhaConta = listaDeContas[i];
        }
    }
}

static Conta PossuiConta(List<Conta> listaDeContas)
{
    Conta minhaConta = new Conta();
    Console.WriteLine("Possui conta? Yes/No");
    string possuiConta = Console.ReadLine();
    if (possuiConta == "yes".ToLower())
    {
        PegarConta(listaDeContas);
    }
    else
    {
        CriarConta(listaDeContas);
    }
    return minhaConta;
}