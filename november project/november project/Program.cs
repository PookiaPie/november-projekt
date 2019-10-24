using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ett matlagningsspel där man har en viss summa att spendera, och ska välja ingredienser att lägga i en gryta. Sedan finns det en jury som gillar olika ingredienser.//

            Människor Spelaren = new Människor();       //skapade en karaktär

            List<Ingridiens> Muffin = new List<Ingridiens>();       //listan till receptet

            Console.WriteLine("Välkommen till matlagnings memori!!!");
            Console.WriteLine("Välj 1 utav 4 olika recept som du vill laga och sen se ifall du kan komma ihåg receptet");

            Ingridiens i1 = new Smör();
            Spelaren.Pengar -= i1.cost;

            Muffin.Add(i1);



        }
    }
}
