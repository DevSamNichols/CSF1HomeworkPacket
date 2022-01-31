using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user to enter an account number for their account
            //Continue to ask the user for their account number until they get it right (the correct account number will be hard coded in your code. See the login section for an example.


             Console.WriteLine("Please enter your account number: ");
             string userName = Console.ReadLine();
             int accountNumber = Convert.ToInt32(userName);

             bool isUser = false;

             if (accountNumber == 123456789)
             {
                 isUser = true;
             }

             if (isUser)
             {
                 Console.WriteLine("Access Granted! ");
             }
             else
             {
                 Console.WriteLine("Access Denied, Please enter a Valid account. ");
             }



            //Create Loop

        }//End Main

    }//End Class

}//End Namespace
