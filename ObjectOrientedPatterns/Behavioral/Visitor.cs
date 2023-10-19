namespace ObjectOrientedPatterns.Behavioral.Visitor
{
    public abstract class IVisitor<TResult>
    {
        public abstract TResult VisitLit(Lit lit);
        public abstract TResult VisitPlus(PlusExp exp);
        public abstract TResult VisitMinus(MinusExp exp);
    }

    public interface IExp
    {
        public TResult Accept<TResult>(IVisitor<TResult> visitor);
    }

    public class Lit : IExp
    {
        public TResult Accept<TResult>(IVisitor<TResult> visitor)
        {
            return visitor.VisitLit(this);
        }
        public int Value { get; set; }
    }

    public class PlusExp : IExp
    {
        public TResult Accept<TResult>(IVisitor<TResult> visitor)
        {
            return visitor.VisitPlus(this);
        }
        public IExp LeftExp { get; set; }
        public IExp RightExp { get; set; }
    }

    public class MinusExp : IExp
    {
        public TResult Accept<TResult>(IVisitor<TResult> visitor)
        {
            return visitor.VisitMinus(this);
        }
        public IExp LeftExp { get; set; }
        public IExp RightExp { get; set; }
    }
}
