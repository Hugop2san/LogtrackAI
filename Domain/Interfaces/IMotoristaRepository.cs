using LogtrackAI.Domain.Entities;

namespace LogtrackAI.Domain.Interfaces
{
    public interface IMotoristaRepository
    {
        Task<IEnumerable<Motorista>> GetAll();
        Task<Motorista?> GetByIdAsync(Guid id);
        Task<Motorista?> GetByNameAsync(string nome);
        Task AddAsync(Motorista motorista);
        Task UpdateAsync(Motorista motorista);
        Task Delete(Guid id);


    }
}
