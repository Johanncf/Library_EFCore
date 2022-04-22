namespace Biblioteca.Entities
{
    public class Author
    {
        public Author(int codigo, string nome, string sobrenome, ICollection<Book> livros)
        {
            Codigo = codigo;
            Nome = nome;
            Sobrenome = sobrenome;
            Livros = livros;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Book> Livros { get; set; }
    }
}