using System.Text.Json.Serialization;

namespace miWeb;

public class Pais
{
    private string countryid;
    private double probability;

    [JsonPropertyName("country_id")]
    public string Countryid { get => countryid; set => countryid = value; }
    [JsonPropertyName("probability")]
    public double Probability { get => probability; set => probability = value; }
}

public class Persona
{
    private int count;
    private string name;
    private List<Pais> country;
    [JsonPropertyName("count")]
    public int Count { get => count; set => count = value; }
    [JsonPropertyName("name")]
    public string Name { get => name; set => name = value; }
    [JsonPropertyName("country")]
    public List<Pais> Country { get => country; set => country = value; }
}