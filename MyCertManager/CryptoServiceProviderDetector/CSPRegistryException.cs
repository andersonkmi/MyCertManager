using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServiceProviderDetector
{
    public class CSPRegistryException : Exception
    {
        public CSPRegistryException()
        {
            // No action performed
        }

        public CSPRegistryException(string message)
            : base(message)
        {
            // No action performed
        }

        public CSPRegistryException(string message, Exception exception)
            : base(message, exception)
        {
            // No action performed
        }
    }
}
