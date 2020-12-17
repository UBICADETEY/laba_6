using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laba_6
{
    class lines
    {
        private double x1,x2,y1,y2;

        public double Getd() { return  (Math.Sqrt( Math.Pow( x2-x1,2)+ Math.Pow(y2-y1,2))); }
        public double Getd1() { return (Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2 , 2))); }

        public double Getd2() { return (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2))); }


        public void Info()
        {
            String str = "*******" +
                "отрезок";
            Console.WriteLine(str);
            Console.WriteLine(" координаты начала отрезка " + x1 + " " + y1);
            Console.WriteLine(" координаты конца отрезка " + x2 + " " + y2);
            Console.WriteLine(string.Format("d = {0:0.00}", Getd()));
            Console.WriteLine(string.Format("d1  = {0:0.00}", Getd1()));
            Console.WriteLine(string.Format("d2 = {0:0.00}", Getd2()));


        }

        public void Load()
        {
            x1 = Convert.ToDouble(Console.ReadLine());
             y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
