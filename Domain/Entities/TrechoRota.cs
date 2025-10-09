using LogtrackAI.Domain.Entities;
using Microsoft.AspNetCore.Server.HttpSys;


namespace LogtrackAI.Domain.Entities
{
    public class TrechoRota // LOCOMOÇÃO - "Ir do Ponto X ao Ponto Y"
    {
        // CADA SEGUIMENTO ENTRE PARADAS 
        public int Id { get; set; }
        public int Ordem { get; set; } // 1° 2° 3°
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double DistanciaKm { get; set; }
        public TimeSpan TempoEstimaddo { get; set;  }
        public Previsao Previsao { get; set; }

        // NAVEGAÇÃO
        public int JornadaTrabalhoId { get; set; }
        public JornadaTrabalho jornadaTrabalho { get; set; }





    }
}
