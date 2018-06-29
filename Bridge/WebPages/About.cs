using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Theme;

namespace Bridge.WebPages
{
    public class About : WebPage
    {
        ITheme theme;
        public About(ITheme theme)
            : base(theme)
        {
            this.theme = theme;
        }

        //public string GetContent()
        //{
        //    return $"Страница About page в теме -{this.theme.GetColor()} ";
        //}

        public override string GetContent()
        {
            return $"Страница About page в теме - {this.theme.GetColor()} ";
        }
    }
}
