using EventManagementSystem.Screens;
using EventManagementSystem.Utilities;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // create database connection
            using ConnectionFactory connectionFactory = new ConnectionFactory();

            // creates database if it does not exist
            connectionFactory.Database.EnsureCreated();

            Application.Run(new Login());
        }
    }
}