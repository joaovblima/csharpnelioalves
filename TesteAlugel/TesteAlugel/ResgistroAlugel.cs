

namespace TesteAlugel
{
    internal class RegistroAlugel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public RegistroAlugel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}

