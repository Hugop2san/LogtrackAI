using LogtrackAI.Domain.Entities;

namespace LogtrackAI.Domain.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<IEnumerable<Veiculo>> GetAll();
        Task<Veiculo?> GetByIdAsync(Guid id);
        Task<Veiculo?> GetByNameAsync(string marca);
        Task AddAsync(Veiculo veiculo);
        Task UpdateAsync(Veiculo veiculo);
        Task Delete(Guid id);
    }
}
