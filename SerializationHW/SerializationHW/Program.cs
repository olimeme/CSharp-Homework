using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 задание
            Book book = new Book
            {
                Name = "Art of not giving a fuck",
                Price = 5000.99,
                Author = "Maison Myers",
                Year = DateTime.Now
            };

            BinaryFormatter formatter = new BinaryFormatter();
            if (!Directory.Exists(@"C:\data\file.bin"))
            {
                Directory.CreateDirectory(@"C:\data");
            }

            using (FileStream stream = File.Create(@"C:\data\file.bin"))
            {
                formatter.Serialize(stream, book);
            }

            //2 задание
            using (FileStream stream = File.OpenRead(@"C:\data\file.bin"))
            {
                var resultBook = formatter.Deserialize(stream) as Book;
            }

            //3 задание
            Type t = typeof(User);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (RoleInfoAttribute roleAttr in attrs)
            {
                Console.WriteLine(roleAttr.Name);
            }
            Console.ReadLine();
        }
    }
}
