namespace miWeb;

class Program
{
    static async Task Main()
    {
        Persona p = await AccesoDatos.GetPersona();
        Console.WriteLine("====PREDICCION DE NACIONALIDAD====");
        Console.WriteLine($"Nombre: {p.Name}");
        Console.WriteLine($"Cantidad de personas con este nombre: {p.Count}");
        Console.WriteLine("\nPaises con mayor probabilidad");
        foreach (var pais in p.Country)
        {
            double porcentaje = pais.Probability * 100;
            Console.WriteLine($"id del pais: {pais.Countryid} | Probabilidad del {porcentaje} %");
        }
        AccesoDatos.ReportePersona(p);

    }
}
