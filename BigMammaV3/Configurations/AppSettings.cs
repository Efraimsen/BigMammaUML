using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.Configurations;

public class AppSettings
{
    public ApplicationSettings Application { get; set; } = new ApplicationSettings();
    public StorageSettings Storage { get; set; } = new StorageSettings();
    public class ApplicationSettings
    {
        public string Name { get; set; } = "";
        public string Version { get; set; } = "";
    }
    public class StorageSettings
    {
        public string DataDirectory { get; set; } = "";
        public string ItemFileName { get; set; } = "";
        public string OrderFileName { get; set; } = "";
        public string MemberFileName { get; set; } = "";
    }
}
