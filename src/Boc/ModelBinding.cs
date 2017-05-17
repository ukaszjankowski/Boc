namespace Boc
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ModelBinding<TModel, TValue> : IModelBinding where TModel :  class
    {
        public object Key { get; internal set; }
        internal Func<TModel, TValue> Func { get; private set; }

        public ModelBinding(Func<TModel, TValue> func)
        {
            Func = func;
        }

        public object GetValue(object obj)
        {
            return Func(obj as TModel);
        }

        public IEqualityComparer GetEqualityComparer()
        {
            return EqualityComparer<TValue>.Default;
        }
    }
}