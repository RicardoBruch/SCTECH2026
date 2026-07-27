/// Exercicio de agora receber nomes e preencher na lista ate que o usuario digite sair, quando digitar sair deve mostrar todos os nomes que foram preenchidos

List<string> nomes = new List<string>();

while (true)        
{
    Console.WriteLine("Digite um nome ou 'sair' para encerrar o programa:");
    string nome = Console.ReadLine();

    if (nome == "sair")
    {
        break;
    }

    nomes.Add(nome);
}

Console.WriteLine("Nomes digitados:");

foreach (string nome in nomes)
{
    Console.WriteLine("- " + nome);
}

