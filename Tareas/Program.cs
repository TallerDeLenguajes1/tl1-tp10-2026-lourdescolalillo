using System.Runtime.CompilerServices;
using Tarea;

class Program
{
    static async Task Main()
    {
        await AccesoDatos.GetTareas();
    }
}
