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
                else if (classname=="CommandRunner")RunCommandRunner();
                else if (classname=="quit")break;
                Console.WriteLine();
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

            if(mode=="Write")CustomOutput.ColorWrite(text,color=="red"?ConsoleColor.Red:ConsoleColor.Green);
            else CustomOutput.ColorWriteLine(text,color=="red"?ConsoleColor.Red:ConsoleColor.Green);

            Console.WriteLine("End\n");
        }

        private static void RunCommandRunner()
        {
            Console.Write("Running mode :");
            int mode=int.Parse(Console.ReadLine());
            Console.Write("Command :");
            string command=Console.ReadLine();
            switch (mode)
            {
                case 0:
                    CommandRunner.Run(command);
                    break;
                case 1:
                    string[] a=CommandRunner.RunReadOut(command);
                    Console.WriteLine("1:\n"+a[0]+"2:\n"+a[1]);
                    break;
            }
        }
    }
}