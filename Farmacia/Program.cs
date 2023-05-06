namespace Farmacia
{
    internal static class Program
    {
       public static  string nivel;
       public static  string usuario;
        public static string cpf;
        public static int id;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

       
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new loguin());
          
        }
       
    }
}