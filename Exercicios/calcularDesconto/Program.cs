Console.WriteLine("Digite o valor do produto: ");
double valor = double.Parse(Console.ReadLine());

double desconto = 0;

if (valor >= 500)
{
    desconto = 0.20;
} 
else if (valor > 200 && valor < 500)
{
    desconto = 0.10;
}
else if (valor < 200)
{
    desconto = 0;
}

Console.WriteLine($"você ganhou: {desconto * 100}% de desconto");
Console.WriteLine($"O valor final do produto é: {valor - (valor * desconto)}");