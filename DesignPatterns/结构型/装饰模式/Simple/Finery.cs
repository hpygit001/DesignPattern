using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.装饰模式.Simple
{
    abstract class Finery
    {

        protected Finery component;
        public void Decorate(Finery component)
        {
            this.component = component;

        }



        public virtual void Show(Person person)
        {
            if(component!=null)
            {
                component.Show(person);
                person.Show();
            }
          
        }

        
    }
}
