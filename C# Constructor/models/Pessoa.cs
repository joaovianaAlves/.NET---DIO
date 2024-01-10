namespace CsharpConstructor.models
{
    public class Pessoa
    {
        public Pessoa(string firstname, string lastname, int age)
        {
            this.age = age;
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        private string _name;
        private int _age;

        public string FirstName
        {
            get => _name;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome nao pode ser nulo");
                }
                _name = value;
            }
        }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}".ToUpper();

        public int age
        {
            get => _age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Idade nao pode ser menor que zero");
                }
                _age = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {FullName}, Idade:{age}");
        }
    }
}