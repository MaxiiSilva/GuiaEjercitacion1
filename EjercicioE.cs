using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GuiaEjercitacion1_Maxi_Silva
{
    public class EjercicioE
    {
    
    }
    abstract class Animal
    {
        public string Nombre { get; }
        public string Especie { get; }

        public Animal(string nombre, string especie)
        {
            Nombre = nombre;
            Especie = especie;
        }

        public abstract void Hablar();

        public virtual string Descripcion()
        {
            return $"{Nombre} es un {Especie}";
        }
    }
    interface IVacunable
    {
        bool EstaVacunado { get; }
        void Vacunar(string vacuna);
    }
    interface IEntrenable
    {
        int NivelEntrenamiento { get; }
        void Entrenar(string ejercicio);
    }
    class Perro : Animal, IVacunable, IEntrenable
    {
        public bool EstaVacunado { get; private set; }
        public int NivelEntrenamiento { get; private set; }

        public Perro(string nombre) : base(nombre, "Perro")
        {
            EstaVacunado = false;
            NivelEntrenamiento = 0;
        }

        public override void Hablar()
        {
            Console.WriteLine($"{Nombre} dice: GUAU");
        }

        public override string Descripcion()
        {
            return base.Descripcion() + $" --- Vacunado: {EstaVacunado} --- Nivel: {NivelEntrenamiento}";
        }

        public void Vacunar(string vacuna)
        {
            EstaVacunado = true;
            Console.WriteLine($"{Nombre} fue vacunado contra la {vacuna}");
        }

        public void Entrenar(string ejercicio)
        {
            NivelEntrenamiento++;
            Console.WriteLine($"{Nombre} entreno: {ejercicio}");
        }
    }
    class Gato : Animal, IVacunable
    {
        public bool EstaVacunado { get; private set; }

        public Gato(string nombre) : base(nombre, "Gato")
        {
            EstaVacunado = false;
        }

        public override void Hablar()
        {
            Console.WriteLine($"{Nombre} dice: MIAU");
        }

        public override string Descripcion()
        {
            return base.Descripcion() + $" --- Vacunado: {EstaVacunado}";
        }

        public void Vacunar(string vacuna)
        {
            EstaVacunado = true;
            Console.WriteLine($"{Nombre} fue vacunado contra la {vacuna}");
        }
    }
    class Veterinaria
    {
        private List<Animal> animales = new List<Animal>();

        public void AgregarAnimal(Animal a)
        {
            animales.Add(a);
        }

        public void MostrarPacientes()
        {
            Console.WriteLine("=== Pacientes ===");
            foreach (var a in animales)
            {
                Console.WriteLine(a.Descripcion());
                a.Hablar();
            }
        }

        public void VacunarTodos(string vacuna)
        {
            foreach (var a in animales)
            {
                if (a is IVacunable vacunable)
                {
                    vacunable.Vacunar(vacuna);
                }
            }
        }
    }
}
