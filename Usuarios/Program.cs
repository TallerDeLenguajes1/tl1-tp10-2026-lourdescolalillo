using Usuario;
class Program
{
    static async Task Main()
    {
        List<Usuarios> lista = await AccesoDatos.GetUsuarios();
        Console.WriteLine("=====PRIMEROS 5 USUARIOS=====");
        for (int i = 0; i < 5; i++)
        {
            if (i < lista.Count)
            {
                Usuarios u = lista[i];
                Console.WriteLine($"\nUsuario nro: {i + 1}");
                Console.WriteLine($"Nombre: {u.Name}");
                Console.WriteLine($"Correo: {u.Email}");
                Console.WriteLine($"Domicilio: {u.Address.Street}, Ciudad {u.Address.City}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}
