namespace LogtrackAI.Domain.Entities
{
    public class Rota
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double DistanciaKm { get; set; }

        // Comportamento
        public double CalcularDistancia()
        {
            // Exemplo de lógica simulada ou integração com serviço externo
            return DistanciaKm > 0 ? DistanciaKm : 10.0;
        }
    }
}
