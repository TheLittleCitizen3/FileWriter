using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;

namespace FileWriter
{
    class SettingsFileFileWriter : BaseFileWriter
    {
        public SettingsFileFileWriter()
        {
            this.FilePath = ConfigurationManager.AppSettings["FilePath"];
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
