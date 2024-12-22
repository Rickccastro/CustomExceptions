namespace CustomExceptions;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            var saldoContaBancaria = 1000;
            Console.WriteLine("Digite quanto você gostaria de sacar de sua conta:");
            var valorSacado = Convert.ToInt32(Console.ReadLine());

            Sacar(saldoContaBancaria, valorSacado);
        }

        catch (InsufficientBalanceException ex)
        {
            throw new InsufficientBalanceException($"ERROR TYPE InsufficientBalanceException, ERROR ID:{ex.IdError}, {ex.Message}");
        }
        catch (FinanceException ex)
        {
            throw new FinanceException($"ERROR TYPE FinanceException, ERROR ID: {ex.IdError}),{ex.Message},");
        }
        catch (Exception ex)
        {
            throw new Exception($"ERROR TYPE GENERIC: {ex.Message}");
        }
    }
    static void Sacar(int saldo, int valor)
    {
        if (saldo < valor)
        {
            throw new InsufficientBalanceException($"O saldo: {saldo} é menor que o Valor Requerido {valor}:", saldo, valor ,1001);
        }
        var novoSaldo = saldo - valor;

        Console.WriteLine($"Saque realizado com sucesso! seu saldo atual é {novoSaldo}");
    }
}
