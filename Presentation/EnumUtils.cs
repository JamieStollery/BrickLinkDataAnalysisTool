using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation
{
    public static class EnumUtils
    {
        public static TEnum? ToNullableEnum<TEnum>(string value) where TEnum : struct, IConvertible
        {
            return Enum.TryParse(value, out TEnum result) ? result : null as TEnum?;
        }

        public static IReadOnlyList<TEnum> ToListOfEnum<TEnum>(IEnumerable<string> values) where TEnum : struct, IConvertible
        {
            return ToEnums(values)?.ToList();

            static IEnumerable<TEnum> ToEnums(IEnumerable<string> values)
            {
                foreach (var value in values)
                {
                    if (Enum.TryParse<TEnum>(value, out var result))
                    {
                        yield return result;
                    }
                }
            }
        }
    }
}
