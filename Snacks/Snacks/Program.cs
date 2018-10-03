using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snacks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Hunger
    {
        public static int hungry(int hungervalue)
        {
            switch (hungervalue) //je hungriger desto mehr essen
            {
                case 0:
             return 2;
                case 1:
             return 1;
                case 2:
             return 0;
                default:
             break;
            }
            return -1;
        }
        public static int weight(int weightvalue)
        {
            switch (weightvalue) //um so schwerer desto weniger || Index ist falsch rum .... 
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
                default:
                    break;
            }
            return -1;
        }
        
    }
}
