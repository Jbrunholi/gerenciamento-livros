using Microsoft.EntityFrameworkCore;
using GerenciamentoLivros.API.Models;

namespace GerenciamentoLivros.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}