using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciamentoLivros.API.Data;
using GerenciamentoLivros.API.Models;

namespace GerenciamentoLivros.API.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ApplicationDbContext _context;

        public LivroRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> GetLivrosAsync()
        {
            return await _context.Livros.ToListAsync();
        }

        public async Task<Livro> GetLivroByIdAsync(int id)
        {
            return await _context.Livros.FindAsync(id);
        }

        public async Task AddLivroAsync(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLivroAsync(Livro livro)
        {
            _context.Livros.Update(livro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLivroAsync(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
            }
        }
    }
}
