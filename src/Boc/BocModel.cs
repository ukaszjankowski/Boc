namespace Boc
{
    using System.Collections.Generic;

    public class BocModel<TModel> where TModel : class
    {
        private List<IModelBinding> bindings = new List<IModelBinding>();

        public void AddBinding(IModelBinding modelBinding)
        {
            bindings.Add(modelBinding);
        }

        public ICollection<Change> Compare(TModel obj1, TModel obj2)
        {
            var changes = new List<Change>();

            foreach (var binding in bindings)
            {
                var oldValue = binding.GetValue(obj1);
                var newValue = binding.GetValue(obj2);
                if (!binding.GetEqualityComparer().Equals(oldValue, newValue))
                    changes.Add(new Change(binding.Key, oldValue, newValue));
            }

            return changes;
        }
    }
}