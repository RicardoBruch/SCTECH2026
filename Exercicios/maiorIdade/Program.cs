Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 18)
{
    Console.WriteLine("Você é menor de idade.");
}
else if (idade > 65)
{
    Console.WriteLine("Você é idoso.");
}
else
{
    Console.WriteLine("Você é maior de idade.");
}