using System.Text.Json;

namespace _17._11._26_practic_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album();

            Console.WriteLine("Enter name  album:");
            album.NameAlbum = Console.ReadLine();

            Console.WriteLine("Enter name artist:");
            album.NameArtist = Console.ReadLine();

            Console.WriteLine("Enter release year:");
            album.Graduation = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter duration:");
            album.Time = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter release studio:");
            album.ReleaseStudio = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAlbum information:");
            Console.WriteLine(album);

            string filePath = "user.json";

            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonStr = JsonSerializer.Serialize(album, options);
            File.WriteAllText(filePath, jsonStr );

            if (File.Exists(filePath))
            {
                string readJson = File.ReadAllText(filePath);
                Album? restoredAlbum = JsonSerializer.Deserialize<Album?>(readJson);
                if (restoredAlbum != null)
                {
                    Console.WriteLine("Album is deserialized");
                    Console.WriteLine(restoredAlbum);
                }
            }
        }
    }
}
