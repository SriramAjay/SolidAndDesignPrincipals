using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Problem
    {

        public void SendInvite(string Email, string fname, string lname) {
            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname))
            {
                Console.WriteLine("fields are mandatory");
            }
            if (!Email.Contains("@")||!Email.Contains("."))
            {
                Console.WriteLine("Please provide valid email address");
            }
            SmtpClient client = new SmtpClient();
            client.Send(new MailMessage("ajaysri420@gmail.com", Email) { Subject="Hi this is from house"});
        }
    
    }
}
