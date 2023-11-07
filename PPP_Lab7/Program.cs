
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace PPP_Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User User1 = new(1, "Alice", "Cather", 25);
            User User2 = new(2, "Bob","Bracker" , 30);
            
            var ratingSystem = SerializeOrDeserialize.JsonDeserialize("output.json");

            Console.WriteLine(ratingSystem);

            ratingSystem.AddOrUpdateRating(User1, 5);

            SerializeOrDeserialize.JsonSerialize(ratingSystem, "output.json");

            SerializeOrDeserialize.XmlSerialize(ratingSystem, "output.xml");

            var ratingSystem1 = SerializeOrDeserialize.XmlDeserialize("output.xml");

            SerializeOrDeserialize.BinarySerialize(ratingSystem1, "output.bin");

            var ratingSystem2 = SerializeOrDeserialize.BinaryDeserialize("output.bin");
         
        }
    }
}