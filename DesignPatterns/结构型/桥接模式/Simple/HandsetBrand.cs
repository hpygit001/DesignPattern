using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.结构型.桥接模式.Simple
{
    abstract class HandsetBrand
    {
        protected HandsetSoft soft;


        /// <summary>
        /// 设置手机软件
        /// </summary>
        /// <param name="soft"></param>
        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }

        public abstract void Run();

    }
}
