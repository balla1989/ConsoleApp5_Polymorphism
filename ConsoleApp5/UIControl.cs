using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class UIControl
    {
        public void enable()
        {
            Console.WriteLine("Enabled");
        }

        public abstract void draw();
    }
}
