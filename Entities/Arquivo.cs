using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("DADOS_ARQUIVO")]
    public class Arquivo : Base
    {
        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public bool Situacao { get; set; }
    }
}
