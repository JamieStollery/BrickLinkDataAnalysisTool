namespace Data.Common.Option
{
    public interface IOption<T>
    {
        T Value { get; set; }
        void ResetValue();
    }
}
