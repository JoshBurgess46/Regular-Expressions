using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name.");
            string input = Console.ReadLine();
            ValidateName(input);

            Console.WriteLine("Enter phone number (123-456-7890)");
            string userAnswer = Console.ReadLine();
            ValidateNumber(userAnswer);

            Console.WriteLine("Enter email.");
            string userEmail = Console.ReadLine();
            ValidateEmail(userEmail);

            Console.WriteLine("Enter in todays date. (dd/mm/yyyy)");
            string date = Console.ReadLine();
            ValidateDay(date);

            Console.ReadKey();
        }
        public static void ValidateName(string userName)
        {
            bool works = Regex.IsMatch(userName, @"^([A-Z]{1,30})+([a-z]{1,30})$");

            if (works)
            {
                Console.WriteLine("name is valid");
            }
            else
            {
                Console.WriteLine("invalid input, please try again.");
            }
        }
        public static void ValidateNumber(string phoneNumber)
        {

            bool works = Regex.IsMatch(phoneNumber, @"^([0-9]{0,9})$");
            if (works)
            {
                Console.WriteLine("Phone number is valid");
            }
            else
            {
                Console.WriteLine("Phone number is not valid");
            }

        }
        public static void ValidateEmail(string userEmail)
        {
            bool works = Regex.IsMatch(userEmail, @"^^([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10})+\.+([a-z]{2,3})$");
            if (works)
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is invalid");
            }
        }
        public static void ValidateDay(string todaysDate)
        {
            bool works = Regex.IsMatch(todaysDate, @"^([0-9]{2})/([0-9]{2})/([0-9]{4})$");
            if (works)
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Date is not valid");
            }
        }
    }
}
