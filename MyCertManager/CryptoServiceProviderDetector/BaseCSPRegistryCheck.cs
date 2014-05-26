using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServiceProviderDetector
{
    public abstract class BaseCSPRegistryCheck : ICSPRegistryCheck
    {
        private const string ProgramsRegistryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

        public abstract CryptoServiceProviderInformation verifyInstallation();
    }
}
