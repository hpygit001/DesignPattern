﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.享元模式
{
    class UnsharedConcreteFlyweight:Flyweight
    {

        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享的具体Flyweight：" + extrinsicstate);
        }

    }
}
