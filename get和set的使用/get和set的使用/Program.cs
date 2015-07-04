using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get和set的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node();
            a.Name = "JiangLinWei";
            System.Console.WriteLine(a.Name);
        }
    }
}
