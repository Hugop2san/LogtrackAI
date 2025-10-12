using LogtrackAI.Domain.Entities;
using LogtrackAI.Domain.Entities.Enums;
using Microsoft.AspNetCore.Server.HttpSys;
using LogtrackAI.Domain.Entities.Enums;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;


namespace LogtrackAI.Domain.Entities
{
    public class Rota // LOCOMOÇÃO - "Ir do Ponto X ao Ponto Y"
    {
        // CADA SEGUIMENTO ENTRE PARADAS 
        public Guid Id { get; set; }
        public string Nome{ get; set; }
        public DateTime? DataCriacao { get; set; }
        public StatutsRota Status { get; set; }

        //Relcionamentos
        public Guid MotoristaId { get; set; }
        public Motorista Motorista { get; set; }

        //Lista de entregas nessa rota
        public List<Entrega> EntregasList { get; set; }

        // METODOS SIMPLES de Add nova entrega na rota
        public void AddEntrega(string endereco, string descricao)
        {

            var ordem = EntregasList.Count + 1;

            EntregasList.Add( new Entrega() {
                    Ordem = ordem,
                    Endereco = endereco,
                    Descricao = descricao,
                    Status = StatusEntrega.EmPreparacao,
             });
        }
        





    }
}
