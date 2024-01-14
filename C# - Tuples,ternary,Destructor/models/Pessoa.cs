namespace CSharpTuples.models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string Name, string LastName)
        {
            name = Name;
            lastName = LastName;
        }

        public void Deconstruct(out string _name, out string _lastname)
        {
            _name = name;
            _lastname = lastName;
        }

        private string _name;
        private string _lastName;

        public string name
        {
            get => _name.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("name atribute cant be empty");
                }
            }
        }

        public string lastName
        {
            get => _lastName.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("lastname atribute cant be empty");
                }
            }
        }
    }
}