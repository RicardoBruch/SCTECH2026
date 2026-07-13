Console.WriteLine("Digite o peso (em kg): ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura (em metros): ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine($"O IMC é: {imc:F2}");