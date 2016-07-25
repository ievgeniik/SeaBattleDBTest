﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
