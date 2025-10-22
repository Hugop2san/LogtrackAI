using LogtrackAI.Domain.Entities;
using LogtrackAI.Domain.Entities.Enums;
using LogtrackAI.Domain.Interfaces;
using LogtrackAI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.EntityFrameworkCore;



namespace LogtrackAI.Infrastructure.Repositories
{
    public class EntregaRepository : IEntregaRepository
    {
        private readonly ApplicationDbContext _context;

        public EntregaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //CRUD BASICO
        public async Task<IEnumerable<Entrega>> GetAllAsync()
        {
            return await _context.ToListAsync();
        }

        public async Task<Entrega?> GetByIdAsync(Guid id)
        {
            return;
        }
        public async Task<Entrega?> GetByNameAsync(string nome)
        {
            return;
        }
        public async Task AddAsync(Entrega entrega)
        {
        }
        public async Task UpdateAsync(Entrega entrega)
        {
        }
        public async Task Delete(Guid id)
        {
        }

        // Consultas específicas de negócio
        public async Task<IEnumerable<Entrega?>> ObterPorRotaAsync(Guid RotaID) //obter a rota que ele
        {
            return;   
        }
        public async Task<IEnumerable<Entrega>> ObterPorStatusAsync(StatusEntrega status)
        {
            return;
        }

    }
}
