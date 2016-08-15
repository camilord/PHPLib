# PHPLib
PHP functions for C#

#Introduction

I found many people looking for functions in C# that works like in PHP. 
Yes, I admit that PHP have a lot of useful functions that you can use 
without reinventing the wheel. I am starting this repository to build 
C# methods that works like PHP functions. Join me with this crusade and 
make/write methods in C# that are more useful...

#Sample Usage:

```csharp
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
```
