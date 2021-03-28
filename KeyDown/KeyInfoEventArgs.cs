using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyDown
{
    public class KeyInfoEventArgs : EventArgs
    {
        public KeyInfoEventArgs(string key)
        {
            this.Key = key;
        }
        public string Key { get; private set; }
    }
}
