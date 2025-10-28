using LogtrackAI.Domain.Entities;
using LogtrackAI.Domain.Entities.Enums;
using LogtrackAI.Domain.Interfaces;
using LogtrackAI.Infrastructure.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.Extensions.Hosting;



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
            return await _context.EntregaDB.ToListAsync();
        }

        public async Task<Entrega?> GetByIdAsync(Guid id)
        {
            var entrega = await _context.EntregaDB
                .Include( y => y.RotaObjeto )
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entrega == null)
                throw new Exception("Entrega nao encontrada.");

            return entrega;
        }

        public async Task AddAsync(Entrega entrega)
        {
            _context.EntregaDB.Add(entrega);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(object id, [FromBody] Entrega atualizaEntrega )
        {
            // RECEBENDO O ID DA ENREGA DECLARO COMO OBJECT E PARA REALIZAR A COMPARAÇÃO UTILIZEI EQUALS E GETHAHCODE
            var entregaget = await _context.EntregaDB.FirstOrDefaultAsync(x => x.Id.Equals(id) );

            //TRATAMENTO 
            if (entregaget == null)
                throw new Exception("Entega nao encontrada para atualização!");

            entregaget.Ordem    = atualizaEntrega.Ordem ;
            entregaget.Endereco = atualizaEntrega.Endereco ;
            entregaget.Descricao= atualizaEntrega.Descricao ;
            entregaget.StatusEnt = atualizaEntrega.StatusEnt;

            await _context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            var entregaremove = await _context.EntregaDB.FirstOrDefaultAsync(x => x.Id.Equals(id));

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
