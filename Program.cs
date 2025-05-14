using GymManagmentSystem7.Data;
using System;
using System.Windows.Forms;

namespace GymManagmentSystem7
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
            new SuperAdminSeeder().SeedSuperAdmin();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainDashboard());
        }
    }
}