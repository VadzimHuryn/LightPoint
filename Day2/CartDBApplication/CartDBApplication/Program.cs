using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartDBApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CartContext())
            {
                
                while (true)
                {
                    Console.WriteLine("\n1) Вывести все OrderItems для указанного Order \n2) Добавить OrderItems для указанного Order");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            GetOrderItems(context);
                            break;
                        case '2':
                            AddOrderItem(context);
                            break;
                        default:
                            Console.WriteLine("Введенное выражение не верно");
                            break;
                    }
                }
            }

        }
        static void GetOrderItems(CartContext context)
        {
            Console.WriteLine("\n Введите OrderId: ");
            int orderNum = Convert.ToInt32(Console.ReadLine());
            var orderItems = context.Order.ToList()[orderNum-1].OrderItem;
            decimal orderItemsSum = orderItems.Sum(e => e.UnitPrice);
            foreach (var n in orderItems)
            {
                Console.WriteLine(n.Id + ". "+ n.UnitPrice);
            }
            Console.WriteLine("Сумма OrderItems для Order с ID={0} равна {1}", orderNum, orderItemsSum);
        }
        static void AddOrderItem(CartContext context)
        {
            Console.WriteLine("\n Введите OrderId: ");
            int orderNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите UnitPrice: ");
            int unitPrice = Convert.ToInt32(Console.ReadLine());
            context.OrderItem.Add(new OrderItem { OrderId = orderNum, UnitPrice = unitPrice });
            context.SaveChanges();
        }
    }
}
