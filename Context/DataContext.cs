//No contex nós podemos adicionar os mapeamentos das entidades
//Configurar a string de conexão
//Identificar os repositórios a serem criados (DbSet)

using Biblioteca.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Biblioteca.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Biblioteca;User Id=admin@meusite.com.br;Password=123456;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}