using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.享元模式.Simple
{
    class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        public WebSite GetWebSiteCategory(string key)
        {
            if(!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteWebSite(key));
            }
            return flyweights[key] as WebSite;
        }

        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }
    }
}
