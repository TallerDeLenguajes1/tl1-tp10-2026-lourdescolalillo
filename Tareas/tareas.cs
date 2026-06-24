using System.Text.Json.Serialization;

namespace Tarea;

public class Tareas
{
    private int userId;
    private int id;
    private string title;
    private bool completed;

    [JsonPropertyName("userId")]
    public int UserId { get => userId; set => userId = value; }
    [JsonPropertyName("id")]
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("title")]
    public string Title { get => title; set => title = value; }
    [JsonPropertyName("completed")]
    public bool Completed { get => completed; set => completed = value; }
}