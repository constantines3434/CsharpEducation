using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialization
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
    }
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        
        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public void ByteSerialize(ref Person obj)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("C:\\VS Projects\\Serialization\\test\\Serialization.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, obj);
                Console.WriteLine("Бинарная сериализация: ");
                fs.Close();
            }

            using (FileStream fs = new FileStream("C:\\VS Projects\\Serialization\\test\\Serialization.dat", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)binaryFormatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newPerson.Id} --- Возраст: {newPerson.Name}");
            }
        }

        public void SerializeJSON( Person obj)
        {
            Console.WriteLine("Сериализация в JSON:");
            string fileName = "C:\\VS Projects\\Serialization\\test\\Serilization.json";
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, jsonString);
            //Console.WriteLine(File.ReadAllText(fileName));


            string jsonStr = File.ReadAllText(fileName);
            Person? person =
                JsonSerializer.Deserialize<Person>(jsonStr);

            Console.WriteLine($"Id: {person.Id} \n" +
                $"Name {person.Name } ");
            //string fileName = "C:\\VS Projects\\Serialization\\test\\Serilization.json";
            //using FileStream createStream = File.Create(fileName);
            //await JsonSerializer.SerializeAsync(createStream, obj);
            //await createStream.DisposeAsync();
        }

        public static void Main(string[] args)
        {
            //Person human = new Person(1, "Constantine");
            //human.SerializeJSON(human);
            //   human.ByteSerialize(ref human);

            IEnumerable<int> ProduceSquares()
            {
                for (int i = 0; ; i += 1)
                {
                    yield return i * i;
                }
            }

            foreach (int i in ProduceSquares())
            {
                Console.WriteLine(i);
            }
            // Output: 0 2 4 6 8
        }

    }
}
