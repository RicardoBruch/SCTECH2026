Console.WriteLine("SheepLog");
Console.WriteLine("Digite a distância que será percorrida em KM:");
double distancia = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o peso da mercadoria em KG:");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite P para Premium e C para Comum:");
string tipoCliente = Console.ReadLine();

if (distancia > 0 && peso > 0 && (tipoCliente.ToUpper() == "P" || tipoCliente.ToUpper() == "C"))
{
    double freteBase = distancia * 1.5;
    double taxa = 0;

    if (tipoCliente.ToUpper() == "P" && peso > 200)
    {
        taxa = -0.15;
    }
    if (peso >= 100)
    {
        taxa += 0.12;
    }
    if (peso > 150 && distancia > 1000)
    {
        taxa += 0.08;
    }

    double frete = freteBase * (1 + taxa);

    Console.WriteLine($"Frete final: R${frete:F2}");

} else {
    Console.WriteLine("Entrada inválida. Certifique-se de que a distância e o peso sejam positivos e que o tipo seja 'P' ou 'C'.");
}
