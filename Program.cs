using System;

namespace CsClasses
{
    public class Control
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("class :");
                string classname=Console.ReadLine();
                if (classname=="CustomOutput")RunCustomOutput();
                else if (classname=="quit")break;
            }
        }

        private static void RunCustomOutput()
        {
            Console.Write("text :");
            string text=Console.ReadLine();
            Console.Write("Color (green or red(default green)) :");
            string color=Console.ReadLine();
            Console.Write("Write mode (WriteLine or Write(default WriteLine)) :");
            string mode=Console.ReadLine();

            if(mode=="Write")CustomOutput.ColorWriteLine(text,color=="red"?ConsoleColor.Red:ConsoleColor.Green);
            else CustomOutput.ColorWrite(text,color=="green"?ConsoleColor.Red:ConsoleColor.Green);
        }
    }
}