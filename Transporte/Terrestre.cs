using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    // Herencia: Clase Hijas de Transporte

    public class Terrestre : Transporte
    {
        public int numeroLlantas = 0;

        //Constructor Vacio
        public Terrestre() { }

        //Sobrecarga de constructores
        public Terrestre(int numeroLlantas) { }

        private void MiMetodo()
        {
            Console.WriteLine("Estoy usando mi metodo protected");
        }
    }
}
