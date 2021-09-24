using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BeautyShopApp.AppDataFile
{
    class SafeSQLinput
    {
        public static void SafeInput(object sender, TextChangedEventArgs args)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @";";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }
    }
}
