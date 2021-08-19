﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
    public interface ICalculatePiService
    {
        double Add(int number);
        double Minus(int number);
    }
}
