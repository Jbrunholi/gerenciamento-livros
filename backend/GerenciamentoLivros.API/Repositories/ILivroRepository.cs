using System.Collections.Generic;
using System.Threading.Tasks;
using GerenciamentoLivros.API.Models;

namespace GerenciamentoLivros.API.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> GetLivrosAsync();
        Task<Livro> GetLivroByIdAsync(int id);
        Task AddLivroAsync(Livro livro);
        Task UpdateLivroAsync(Livro livro);
        Task DeleteLivroAsync(int id);
    }
}

