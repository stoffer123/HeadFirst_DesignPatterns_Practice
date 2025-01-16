﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    internal interface ILightCommand
    {
        void Execute();
        void UnExecute();
    }
}
