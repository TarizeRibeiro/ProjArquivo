using Business.Interfaces;
using Data.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business
{
    public class ArquivoBusiness : IArquivoBusiness
    {
        IArquivoData _arquivoData;
        public ArquivoBusiness(IArquivoData arquivoData)
        {
            _arquivoData = arquivoData;
        }

        public void PopularArquivo(string[] linhas)
        {
            List<Arquivo> arquivos = new List<Arquivo>();
            foreach (var linha in linhas)
            {
                var tamanhoStauts = linha.Length - 40;

                Arquivo arq = new Arquivo()
                {
                    Codigo = Convert.ToInt32(linha.Substring(0, 2).Trim()),
                    Data = Convert.ToDateTime(string.Format("{0}/{1}/{2}", linha.Substring(2, 2), linha.Substring(4, 2), linha.Substring(6, 4))),
                    Descricao = linha.Substring(10, 30).Trim(),
                    Situacao = Convert.ToBoolean(linha.Substring(40, tamanhoStauts).Trim())
                };
                arquivos.Add(arq);
            }
            this.SalvarArquivo(arquivos);
        }

        public void SalvarArquivo(List<Arquivo> lista)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    foreach (var item in lista)
                    {
                        _arquivoData.SalvarDadosArquivo(item);
                    }
                    trans.Complete();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
