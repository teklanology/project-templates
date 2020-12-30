using System;

namespace Tekla.Technology.Akit.UserScript
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Script.Run(akit);
        }

        static Tekla.Technology.Akit.IScript akit;
    }
}

namespace Tekla.Technology.Akit
{
    public class IScript
    {

    }
}