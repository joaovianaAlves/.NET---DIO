namespace CSharp
.models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string _nome)
        {
            nome = _nome;
        }

        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }
    }
}