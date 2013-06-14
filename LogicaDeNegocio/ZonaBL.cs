using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;   // Clase Acceso a Datos
using Entidades;      // Clase Entidades

// ----------------------------------------------------------------//
// Capa de Negocios: Llamadas a las clases definidas en Entidades.

namespace LogicaDeNegocio
{
    public class ZonaBL
    {
        
        // Recupera todas las Zonas existentes.        
        public static List<zonas> CargarZonas()
        {
            return Zona_Todas.CargarZonas();
        }
    
        // Crear nueva Zona
        public static zonas Guardar(zonas zon)
        {
            return Zona_Todas.CrearZona(zon);
        }

        // Actualizar Zona
        public static zonas ActualizarZona(zonas zon)
        {
            return Zona_Todas.ActualizarZona(zon);
        }

        // Borrar zona
        public static zonas BorrarZona(zonas zon)
        {
            return Zona_Todas.BorrarZona(zon);
        }

        // Control si existe la Zona
        public static bool Existe(zonas zon)
        {
            if (Zona_Todas.Existe(zon))
                return true;
            else
                return false;
        }
    } // public class ZonaBl
}
