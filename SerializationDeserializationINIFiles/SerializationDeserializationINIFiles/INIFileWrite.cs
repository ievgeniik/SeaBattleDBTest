using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace SerializationDeserializationINIFiles
{
    public class INIFileWrite
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        static public void INIWriteValue(string fileINISection, string fileINIKey, string fileINIValue, string fileINIpath)
        {
            WritePrivateProfileString(fileINISection, fileINIKey, fileINIValue, fileINIpath);
        }
    }
}
