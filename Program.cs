using Biblioteca.Context;

using (var contexto = new DataContext())
{
    contexto.Database.EnsureCreated();
}