namespace Boc
{
    using System;

    public static class ModelBindingFactory
    {
        public static ModelBinding<TModel, TValue> Bind<TModel, TValue>(this BocModel<TModel> model, Func<TModel, TValue> func) where TModel : class
        {
            var binding = new ModelBinding<TModel, TValue>(func);
            model.AddBinding(binding);
            return binding;
        }

        public static ModelBinding<TModel, TValue> As<TModel, TValue>(this ModelBinding<TModel, TValue> modelBinding, object key) where TModel : class
        {
            modelBinding.Key = key;
            return modelBinding;
        }
    }
}