namespace LogtrackAI.Domain.Entities
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        //private string _ano;
        public string Ano {
            get;
            set 
            {
                if (value?.Length >= 5)
                    throw new ArgumentException(" Campo ano, apenas 4 caractres.");
            }
        }


    }
}
