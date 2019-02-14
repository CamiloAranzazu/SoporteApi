using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Soporte.DTO
{
    public class DTOsop_auditoriacomponentes
    {
        public int id { get; set; }
        public string Opcion { get; set; }
        public string Proyecto { get; set; }
        public string Ruta { get; set; }
        public string EsquemaComponente { get; set; }
        public string NombreComponente { get; set; }
        public string TipoComponente { get; set; }
        public string Observacion { get; set; }
    }
}
