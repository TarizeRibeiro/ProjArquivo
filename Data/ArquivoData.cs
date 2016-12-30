using Data.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ArquivoData : BaseData<Arquivo>, IArquivoData
    {
        public void SalvarDadosArquivo(Arquivo arquivo)
        {            
            Salvar(arquivo);
            Commit();
        }
    }
}
