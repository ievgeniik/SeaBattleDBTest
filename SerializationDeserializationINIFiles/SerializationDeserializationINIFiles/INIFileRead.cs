using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace SerializationDeserializationINIFiles
{
    public class INIFileRead
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        static public string INIReadValue(string Section, string Key, string fileINIpath)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, fileINIpath);
            return temp.ToString();
        }
    }
}
