using System;
using System.Linq;

namespace Extensions
{
    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            string temp = new string(s.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)).ToArray());
            return temp;
        }
    }
}