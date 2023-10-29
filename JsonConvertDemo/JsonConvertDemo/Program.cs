using Newtonsoft.Json;
using System.Collections.Generic;
using System;


class JsonConverDemo {
    public class Shirt {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public List<string> Sizes { get; set; }
    }
    static void Main() {
        Shirt shirt1 = new Shirt {
            Name = "RedShirt",
            Created = new DateTime(2020, 01, 01),
            Sizes = new List<string> { "Small" }
        };
        string json1 = JsonConvert.SerializeObject(shirt1, Formatting.Indented);
        Console.WriteLine(json1);

        Shirt shirt2 = JsonConvert.DeserializeObject<Shirt>(json1);
        Console.WriteLine(shirt2.Name);
    }
}