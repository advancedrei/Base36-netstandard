
using AdvancedREI;

namespace System
{

    /// <summary>
    /// 
    /// </summary>
    public static class Base36Extensions
    {

        /// <summary>
        /// Converts a <see cref="long" /> number to a Base36 string. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToBase36(this long value) => Base36.NumberToBase36(value);

        /// <summary>
        /// Converts a Base36 alphanumeric string to its <see cref="long">numerical</see> representation.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static long FromBase36(this string input)
        {
            input = input.ToUpper();
            return string.IsNullOrEmpty(input) ? 0 : Base36.Base36ToNumber(input);
        }

    }

}