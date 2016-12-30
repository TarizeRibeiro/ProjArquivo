using Business;
using Business.Interfaces;
using Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ArquivoService : IArquivoService
    {
        public const string CAMINHO_ARQUIVO = "caminhoArquivo";

        public ArquivoService() : base()
        {
            _arquivoBusiness = new ArquivoBusiness(new ArquivoData());
        }

        IArquivoBusiness _arquivoBusiness;
        public ArquivoService(IArquivoBusiness arquivoBusiness)
        {
            _arquivoBusiness = arquivoBusiness;
        }

        /// <summary>
        /// Recupera o arquivo do caminho especificado no App.config (Service)
        /// </summary>
        public void RecuperarArquivo()
        {
            if (File.Exists(ConfigurationManager.AppSettings[CAMINHO_ARQUIVO]))
            {
                string[] linhas = File.ReadAllLines(ConfigurationManager.AppSettings[CAMINHO_ARQUIVO]);
                _arquivoBusiness.PopularArquivo(linhas);
            }
        }
    }
}
