using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    // Herencia: Clase Hijas de Terrestre
    public class Automovil : Terrestre
    {
        public int puertas = 0;

        public string placa;

        //Constructor Vacio
        public Automovil() { }

        //Sobrecarga de Constructores
        public Automovil(int pasajeros, int velocidadMaxima, int numeroLlantas, int puertas)
        {
            //atributos de la clase Transporte
            this.pasajeros = pasajeros;
            this.velocidadMaxima = velocidadMaxima;

            //atributos de la clase Terrestre
            this.numeroLlantas = numeroLlantas;

            //Atributos de la clase Automovil
            this.puertas = puertas;

        }

        public Automovil(int pasajeros, int velocidadMaxima, int numeroLlantas, int puertas, string placa)
        {
            this.pasajeros = pasajeros;
            this.velocidadMaxima = velocidadMaxima;

            //atributos de la clase Terrestre
            this.numeroLlantas = numeroLlantas;

            //Atributos de la clase Automovil
            this.puertas = puertas;
            this.placa = placa;
        }

        //METODOS

        public void CambiarLlanta(int numeroLlantas)
        {
            Console.WriteLine("Estoy cambiando las " + numeroLlantas + " llantas");
        }


        //Sobrecarga de Metodos
        public void CambiarLlanta()
        {
            Console.WriteLine("Estoy cambiando las llantas");
        }

        public override void Avanzar()
        {
            Console.WriteLine("Estoy avanzando desde la clase Automovil");
        }

    }
}
