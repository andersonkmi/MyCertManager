using System;

namespace CryptoServiceProviderDetector
{
    public class CryptoServiceProviderInformation
    {
        public String Name
        {
            get;
            set;
        }

        public String Vendor
        {
            get;
            set;
        }

        public String Version
        {
            get;
            set;
        }

        public String Pkcs11LibraryPath
        {
            get;
            set;
        }

        public string InstallDate
        {
            get;
            set;
        }
    }
}
