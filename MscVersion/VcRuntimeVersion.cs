using System;

namespace MscVersion
{
    public class VcRuntimeVersion
    {
        public Guid ProductCode { get; set; }
        public MscVer MscVer { get; set; }
        public ArchType Architecture { get; set; }
        public string Version { get; set; }

        public VcRuntimeVersion(Guid productCode, MscVer mscVer, ArchType architecture, string version = "")
        {
            ProductCode = productCode;
            MscVer = mscVer;
            Architecture = architecture;
            Version = version;
        }
    }
}