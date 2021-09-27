using System;
using System.Collections.Generic;

namespace Creating_Account_in_bank
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************Welcome to the Bank Of India**********************************\n\n");
            Dictionary<string, string> user = new Dictionary<string, string>();
            Console.WriteLine("Which type of account you want to open saving or current:");
            string Ac_t = (Console.ReadLine());
            string acc_type = Ac_t.ToLower();
            if (acc_type == "saving" || acc_type == "current") { }
            else
            {
                while ((acc_type) != "saving" || acc_type != "current")
                {
                    Console.WriteLine("You choosen wrong account type, please choose saving or current account:");
                    Ac_t = Console.ReadLine();
                    acc_type = Ac_t.ToLower();
                    if (acc_type == "saving" || acc_type == "current")
                    {
                        break;
                    }
                }
            }
            user.Add("Account Type", acc_type);
            
            Console.WriteLine("Please enter your full name:");
            string name = Console.ReadLine();
            user.Add("Full name", name);
            
            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            user.Add("Age", age);

            Console.WriteLine("Enter your full Address:");
            string address = Console.ReadLine();
            while (address.Length < 20)
            {
                Console.WriteLine("You enterd wrong Address, please try again:");
                address = Console.ReadLine();
                if (address.Length > 20)
                {
                    break;
                }
            }
            user.Add("Address", address);
            
             Console.WriteLine("Enter Your Mobile no.:");
            string mob_no = Console.ReadLine();
            while (mob_no.Length != 10)
            {
                Console.WriteLine("You enterd wrong Mobile no., please try again:");
                mob_no = Console.ReadLine();
                if (mob_no.Length == 10)
                {
                    break;
                }
            }
            user.Add("Mobile_no", mob_no);

            Console.WriteLine("Enter your Aadhar no.:");
            string aadhar = Console.ReadLine();
            while (aadhar.Length != 16)
            {
                Console.WriteLine("You enterd wrong Aadhar no., please try again:");
                aadhar = Console.ReadLine();
                if (aadhar.Length == 16)
                {
                    break;
                }
            }
            user.Add("Aadhar", aadhar);

            Console.WriteLine("Enter your Pancard no.:");
            string pan = Console.ReadLine();
            while (pan.Length != 10)
            {
                Console.WriteLine("You enterd wrong Pancard no., please try again:");
                pan = Console.ReadLine();
                if (pan.Length == 10)
                {
                    break;
                }
            }
            user.Add("Pancard_no", pan);

            Console.WriteLine("How much amount you want to deposite in Starting:");
            string amt = Console.ReadLine();
            user.Add("Amount", amt);

            Console.WriteLine("Are you want to saw your details if Yes enter '1'. ");
            string verify = Console.ReadLine();
            Console.WriteLine();

            if (verify == "1")
            {
                Console.WriteLine($"Hey Mr./Ms. {name} below is the details which you provide us if any mistake then inform me.");
                foreach (KeyValuePair<string, string> detials in user)
                {
                    Console.WriteLine("{0} :- {1}", detials.Key, detials.Value);
                }
            }

            Console.WriteLine($"\n{name} you have successfully created your {acc_type} account in Bank of Indian. " +
                    $"\n***************Welcome to be member of Bank Of Indian***************");
        }
    }
}
