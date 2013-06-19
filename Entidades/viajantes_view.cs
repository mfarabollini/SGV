using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    using System;
    using System.Collections.Generic;

    public partial class viajantes_view
    {
        public int Cod_Viajante { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cod_Localidad { get; set; }
        public string Desc_Localidad { get; set; }
        public string Cod_Provincia { get; set; }
        public string Desc_Provincia { get; set; }
        public string CUIT { get; set; }
        public string Telefono { get; set; }
    }
}
