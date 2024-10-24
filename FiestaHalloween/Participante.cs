using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiestaHalloween
{
    //Clase del cliente o participante para el registro de sus datos como atributos
    internal class Participante
    {
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string contrasena {  get; set; }
        public string disfraz {  get; set; }
        public string fotoDisfraz {  get; set; }
    }
}
