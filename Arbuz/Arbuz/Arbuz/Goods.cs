using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Arbuz
{
    public class Goods
    {
        private Categories Category { get; set; }
        private string Name { get; set; }
        private int Price { get; set; }

        public Goods()
        {

        }

        public Goods(Categories categories,string name, int price)
        {
            Price = price;
            Category = categories;
            Name = name;
        }

        public Categories GetCategories()
        {
            return Category;
        }

        public void SetCategories(Categories categories)
        {
            Category = categories;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public int GetPrice()
        {
            return Price;
        }

        public void SetPrice(int price)
        {
            Price = price;
        }

        public void PrintInfo()
        {
                WriteLine("Название: " + Name);
                WriteLine("Цена: " + Price);
        }
    }
}
