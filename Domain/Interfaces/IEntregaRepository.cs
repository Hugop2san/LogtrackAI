using LogtrackAI.Domain.Entities;

namespace LogtrackAI.Domain.Interfaces
{
    public interface IEntregaRepository
    {
        Task<IEnumerable<Entrega>> GetAll();
        Task<Entrega?> GetByIdAsync(Guid id);
        Task<Entrega?> GetByNameAsync(string nome);
        Task AddAsync(Entrega entrega);
        Task UpdateAsync(Entrega entrega);
        Task Delete(Guid id);


    }
}

