using System.Text.Json;


// Serializar un objeto a Json
var luise1 = new People() { Name = "Luis Arrieta", Age = 27 };
string json = JsonSerializer.Serialize(luise1);
Console.WriteLine(json); // {"Name":"Luis Arrieta","Age":27}

// Deserializar un Json a objeto
string luiseJson = "{\"Name\":\"Luis Arrieta\",\"Age\":27}";
People? luise2 = JsonSerializer.Deserialize<People>(luiseJson);
Console.WriteLine($"{luise2?.Name} tiene {luise2?.Age} años"); // Luis Arrieta tiene 27 años

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}