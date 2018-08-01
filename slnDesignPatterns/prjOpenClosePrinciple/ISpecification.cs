namespace prjOpenClosePrinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }
}
