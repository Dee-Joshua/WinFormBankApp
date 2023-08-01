using Microsoft.Extensions.Configuration;

namespace WinFormBankApp
{
    public static class Program
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
            Application.Run(new Form1());
        }
    }
}


//// Build the configuration using appsettings.json
//var config = new ConfigurationBuilder()
//    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//    .Build();

//// Get the connection string from appsettings.json
//var connectionString = config.GetConnectionString("Default");

//// Setup the DbContextOptions using the connection string
//var options = new DbContextOptionsBuilder<AppDbContext>()
//    .UseSqlServer(connectionString)
//    .Options;

//Application.EnableVisualStyles();
//Application.SetCompatibleTextRenderingDefault(false);

//// Pass the options to the MainForm constructor
//Application.Run(new MainForm(options));