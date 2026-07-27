
namespace DesafioSCBANK
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        private double Saldo { get; set; }
        private int NumeroCartao { get; set; }
        public List<string> Movimentacoes { get; set; }
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            NumeroCartao = new Random().Next(1000, 9999);
            Movimentacoes = new List<string>();
        }
    
    public void Depositar()
    {
        int valorDeposito = Convert.ToInt32(Console.ReadLine());

        if (valorDeposito <= 0)
        {
        Console.WriteLine("Valor inválido.");
        return;
        }

        Saldo+=valorDeposito;
        Console.WriteLine($"Depósito de R${valorDeposito} realizado com sucesso!");
        Movimentacoes.Add($"{DateTime.Now} - Depósito de R${valorDeposito}");
    }

    public void Sacar()
    {
        int valorSaque = Convert.ToInt32(Console.ReadLine());
        if (valorSaque <= Saldo)
        {
            Saldo-=valorSaque;
            Console.WriteLine($"Saque de R${valorSaque} realizado com sucesso!");
            Movimentacoes.Add($"{DateTime.Now} - Saque de R${valorSaque}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
    }
    public double ExibirSaldo()
        {
            return Saldo;
        }
    public void VerExtrato()
        {
        foreach (var item in Movimentacoes)
        {
            Console.WriteLine($"Movimentações do cartão {NumeroCartao}:");
            Console.WriteLine(item);
        }
        Console.WriteLine($"Saldo atual: R${Saldo}");
        }
    }
}