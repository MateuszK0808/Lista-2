﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy_Lista_2
{
    class Liczba
    {
        public Liczba(int value)
        {
            Value = value;
        }

        public int Value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
