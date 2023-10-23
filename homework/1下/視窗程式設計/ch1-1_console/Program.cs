using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH1_1Console
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console_CH1_1 Co = new Console_CH1_1();
            Application.Run(Co);
        }
    }
}