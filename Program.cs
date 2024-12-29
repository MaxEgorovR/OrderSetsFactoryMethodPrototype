using System;

namespace OrderSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderSet festiveSet = new OrderSet(2,3,1);
            Console.WriteLine(festiveSet);
            var officeSet = festiveSet.Clone();
            Console.WriteLine(officeSet);
            officeSet.Burger = 0;
            Console.WriteLine(festiveSet);
            Console.WriteLine(officeSet);
        }
    }

    public interface IClonePrototype<T>
    {
        T Clone();
    }

    public class OrderSet : IClonePrototype<OrderSet>
    {
        public int Sushi { get; set; }
        public int Burger { get; set; }
        public int Pizza { get; set; }

        public string Weapon { get; set; }
        public OrderSet(int sushi, int burger, int pizza)
        {
            Sushi = sushi;
            Burger = burger;
            Pizza = pizza;
        }
        public OrderSet Clone()
        {
            return (OrderSet)MemberwiseClone();
        }

        public override string ToString()
        {
            string result = $"";
            if (Sushi > 0)
            {
                result += $"Sushi: {Sushi}\n";
            }
            if (Burger > 0)
            {
                result += $"Burger: {Burger}\n";
            }
            if (Pizza > 0) {
                result += $"Pizza: {Pizza}\n";
            }
            return result;
        }
    }
}
