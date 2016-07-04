using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializationDeserializationINIFiles
{
    public class DatabaseOptions
    {
        [IniSection("owner")]
        [IniKey("name")]
        public string Name{set; get; }

        [IniSection("owner")]
        [IniKey("organization")]
        public string OrganizationName{set; get; }

        [IniSection("database")]
        [IniKey("server")]
        public string ServerName{set; get; }

        [IniSection("database")]
        [IniKey("port")]
        public string PortName{set; get; }

        [IniSection("database")]
        [IniKey("file")]
        public string FileName{set; get; }
    }
}
