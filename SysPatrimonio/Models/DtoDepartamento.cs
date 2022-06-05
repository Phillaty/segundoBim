using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SysPatrimonio.Models
{
    public class DtoDepartamento
    {
        public int id { get; set; }
        public string nomedepartamento { get; set; }
        public string descricaodepartamento { get; set; }

        public int idlocal { get; set; }
        public string nomelocal { get; set; }
    }
}
