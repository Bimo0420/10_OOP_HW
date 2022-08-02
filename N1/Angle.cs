using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Angle
    {
        int degree;
        int minute;
        int second;
        public bool isCorrect = true;
        public int Degree
        {
            get
            { 
                return degree;
            }
            set
            {
                degree = value % 360; //угол может быть отрицательным
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Degree += value / 60;
                    minute = value % 60;
                }
                    
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Minute += value / 60;
                    second = value % 60;
                }
                    
            }
        }
        public double ToRadians()
        {
            return (second + minute * 60 + degree * 3600 * Math.PI) / 180 * 3600;
        }
    }
}
