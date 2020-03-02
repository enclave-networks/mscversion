using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace MscVersion
{
    public static class Msi
    {
        public static bool IsInstalled(IEnumerable<Guid> productCodes)
        {
            return productCodes.Any(IsInstalled);
        }

        public static bool IsInstalled(Guid productCode)
        {
            var state = MsiQueryProductState($"{{{productCode}}}");

            return state == InstallState.LOCAL ||
                   state == InstallState.DEFAULT;
        }

        [DllImport("msi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern InstallState MsiQueryProductState(string product);
    }

    public enum InstallState
    {
        // ReSharper disable InconsistentNaming
        NOTUSED = -7,  // component disabled
        BADCONFIG = -6,  // configuration datacorrupt
        INCOMPLETE = -5,  // installationsuspended or in progress
        SOURCEABSENT = -4,  // run from source,source is unavailable
        MOREDATA = -3,  // return bufferoverflow
        INVALIDARG = -2,  // invalid functionargument
        UNKNOWN = -1,  // unrecognized productor feature
        BROKEN = 0,  // broken
        ADVERTISED = 1,  // advertised feature
        REMOVED = 1,  // component being removed(action state, not settable)
        ABSENT = 2,  // uninstalled (or actionstate absent but clients remain)
        LOCAL = 3,  // installed on local drive
        SOURCE = 4,  // run from source, CD ornet
        DEFAULT = 5,  // use default, local orsource
    }
}
