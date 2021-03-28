using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyDown
{
    class Program
    {
        private static void PressKey_Handler(object sender, KeyInfoEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            switch(e.Key)
            {
                case "":
                    Console.WriteLine($"{DateTime.Now} - Клавиша enter");
                    break;
                case " ":
                    Console.WriteLine($"{DateTime.Now} - Клавиша пробел");
                    break;
                default:
                    Console.WriteLine($"{DateTime.Now} - Клавиша {e.Key}");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main()
        {
            Keyboard keyboard = new Keyboard();

            keyboard.PressKey += PressKey_Handler;

            keyboard.Start();

            Console.ReadKey();
        }
    }
}
