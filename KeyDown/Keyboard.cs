using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyDown
{
    public class Keyboard
    {
        public event EventHandler<KeyInfoEventArgs> PressKey = null;
        public void PressKeyEvent(string key)
        {
            RaiseNewKeyInfo(key);
        }

        protected virtual void RaiseNewKeyInfo(string key)
        {
            EventHandler<KeyInfoEventArgs> newKeylnfo = PressKey;
            if (newKeylnfo != null)
            {
                newKeylnfo(this, new KeyInfoEventArgs(key));
            }
        }

        public void Start()
        {
            int num = 0;

            while (true)
            {
                Console.WriteLine("Нажмите одну клавишу(введите 'выход' для выхода):");

                string key = Console.ReadLine();

                if (key == "выход")
                {
                    Console.WriteLine($"выполнен выход в {DateTime.Now}");
                    break;
                }

                else if (key.ToCharArray().Length > 1)
                    Console.WriteLine("Было нажато несколько клавиш за раз, определить их невозможно");

                else
                {
                    PressKeyEvent(key);
                    num++;
                }
            }
            Console.WriteLine($"Всего было нажато клавиш: {num}");
        }
    }
}
