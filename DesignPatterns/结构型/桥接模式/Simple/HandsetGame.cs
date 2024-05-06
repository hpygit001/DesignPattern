using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.桥接模式.Simple
{
    /// <summary>
    /// 手机游戏
    /// </summary>
    class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }
}
