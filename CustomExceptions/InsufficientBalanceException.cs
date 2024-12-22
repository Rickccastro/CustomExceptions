namespace CustomExceptions;

public class InsufficientBalanceException : FinanceException
{
    public decimal SaldoAtual { get; }
    public decimal ValorRequerido { get; }

    public InsufficientBalanceException(string mensagem) : base(mensagem)
    {

    } 
    public InsufficientBalanceException(string mensagem,int saldoAtual,int valorRequerido,int idError) : base(mensagem, idError)
    {
        SaldoAtual = saldoAtual;
        ValorRequerido = valorRequerido;
    }
}
