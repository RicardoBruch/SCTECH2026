Console.WriteLine("Digite o número para saber se ele é ímpar ou par: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par.");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar.");
}