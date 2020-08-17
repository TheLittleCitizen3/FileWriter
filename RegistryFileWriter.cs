using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Configuration;
using System.IO;

namespace FileWriter
{
    class RegistryFileWriter : BaseFileWriter
    {
        public RegistryFileWriter()
        {
            string RegPath = ConfigurationManager.AppSettings["RegPath"];
            string ValuePath = ConfigurationManager.AppSettings["RegValue"];
            this.FilePath = (string)Registry.GetValue(RegPath,ValuePath,null);
        }
        public override void WriteLine(string line)
        {
            using (StreamWriter sw = new StreamWriter(this.FilePath))
            {
                sw.WriteLine(line);
            }
        }
    }
}
