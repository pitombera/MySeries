using System;
using System.Xml.Serialization;

namespace MySeries.Core.Entities
{
    public class Serie
    {
        private string _titulo, _descricao;
        private int _ano;

        public Serie(string titulo, string descricao, int ano)
        {
            _titulo = titulo;
            this._descricao = descricao;
            _ano = ano;
        }

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

        public override string ToString()
        {
            string retorno = "";
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            return retorno;
        }
    }
}