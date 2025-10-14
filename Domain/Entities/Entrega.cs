using LogtrackAI.Domain.Entities.Enums;

namespace LogtrackAI.Domain.Entities
{
    public class Entrega                                //AÇÃO - "Entregar pacote no Cliente A"
    {
        public Guid Id { get; set; }
        public int Ordem { get; set; }                  // 1° 2° 3° ....
        public string Endereco { get; set; }            // Agora o destinatario é a proxima entrega
        public string Descricao { get; set; }           //Obs no geral
        public StatusEntrega StatusEnt { get; set; } = StatusEntrega.EmPreparacao;      // Pendente, EmTransporte, Entregue (    MODELO DE CLASSIFICAÇÃO     )

        //  Data e hora de quando foi enrtegue
        public DateTime? EntregueEm { get; set; }       

        //  Relacionamento
        public Guid RotaID { get; set; }
        public Rota RotaObjeto { get; set; }

        //  Metodos Simples
        public void EntregaEntregue() 
        {
            if( !(StatusEnt == StatusEntrega.EmPreparacao) )
                StatusEnt = StatusEntrega.Entregue;
                EntregueEm = DateTime.MinValue;

        }
        public void EntregaDevoluacao()
        {
            StatusEnt = StatusEntrega.Devoluacao;
            EntregueEm = DateTime.MinValue;
        }
        public void EntregaAusente1()
        {
            StatusEnt = StatusEntrega.Ausente1;
            EntregueEm = DateTime.MinValue;
        }
        public void EntregaAusente2()
        {
            StatusEnt = StatusEntrega.Ausente2;
            EntregueEm = DateTime.MinValue;
        }
        public void EntregaAusente3()
        {
            StatusEnt = StatusEntrega.Ausente3;
            EntregueEm = DateTime.MinValue;
        }






    }
}
