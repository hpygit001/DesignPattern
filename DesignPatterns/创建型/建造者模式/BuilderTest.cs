using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.创建型.建造者模式
{
    class BuilderTest
    {

        public static void Test()
        {
            PersonBuilder person = new PersonFatBuilder();


            PersonDirector director = new PersonDirector(person);
            director.CreatePerson();



        }
    }
}
