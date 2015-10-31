﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deductive_Fault_Simulator_BusinessLogic
{
    /// <summary>
    /// Operators contain the different types of logic
    /// gates which are possible
    /// </summary>
    public enum Operators
    {
        AND,
        OR,
        INV,
        NAND,
        NOR,
        BUF,
        NONE
    }
}
