using MyGroup.DataAccess;
using MyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGroup.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataService = new UsersTableDataService();
            dataService.AddUser(new User
            {
                Name = "Ivan",
            });
            foreach (var user in dataService.GetAllUsers())
            {
                System.Console.WriteLine($"{user.Id}, {user.Name}");
            }
            System.Console.ReadLine();
        }
    }
}
