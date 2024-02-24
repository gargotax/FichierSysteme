using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_File_System
{
    public class LocalDisk_C : ICommonComponent
    {
        public string Name { get ; set; }

        public List<ICommonComponent> ComponentsInDiskC { get; set; }
        public int Size { get; private set; }

        public LocalDisk_C(string name, List<ICommonComponent> componentsInDiskC)
        {
            Name = name;
            Size = 0;
            ComponentsInDiskC = componentsInDiskC;

        }

        public void AddComponentsToDisc(ICommonComponent element)
        {
            ComponentsInDiskC.Add(element);

            Size += element.Size;
        }

        public void AddComponentToDisc(ICommonComponent component)
        {
            ComponentsInDiskC.Add(component);
            Size += component.Size;
        }

        public List<string> GetFullPathOfDisk(string path = "")
        {
            List <string> result = new List<string>();

            foreach (var element in ComponentsInDiskC)
            {
                if(element is ICommonComponent commonComponent)
                {
                    string elementPath = path + "/" + commonComponent.Name;
                    result.Add(elementPath);

                    // Si l'élément est un dossier, appelez récursivement GetFullPath
                    if (element is Folder folder)
                    {
                       // result.AddRange(folder.GetFullPathOfDisk(elementPath));
                    } 
                   
                }
            }       

            return result;
        }
    }
}
