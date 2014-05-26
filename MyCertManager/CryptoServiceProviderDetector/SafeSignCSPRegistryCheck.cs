using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace CryptoServiceProviderDetector
{
    public class SafeSignCSPRegistryCheck : ICSPRegistryCheck
    {
        private const string ProgramsRegistryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

        public CryptoServiceProviderInformation verifyInstallation()
        {
            CryptoServiceProviderInformation cspInformation = new CryptoServiceProviderInformation();
            findKey(cspInformation);
            return cspInformation;
        }

        private void findKey(CryptoServiceProviderInformation cspInfo)
        {
            using (RegistryKey root = Registry.LocalMachine.OpenSubKey(ProgramsRegistryKey))
            {
                foreach (string subKeyName in root.GetSubKeyNames())
                {
                    using (RegistryKey subKey = root.OpenSubKey(subKeyName))
                    {
                        string name = (string) subKey.GetValue("DisplayName");
                        if (name.Contains("SafeSign"))
                        {
                            cspInfo.Vendor = (string)subKey.GetValue("Publisher");
                            cspInfo.Version = (string)subKey.GetValue("DisplayVersion");
                            cspInfo.Name = name;
                            cspInfo.InstallDate = (string)subKey.GetValue("InstallDate");
                            cspInfo.Pkcs11LibraryPath = @"C:\Windwos\system32\aetpkss1.dll";
                            break;
                        }
                    }
                }
            }
        }
    }
}
