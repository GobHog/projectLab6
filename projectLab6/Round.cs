﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectLab6
{
    public class Round
    {
        public int[] balls
        {
            get;
            set;
        }
        public int win_amount
        {
            get;
            set;
        }
        public Round(int[] balls, int win_amount)
        {
            this.balls = balls;
            this.win_amount = win_amount;
        }
    }
}
