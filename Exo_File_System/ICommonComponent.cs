using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_File_System
{
    public interface ICommonComponent
    {
        public string Name { get; set; }
        public int Size { get; }
    }
}
