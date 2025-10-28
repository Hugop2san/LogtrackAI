using LogtrackAI.Domain.Entities;
using LogtrackAI.Domain.Entities.Enums;
using Microsoft.AspNetCore.Mvc;

namespace LogtrackAI.Domain.Interfaces
{
    public interface IEntregaRepository
    {

        // CRUD básico
        Task<IEnumerable<Entrega>> GetAllAsync();
        Task<Entrega?> GetByIdAsync(Guid id);

        Task AddAsync(Entrega entrega);
        Task UpdateAsync(object id, [FromBody] Entrega entrega);
        Task Delete(Guid id);                  

        // Consultas específicas de negócio
        Task<IEnumerable<Entrega>> ObterPorRotaAsync(Guid RotaID); //obter a rota que ele
        Task<IEnumerable<Entrega>> ObterPorStatusAsync(StatusEntrega status);
            
        // Ações de negócio
        //Task MarcarComoEntregueAsync(Guid entregaId);
        //Task MarcarComoDevolucaoAsync(Guid entregaId);
        //Task MarcarComoAusenteAsync(Guid entregaId, int tentativa);
 



    }
}

