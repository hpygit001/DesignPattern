namespace DesignPatterns.行为型.访问者模式
{
    /// <summary>
    /// 具体元素，实现Accpet操作
    /// </summary>
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
    }
}