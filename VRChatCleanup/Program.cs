using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRChatCleanup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is irreversible and will delete all VRChat Cache / Temp data & Registry things\nPress any key to continue");
            Console.ReadLine();
            Console.WriteLine("Deleting VRChat Local Folder");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\VRChat");
            Console.WriteLine("Borrado " + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+"\\VRChat");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\VRChat");
            Console.WriteLine("Borrado " + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\VRChat");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\VRChat");
            Console.WriteLine("Borrado " + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\VRChat");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\VRChat");
            Console.WriteLine("Borrado " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\VRChat");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\DefaultCompany");
            Console.WriteLine("Borrado " + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\DefaultCompany");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\DefaultCompany");
            Console.WriteLine("Borrado " + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\DefaultCompany");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyAntiCheat");
            Console.WriteLine("Borrado " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyAntiCheat" + "\nDeleting Registry Values");
            DeleteRegistry();
            Console.WriteLine("Hecho, usa el hwid spoofer y ya.");
            Console.ReadLine();
            

        }

        static private void DeleteFolder(string folder)
        {
            try
            {
                Directory.Delete(folder, true);
            } catch { }
        }

        static private void DeleteRegistry()
        {
            try
            { 
                string keyName = @"Software\VRChat";
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
                {
                    if (key != null)
                    {
                        key.DeleteSubKey("VRChat");
                    }
                }
            } catch {  }
        }
    }
}
