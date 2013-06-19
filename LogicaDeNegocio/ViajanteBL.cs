using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoADatos;

namespace LogicaDeNegocio
{
    public class ViajanteBL
    {
        // Cargar todos los viajantes
        public static List<viajantes> Cargar_Viajantes()
        {
            return ViajanteDAL.Cargar_Viajantes();
        }

        // Cargar Viajante
        public static viajantes Alta_Viajante(viajantes Viaj)
        {
            return ViajanteDAL.Alta_Viajante(Viaj);
        }


    }
}
