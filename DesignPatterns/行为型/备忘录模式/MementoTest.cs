using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.备忘录模式
{
    class MementoTest
    {


        public static void Test()
        {
            Originator o = new Originator();
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
            o.State = "off";

            o.Show();

            o.SetMemento(c.Memento);

            o.Show();



        }
    }
}
