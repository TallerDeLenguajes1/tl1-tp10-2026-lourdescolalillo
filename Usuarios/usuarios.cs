using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Usuario;

public class Usuarios
{
    private int id;
    private string name;
    private string email;
    private Domicilio address;

    [JsonPropertyName("id")]
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("name")]
    public string Name { get => name; set => name = value; }
    [JsonPropertyName("email")]
    public string Email { get => email; set => email = value; }
    [JsonPropertyName("address")]
    public Domicilio Address { get => address; set => address = value; }
}

public class Domicilio
{
    private string street;
    private string city;

    [JsonPropertyName("street")]
    public string Street { get => street; set => street = value; }
    [JsonPropertyName("city")]
    public string City { get => city; set => city = value; }
}