using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tom = new Cat() { Id = 1, Name = "Tom" };
            Console.WriteLine(Tom.ToString());
            Console.ReadLine();
        }
    }
}
