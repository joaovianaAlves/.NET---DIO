namespace CSharp.models.models
{
    public class ContaCorrente : Conta
    {
        public override void creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}