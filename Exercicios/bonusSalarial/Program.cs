Console.WriteLine("Digite o tempo de empresa: ");
int tempo = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o salário atual: ");
double salario = double.Parse(Console.ReadLine());

double bonus = 0;

if (tempo >= 5)
{
    bonus = 0.15;
}
else
{
    bonus = 0.05;
}

Console.WriteLine($"O bônus salarial é: {bonus}");
Console.WriteLine($"O salário final é: {salario + (salario * bonus)}");