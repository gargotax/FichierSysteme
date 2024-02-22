using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_File_System
{
    public class File : ICommonComponent
    {
        public string Name { get ; set ; }

        public int Size { get; }

        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }
    }
}
