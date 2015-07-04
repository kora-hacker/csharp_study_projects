using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD5_Consolo_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "admin";
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] test_encrypt = System.Text.Encoding.ASCII.GetBytes(test);
            byte[] result = md5.ComputeHash(test_encrypt);
        }
    }
}
