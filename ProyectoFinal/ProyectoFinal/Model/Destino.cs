using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    public class Destino
    {
        public int DestinoID { get; set; }
        public required string NombreDestino { get; set; }   
        public int PaisId { get; set; }
        public int DuracionDias { get; set; }
        public int DuracionHora { get; set; }




    }
}
