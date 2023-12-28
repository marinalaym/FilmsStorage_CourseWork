using FilmsStorage.Forms.Users;

namespace FilmsStorage
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Authorization());
        }
    }
}