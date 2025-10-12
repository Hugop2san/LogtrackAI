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

/*
   public class Entrega    //AÇÃO - "Entregar pacote no Cliente A"
    {
        public Guid Id { get; set; }
        public int Ordem { get; set; } // 1° 2° 3°
        public Base Destinatario { get; set; } // Agora o destinatario é a proxima entrega
        public string Status { get; set; } // Pendente, EmTransporte, Entregue (    MODELO DE CLASSIFICAÇÃO     )
        public DateTime? CriadoEm { get; set; }

        // Previsao especifica para esta entrega
        public Previsao PrevisaoEntrega { get; set; }   

        // Navegação
        public Guid JornadaTrabalhoId { get; set; }
        public JornadaTrabalho jornadaTrabalho { get; set; }


 */