using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace People
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(basePath,filename);
            
        }
    }
}
