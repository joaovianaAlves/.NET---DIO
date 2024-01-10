namespace CSharp.models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void creditar(decimal valor);

        public void exibirSaldo()
        {
            Console.WriteLine(saldo);
        }
    }
}