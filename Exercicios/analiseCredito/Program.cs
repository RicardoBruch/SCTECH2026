Console.WriteLine("Digite a sua renda mensal: ");
double rendaMensal = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Você está negativado? (S/N)");
string negativado = Console.ReadLine();

if (idade > 18 && idade < 65)
{
    if (negativado.ToUpper() == "N")
    {
        if (rendaMensal >=3000)
        {
            if (rendaMensal >= 8000)
            {
                Console.WriteLine("Crédito aprovado!");
            }
            else
            {
                Console.WriteLine("Crédito em análise!");
            }
        }else
        {
            Console.WriteLine("Crédito negado!");
        }
    }else
    {
        Console.WriteLine("Crédito negado!");
    }
}else
{
Console.WriteLine("Crédito negado!");
}