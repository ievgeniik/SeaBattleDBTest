using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializationDeserializationINIFiles
{
    public class IniKeyAttribute : Attribute
    {
        public IniKeyAttribute(string INIKey)
        {
            fileINIKey = INIKey;
        }
        public string fileINIKey { get; set; }
    }
}
