Console.WriteLine("Digite a primeira nota: ");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
double n3 = double.Parse(Console.ReadLine());

double media = (n1 + n2 + n3) / 3;

Console.WriteLine($"A média das notas é: {media:F2}");