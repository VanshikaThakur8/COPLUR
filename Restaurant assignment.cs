using System;
using System.Collections.Generic;

namespace Restaurant_Management_System
{
    abstract class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Display();
    }

    class FoodItem : MenuItem
    {
        public FoodItem(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine("Food: " + Name + "  Price: " + Price);
        }
    }

    class DrinkItem : MenuItem
    {
        public DrinkItem(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine("Drink: " + Name + "  Price: " + Price);
        }
    }

    class Restaurant
    {
        public List<MenuItem> menuItems;

        public Restaurant()
        {
            menuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem item)
        {
            menuItems.Add(item);
        }

        public void RemoveMenuItem(string itemName)
        {
            foreach (var item in menuItems)
            {
                if (item.Name.ToLower() == itemName.ToLower())
                {
                    menuItems.Remove(item);
                    Console.WriteLine("Item " + itemName + " is removed.");
                    Console.WriteLine("-------------------------------------------------------------");
                    return;
                }
            }
            Console.WriteLine("Item not found");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("The Menu Items are:");

            Console.WriteLine("-------------------------------------------------------------");
            foreach (var item in menuItems)
            {
                item.Display();
            }
            Console.WriteLine("-------------------------------------------------------------");
        }

        public double CalculateTotalOrderCost(List<MenuItem> orderItems)
        {
            double totalCost = 0;
            foreach (var item in orderItems)
            {
                totalCost += item.Price;
            }
            return totalCost;
        }
    }

    class Program
    {
        static void Main()
        {
            Restaurant restaurant = new Restaurant();

            restaurant.AddMenuItem(new FoodItem("Pizza", 249));
            restaurant.AddMenuItem(new FoodItem("Burger", 99));
            restaurant.AddMenuItem(new FoodItem("Fries", 49));
            restaurant.AddMenuItem(new FoodItem("Momos", 149));
            restaurant.AddMenuItem(new FoodItem("Hot Dog", 80));
            restaurant.AddMenuItem(new DrinkItem("Sprite", 40));
            restaurant.AddMenuItem(new DrinkItem("Coolberg", 120));
            restaurant.AddMenuItem(new DrinkItem("Coco Cola", 40));
            restaurant.AddMenuItem(new DrinkItem("beer", 259));
            restaurant.AddMenuItem(new DrinkItem("Vodka", 549));

            restaurant.DisplayMenu();

            Console.WriteLine("Enter the item name to remove:");
            string itemName = Console.ReadLine();
            restaurant.RemoveMenuItem(itemName);

            restaurant.DisplayMenu();

            Console.WriteLine("Enter the items to order:");
            string orderItemsStr = Console.ReadLine();
            string[] orderItemsArr = orderItemsStr.Split(',');
            List<MenuItem> orderItems = new List<MenuItem>();
            foreach (string item in orderItemsArr)
            {
                foreach (var menuItem in restaurant.menuItems)
                {
                    if (menuItem.Name.ToLower() == item.Trim().ToLower())
                    {
                        orderItems.Add(menuItem);
                        break;
                    }
                }
            }

            double totalCost = restaurant.CalculateTotalOrderCost(orderItems);
            Console.WriteLine("Total Cost of Order in rupees: " + totalCost);
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}