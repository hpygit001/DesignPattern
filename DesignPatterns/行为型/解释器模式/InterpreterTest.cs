using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.行为型.解释器模式
{
    class InterpreterTest
    {

        public static void Test()
        {
            //Content content = new Content();

            //IList<AbstractExpression> list = new List<AbstractExpression>();
            //list.Add(new TermianlExpression());
            //list.Add(new NonterminalExpression());
            //list.Add(new TermianlExpression());
            //list.Add(new TermianlExpression());


            //foreach (var item in list)
            //{
            //    item.InterpretContext(content);
            //}


            //*****************************************************************************

            simple.PlayContext context = new simple.PlayContext();
            //音乐-上海
            Console.WriteLine("上海滩: ");
            context.PlayText = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 ";
            simple.Expression expression = null;
            try
            {
                while(context.PlayText.Length>0)
                {
                    string str = context.PlayText.Substring(0, 1);

                    switch(str)
                    {
                        case "O":
                            expression = new simple.Scale();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression = new simple.Note();
                            break;

                    }

                    expression.Interpret(context);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



        }
    }
}
