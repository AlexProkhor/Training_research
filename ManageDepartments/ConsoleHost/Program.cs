using ConsoleHost.MenuItems;
using ManageDepartments.Data;
using System;
using System.Collections.Generic;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ContextFactory();
            using var context = factory.CreateDbContext(args);

            int index;
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("0 - выход");
                for (int i = 0; i < _menuItems.Count; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, _menuItems[i].Name);
                }
                Console.Write("Введите пункт меню: ");
                var menu = Console.ReadLine();

                if (!int.TryParse(menu, out index))
                    Console.WriteLine("Необходимо ввести номер пункта меню.");
                else
                {
                    if (index == 0)
                        break;
                    else if (index > _menuItems.Count)
                        Console.WriteLine("Нет такого пункта меню.");
                    else
                    {
                        index--;
                        Console.WriteLine();
                        Console.WriteLine("--------------------");
                        Console.WriteLine(_menuItems[index].Name);
                        Console.WriteLine("--------------------");
                        _menuItems[index].Execute(context);
                    }
                }

                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
        }

        private static List<IMenuItem> _menuItems = new List<IMenuItem>()
        {
            new BranchList(),
            new DepartmentList(),
        };
    }
}
