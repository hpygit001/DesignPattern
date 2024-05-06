using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.访问者模式.Simple
{
    abstract class Person
    {
        //接受
        public abstract void Accept(Action visitor);
    }
}
