using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Contacto
    {
        //Auto propertires
        //Cuando se declara una variable utilizando properties usar mayuscular para el nombre de la variable
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string TelefonoCasa { get; set; }
        public string CorreoElectronico { get; set; }

        //Properties
        private string _telefonoCelular;// Variable de respaldo (se usa el _ para identificarlo como tal)
        public string TelefonoCelular
        {
            get {
                return _telefonoCelular;
            }
            set{
                if (value.Length == 10)
                {
                    _telefonoCelular = value;
                }
                else if (value.Length == 7)
                {
                    _telefonoCelular = "644" + value;
                }
                else
                {
                    Console.WriteLine("Introduce un número de celular válido");
                }
            }
        } 
    }
}
