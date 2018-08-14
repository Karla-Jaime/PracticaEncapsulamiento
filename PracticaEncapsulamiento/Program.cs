using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de contacto
            Contacto contactoUno = new Contacto();

            contactoUno.Nombre = 
                "Maria Antonieta de las Nieves";
            contactoUno.Direccion =
                "Bahía de Kino 1211";
            contactoUno.CorreoElectronico = 
                "chilindrina-lentitos@el-chavo.com";
            contactoUno.TelefonoCasa = 
                "4-35-78-15";
            contactoUno.TelefonoCelular = 
                "64418517889";

            Console.WriteLine("Nombre: " + contactoUno.Nombre);
            Console.WriteLine("Dirección: " + contactoUno.Direccion);
            Console.WriteLine("Correo: " + contactoUno.CorreoElectronico );
            Console.WriteLine("Telefono de Casa: " + contactoUno.TelefonoCasa);
            Console.WriteLine("Telefono Celular: " + contactoUno.TelefonoCelular);

            Console.ReadLine();
        }
    }
}
