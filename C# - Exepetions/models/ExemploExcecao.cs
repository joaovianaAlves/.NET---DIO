namespace CSharpExepetions.models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada. \n" + ex.StackTrace);
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            Metodo5();
        }
        public void Metodo5()
        {
            throw new Exception("Ocorreu uma execeção");
        }
    }
}