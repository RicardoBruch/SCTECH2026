Console.WriteLine("Diga a temperatura em Celsius: ");
double temperatura = double.Parse(Console.ReadLine());

double fahrenheit = (temperatura * 9 / 5) + 32;

Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit:F2}");