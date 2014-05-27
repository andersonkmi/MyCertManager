using Microsoft.Win32;


namespace CryptoServiceProviderDetector
{
    public class SafeNetCSPRegistryCheck : ICSPRegistryCheck
    {
        protected override string CryptoServiceProviderDisplayName
        {
            get
            {
                return "SafeNet";
            }
        }

        protected override string Pkcs11LibraryPath
        {
            get
            {
                return @"C:\Windows\system32\eTPKCS11.dll";
            }
        }
    }
}
