using System.Runtime.CompilerServices;

namespace Checkers
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
            Form checkerForm = new Form2();
            Application.Run(checkerForm);
        }
    }
} 