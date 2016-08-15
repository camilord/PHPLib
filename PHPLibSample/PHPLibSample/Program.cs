using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PHPLib;

namespace PHPLibSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Directory.GetCurrentDirectory() + @"\PHPLibSample.vshost.exe.manifest";
            Console.WriteLine("\n\nFull filename path: " + filename);

            string dirname_text = PHP.dirname(filename);
            Console.WriteLine("PHP dirname() function: " + dirname_text);

            Console.WriteLine("MD5 File Hash: " + PHP.md5_file(filename));
        }
    }
}
