using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.命令模式.Simple.one
{
    ///// <summary>
    ///// 服务员类
    ///// </summary>
    //public class Waiter
    //{
    //    private Command command;

    //    /// <summary>
    //    /// 设置订单
    //    /// </summary>
    //    /// <param name="command"></param>
    //    public void SetOrder(Command command)
    //    {
    //        this.command = command;
    //    }

    //    //通知执行
    //    public void Notify()
    //    {
    //        command.ExcuteCommand();
    //    }

    //}


    /// <summary>
    /// 服务员
    /// </summary>
    public class Waiter
    {
        private IList<Command> orders = new List<Command>();

        /// <summary>
        /// 设置订单
        /// </summary>
        /// <param name="command"></param>
        public void SetOrder(Command command)
        {
            if(command.ToString()== "BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了,请点别的烧烤。");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加订单："+command.ToString()+" 时间："+DateTime.Now.ToString());
            }
        }

        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="command"></param>
        public void CancleOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单："+command.ToString()+ " 时间：" + DateTime.Now.ToString());


        }



        /// <summary>
        /// 通知全部执行
        /// </summary>
        public void Notify()
        {
            foreach (var item in orders)
            {
                item.ExcuteCommand();
            }
        }
    }
}
