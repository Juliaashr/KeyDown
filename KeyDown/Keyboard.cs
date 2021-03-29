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

        protected virtual void RaiseNewKeyInfo(string key) => PressKey?.Invoke(this, new KeyInfoEventArgs(key));
        

        public void Start()
        {
            int num = 0;

            while (true)
            {
                Console.WriteLine("Нажмите одну клавишу(введите 'выход' для выхода):");

                string key = Console.ReadLine();

                if (key == "выход" || key == null)
                {
                    Console.WriteLine($"выполнен выход в {DateTime.Now}");
                    break;
                }

                else if (key?.ToCharArray().Length < 2)
                {
                    RaiseNewKeyInfo(key);
                    num++;
                }
            }
            Console.WriteLine($"Всего было нажато клавиш: {num}");
        }
    }
}
