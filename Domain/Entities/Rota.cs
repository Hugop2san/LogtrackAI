using LogtrackAI.Domain.Entities;
using LogtrackAI.Domain.Entities.Enums;
using LogtrackAI.Domain.Entities.Enums;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System.Linq;
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
                    StatusEnt = StatusEntrega.EmPreparacao,
                    EntregueEm = DateTime.MinValue
            });
        }
        public void IniciarRota() 
        {
            //quando iniciar a rotao status da rota é em andamento...
            Status = StatutsRota.RotaEmAndamento;

            //atualizar ao mesmo tempo cada entrega :
            foreach (var entrega in EntregasList.Where(x => x.StatusEnt == StatusEntrega.EmPreparacao))
            {
                entrega.StatusEnt = StatusEntrega.EmTransito  ;
            }
        }
        public void FinalizarRota()
        {
            var statusFinais = new[]
            {
                StatusEntrega.Entregue,
                StatusEntrega.Ausente1,
                StatusEntrega.Ausente2,
                StatusEntrega.Ausente3,
                StatusEntrega.Devoluacao
            };

            bool truefinalizados = EntregasList.All( x => statusFinais.Contains(x.StatusEnt) ) ;

            if (truefinalizados == true )
                //quando finalizr a rota status da rota é RotaFinalizada...
                Status = StatutsRota.RotaFinalizada;
        }


    }
}
