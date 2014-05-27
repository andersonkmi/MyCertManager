using System.Collections.Generic;

namespace CryptoServiceProviderDetector
{
    public class CSPDetector
    {
        #region Internal attributes
        private ISet<ICSPRegistryCheck> cspDetectors;
        #endregion

        #region Constructor
        public CSPDetector()
        {
            this.cspDetectors = new HashSet<ICSPRegistryCheck>();
        }
        #endregion

        #region Methods
        public void AddCryptoServiceProviderVerifier(ICSPRegistryCheck item)
        {
            this.cspDetectors.Add(item);
        }

        public ISet<CryptoServiceProviderInformation> detectCSPs()
        {
            ISet<CryptoServiceProviderInformation> results = new HashSet<CryptoServiceProviderInformation>();
            executeDetectors(results);
            return results;
        }

        private void executeDetectors(ISet<CryptoServiceProviderInformation> items)
        {
            foreach (ICSPRegistryCheck detector in cspDetectors)
            {
                items.Add(detector.verifyInstallation());
            }
        }
        #endregion
    }
}
