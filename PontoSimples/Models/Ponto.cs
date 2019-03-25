using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models
{
    public class Ponto
    {
        public int IdPonto { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataMarcacao { get; set; }
        public DateTime MarcacaoEntrada { get; set; }
        public DateTime MarcacaoSaida { get; set; }
        public DateTime MarcacaoIniAlmoco { get; set; }
        public DateTime MarcacaoFimAlmoco { get; set; }

        public Ponto()
        {
        }

        public Ponto(int idPonto, Funcionario funcionario, DateTime dataMarcacao, DateTime marcacaoEntrada, DateTime marcacaoSaida, DateTime marcacaoIniAlmoco, DateTime marcacaoFimAlmoco)
        {
            IdPonto = idPonto;
            Funcionario = funcionario;
            DataMarcacao = dataMarcacao;
            MarcacaoEntrada = marcacaoEntrada;
            MarcacaoSaida = marcacaoSaida;
            MarcacaoIniAlmoco = marcacaoIniAlmoco;
            MarcacaoFimAlmoco = marcacaoFimAlmoco;
        }

        public Ponto(Funcionario funcionario, DateTime dataMarcacao, DateTime marcacaoEntrada, DateTime marcacaoSaida, DateTime marcacaoIniAlmoco, DateTime marcacaoFimAlmoco)
        {
            Funcionario = funcionario;
            DataMarcacao = dataMarcacao;
            MarcacaoEntrada = marcacaoEntrada;
            MarcacaoSaida = marcacaoSaida;
            MarcacaoIniAlmoco = marcacaoIniAlmoco;
            MarcacaoFimAlmoco = marcacaoFimAlmoco;
        }
    }
}
