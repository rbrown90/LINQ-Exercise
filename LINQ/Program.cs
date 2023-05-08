using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myVideogames = new List<string>() { "Nanobreaker", "RE4", "Devil May Cry 5", "Metal Gear Solid", "Final Fantasy 7" };

            var orderVideogames = myVideogames.OrderBy(name => name.Length);

            foreach (var game in orderVideogames)
            {
                Console.WriteLine(game);
            }
        }

    }
}
