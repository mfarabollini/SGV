using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace AccesoADatos
    {
        using System;
        using System.Collections.Generic;

        public partial class clientes_view
        {
            public int Cod_Cliente { get; set; }
            public string razon_social { get; set; }
            public string direccion { get; set; }
            public string codigo_postal { get; set; }
            public string cod_localidad { get; set; }
            public string Cod_Viajante { get; set; }
            public string Cod_Zona { get; set; }
            public string CUIT { get; set; }
            public string contacto { get; set; }
            public string telefono { get; set; }
            public string Desc_Localidad { get; set; }
            public string Nombre { get; set; }
            public string Desc_Zona { get; set; }
        }
    }
