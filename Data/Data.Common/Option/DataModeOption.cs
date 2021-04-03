namespace Data.Common.Option
{
    public class DataModeOption : IOption<DataMode>
    {
        public DataMode Value { get; set; }

        public void ResetValue() => Value = DataMode.Database;
    }
}
