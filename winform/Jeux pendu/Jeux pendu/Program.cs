namespace Jeux_pendu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            ShowHangedMan.CheckFolder(Path.Combine(path + "/Jeux_pendu"));
            ShowHangedMan.CheckFolder(Path.Combine(path + "/Jeux_pendu/Player"));
            ShowHangedMan.CheckFolder(Path.Combine(path + "/Jeux_pendu/WordList"));
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}