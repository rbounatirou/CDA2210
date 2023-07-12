namespace CompositeAddition
{
    public interface IExpression
    {
        public abstract double Calculer();

        public abstract string Formate();

        public abstract string GetShortString();
    }
}