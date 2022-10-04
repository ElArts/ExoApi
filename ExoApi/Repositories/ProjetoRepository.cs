using ExoApi.Context;
using ExoApi.Models;
using ExoApi.Controllers;
using Microsoft.EntityFrameworkCore.Query;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly SqlContext _context;
        public ProjetoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Projetos> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projetos BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public Projetos BuscarPorStatus(string? status)
        {
            return _context.Projetos.Find(status);
        }

        public Projetos BuscarPorArea(string? area)
        {
            return _context.Projetos.Find(area);
        }

        public void Editar (int id, Projetos projeto)
        {
            Projetos projetoBuscado = _context.Projetos.Find(id);

            if(projetoBuscado != null)
            {
                projetoBuscado.Titulo = projeto.Titulo;
                projetoBuscado.Status = projeto.Status;

                _context.SaveChanges();
            }
        }

        public void Deletar (int id, Projetos projetos)
        {
            Projetos projeto = _context.Projetos.Find(id);

            _context.Projetos.Remove(id);

            _context.SaveChanges();
        }
    }
}
