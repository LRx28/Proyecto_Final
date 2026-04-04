using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Model
{
    internal class Tour
    {
        public int TourID { get; set; }
        public required string NombreTour { get; set; }
        public int PaisID { get; set; }
        public int DestinoID { get; set; }
        public int Fecha { get; set; }
        public int Hora { get; set; }
        public decimal Precio { get; set; }
        public decimal Itbis { get; set; }
        public required string Duracion { get; set; }   
        public int fechaYHora { get; set; } 
        public required string Estado { get; set; }  









    }
}