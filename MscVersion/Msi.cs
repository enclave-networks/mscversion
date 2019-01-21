using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace MscVersion
{
    public static class Msi
    {
        [DllImport("msi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern InstallState MsiQueryProductState(string product);

        public static bool Any(IEnumerable<Guid> productCodes)
        {
            return productCodes.Any(IsInstalled);
        }

        public static bool IsInstalled(Guid productCode)
        {
            var state = MsiQueryProductState($"{{{productCode}}}");

            return state == InstallState.INSTALLSTATE_LOCAL ||
                   state == InstallState.INSTALLSTATE_DEFAULT;
        }

        public static bool IsInstalled(IEnumerable<string> productCodes)
        {
            return productCodes.Select(MsiQueryProductState).Any(state => state == InstallState.INSTALLSTATE_LOCAL || state == InstallState.INSTALLSTATE_DEFAULT);
        }

        public static IEnumerable<Guid> Where(IEnumerable<Guid> productCodes)
        {
            return productCodes.Where(IsInstalled);
        }
    }

    public enum InstallState
    {
        // ReSharper disable InconsistentNaming
        INSTALLSTATE_NOTUSED = -7,  // component disabled
        INSTALLSTATE_BADCONFIG = -6,  // configuration datacorrupt
        INSTALLSTATE_INCOMPLETE = -5,  // installationsuspended or in progress
        INSTALLSTATE_SOURCEABSENT = -4,  // run from source,source is unavailable
        INSTALLSTATE_MOREDATA = -3,  // return bufferoverflow
        INSTALLSTATE_INVALIDARG = -2,  // invalid functionargument
        INSTALLSTATE_UNKNOWN = -1,  // unrecognized productor feature
        INSTALLSTATE_BROKEN = 0,  // broken
        INSTALLSTATE_ADVERTISED = 1,  // advertised feature
        INSTALLSTATE_REMOVED = 1,  // component being removed(action state, not settable)
        INSTALLSTATE_ABSENT = 2,  // uninstalled (or actionstate absent but clients remain)
        INSTALLSTATE_LOCAL = 3,  // installed on local drive
        INSTALLSTATE_SOURCE = 4,  // run from source, CD ornet
        INSTALLSTATE_DEFAULT = 5,  // use default, local orsource
    }
}
