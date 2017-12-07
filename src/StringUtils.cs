using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaArea {
    public class StringUtils {
        public static string Between(string str, string leftstr, string rightstr) {
            //Regex rg = new Regex(string.Format("(?<=({0}))[.\\s\\S]*?(?=({1}))", leftstr, rightstr), RegexOptions.Multiline | RegexOptions.Singleline);
            //return rg.Match(str).Value;

            int start = str.IndexOf(leftstr);
            if (start == -1)
                return null;

            int i = start + leftstr.Length;
            int end = str.IndexOf(rightstr, i);
            if (end == -1)
                return null;

            string temp = str.Substring(i, end - i);
            if (string.IsNullOrWhiteSpace(temp)) {
                return null;
            }
            return temp;
        }
    }
}
