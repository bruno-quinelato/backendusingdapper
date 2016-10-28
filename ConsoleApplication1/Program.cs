using Domain.Models;
using Domain.Repositories;
using Repository.Repositories;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruno.quinelato\Documents\Sample.mdf;Integrated Security=True;Connect Timeout=30";

        static void Main(string[] args)
        {
            IUserRepository userRepository;

            userRepository = new UserRepository(new System.Data.SqlClient.SqlConnection(ConnectionString));
            //var users = userRepository.GetAll();

            //foreach(var user in users)
            //{
            //    Console.WriteLine(user.ToString());
            //}
            var bruno = new User("Bruno Quinelato", "bquinelato@hotmail.com", "bruno", UserType.Admin);
            userRepository.Add(bruno);

            var mariana = new User("Mariana Albieri", "mahri_albieri@hotmail.com", "mariana", UserType.Customer);
            userRepository.Add(mariana);
        }
    }
}
