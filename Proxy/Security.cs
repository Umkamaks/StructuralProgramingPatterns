using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
   public class Security
    {
        IDoor door;
        public Security(IDoor door)
        {
            this.door = door;
        }

        private string Authenticate(string password)
        {
            if (password == "123")
                return password;
            else return "Unknown password";
        }

        public void Open(string password)
        {
            if (password==Authenticate(password))
            {
                this.door.Open();
            }
            else
            {
                Console.WriteLine(Authenticate(password));
            }
        }

        public void Close()
        {
            this.door.Close();
        }
    }
}
