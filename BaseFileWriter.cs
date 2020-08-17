using System;
using System.Collections.Generic;
using System.Text;

namespace FileWriter
{
    abstract class BaseFileWriter : IImageSizeFinder
    {
        public string FilePath { get; set; }


        public abstract void WriteLine(string line);

    }
}
