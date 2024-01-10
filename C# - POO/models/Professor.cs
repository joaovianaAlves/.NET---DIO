using CSharp.models;

namespace CSharpPOO.models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
        public Professor(string _nome) : base(_nome)
        {

        }

        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.Write($"Olá, meu nome é {nome}, tenho {idade} anos, sou professor e recebo: {Salario}");
        }
    }
}