using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClipToHTML
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (Clipboard.ContainsData(DataFormats.Html))
            {
                var cf_html = Clipboard.GetText(TextDataFormat.Html);
                var html_start = cf_html.IndexOf('<');
                if (html_start >= 0)
                {
                    var html = cf_html.Substring(html_start);
                    Clipboard.SetText(html);
                }
            }
        }
    }
}
