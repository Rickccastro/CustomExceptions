using System.Net.NetworkInformation;

namespace CustomExceptions;

public class FinanceException : Exception
{
    public int IdError { get; set; }
    public FinanceException(string mensagem): base(mensagem)
    {
            
    }
    public FinanceException(string mensagem, int idError):base(mensagem)
    {
        IdError = idError;
    }
}
