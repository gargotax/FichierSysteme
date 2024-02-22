using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_File_System
{
    public class LocalDisc_C : ICommonComponent
    {
        public string Name { get ; set; }

        public List<ICommonComponent> CommonComponents { get; set; }
        public int Size { get; private set; }

        public LocalDisc_C(string name)
        {
            Name = name;
            Size = 0;
        }

        public void AddComponentToDisc(ICommonComponent component)
        {
            CommonComponents.Add(component);
            Size += component.Size;
        }
    }
}
