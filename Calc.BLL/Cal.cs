﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.BLL
{
    public class Cal:ICalc
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
        public int Mul(int a,int b)
        {
            return a * b;
        }
        public int Div(int a,int b)
        {
            return a / b;
        }
    }
}
