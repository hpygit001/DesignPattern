using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.桥接模式.Simple
{
    /// <summary>
    /// 手机品牌 N
    /// </summary>
    class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            Console.Write("N品牌：");
            soft.Run();
        }
    }
}
