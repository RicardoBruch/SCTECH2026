Console.WriteLine("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
int numero3 = int.Parse(Console.ReadLine());

int maior;

if (numero1 >= numero2 && numero1 >= numero3)
{
    maior = numero1;
}
else if (numero2 >= numero1 && numero2 >= numero3)
{
    maior = numero2;
}
else
{
    maior = numero3;
}

Console.WriteLine($"O maior número é: {maior}");
