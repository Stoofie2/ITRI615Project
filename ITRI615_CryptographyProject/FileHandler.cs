using System.IO;
using System.Diagnostics;

namespace ITRI615_CryptographyProject
{
    public static class FileHandler
    {
        static string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public static void OpenFolder()
        {
            if (Directory.Exists(directoryPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                { Arguments = directoryPath, FileName = "explorer.exe" };
                Process.Start(startInfo);
            }
        }
    }
}
