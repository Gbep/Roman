using System;
using System.IO;
using System.Text.Json;


public class MyObject
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
    public static void Main()
    {
        
        MyObject myObject = new MyObject
        {
            Id = 1,
            Name = "Roman",
            City = "Chernivtsi",
            Ip = "192.168.0.1",
            PhoneNumber = "333-333-3333",
            CreatedTime = DateTime.Now,
            status = MyObject.Status.New

        };

        string json = JsonSerializer.Serialize(myObject);
        File.WriteAllText("myObject.json", json);


        json = File.ReadAllText("myObject.json");
         myObject = JsonSerializer.Deserialize<MyObject>(json);

        Console.WriteLine("Id: " + myObject.Id);
        Console.WriteLine("Name: " + myObject.Name);
        Console.WriteLine("City: " + myObject.City);
        Console.WriteLine("IP: " + myObject.Ip);
        Console.WriteLine("Phone number: " + myObject.PhoneNumber);
        Console.WriteLine("Created time: " + myObject.CreatedTime);
        Console.WriteLine("Status: " + myObject.status);
        Console.ReadKey();
       
    }
}
