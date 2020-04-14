using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//based on tutorial https://www.youtube.com/watch?v=NU_1StN5Tkk&t=2162s//

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //CheckBox cbox = new CheckBox();
            //cbox.draw();
            //cbox.enable();
            //Console.ReadLine();
            drawUIControl(new TextBox());
           
              
        }

        public static void drawUIControl(UIControl control)
        {
            control.draw();
        }
    }
}
