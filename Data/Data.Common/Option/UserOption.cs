using Data.Common.Model;

namespace Data.Common.Option
{
    public class UserOption : IOption<User>
    {
        public User Value { get; set; }

        public void ResetValue() => Value = null;
    }
}
