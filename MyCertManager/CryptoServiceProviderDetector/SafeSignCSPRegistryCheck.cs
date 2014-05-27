using Microsoft.Win32;

namespace CryptoServiceProviderDetector
{
    public class SafeSignCSPRegistryCheck : BaseCSPRegistryCheck
    {
        protected override string CryptoServiceProviderDisplayName
        {
            get
            {
                return "SafeSign";
            }
        }

        protected override string Pkcs11LibraryPath
        {
            get
            {
                return @"C:\Windows\system32\aetpkss11.dll";
            }
        }
    }
}
