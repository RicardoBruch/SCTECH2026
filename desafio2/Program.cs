Console.WriteLine("Digite um numero inteiro para saber se ele é multiplo de 5: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 5 == 0)
{
    Console.WriteLine("O número é múltiplo de 5.");
}
else
{
    Console.WriteLine("O número não é múltiplo de 5.");
}
