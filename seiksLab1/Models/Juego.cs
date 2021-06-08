using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace seiksLab1.Models
{
    public class Juego
    {
        public int ID { get; set; }
        public string NomJuego { get; set; }
        public double Precio { get; set; }
        public int Existencias { get; set; }
        public string Imagen { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}