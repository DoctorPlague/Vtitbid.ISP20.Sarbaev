using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Sarbaev.Route
{
    public  class Route
    {
        public string? Start{ get; set; }
        public string? Finish { get; set; }
        public int Number { get; set; }
        public Route(string? start, string? finish, int number)
        {
            Start = start;
            Finish = finish;
            Number = number;
        }
        public override string ToString()
        {
            return $"Маршрут №{Number}: {Start} - {Finish}\n";
        }
    }
}
