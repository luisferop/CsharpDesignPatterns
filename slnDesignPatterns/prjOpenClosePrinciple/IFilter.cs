using System.Collections.Generic;

namespace prjOpenClosePrinciple
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
