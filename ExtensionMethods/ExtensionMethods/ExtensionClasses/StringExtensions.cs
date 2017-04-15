using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Extensions
{
    using System;

    public static class StringExtensions
    {
        static int outInt;
        static short outShort;
        static long outLong;
        static double outDouble;
        static decimal outDecimal;
        static float outFloat;

        public static bool IsEmpty(this string str) => string.IsNullOrEmpty(str);

        public static bool IsWhitespace(this string str) => string.IsNullOrWhiteSpace(str);

        public static bool IsNotEmpty(this string str) => !string.IsNullOrEmpty(str);

        public static bool IsNotWhitespace(this string str) => !string.IsNullOrWhiteSpace(str);

        public static Uri ToUri(this string source) => new Uri(source);

        public static int ToInt(this string str) => str.IsWhitespace() ? 0 : Convert.ToInt32(str);

        public static short ToShort(this string str) => str.IsWhitespace() ? (short)0 : Convert.ToInt16(str);

        public static long ToLong(this string str) => str.IsWhitespace() ? 0 : Convert.ToInt64(str);

        public static double ToDouble(this string str) => str.IsWhitespace() ? 0 : Convert.ToDouble(str);

        public static decimal ToDecimal(this string str) => str.IsWhitespace() ? 0 : Convert.ToDecimal(str);

        public static int ToIntSafe(this string source) => !source.IsWhitespace() && int.TryParse(source, out outInt) ? outInt : 0;

        public static short ToShortSafe(this string source) => !source.IsWhitespace() && short.TryParse(source, out outShort) ? outShort : (short)0;

        public static long ToLongSafe(this string source) => !source.IsWhitespace() && long.TryParse(source, out outLong) ? outLong : 0;

        public static double ToDoubleSafe(this string source) => !source.IsWhitespace() && double.TryParse(source, out outDouble) ? outDouble : 0;

        public static decimal ToDecimalSafe(this string source) => !source.IsWhitespace() && decimal.TryParse(source, out outDecimal) ? outDecimal : 0;

        public static float ToFloatSafe(this string source) => !source.IsWhitespace() && float.TryParse(source, out outFloat) ? outFloat : 0;

        public static bool ToBoolean(this string source) => source.IsEmpty() && (source.ToLower().Equals("true") || source.Equals("1"));
    }
}
