namespace Biblioteca.Entities
{
    public class Category
    {
        public Category(int codigo, string nome, ICollection<Book> livros)
        {
            Codigo = codigo;
            Nome = nome;
            Livros = livros;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public ICollection<Book> Livros { get; set; }
    }
}