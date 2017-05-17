namespace Boc
{
    public class Change
    {
        public object Key { get; private set; }
        public object OldValue { get; private set; }
        public object NewValue { get; private set; }

        public Change(object key, object oldValue, object newValue)
        {
            Key = key;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}