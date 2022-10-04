using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExoApi.Context;
using ExoApi.Models;
using ExoApi.Repositories;

namespace ExoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class _ProjectController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public _ProjectController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            try
            {
                return Ok(_projetoRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpPut("{Id}")]
        public IActionResult Editar (int id, Projetos projeto)
        {
            try
            {
                _projetoRepository.Editar(id, projeto);

                return StatusCode(204);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult Deletar (int id)
        {
            try
            {
                _projetoRepository.Deletar();

                return Ok("O Projeto foi deletado com sucesso!");
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
