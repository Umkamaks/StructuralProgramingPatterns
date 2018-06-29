using Bridge.Theme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.WebPages
{
    public abstract class WebPage
    {

        public WebPage(ITheme theme) { }
        public abstract string GetContent();
    }
}
