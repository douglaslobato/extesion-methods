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
    }
}
