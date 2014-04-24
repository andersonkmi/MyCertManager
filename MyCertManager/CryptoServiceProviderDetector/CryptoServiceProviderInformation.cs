using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServiceProviderDetector
{
    public class CryptoServiceProviderInformation
    {
        public String Name
        {
            get;
            set;
        }

        public String Editor
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
    }
}
