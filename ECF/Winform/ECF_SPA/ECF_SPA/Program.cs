using ECF_SPA.Models;
using Microsoft.EntityFrameworkCore;

namespace ECF_SPA
{
    internal static class Program
    {
        private static Chat chatSQL;
        private static SpaContext context;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            context = new SpaContext();
            context.Chats.Load();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                chatSQL = context.Chats.First();
            }
            catch (InvalidOperationException)
            {
                chatSQL = null;
            }
            Application.Run(new FormChat(chatSQL,context));
        }
    }
}