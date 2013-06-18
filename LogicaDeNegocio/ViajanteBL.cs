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
        // Obtener el último ID
        public static viajantes Obtener_Id(viajantes viaj)
        {
            return ViajanteDAL.Obtener_Id(viaj);
        }
    }
}
