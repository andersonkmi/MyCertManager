using System;

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
