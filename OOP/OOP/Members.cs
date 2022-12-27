using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Members
    {
        //members
        private string memberName;
        private string jobTitle;
        private bool isFriend;

        //constructor 
        public Members(string memberName, string jobTitle, bool isFriend){
            this.memberName = memberName;
            this.jobTitle = jobTitle;
            this.isFriend = isFriend;

        }

        //member property - exposes jobTitle safely
        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }

        
        public void Introduce() {
            if (isFriend)
            {
                sayHello();
            }
            else
            {
                Console.WriteLine("Not a friend. Nope :)");
            }
        }

        //private function can only be called from within the class or by a class that inherits from this 
        private void sayHello()
        {
            Console.WriteLine($"It is {isFriend} that {memberName}, working as the {jobTitle} is a friend.");
        }

        //destructor
        ~Members()
        {
            Console.WriteLine("Exiting");
        }

    }

}
