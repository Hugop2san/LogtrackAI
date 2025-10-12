using LogtrackAI.Domain.Entities.Enums;

namespace LogtrackAI.Domain.Entities
{
    public class Entrega                                //AÇÃO - "Entregar pacote no Cliente A"
    {
        public Guid Id { get; set; }
        public int Ordem { get; set; }                  // 1° 2° 3° ....
        public string Endereco { get; set; }            // Agora o destinatario é a proxima entrega
        public string Descricao { get; set; }           //Obs no geral
        public StatusEntrega Status { get; set; }       // Pendente, EmTransporte, Entregue (    MODELO DE CLASSIFICAÇÃO     )

        //Data e hora de quando foi enrtegue
        public DateTime? EntregueEm { get; set; }       

        // Relacionamento
        public Guid RotaID { get; set; }
        public Rota RotaObjeto { get; set; }


    }
}
