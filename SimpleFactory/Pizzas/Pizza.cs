﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Pizzas
{
    interface Pizza
    {
        void prepare();
        void bake();
        void cut();
        void box();

        void consume();
    }
}
