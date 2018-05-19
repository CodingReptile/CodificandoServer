using System;

namespace CodificandoServer
{
    public class MainServer
    {
        public static void Main(string[] args)
        {
            var handler = new RequestHandler();

            try
            {
                handler.Initialize();
                handler.StartMainLoop();
            }
            catch (Exception e)
            {
                PrintError(e);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void PrintError(object obj)
        {
            ConsoleColor current = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(obj);
            Console.ForegroundColor = current;
        }
    }
}