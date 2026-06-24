using System.Runtime.CompilerServices;
using Tarea;

class Program
{
    static async Task Main()
    {
        List<Tareas> lista = await AccesoDatos.GetTareas();
        Console.WriteLine("\n====LISTADO DE TAREAS====");
        Console.WriteLine("====TAREAS PENDIENTES====");
        foreach (var tar in lista)
        {
            if (tar.Completed == false)
            {
                Console.WriteLine($"TITULO: {tar.Title}");
                Console.WriteLine($"ESTADO: PENDIENTE");
                Console.WriteLine("-----------------");
            }

        }

        Console.WriteLine("====TAREAS COMPLETADAS====");
        foreach (var tar in lista)
        {
            if (tar.Completed == true)
            {
                Console.WriteLine($"TITULO: {tar.Title}");
                Console.WriteLine($"ESTADO: COMPLETADA");
                Console.WriteLine("-----------------");
            }
        }
        AccesoDatos.ReporteTareas(lista);
    }
}
