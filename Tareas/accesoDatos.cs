using System.Runtime.CompilerServices;
using System.Text.Json;
using Tarea;

public class AccesoDatos
{
    private static readonly HttpClient client = new HttpClient();
    public static async Task<List<Tareas>> GetTareas()
    {
        var url = "https://jsonplaceholder.typicode.com/todos/";
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        List<Tareas> listaTareas = JsonSerializer.Deserialize<List<Tareas>>(responseBody);
        return listaTareas;
    }   

    
}