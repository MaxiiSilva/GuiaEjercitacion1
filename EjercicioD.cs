using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion1_Maxi_Silva
{
    public class EjercicioD
    {
        // ============================================
        // SECCIÓN D — Pregunta 1
        // Respuesta: 
        /* public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Persona(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            public virtual void Saludar()
            {
                Console.WriteLine("Hola, soy " + Nombre + ", tengo " + Edad + " años.");
            }
        }

        public class Estudiante : Persona
        {
            public string Carrera { get; set; }

            public Estudiante(string nombre, int edad, string carrera) : base(nombre, edad)
            {
                Carrera = carrera;
            }

            public override void Saludar()
            {
                Console.WriteLine("Soy " + Nombre + ", estudiante de " + Carrera + ".");
            }
        }*/
        // ============================================
        // ============================================
        // SECCIÓN D — Pregunta 2
        // Respuesta:
        /*public interface ICalculable
        {
            double Calcular();
            string Descripcion();
        }

        public class Circulo : ICalculable
        {
            public double Radio { get; private set; }

            public Circulo(double radio)
            {
                Radio = radio;
            }

            public double Calcular()
            {
                return 3.14 * Radio * Radio;
            }

            public string Descripcion()
            {
                return "Círculo de radio " + Radio;
            }
        }
        ICalculable figura = new Circulo(5);
        Console.WriteLine(figura.Descripcion() + " Area: " + figura.Calcular());
        */
        // ============================================
    }
}
