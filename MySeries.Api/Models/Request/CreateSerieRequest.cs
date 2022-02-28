namespace MySeries.Api.Models.Request
{
    public class CreateSerieRequest
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
    }
}