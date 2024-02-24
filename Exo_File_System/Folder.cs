using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_File_System
{
    public class Folder : ICommonComponent
    {
        public string Name { get; set ; }
        public List <ICommonComponent> FilesAndFolders { get; set ; }
        public int Size { get; private set; }

        public Folder (string name, List<ICommonComponent> filesAndFolders)
        {
            Name = name;
            FilesAndFolders = filesAndFolders;
            Size = 0;
        }

        public void AddFilesToFolder(File file)
        {
            FilesAndFolders.Add(file);

            Size += file.Size;
        }

        public void RemoveFilesFromFolder(File file)
        {
            FilesAndFolders.Remove(file);
            Size -= file.Size;
        }

        public void AddFoldersToFolder (Folder folder)
        {
            FilesAndFolders.Add(folder);
            Size += folder.Size;
        }

        public void RemoveFoldersFromoFolder(Folder folder)
        {
            FilesAndFolders.Remove(folder);
            Size -= folder.Size;
        }

        public List<string> GetFullPath(string currentPath = "")
        {
            List<string> result = new List<string>();

            foreach (ICommonComponent element in FilesAndFolders)
            {
                if (element is ICommonComponent commonComponent)
                {
                    string elementPath = currentPath + "/" + commonComponent.Name;
                    result.Add(elementPath);

                    if (element is Folder folder)
                    {
                       result.AddRange(folder.GetFullPath(elementPath));
                    }
                    else if (element is File file)
                    {
                        result.AddRange(file.GetFullPath(elementPath));
                    }
                }
            }

            return result;
        }
    }
}
