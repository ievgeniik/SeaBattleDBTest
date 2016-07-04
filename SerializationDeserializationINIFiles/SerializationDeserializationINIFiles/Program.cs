using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SerializationDeserializationINIFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string testINIfilePath = "C:\\temp.ini";
            DatabaseOptions databaseOptionsSerialization = new DatabaseOptions();
            DatabaseOptions databaseOptionsDeserialization = new DatabaseOptions();
            databaseOptionsSerialization.Name = "John Doe";
            databaseOptionsSerialization.OrganizationName = "Acme Widgets Inc.";
            databaseOptionsSerialization.ServerName = "192.0.2.62";
            databaseOptionsSerialization.PortName = "143";
            databaseOptionsSerialization.FileName = "\"payroll.dat\"";
            PropertyInfo[] propsDatabaseOptions = typeof(DatabaseOptions).GetProperties();
            foreach (PropertyInfo propDBOptions in propsDatabaseOptions)
            {
                IniSectionAttribute attrINISection = Attribute.GetCustomAttribute(propDBOptions, typeof(IniSectionAttribute)) as IniSectionAttribute;
                IniKeyAttribute attrINIKey = Attribute.GetCustomAttribute(propDBOptions, typeof(IniKeyAttribute)) as IniKeyAttribute;
                INIFileWrite.INIWriteValue(attrINISection.fileINISection, attrINIKey.fileINIKey, propDBOptions.GetValue(databaseOptionsSerialization, null).ToString(), testINIfilePath);
                propDBOptions.SetValue(databaseOptionsDeserialization, INIFileRead.INIReadValue(attrINISection.fileINISection, attrINIKey.fileINIKey, testINIfilePath), null);
            }
        }
    }
}
