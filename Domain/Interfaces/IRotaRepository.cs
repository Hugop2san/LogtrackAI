using LogtrackAI.Domain.Entities;
using LogtrackAI.Domain.Entities.Enums;

namespace LogtrackAI.Domain.Interfaces
{
    public interface IRotaRepository
    {
        // CRUD básico
        Task<IEnumerable<Rota>> GetAllAsync();
        Task<Rota?> GetByIdAsync(Guid id);
        Task<Rota?> GetByNameAsync(string nome);
        Task AddAsync(Rota rota);
        Task UpdateAsync(Rota rota);
        Task DeleteAsync(Guid id);

        // Consultas específicas de negócio
        Task<IEnumerable<Rota>> ObterPorMotoristaAsync(Guid motoristaId);
        Task<IEnumerable<Rota>> ObterPorStatusAsync(StatutsRota status);

        // Consultas de apoio (não de domínio)
        Task<IEnumerable<Rota>> ObterRotasComEntregasAsync();
    }
}
