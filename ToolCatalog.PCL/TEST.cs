using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCatalog.PCL
{
    public static class TEST
    {
        public static bool StartsWithUpper(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            Char ch = str[0];
            return Char.IsUpper(ch);
        }
        public static bool StartsWithLower(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            Char ch = str[0];
            return Char.IsLower(ch);
        }
        public static bool StartsWithNumber(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            Char ch = str[0];
            return Char.IsNumber(ch);
        }
    }
}
