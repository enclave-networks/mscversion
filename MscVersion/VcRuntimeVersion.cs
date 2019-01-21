using System;

namespace MscVersion
{
    public class VcRuntimeVersion
    {
        public Guid Guid { get; set; }
        public MscVer MscVer { get; set; }
        public ArchType Architecture { get; set; }
        public string Version { get; set; }

        public VcRuntimeVersion(Guid guid, MscVer mscVer, ArchType architecture, string version = "")
        {
            Guid = guid;
            MscVer = mscVer;
            Architecture = architecture;
            Version = version;
        }
    }
}