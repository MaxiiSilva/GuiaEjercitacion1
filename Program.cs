namespace GuiaEjercitacion1_Maxi_Silva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veterinaria vet = new Veterinaria();

            Perro p1 = new Perro("Osito");
            Gato g1 = new Gato("Garfield");

            vet.AgregarAnimal(p1);
            vet.AgregarAnimal(g1);

            vet.MostrarPacientes();

            Console.WriteLine("--- Vacunando ---");
            vet.VacunarTodos("Rabia");

            Console.WriteLine("--- Entrenando perro ---");
            p1.Entrenar("Saltar");

            Console.WriteLine("--- Estado final ---");
            vet.MostrarPacientes();
        }
    }
}
