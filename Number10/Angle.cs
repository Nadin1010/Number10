﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number10
{
    class Angle
    {
        int gradus;
        int minute;
        int second;
        public bool isCorrect = true;

        public int Gradus
        {
            get { return gradus; }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    gradus = value % 360;
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    Gradus += value / 60;
                minute = value % 60;
            }
        }

       // internal int ToRadians()
        //{
            //throw new NotImplementedException();
        //}

        public int Second
        {
            get { return second; }
            set
            {
                Minute += value / 60;
                second = value % 60;
            }
        }
        public Angle(int gradus, int minute, int second)
        {
            this.Gradus = gradus;
            this.Minute = minute;
            this.Second = second;
        }
        public  double ToRadians(/*double degAngle*/)
        { return Math.PI * (Gradus + 60 * Minute + 3600 * Second) / 180; }
    }
}
    
