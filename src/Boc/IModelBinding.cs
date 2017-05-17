namespace Boc
{
    using System.Collections;

    public interface IModelBinding
    {
        object Key { get; }

        IEqualityComparer GetEqualityComparer();

        object GetValue(object obj);
    }
}