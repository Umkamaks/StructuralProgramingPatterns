using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Theme
{
    class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "Light color";
        }
    }

}
