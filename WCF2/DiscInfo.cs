using System;

namespace WCF2
{
    public class DiscInfo : IDiscInfo
    {
        public string[] GetDiskInfo(string path)
        {
            if (string.IsNullOrEmpty(path) == false)
            {
                string[] folders = System.IO.Directory.GetDirectories(path);
                Console.WriteLine("Disc Info Gets");
                return folders;
            }
            else return null;
        }
    }
}
