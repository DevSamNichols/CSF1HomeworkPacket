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

            //Homepage to ATM
            Console.WriteLine("----CasualCash----\n\n");

            //variables needed
            int accountNumber = 123456789;
            int pinNumber = 1234;
            decimal currentBalance = 1337;
            bool isUser = false;


            //ADD ATTEMPTS REMAINING IN THE FUTURE
            do
            {

                Console.WriteLine("Please Enter Your Account Number: ");
                int accountInput = Convert.ToInt32(Console.ReadLine());

                if (accountInput == accountNumber)
                {
                    isUser = true;
                    Console.Clear();
                    Console.WriteLine("------CasualCash------\n\n");
                    Console.WriteLine("Please Enter Your PIN For Account " + accountNumber + ".");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("----CasualCash----\n\n");
                    Console.WriteLine("No Account Found Under " + accountInput + "\n\n");
                }
            } while (isUser != true);



            //Create Loop

        }//End Main

    }//End Class

}//End Namespace
