using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Sarbaev.Route
{
    static public class RouteAction
    {
        public static void Inicialise(List<Route> routes, int counter)
        {
            int i = 0;
            while (i< counter)
            {
                Console.WriteLine("№" +(i + 1));
                Console.WriteLine("Введите название начального пункта маршрута");
                string? start = Console.ReadLine();
                Console.WriteLine("Введите название конечного пункта маршрута");
                string? end = Console.ReadLine();
                Console.WriteLine("Введите номер маршрута");
                if (!Int32.TryParse(Console.ReadLine(), out int number) || number < 0 || String.IsNullOrEmpty(end) || String.IsNullOrEmpty(start))
                {
                    PaintAsError("Некорректные даннные");
                    continue;
                }
                else if (CheckForMatches(routes, number))
                {
                    PaintAsError("Маршрут с таким номером уже существует");
                    continue;
                }
                routes.Add(new Route(start, end, number));
                i++;
            }
        }
        public static void RouteSort(List<Route> routes)
        {
            for (int i = 0; i < routes.Count; i++)
            {
                for (int j = 0; j < routes.Count - 1; j++)
                {
                    if (routes[i].Number < routes[j].Number)
                    {
                        Route empty = routes[i];
                        routes[i] = routes[j];
                        routes[j] = empty;
                    }
                }
            }
        }
        private static bool CheckForMatches(List<Route> routes, int number)
        {
            bool checker = false;
            for (int i = 0; i < routes.Count; i++)
            {
                if (routes[i].Number == number)
                {
                    checker = true;
                }
            }
            return checker;
        }
        public static void RouteFind(List<Route> routes)
        {
            Console.WriteLine("Введите номер маршрута длля поиска");
            bool checker = false;
            if (!Int32.TryParse(Console.ReadLine(),out int number))
            {
                PaintAsError("Некорректные даннные");
            }
            Console.WriteLine("---------------------");
            for (int i = 0; i < routes.Count; i++)
            {
                if (routes[i].Number == number)
                {
                    Console.WriteLine(routes[i]);
                    checker = true;
                }
            }
            if (!checker)
            {
                Console.WriteLine("Таких маршрутов нет");
            }
            Console.WriteLine("---------------------");
        }
        public static void GetInfo(List<Route> routes)
        {
            Console.WriteLine("Список всех маршрутов: \n");
            for (int i = 0; i < routes.Count; i++)
            {
                Console.WriteLine(routes[i]);
            }
        }
        static private void PaintAsError(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
