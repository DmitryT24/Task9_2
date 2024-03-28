using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task9_2
{
    internal class Program
    {

        static public void DisplayUs(List<string> names)
        {
            Console.WriteLine("Отсортированный список:  ");
            foreach (string name in names)
            {
                Console.WriteLine($" {name}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            try
            {
                SortName sortName = new SortName();
                sortName.EventDisplay += DisplayUs;
                sortName.ClickUser();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
