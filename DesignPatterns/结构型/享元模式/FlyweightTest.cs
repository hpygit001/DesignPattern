using DesignPatterns.结构型.享元模式.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.享元模式
{
    class FlyweightTest
    {

        public static void Test()
        {

            //int extrinsicstate = 22;
            //FlyweightFactory f = new FlyweightFactory();

            //Flyweight fx = f.GetFlyweight("X");
            //fx.Operation(--extrinsicstate);

            //Flyweight fy = f.GetFlyweight("Y");
            //fy.Operation(--extrinsicstate);

            //Flyweight fz = f.GetFlyweight("Z");
            //fz.Operation(--extrinsicstate);

            //UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();
            //uf.Operation(--extrinsicstate);


            //==================================================================================
            WebSiteFactory f = new WebSiteFactory();
            WebSite fx = f.GetWebSiteCategory("产品展示");
            fx.Use();

            WebSite fy = f.GetWebSiteCategory("产品展示");
            fy.Use();

            WebSite fz = f.GetWebSiteCategory("产品展示");
            fz.Use();


            WebSite fl = f.GetWebSiteCategory("博客");
            fl.Use();

            WebSite fm = f.GetWebSiteCategory("博客");
            fm.Use();

            WebSite fn = f.GetWebSiteCategory("博客");
            fn.Use();

            Console.WriteLine("网站分类总数为{0}",f.GetWebSiteCount());



        }
    }
}
