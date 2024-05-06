﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.适配器模式
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }
}
