using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Gato gato = new Gato();
            Pajaro pajaro = new Pajaro();
            perro.perr();
            gato.gat();
            pajaro.paj();
            Console.ReadKey();
        }
        public class Animal
        {
            public string nacimiento { get; set; }
            public string habitat { get; set; }
            public int edad { get; set; }
        }
        public class Perro : Animal
        {
            public string raza { get; set; }

            public Perro()
            {
                nacimiento = "viviparo";
                habitat = "terrestre";
                edad = 3;
                raza = "Bulldog";
            }

            public void perr()
            {
                Console.WriteLine($"Soy un perro, mi nacimiento es {nacimiento}, mi habitat es {habitat}, mi edad es {edad} y mi raza es {raza} .");
                
            }
        }
        public class Gato : Animal
        {
            public int vida { get; set; }

           public Gato()
           {
               nacimiento = "viviparo";
               habitat = "terrestre";
               edad = 2;
               vida = 9;
           }
            public void gat()
            {
                Console.WriteLine($"Soy un gato, mi nacimiento es {nacimiento}, mi habitat es {habitat}, mi edad es {edad} y estoy en mi {vida} vida.");
            }
        }

        public class Pajaro : Animal
        {
            public string color { get; set; }
            public Pajaro()
            {
                nacimiento = "oviparo";
                habitat = "aereo";
                edad = 1;
                color = "rojo";
            }
            public void paj()
            {
                Console.WriteLine($"Soy un pajaro, mi nacimiento es {nacimiento}, mi habitat es {habitat}, mi edad es {edad} y mi color es {color}.");
            }
        }
    }
}
