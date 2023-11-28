using System.IO;
using System.Xml.Serialization;

namespace SerializableTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Smith", 21);
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            string fileName = "C:\\Users\\Divse\\Desktop\\Uni Imp Stuff\\YEAR 2\\COM326\\Week10\\SerializableTest/serialize.xml";

            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, person);
            writer.Close();

            FileStream fs = new FileStream(fileName, FileMode.Open);
            Person deserializedPerson = (Person)serializer.Deserialize(fs);
            Console.WriteLine(deserializedPerson.ToString());
            fs.Close();

        }
    }
}
