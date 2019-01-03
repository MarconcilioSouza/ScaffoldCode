using System;

namespace ScaffoldCode.Infra.Helpers.HelperExtensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this String value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        public static bool IsNullOrEmpty(this String value)
        {
            return String.IsNullOrEmpty(value);
        }

        public static bool Equals(this String value1, String value2)
        {
            return String.Equals(value1, value2);
        }
    }
}
