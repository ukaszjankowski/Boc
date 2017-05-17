namespace Boc
{
    public class ModelBindingKey<T>
    {
        public T Key { get; private set; }

        public ModelBindingKey(T key)
        {
            Key = key;
        }
    }
}