using Bridge.Theme;
using Bridge.WebPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем темы 
            ITheme darkTheme = new DarkTheme();
            ITheme ligtTheme = new LightTheme();
            ITheme aquaTheme = new AquaTheme();

            //Создаем страницы

            WebPage aboutPage = new About(darkTheme); //Устанавливаем Темную тему
            WebPage careersPage = new Careers(darkTheme);

            Console.WriteLine(aboutPage.GetContent());
            Console.WriteLine(careersPage.GetContent());
            Console.WriteLine(new String('-',50));
            //Устанавливаем Светлую тему
            aboutPage = new About(ligtTheme);
            careersPage = new Careers(ligtTheme);

            Console.WriteLine(aboutPage.GetContent());
            Console.WriteLine(careersPage.GetContent());
            Console.WriteLine(new String('-', 50));
            //Устанавливаем Аква тему
            aboutPage = new About(aquaTheme);
            careersPage = new Careers(aquaTheme);

            Console.WriteLine(aboutPage.GetContent());
            Console.WriteLine(careersPage.GetContent());
            Console.WriteLine(new String('-', 50));
            Console.ReadKey();

        }
    }
}
