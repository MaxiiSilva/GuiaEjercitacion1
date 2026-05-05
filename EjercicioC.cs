using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercitacion1_Maxi_Silva
{
    public class EjercicioC
    {
        // ============================================
        // SECCIÓN C — Pregunta 1
        // Respuesta: El error es que no usa el override.
        // correción: public override double Calcular(){return Ancho * Alto;}
        // ============================================
        // ============================================
        // SECCIÓN C — Pregunta 2
        // Respuesta: El error es que saldo esta declarado como privado lo cual la subclase no puede accerder.
        // // Una de las correciones seria: public decimal Saldo {get; protected set;}
        // ============================================
        // ============================================
        // SECCIÓN C — Pregunta 3
        // Respuesta: El error que tiene es que no agrego todos los metodos de la interface por eso no compila el codigo.
        /*class Documento : IGuardable
        {
        public string Titulo { get; private set; }
        private bool guardado;

        public Documento(string titulo) { Titulo = titulo; }

        public void Guardar()
        {
            guardado = true;
            Console.WriteLine(Titulo + " guardado.");
        }

        public void Cargar()
        {
            Console.WriteLine(Titulo + " cargado.");
        }

        public bool EstaGuardado()
        {
            return guardado;
        }
        }*/
        // ============================================



}
}
