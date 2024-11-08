using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Corner
    {
        public double Gradus { get; set; }
        double Min;
        double Sec;
       public int bug = 0;

        public Corner(double gradus, double min, double sec)
        {
                Gradus = gradus;
                Min_ = min;
                Sec_ = sec;
        }
        public double Min_
        {
            set
            {
                if (value <= 60 && value >= 0)
                {
                    Min = value;
                }
                else
                {
                    bug = 1;
                    Console.WriteLine("Диапазон возможных значений, угловых  минут : [от 0 до 60]");
                }
            }
            get
            {
                return Min;
            }
        }
        public double Sec_
        {
            set
            {
                if (value <= 60 && value >= 0)
                {
                    Sec = value;
                }
                else
                {
                    bug = 1;
                    Console.WriteLine("Диапазон возможных значений, угловых  секунд : [от 0 до 60]");
                }
            }
            get
            {
                return Sec;
            }
        }

        public string ToRadians()
        {
            if (bug == 0)
            {
                double radian = (Gradus + (Min + (Sec / 60)) / 60) * Math.PI / 180;
                return radian.ToString();
            }
            else
            {
                return "Введены некорректные значения.";
            }
           
        }
    }
}
