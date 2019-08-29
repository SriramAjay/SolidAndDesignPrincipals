using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibility;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem p = new Problem();
            p.SendInvite("ajaysri420@gmail.com","Ajay","Sriram");
            Console.ReadLine();
        }
    }
}
