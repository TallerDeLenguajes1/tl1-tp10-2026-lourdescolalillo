using System.Net;
using System.Reflection.Metadata;
using System.Text.Json;
using Usuario;
public class AccesoDatos
{
    private static readonly HttpClient client = new HttpClient();
    public static async Task<List<Usuarios>> GetUsuarios()
    {
        var url = "https://jsonplaceholder.typicode.com/users/";
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        List<Usuarios> listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(responseBody);
        return listaUsuarios;
    }
}