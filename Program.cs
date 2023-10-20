using c1;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace ManiHf
{
    class Program
    {
        static public WindowSettings c_windowSettings = new WindowSettings();
        static void Main(string[] args)
        {
            c_windowSettings.MethodWindow("Manihf| Github| WindowName");
            c_windowSettings.MethodWondowSizeDeform(false);
            Console.ReadKey();
        }
    }
}    
