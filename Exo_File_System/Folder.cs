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

        public void AddFoldersToFolder (Folder folder)
        {
            FilesAndFolders.Add(folder);
        }

        public List<string> GetFullPath()
        {
            List<string> result = new List<string> ();
            foreach (ICommonComponent file in FilesAndFolders)
            {
                 result =file.Name;
            }

            return result;
        }
    }
}
