using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellDontAsk.Bad
{
    public class User
    {
        public bool IsAdmin => true;

        public void PerformAdminOperation()
        {
            Console.WriteLine("I did this because I am an admin!");
        }
    }
}
