using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryFileWriter s = new RegistryFileWriter();
            s.WriteLine("Hello World");
            ///Console.WriteLine((string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Mamas", "FilePath",null));
        }
        
    }

}
