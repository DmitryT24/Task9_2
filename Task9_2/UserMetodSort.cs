using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_2
{
    internal class SortName
    {
        public List<string> names = new List<string> { "Васин", "Ахматова", "Голубев", "Янкин", "Пыхтин" };

        public delegate void SortEventDisplay(List<string> names);
        public event SortEventDisplay EventDisplay;

        public void ClickUser()
        {
            try
            {
                UserSort();
                EventDisplay(names);
            }
            catch (CheckDataInputExp checkExp)
            {
                Console.WriteLine(checkExp.Message);
            }
            finally
            {
                Console.WriteLine("Программа выполнилась.");
            }

        }

        public void UserSort()
        {

            int sortNum;
            Console.WriteLine("Представлены следующие имена:  ");
            foreach (string name in names)
            {
                Console.Write($" {name} ");
            }
            Console.WriteLine("");
            Console.WriteLine("Для сортировки по возрастанию (А-Я)  введите - 1");
            Console.WriteLine("Для сортировки по убыванию    (Я-А)  введите - 2");
            Console.Write("Ваш ввод:");

            if (int.TryParse(Console.ReadLine(), out sortNum))
            {
                switch (sortNum)
                {
                    case 1:
                        names.Sort(delegate (string x, string y)
                        {
                            if (x == null && y == null) return 0;
                            else if (x == null) return -1;
                            else if (y == null) return 1;
                            else return x.CompareTo(y);
                        });

                        break;
                    case 2:
                        names.Sort(delegate (string y, string x)
                        {
                            if (x == null && y == null) return 0;
                            else if (x == null) return -1;
                            else if (y == null) return 1;
                            else return x.CompareTo(y);
                        });
                        break;
                    default:
                        throw new CheckDataInputExp("Ошибка! Вы указали неверное число! ");
                }
            }
            else
            {
                throw new CheckDataInputExp("Ошибка! Вы указали не число! ");
            }


        }
    }
}
