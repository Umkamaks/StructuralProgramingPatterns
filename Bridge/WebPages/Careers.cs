using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Theme;

namespace Bridge.WebPages
{
    public class Careers : WebPage
    {
        ITheme theme;
        public Careers(ITheme theme):base(theme)
        {
            this.theme = theme;
        }


        public override string GetContent()
        {
           return $"Страница Careers page в теме - {this.theme.GetColor()}";
        }
    }
}
