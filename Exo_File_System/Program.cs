namespace Exo_File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            Folder programFiles = new Folder("Program files", new List<ICommonComponent>());
            Folder dossier1 = new Folder("dossier1", new List<ICommonComponent>());
            Folder dossier2 = new Folder("dossier2", new List<ICommonComponent>());
            Folder dossier3 = new Folder("dossier3", new List<ICommonComponent>());

            programFiles.AddFoldersToFolder(dossier1);
            LocalDisk_C localDisk = new LocalDisk_C("C:", new List<ICommonComponent>());
            localDisk.AddComponentsToDisc(dossier1);

            List<string> fullPathOfDisk = programFiles.GetFullPath();
            foreach (string item in fullPathOfDisk)
            {
                Console.WriteLine(item);
            }

            File fichier1 = new File("fichier1.txt", 2);
            File fichier2 = new File("fichier2.txt", 2);
            dossier1.AddFilesToFolder(fichier1);
            dossier1.AddFilesToFolder(fichier2);
            dossier2.AddFoldersToFolder(dossier3);
            dossier2.AddFilesToFolder(fichier1);

            List<string> fullPathOfFolder = dossier1.GetFullPath();

            foreach (string fullPath in fullPathOfFolder)
            {
                Console.WriteLine(fullPath);
            }

            List<string> fullPathOfProgramFiles = programFiles.GetFullPath();

            foreach (string fullPath in fullPathOfProgramFiles)
            {
                Console.WriteLine(fullPath);
            }

            Console.WriteLine(dossier1.Name);
            Console.WriteLine(dossier1.Size);

            Console.WriteLine(dossier2.Name);
            Console.WriteLine(dossier2.Size);


        }
    }
}
