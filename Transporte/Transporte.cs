using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Transporte
    {
        public int velocidadMaxima = 0;

        public int pasajeros = 0;

        public string Marca;

        public string Motor;

        //Constructor Vacio
        public Transporte()
        {

        }

        public virtual void Avanzar()
        {
            Console.WriteLine("Estoy avanzando");
        }

        public virtual void Frenar()
        {
            Console.WriteLine("Estoy frenando");
        }



    }
}

