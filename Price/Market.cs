using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Sarbaev.Price
{
    public class Market
    {
        public string Product { get; set; }
        public string MarketPlace { get; set; }
        public decimal Price { get; set; }
        public Market(string product, string marketplace, decimal price)
        {
            Product = product;
            MarketPlace = marketplace;
            Price = price;
        }
        public override string ToString()
        {
            return $"Магазин: {MarketPlace}\nПродукт: {Product}\nЦена: {Price}\n";
        }
    }
    
}
