using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Objeto Auto utilizando herencia de un metodo de TRANSPORTE

            //Pasajeros - Velocidad - Llantas

            //Automovil SIN PLACA
            Console.WriteLine("Soy el automovil 1");
            Automovil miAuto = new Automovil(4, 200, 4, 4);
            miAuto.CambiarLlanta();
            miAuto.Frenar();



            //AUTOMOVIL CON PLACA
            Console.WriteLine("\n Soy el automovil 2");
            Automovil miAuto2 = new Automovil(4, 200, 4, 4, "CDMX2024");
            miAuto2.CambiarLlanta(2);
            miAuto2.Avanzar();
            // miAuto.MiMetodo();


            //USO DE LOS COSTRUCTORES VACIOS

            Console.WriteLine("\n Soy el transporte terrestre");
            Terrestre terrestre = new Terrestre();

            Terrestre terrestre2 = new Terrestre(4);
            // terrestre.MiMetodo();


            Console.ReadKey();

        }
    }
}
