using System.Diagnostics;

namespace CsharpConstructor.models
{
    public class Curso
    {
        public string nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QtdAlunos()
        {
            return Alunos.Count();
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {nome}");
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.FullName);
            // }
            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = $"N° {i + 1} - {Alunos[i].FullName}";
                Console.WriteLine(texto);
            }
        }
    }
}