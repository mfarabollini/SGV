using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

//----------------------------------------------------------//
// Acceso a la tabla Zona. 
//---------------------------------------------------------//
namespace AccesoADatos
{

    public class Zona_Todas
    {
        // Recupera todas las zonas de la base de datos
        public static List<zonas> CargarZonas()
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                return bd.zonas.ToList();
            }
        }

        // Crear una Zona
        public static zonas CrearZona(zonas zon)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                zonas zona = new zonas();
                zona.Cod_Zona = zon.Cod_Zona;
                zona.Desc_Zona = zon.Desc_Zona;
                bd.zonas.Add(zona);
                bd.SaveChanges();

            }
            return zon;
        }

        // Actualizar una Zona
        public static zonas ActualizarZona(zonas zon)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                // Realiza la actualización a la tabla
                var query = (from n in bd.zonas
                             where n.Cod_Zona == zon.Cod_Zona
                             select n).Single();

                query.Cod_Zona = zon.Cod_Zona;
                query.Desc_Zona = zon.Desc_Zona;

                bd.SaveChanges();

                return zon;
            }   
        }
        // Borrar una Zona
        public static zonas BorrarZona(zonas zon)
        {
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                zonas zona = new zonas();

                bd.zonas.Attach(zon);
                bd.zonas.Remove(zon);
                bd.SaveChanges();
            }
            return zon;
        }

        // Control que exista una Zona
        public static bool Existe(zonas zon)
        { 
            using (ChequeEntidades bd = new ChequeEntidades())
            {
                var query = (from z in bd.zonas where z.Cod_Zona == zon.Cod_Zona select z).Count();
                if (query == 0)
                    return false;
                else
                {
                    return true;
                }                
            }   
        }
    }
}