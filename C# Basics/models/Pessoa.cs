namespace Teste.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine(Nome + ", " + Idade + " anos");    
        }
    }
}