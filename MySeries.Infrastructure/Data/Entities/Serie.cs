using MySeries.Infrastructure.Data.EntityFramework.Entities;

namespace MySeries.Infrastructure.Data.Entities
{
    public class Serie : BaseEntity
    {
        private string _titulo, _descricao;
        private int _ano;


        public string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }

        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        public int Ano
        {
            get => _ano;
            set => _ano = value;
        }
    }
}