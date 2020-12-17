using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    class line_seg
    {
        private double r;

        public double GetV() { return (4 / 3) * Math.PI * Math.Pow(r, 3); }

        public double GetS() { return 4 * Math.PI * Math.Pow(r, 2); }

        public void Info()
        {
            String str =
                "          ****           \n" +
                "       **      **        \n" +
                "    **            **     \n" +
                " **                  **  \n" +
                "**        шар         ** \n" +
                " **                  **  \n" +
                "   **              **    \n" +
                "     **         **       \n" +
                "         ****            \n";
            Console.WriteLine(str);
            Console.WriteLine(string.Format("R = {0:0.00}", r));
            Console.WriteLine(string.Format("V = {0:0.00}", GetV()));
            Console.WriteLine(string.Format("S = {0:0.00}", GetS()));
        }

        public void Load()
        {
            r = Convert.ToDouble(Console.ReadLine());
        }
    }
}