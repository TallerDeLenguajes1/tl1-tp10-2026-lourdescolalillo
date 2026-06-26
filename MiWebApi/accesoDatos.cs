using System.Runtime.CompilerServices;
using System.Text.Json;
namespace miWeb;

public class AccesoDatos
{
    private static readonly HttpClient client = new HttpClient();
    public static async Task<Persona> GetPersona()
    {
        var url = "https://api.nationalize.io?name=nathaniel";
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Persona datosPersona = JsonSerializer.Deserialize<Persona>(responseBody);
        return datosPersona;
    }

    public static void ReportePersona(Persona datosOriginales)
    {
        string jsonString = JsonSerializer.Serialize(datosOriginales);
        File.WriteAllText("datosPersona.json", jsonString);
        Console.WriteLine("archivo creado con exito");
    }
}