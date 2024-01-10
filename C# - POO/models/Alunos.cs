using CSharp.models;

namespace CSharpPOO.models
{
    public class Alunos : Pessoa
    {
        public Alunos()
        {

        }
        public Alunos(string _nome) : base(_nome)
        {

        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.Write($"Olá, meu nome é {nome}, tenho {idade} anos, e sou um aluno nota {Nota}");
        }
    }
}