using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{
    class Program
    {
        public static bool IsValid<T>(T toCheck, params T[] arr)
        {
            foreach (T t in arr)
            {
                if (t.Equals(toCheck))
                    return true;
            }

            Console.WriteLine("Invalid input.");
            return false;
        }

        public static bool IsValid(int toCheck, int min)
        {
            if (toCheck < min)
                Console.WriteLine("Invalid input.");
            return toCheck > min;
        }

        public static void add()
        {
            Console.WriteLine("Please enter relative information.");
            Console.Write("Client name: ");
            string clientName = Console.ReadLine();
            Console.Write("Client Id: ");
            string clientId = Console.ReadLine();
            Console.Write("Number of types of goods: ");
            //check valid
            int goodsCount = Int32.Parse(Console.ReadLine());
            while (!IsValid(goodsCount, 0))
                goodsCount = Int32.Parse(Console.ReadLine());
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            for (int i = 0; i < goodsCount; i++)
            {
                Console.WriteLine("Goods " + i + ": ");
                Console.Write("Name: ");
                string goodsName = Console.ReadLine();
                Console.Write("Price: ");
                double goodsPrice = Double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int goodsQuantity = Int32.Parse(Console.ReadLine());
                Console.Write("Discount: ");
                double discount = Double.Parse(Console.ReadLine());
                orderDetails.Add(new OrderDetail(new Goods(goodsName, goodsPrice), goodsQuantity, discount));
            }

            OrderService.AddOrder(new Order(new Client(clientName, clientId), orderDetails.ToArray()));
        }

        public static void delete()
        {
            Console.Write("Please enter order id: ");
            int orderId = Int32.Parse(Console.ReadLine());
            OrderService.DeleteOrder(orderId);
        }

        public static void modify()
        {
            while(true)
            {
                Console.Write("Please enter order id: ");
                int orderId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Choose the info you want to modify: ");
                Console.WriteLine("1. Client\t2.Order details");
                int toModify = Int32.Parse(Console.ReadLine());
                if (!IsValid(toModify, 1, 2, 0)) 
                    continue;
                switch (toModify)
                {
                    //check valid
                    case 1:
                    {
                        Console.Write("Client name: ");
                        string clientName = Console.ReadLine();
                        Console.Write("Client Id: ");
                        string clientId = Console.ReadLine();
                        OrderService.ModifyOrder(orderId, new Client(clientName, clientId));
                        return;
                    }
                    case 2:
                    {
                        Console.Write("The number of order detail: ");
                        int num = Int32.Parse(Console.ReadLine());
                        //check valid
                        Console.Write("Goods name: ");
                        string goodsName = Console.ReadLine();
                        Console.Write("Goods price: ");
                        double goodsPrice = Double.Parse(Console.ReadLine());
                        Console.Write("Quantity: ");
                        int goodsQuantity = Int32.Parse(Console.ReadLine());
                        Console.Write("Discount: ");
                        double discount = Double.Parse(Console.ReadLine());
                        OrderService.ModifyOrder(orderId, num, new Goods(goodsName, goodsPrice), goodsQuantity,
                            discount);
                        return;
                    }
                    case 0:
                        return;
                }
            }
        }

        public static void check()
        {
            while (true)
            {
                Console.WriteLine("Check according to ");
                Console.WriteLine("1. Order id");
                Console.WriteLine("2. Goods name");
                Console.WriteLine("3. Client name");
                Console.WriteLine("4. Order price");
                int choice = Int32.Parse(Console.ReadLine());
                if(!IsValid(choice,1,2,3,4,0))
                    continue;
                switch (choice)
                {
                    
                    case 1:
                    {
                        Console.Write("Order id: ");
                        int id = Int32.Parse(Console.ReadLine());
                        IsValid(id, 0);
                        Console.WriteLine(OrderService.FindOrder(id).ToString());
                        return;
                    }
                    case 2:
                    {
                        Console.Write("Goods name: ");
                        string name = Console.ReadLine();
                        foreach (var order in OrderService.FindOrderByGoods(name))
                        {
                            Console.WriteLine(order.ToString());
                        }
                        return;
                    }
                    case 3:
                    {
                        Console.Write("Client name: ");
                        string name = Console.ReadLine();
                        foreach (var order in OrderService.FindOrderByClient(name))
                        {
                            Console.WriteLine(order.ToString());
                        }
                        return;
                    }
                    case 4:
                    {
                        Console.Write("Order Price: ");
                        double price = Double.Parse(Console.ReadLine());
                        IsValid((int) price, 0);
                        foreach (var order in OrderService.FindOrderByPrice(price))
                        {
                            Console.WriteLine(order.ToString());
                        }
                        return;
                    }
                    case 0:
                        return;
                }
            }
            
        }
        
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Welcome to order management system.");
                Console.WriteLine("1. Add new order");
                Console.WriteLine("2. Delete order");
                Console.WriteLine("3. Modify order");
                Console.WriteLine("4. Check order");
                Console.WriteLine("Enter 0 to end the program.");
                int choice = Int32.Parse(Console.ReadLine());
                if (!IsValid(choice, 0, 1, 2, 3, 4))
                    continue;
                switch (choice)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        delete();
                        break;
                    case 3:
                        modify();
                        break;
                    case 4:
                        check();
                        break;
                    case 0:
                        Console.WriteLine("Thanks for using!");
                        return;
                }
            }
        }
    }
}