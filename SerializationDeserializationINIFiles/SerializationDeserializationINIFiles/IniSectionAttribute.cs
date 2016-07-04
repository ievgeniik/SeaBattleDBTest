using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializationDeserializationINIFiles
{
    public class IniSectionAttribute : Attribute
    {
        public IniSectionAttribute(string INISection)
        {
            fileINISection = INISection;
        }
        public string fileINISection { get; set; }
    }
}
