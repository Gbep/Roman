using System;
using System.IO;
using System.Text.Json;


public class data
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Ip { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime CreatedTime { get; set; }
    public Status status { get; set; }

    public enum Status
    {
        Done,
        New,
        InProgress
    }
}

public static class Program
{
    public static void Main(string[] args)
    {

        data Object = new data
        {
            Id = 1,
            Name = "Roman",
            City = "Chernivtsi",
            Ip = "192.168.0.1",
            PhoneNumber = "333-333-3333",
            CreatedTime = DateTime.Now,
            status = data.Status.New

        };
        [JsonProperty]
        string json = JsonSerializer.Serialize(Object);
        File.WriteAllText("myObject.json", json);


        json = File.ReadAllText("myObject.json");
        Object = JsonSerializer.Deserialize<data>(json);

        Console.WriteLine("Id: " + Object.Id);
        Console.WriteLine("Name: " + Object.Name);
        Console.WriteLine("City: " + Object.City);
        Console.WriteLine("IP: " + Object.Ip);
        Console.WriteLine("Phone number: " + Object.PhoneNumber);
        Console.WriteLine("Created time: " + Object.CreatedTime);
        Console.WriteLine("Status: " + Object.status);
        Console.ReadKey();
    }
 
}
