using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Model
{
    public class Tour
    {
     
        public int TourID { get; set; }
        public required string NombreTour { get; set; }
        public int PaisID { get; set; }
        public int DestinoID { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Precio { get; set; }
        public decimal Itbis { get; set; }
        public required string Duracion { get; set; }   
        public DateTime fechaYHoraFin { get; set; } 
        public required string Estado { get; set; }

       
    }
}