using DesafioSCBANK;

List<Cliente> clientes = new List<Cliente>{
    new Cliente("Ricardo", 25),
    new Cliente("Nádia", 32),
    new Cliente("Jade", 45)
};

string opcao;
int clienteLogado = -1;

void Login()
{
    Console.WriteLine("Bem vindo ao SCTechBank!");
    Console.WriteLine("Digite seu nome para continuar:");
    string nome = Console.ReadLine();
    for (int i = 0; i < clientes.Count; i++)
    {
        if (clientes[i].Nome == nome)
        {
            clienteLogado = i;
            return;
        }
    }
    Console.WriteLine("Cliente não encontrado.");
}

void Menu()
{
    Console.WriteLine($"Olá, {clientes[clienteLogado].Nome}!");
    Console.WriteLine("Escolha uma das opções abaixo para seguir:");
    Console.WriteLine("1 - Depositar.");
    Console.WriteLine("2 - Sacar.");
    Console.WriteLine("3 - Ver extrato.");
    Console.WriteLine("4 - Ver saldo.");
    Console.WriteLine("5 - Sair");
}
void FicarOuSair()
{
    Console.WriteLine("Deseja realizar outra operação? (S/N)");
    string resposta = Console.ReadLine();
    if (resposta.ToUpper() == "N")
    {
        Console.WriteLine("Obrigado por usar os serviços da SCTechBank");
        opcao = "5";
    }
}

Login();
do
{   
    Menu();
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o valor que deseja depositar:");
            clientes[clienteLogado].Depositar();
            FicarOuSair();
        break;
        case "2":
            Console.WriteLine("Digite o valor que deseja sacar:");
            clientes[clienteLogado].Sacar();
            FicarOuSair();
        break;
        case "3":
            Console.WriteLine("Segue extrato:");
            clientes[clienteLogado].VerExtrato();
            FicarOuSair();
        break;
        case "4":
            Console.WriteLine("Seu saldo atual é: R$" + clientes[clienteLogado].ExibirSaldo());
            FicarOuSair();
        break;
        case "5":
            Console.WriteLine("Obrigado por usar os serviços da SCTechBank");
        break;
    }
}while( opcao != "5");