namespace LogtrackAI.Domain.Entities
{
    public class Entrega    //AÇÃO - "Entregar pacote no Cliente A"
    {
        public int Id { get; set; }
        public int Ordem { get; set; } // 1° 2° 3°
        public Bases Destinatario { get; set; } // Agora o destinatario é a proxima entrega
        public string Status { get; set; } // Pendente, EmTransporte, Entregue (    MODELO DE CLASSIFICAÇÃO     )
        public DateTime? CriadoEm { get; set; }

        // Previsao especifica para esta entrega
        public Previsao PrevisaoEntrega { get; set; }   

        // Navegação
        public int JornadaTrabalhoId { get; set; }
        public JornadaTrabalho jornadaTrabalho { get; set; }


    }
}
