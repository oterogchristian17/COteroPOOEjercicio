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
            Console.WriteLine("Soy el automovil 1");
            Automovil miAuto = new Automovil(4, 200, 4, 4);
            miAuto.CambiarLlanta();
            miAuto.Avanzar();




            Console.WriteLine("\n Soy el automovil 2");
            Automovil miAuto2 = new Automovil(4, 200, 4, 4, "CDMX2024");
            miAuto2.CambiarLlanta(2);
            miAuto.Avanzar();



            Console.ReadKey();  

        }
    }
}
