namespace Biblioteca.Entities
{
    public class Book
    {
        public Book(int codigo, int codigoCategoria, int codigoAutor, string titulo, int anoPublicacao, Category categoria, Author autor)
        {
            Codigo = codigo;
            CodigoCategoria = codigoCategoria;
            CodigoAutor = codigoAutor;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Categoria = categoria;
            Autor = autor;
        }

        public int Codigo { get; set; }      
        public int CodigoCategoria { get; set; }
        public int CodigoAutor { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Category Categoria { get; set; }
        public Author Autor { get; set; }
    }
}