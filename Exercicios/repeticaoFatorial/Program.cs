
Console.WriteLine("Digite um número para calcular o fatorial: ");
int numero = int.Parse(Console.ReadLine());

int fatorial = 1;
for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}
Console.WriteLine($"O fatorial de {numero} é {fatorial}");

// Console.WriteLine("Digite um número para calcular o fatorial: ");
// int numero = int.Parse(Console.ReadLine());

// int fatorial = 1;
// int i = 1;

// while (i <= numero)
// {
//     fatorial *= i;
//     i++;
// }

// Console.WriteLine($"O fatorial de {numero} é {fatorial}");

// Console.WriteLine("Digite um número para calcular o fatorial: ");
// int numero = int.Parse(Console.ReadLine());

// int fatorial = 1;
// int i = 1;

// do
// {
//     fatorial *= i;
//     i++;
// } while (i <= numero);

// Console.WriteLine($"O fatorial de {numero} é {fatorial}");

