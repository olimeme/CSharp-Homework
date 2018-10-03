using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arbuz
{
    public class Cart
    {
        private List<Goods> Good = new List<Goods>();
        private int SumOfAllGoods { get; set; }

        public Cart()
        {
        }

        public Cart(List<Goods> goods)
        {
            Good = goods;
        }

        public void AddToCart(Goods item)
        {
            Good.Add(item);
        }

        public void DeleteFromCart(int index)
        {
            if (Good.Capacity == 0)
                WriteLine("Корзина пуста!");
            Good.RemoveAt(index);
        }

        public void PrintInfo()
        {
            if (Good.Capacity == 0)
                WriteLine("Корзина пуста!");
            for (int i = 0; i < Good.Count; i++)
            {
                WriteLine("Название: " + Good[i].GetName());
                WriteLine("Цена: " + Good[i].GetPrice());
            }
        }

        public void ClearCart()
        {
            Good.Clear();
        }

        public int CalculateTheSumOfAllGoods()
        {
            int sum = 0;
            if (Good.Capacity == 0)
                WriteLine("Корзина пуста!");
            else
            {
                for (int i = 0; i < Good.Count; i++)
                    sum += Good[i].GetPrice();
            }
            return sum;
        }
    }
}
