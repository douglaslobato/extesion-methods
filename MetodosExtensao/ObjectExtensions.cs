using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao
{
    public static class ObjectExtensions
    {
        public static int ToIntZeroAble(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            int intValue;
            if (int.TryParse(value, out intValue))
                return intValue;

            return 0;
        }

        public static string ToStringOrEmpty<T>( this T obj)
        {
            if (obj == null)
                return string.Empty;          

            return obj.ToString();
        }
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}
