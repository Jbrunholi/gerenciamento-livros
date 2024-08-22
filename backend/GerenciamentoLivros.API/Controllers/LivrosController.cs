using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GerenciamentoLivros.API.DTOs;
using GerenciamentoLivros.API.Models;
using GerenciamentoLivros.API.Repositories;

namespace GerenciamentoLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper _mapper;

        public LivrosController(ILivroRepository livroRepository, IMapper mapper)
        {
            _livroRepository = livroRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LivroDTO>>> GetLivros()
        {
            var livros = await _livroRepository.GetLivrosAsync();
            return Ok(_mapper.Map<IEnumerable<LivroDTO>>(livros));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LivroDTO>> GetLivro(int id)
        {
            var livro = await _livroRepository.GetLivroByIdAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<LivroDTO>(livro));
        }

        [HttpPost]
        public async Task<ActionResult<LivroDTO>> CreateLivro(LivroDTO livroDto)
        {
            var livro = _mapper.Map<Livro>(livroDto);
            await _livroRepository.AddLivroAsync(livro);
            return CreatedAtAction(nameof(GetLivro), new { id = livro.Id }, _mapper.Map<LivroDTO>(livro));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLivro(int id, LivroDTO livroDto)
        {
            if (id != livroDto.Id)
            {
                return BadRequest();
            }

            var livro = _mapper.Map<Livro>(livroDto);
            await _livroRepository.UpdateLivroAsync(livro);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLivro(int id)
        {
            await _livroRepository.DeleteLivroAsync(id);
            return NoContent();
        }
    }
}
