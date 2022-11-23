using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;


namespace WindowsFormsApp1
{
    class password_encrypt
    {
        static void Main(string[] args)
        {
            string password = " + password.Text + ";
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            Console.WriteLine("The hashed password is: {0}", passwordHash);
        }
    }
}
